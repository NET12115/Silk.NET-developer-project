// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using ClangSharp;
using ClangSharp.Interop;
using Humanizer;
using Microsoft.Extensions.FileSystemGlobbing;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Type = Silk.NET.BuildTools.Common.Functions.Type;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;

namespace Silk.NET.BuildTools.Cpp
{
    public static class Clang
    {
        private static FlowDirection _f; // a throwaway variable to store flows where we don't need them
        public static unsafe Profile GenerateProfile(string fileName, Stream input, BindTask task)
        {
            var profile = new Profile
            {
                Name = Path.GetFileNameWithoutExtension(fileName)
            };

            var matcher = new Matcher();
            matcher.AddIncludePatterns(task.ClangOpts.Traverse.Select(x => x.ToLower().Replace('\\', '/'))
                .Where(x => !x.StartsWith("!")));
            matcher.AddExcludePatterns(task.ClangOpts.Traverse.Select(x => x.ToLower().Replace('\\', '/'))
                .Where(x => x.StartsWith("!"))
                .Select(x => x.Substring(1)));
            
            var traversals = matcher.GetResultsInFullPath(Environment.CurrentDirectory)
                .Concat(task.ClangOpts.Traverse.Where(x => File.Exists(x)))
                .Select(x => Path.GetFullPath(x).ToLower().Replace('\\', '/'))
                .Distinct()
                .ToArray();

            Console.WriteLine("Loading input header...");
            using var ms = new MemoryStream();
            input.CopyTo(ms);
            var arr = ms.ToArray();
            string str;
            fixed (byte* arrPtr = arr)
            {
                str = new string((sbyte*) arrPtr, 0, arr.Length);
            }

            Console.WriteLine("Creating translation unit...");
            using var index = CXIndex.Create();
            // ReSharper disable BitwiseOperatorOnEnumWithoutFlags
            var translationFlags = CXTranslationUnit_Flags.CXTranslationUnit_None;
            translationFlags |=
                CXTranslationUnit_Flags.CXTranslationUnit_SkipFunctionBodies; // Don't traverse function bodies
            translationFlags |=
                CXTranslationUnit_Flags.CXTranslationUnit_IncludeAttributedTypes; // Include attributed types in CXType
            translationFlags |=
                CXTranslationUnit_Flags
                    .CXTranslationUnit_VisitImplicitAttributes; // Implicit attributes should be visited
            translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
            ReadOnlySpan<CXUnsavedFile> unsavedFiles = stackalloc CXUnsavedFile[] {CXUnsavedFile.Create(fileName, str)};
            var cxTranslationUnit = CXTranslationUnit.Parse
                (index, fileName, task.ClangOpts.ClangArgs, unsavedFiles, translationFlags);
            using var translationUnit = TranslationUnit.GetOrCreate(cxTranslationUnit);

            var visitedDecls = new List<Decl>();
            var error = false;
            for (uint i = 0; i < translationUnit.Handle.NumDiagnostics; ++i)
            {
                using var diagnostic = translationUnit.Handle.GetDiagnostic(i);
                if ((diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Error) ||
                    (diagnostic.Severity == CXDiagnosticSeverity.CXDiagnostic_Fatal))
                {
                    error = true;
                }

                Console.WriteLine
                (
                    $"{diagnostic.Severity.ToString().Substring(13)}: clang {diagnostic.Category} " +
                    $"{diagnostic.Spelling} ({diagnostic.CategoryText.CString}) ({diagnostic.Location})"
                );
            }

            if (error)
            {
                Console.WriteLine("Halted due to the above errors.");
                throw new Exception("See above.");
            }

            var translationUnitDecl = translationUnit.TranslationUnitDecl;
            visitedDecls.Add(translationUnitDecl);

            var functions = new List<Function>();
            var constants = new List<Constant>();
            var structs = new List<Struct>();
            var enums = new List<Enum>();
            var pfns = new Dictionary<string, Struct>();

            Console.WriteLine("Visting declarations...");
            VisitDecls(translationUnitDecl.Decls);
            // ReSharper restore BitwiseOperatorOnEnumWithoutFlags

            Console.WriteLine("Creating finished profile...");
            var destInfo = task.ClangOpts.ClassMappings[fileName];
            var indexOfOpenSqBracket = destInfo.IndexOf('[');
            var indexOfCloseSqBracket = destInfo.LastIndexOf(']');
            var projectName = destInfo.Substring
                (indexOfOpenSqBracket + 1, indexOfCloseSqBracket - indexOfOpenSqBracket - 1);
            var className = destInfo.Substring(indexOfCloseSqBracket + 1);
            var project = profile.Projects[projectName] = new Project
                {IsRoot = projectName == "Core", Namespace = task.Namespace};
            var @class = new Class
            {
                ClassName = className,
                Constants = constants,
                NativeApis = {[fileName] = new NativeApiSet {Name = "I" + className, Functions = functions}}
            };
            project.Structs = structs;
            project.Enums = enums;
            project.Classes.Add(@class);

            Console.WriteLine("Mapping C# names...");
            var variedNameMap = TypeMapper.CreateVariedNameMap(project);
            task.InjectTypeMap(variedNameMap);
            foreach (var map in task.TypeMaps)
            {
                TypeMapper.Map(map, project.Structs);
                TypeMapper.Map(map, @class.NativeApis[fileName].Functions);
            }

            return profile;

            Type GetOrAddPfnWrapper(Type type)
            {
                if (type.IsFunctionPointer)
                {
                    throw new ArgumentException("Not a function pointer.", nameof(type));
                }
                
                var name = GetFunctionPointerWrapperName(type);
                if (pfns.TryGetValue(name, out var val))
                {
                    var ret = new Type
                    {
                        Name = val.Name, OriginalName = "Pfn" + name,
                        FunctionPointerSignature = type.FunctionPointerSignature
                    };
                    ret.ForceNegativeIndirection(-1);
                    return ret;
                }
                else
                {
                    name = GetFunctionPointerWrapperName(type);
                    var nameChanged = task.RenamedNativeNames.TryGetValue(name, out var renamed);
                    if (nameChanged)
                    {
                        name = renamed;
                    }

                    var delegateName = nameChanged ? name : $"{name}Proc";
                    Struct s;
                    pfns.Add
                    (
                        GetFunctionPointerWrapperName(type), s = new Struct
                        {
                            Name = "Pfn" + name,
                            NativeName = "Pfn" + GetFunctionPointerWrapperName(type),
                            Fields = type.FunctionPointerSignature.Parameters.Select
                                    ((x, i) => new Field {Name = $"Arg{i}", NativeName = $"arg{i}", Type = x.Type})
                                .Concat
                                (
                                    new[]
                                    {
                                        new Field
                                        {
                                            Name = "Return", NativeName = "return",
                                            Type = type.FunctionPointerSignature.ReturnType
                                        }
                                    }
                                )
                                .ToList(),
                            Attributes = new List<Attribute>
                            {
                                new Attribute{Name = "BuildToolsIntrinsic", Arguments = new List<string>
                                {
                                    "$PFN",
                                    delegateName,
                                    "Pfn" + name,
                                    type.FunctionPointerSignature.Convention.ToString()
                                }}
                            }
                        }
                    );
                    
                    structs.Add(s);

                    var ret = new Type
                    {
                        Name = s.Name, OriginalName = s.NativeName,
                        FunctionPointerSignature = type.FunctionPointerSignature
                    };

                    ret.ForceNegativeIndirection(-1);
                    return ret;
                }
            }

            static string GetFunctionPointerWrapperName(Type type)
            {
                return (type.FunctionPointerSignature.Parameters.Aggregate
                    (string.Empty, (current, parameter) => current + (WriteType(parameter.Type) + " ")) + WriteType
                    (type.FunctionPointerSignature.ReturnType)).Pascalize();

                static string WriteType(Type type) => type.IsFunctionPointer
                    ? $"Fv{GetFunctionPointerWrapperName(type)}"
                    : type.Name switch
                {
                    "void" => "V",
                    "int" => "i",
                    "uint" => "ui",
                    "long" => "i64",
                    "ulong" => "ui64",
                    "short" => "s",
                    "ushort" => "us",
                    "Half" => "h",
                    "float" => "f",
                    "double" => "d",
                    "byte" => "b",
                    _ => type.Name
                } + new string('v', type.IndirectionLevels);
            }

            void VisitDecls(IEnumerable<Decl> decls)
            {
                foreach (var decl in decls)
                {
                    if (decl.Location.IsFromMainFile)
                    {
                        Visit(decl);
                    }
                    else if (task.ClangOpts.Traverse.Length == 0)
                    {
                        if (!decl.Location.IsFromMainFile)
                        {
                            // It is not uncommon for some declarations to be done using macros, which are themselves
                            // defined in an imported header file. We want to also check if the expansion location is
                            // in the main file to catch these cases and ensure we still generate bindings for them.

                            decl.Location.GetExpansionLocation(out CXFile file, out uint line, out uint column, out _);
                            var expansionLocation = decl.TranslationUnit.Handle.GetLocation(file, line, column);

                            if (!expansionLocation.IsFromMainFile)
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        decl.Location.GetFileLocation(out CXFile file, out _, out _, out _);
                        if (!traversals.Contains(Path.GetFullPath(file.Name.ToString()).ToLower().Replace('\\', '/')))
                        {
                            // It is not uncommon for some declarations to be done using macros, which are themselves
                            // defined in an imported header file. We want to also check if the expansion location is
                            // in the main file to catch these cases and ensure we still generate bindings for them.

                            decl.Location.GetExpansionLocation(out CXFile expansionFile, out _, out _, out _);
                            if (!traversals.Contains
                                (Path.GetFullPath(file.Name.ToString()).ToLower().Replace('\\', '/')))
                            {
                                continue;
                            }
                        }
                    }

                    Visit(decl);
                }
            }

            void Visit(Cursor cursor)
            {
                if (cursor is Attr attr)
                {
                    // We don't consider most attributes particularly important and so we do nothing
                }
                else if (cursor is Decl decl)
                {
                    if (visitedDecls.Contains(decl))
                    {
                        return;
                    }

                    visitedDecls.Add(decl);

                    VisitDecl(decl);
                }
                // TODO maybe?
                //else if (cursor is Ref @ref)
                //{
                //    VisitRef(@ref);
                //}
                //else if (cursor is Stmt stmt)
                //{
                //    VisitStmt(stmt);
                //}
                else
                {
                    Console.WriteLine
                    (
                        $"Warning: Unsupported cursor: '{cursor.CursorKindSpelling}'." +
                        " Generated bindings may be incomplete."
                    );
                }
            }

            string GetAnonymousName(Cursor cursor, string kind)
            {
                cursor.Location.GetFileLocation(out var file, out var line, out var column, out _);
                var fileName = Path.GetFileNameWithoutExtension(file.Name.ToString());
                return $"__Anonymous{kind}_{fileName}_L{line}_C{column}";
            }

            string GetAnonymousName2(CXCursor cursor, string kind)
            {
                cursor.Location.GetFileLocation(out var file, out var line, out var column, out _);
                var fileName = Path.GetFileNameWithoutExtension(file.Name.ToString());
                return $"__Anonymous{kind}_{fileName}_L{line}_C{column}";
            }
            
            string GetSourceRangeContents(CXTranslationUnit translationUnit, CXSourceRange sourceRange)
            {
                sourceRange.Start.GetFileLocation(out var startFile, out var startLine, out var startColumn, out var startOffset);
                sourceRange.End.GetFileLocation(out var endFile, out var endLine, out var endColumn, out var endOffset);

                if (startFile != endFile)
                {
                    return string.Empty;
                }

                var fileContents = translationUnit.GetFileContents(startFile, out var fileSize);
                fileContents = fileContents.Slice(unchecked((int)startOffset), unchecked((int)(endOffset - startOffset)));

#if NETCOREAPP
                return Encoding.UTF8.GetString(fileContents);
#else
                return Encoding.UTF8.GetString(fileContents.ToArray());
#endif
            }
            
            bool TryGetUuid(RecordDecl recordDecl, out Guid uuid)
            {
                var uuidAttrs = recordDecl.Attrs.Where((attr) => attr.Kind == CX_AttrKind.CX_AttrKind_Uuid).ToArray();

                if (!uuidAttrs.Any())
                {
                    uuid = Guid.Empty;
                    return false;
                }

                if (uuidAttrs.Count() != 1)
                {
                    Console.WriteLine
                    (
                        $"Warning: Multiply uuid attributes for {recordDecl.Name}. " +
                        $"Falling back to first attribute. ({recordDecl.Location})"
                    );
                }

                var uuidAttr = uuidAttrs.First();
                var uuidAttrText = GetSourceRangeContents(recordDecl.TranslationUnit.Handle, uuidAttr.Extent);
                var uuidText = uuidAttrText.Split(new char[] { '"' }, StringSplitOptions.RemoveEmptyEntries)[1];

                if (!Guid.TryParse(uuidText, out uuid))
                {
                    Console.WriteLine
                    (
                        $"Warning: Failed to parse uuid attr text '{uuidAttrText}'. " +
                        $"Extracted portion: '{uuidText}'. ({recordDecl.Location})"
                    );
                    return false;
                }
                return true;
            }

            void VisitTypedefDecl(TypedefDecl tdDecl)
            {
                bool isPlain = false;
                VisitTypedefDeclUnderlyingType(tdDecl.UnderlyingType, ref isPlain, out var anonName, out var decl);
                if (decl is null || !string.IsNullOrWhiteSpace(((TagDecl)decl).Name))
                {
                    return;
                }

                if (decl is EnumDecl)
                {
                    var enumSpec = enums.FirstOrDefault(x => x.NativeName == anonName);
                    var name = Naming.TranslateLite(Naming.TrimName(tdDecl.Name, task), task.FunctionPrefix);
                    if (task.RenamedNativeNames.TryAdd(anonName, name) && !(enumSpec is null))
                    {
                        enumSpec.Attributes.Add(new Attribute
                        {
                            Arguments = new List<string>{"\"AnonymousName\"", $"\"{anonName}\""},
                            Name = "NativeName"
                        });
                        enumSpec.Name = name;
                        enumSpec.NativeName = tdDecl.Name;
                    }
                }
                else if (decl is RecordDecl)
                {
                    var structSpec = structs.FirstOrDefault(x => x.NativeName == anonName);
                    var name = Naming.TranslateLite(Naming.TrimName(tdDecl.Name, task), task.FunctionPrefix);
                    if (task.RenamedNativeNames.TryAdd(anonName, name) && !(structSpec is null))
                    {
                        structSpec.Name = name;
                        structSpec.NativeName = tdDecl.Name;
                    }
                }
            }

            void VisitTypedefDeclUnderlyingType
            (
                ClangSharp.Type type,
                ref bool isPlain,
                out string anonymousName,
                out Decl decl
            )
            {
                decl = null;
                anonymousName = null;
                if (type is ArrayType arrayType)
                {
                    isPlain = false;
                    VisitTypedefDeclUnderlyingType
                        (arrayType.ElementType, ref isPlain, out anonymousName, out decl);
                }
                else if (type is AttributedType attributedType)
                {
                    isPlain = false;
                    VisitTypedefDeclUnderlyingType
                        (attributedType.ModifiedType, ref isPlain, out anonymousName, out decl);
                }
                else if (type is BuiltinType)
                {
                    decl = null;
                }
                else if (type is ElaboratedType elaboratedType)
                {
                    VisitTypedefDeclUnderlyingType
                        (elaboratedType.NamedType, ref isPlain, out anonymousName, out decl);
                }
                else if (type is FunctionType functionType)
                {
                    // todo maybe?
                }
                else if (type is PointerType pointerType)
                {
                    isPlain = false;
                    VisitTypedefDeclUnderlyingType
                        (pointerType.PointeeType, ref isPlain, out anonymousName, out decl);
                }
                else if (type is ReferenceType referenceType)
                {
                    isPlain = false;
                    VisitTypedefDeclUnderlyingType
                        (referenceType.PointeeType, ref isPlain, out anonymousName, out decl);
                }
                else if (type is TagType tagType)
                {
                    if (tagType.Handle.IsConstQualified)
                    {
                        anonymousName = GetAnonymousName2
                        (
                            tagType.Decl.TypeForDecl.Handle.Declaration,
                            tagType.Kind.ToString().Substring("CXType_".Length)
                        );
                    }
                    else
                    {
                        anonymousName = GetAnonymousName
                            (tagType.Decl, tagType.Kind.ToString().Substring("CXType_".Length));
                    }

                    decl = tagType.Decl;
                }
                else if (type is TypedefType typedefType)
                {
                    // return...
                }
            }

            CallingConvention GetCallingConvention(CXCallingConv conv)
            {
                switch (conv)
                {
                    case CXCallingConv.CXCallingConv_Default: break;
                    case CXCallingConv.CXCallingConv_C:
                    {
                        return CallingConvention.Cdecl;
                    }
                    case CXCallingConv.CXCallingConv_X86StdCall:
                    {
                        return CallingConvention.StdCall;
                    }
                    case CXCallingConv.CXCallingConv_X86FastCall:
                    {
                        return CallingConvention.FastCall;
                    }
                    case CXCallingConv.CXCallingConv_X86ThisCall:
                    {
                        return CallingConvention.ThisCall;
                    }
                    //case CXCallingConv.CXCallingConv_X86Pascal: break;
                    //case CXCallingConv.CXCallingConv_AAPCS: break;
                    //case CXCallingConv.CXCallingConv_AAPCS_VFP: break;
                    //case CXCallingConv.CXCallingConv_X86RegCall: break; 
                    //case CXCallingConv.CXCallingConv_IntelOclBicc: break;
                    case CXCallingConv.CXCallingConv_Win64:
                    {
                        return CallingConvention.Winapi;
                    }
                    //case CXCallingConv.CXCallingConv_X86_64SysV: break;
                    //case CXCallingConv.CXCallingConv_X86VectorCall: break;
                    //case CXCallingConv.CXCallingConv_Swift: break;
                    //case CXCallingConv.CXCallingConv_PreserveMost: break;
                    //case CXCallingConv.CXCallingConv_PreserveAll: break;
                    //case CXCallingConv.CXCallingConv_AArch64VectorCall: break;
                    //case CXCallingConv.CXCallingConv_Invalid: break;
                    //case CXCallingConv.CXCallingConv_Unexposed: break;
                    default:
                    {
                        Console.WriteLine($"Warning: Unsupported calling convention {conv}. Defaulting to StdCall.");
                        return CallingConvention.StdCall;
                    }
                }

                return CallingConvention.StdCall;
            }

            Type GetType(ClangSharp.Type type, out Count count, ref FlowDirection flow, out bool success)
            {
                FlowDirection ignoreFlow = default;
                success = true;
                count = null;
                Type ret = new Type {Name = "void", IndirectionLevels = 1};

                if (type is ArrayType arrayType)
                {
                    ret = GetType(arrayType.ElementType, out var currentCount, ref flow, out _);
                    ret.IndirectionLevels++;
                    var asize = arrayType.Handle.ArraySize;
                    if (asize != -1)
                    {
                        count = new Count
                            ((int) (asize * (currentCount?.IsStatic ?? false ? currentCount.StaticCount : 1)));
                    }
                    else
                    {
                        count = currentCount;
                    }
                }
                else if (type is AttributedType attributedType)
                {
                    ret = GetType(attributedType.ModifiedType, out _, ref flow, out _);
                }
                else if (type is BuiltinType)
                {
                    switch (type.Kind)
                    {
                        case CXTypeKind.CXType_Void:
                        {
                            ret = new Type {Name = "void"};
                            break;
                        }

                        case CXTypeKind.CXType_Bool:
                        {
                            ret = new Type {Name = "bool"};
                            break;
                        }

                        case CXTypeKind.CXType_Char_U:
                        case CXTypeKind.CXType_UChar:
                        {
                            ret = new Type {Name = "byte"};
                            break;
                        }

                        case CXTypeKind.CXType_UShort:
                        {
                            ret = new Type {Name = "ushort"};
                            break;
                        }

                        case CXTypeKind.CXType_UInt:
                        {
                            ret = new Type {Name = "uint"};
                            break;
                        }

                        case CXTypeKind.CXType_ULong:
                        {
                            goto case CXTypeKind.CXType_UInt;
                        }

                        case CXTypeKind.CXType_ULongLong:
                        {
                            ret = new Type {Name = "ulong"};
                            break;
                        }

                        case CXTypeKind.CXType_Char_S:
                        case CXTypeKind.CXType_SChar:
                        {
                            ret = new Type {Name = "byte"};
                            break;
                        }

                        case CXTypeKind.CXType_WChar:
                        {
                            ret = new Type {Name = "char"};
                            break;
                        }

                        case CXTypeKind.CXType_Short:
                        {
                            ret = new Type {Name = "short"};
                            break;
                        }

                        case CXTypeKind.CXType_Int:
                        {
                            ret = new Type {Name = "int"};
                            break;
                        }

                        case CXTypeKind.CXType_Long:
                        {
                            goto case CXTypeKind.CXType_Int;
                        }

                        case CXTypeKind.CXType_LongLong:
                        {
                            ret = new Type {Name = "long"};
                            break;
                        }

                        case CXTypeKind.CXType_Float:
                        {
                            ret = new Type {Name = "float"};
                            break;
                        }

                        case CXTypeKind.CXType_Double:
                        {
                            ret = new Type {Name = "double"};
                            break;
                        }

                        default:
                        {
                            Console.WriteLine
                                ($"Warning: Unsupported builtin type: '{type.TypeClass}'. Falling back '{ret}'.");
                            break;
                        }
                    }
                }
                else if (type is ElaboratedType elaboratedType)
                {
                    if (elaboratedType.NamedType.Handle.Declaration.IsAnonymous)
                    {
                        ret = new Type
                        {
                            Name = GetAnonymousName2
                            (
                                elaboratedType.NamedType.Handle.Declaration,
                                elaboratedType.NamedType.Handle.kind.ToString().Substring("CXType_".Length)
                            )
                        };
                    }
                    else
                    {
                        ret = new Type {Name = elaboratedType.NamedType.AsString};
                    }
                }
                else if (type is FunctionType functionType)
                {
                    if ((functionType is FunctionProtoType functionProtoType))
                    {
                        ret = GetOrAddPfnWrapper
                        (
                            new Type
                            {
                                Name = "void",
                                FunctionPointerSignature = new Function
                                {
                                    Convention = GetCallingConvention(functionProtoType.CallConv),
                                    Parameters = functionProtoType.ParamTypes.Select
                                        (
                                            (x, i) => new Parameter
                                            {
                                                Name = $"arg{i}",
                                                Type = GetType(x, out var count2, ref ignoreFlow, out _),
                                                Count = count2
                                            }
                                        )
                                        .ToList(),
                                    ReturnType = GetType(functionProtoType.ReturnType, out _, ref ignoreFlow, out _)
                                }
                            }
                        );
                    }
                    else
                    {
                        ret = new Type {Name = "IntPtr"};
                    }
                }
                else if (type is PointerType pointerType)
                {
                    ret = GetType(pointerType.PointeeType, out _, ref flow, out _);
                    ret.IndirectionLevels++;
                }
                else if (type is ReferenceType referenceType)
                {
                    ret = GetType(referenceType.PointeeType, out _, ref flow, out _);
                    ret.IndirectionLevels++;
                }
                else if (type is TagType tagType)
                {
                    if (tagType.Decl.Handle.IsAnonymous)
                    {
                        ret = new Type {Name = GetAnonymousName(tagType.Decl, tagType.KindSpelling)};
                    }
                    else if (tagType.Handle.IsConstQualified)
                    {
                        if (flow == FlowDirection.Undefined)
                        {
                            flow = FlowDirection.In;
                        }

                        ret = GetType(tagType.Decl.TypeForDecl, out _, ref flow, out _);
                    }
                    else
                    {
                        ret = new Type {Name = tagType.Decl.Name};
                    }
                }
                else if (type is TypedefType typedefType)
                {
                    // We check remapped names here so that types that have variable sizes
                    // can be treated correctly. Otherwise, they will resolve to a particular
                    // platform size, based on whatever parameters were passed into clang.
                    if (task.ExcludedNativeNames.Contains(typedefType.Decl.Name))
                    {
                        ret = new Type {Name = typedefType.Decl.Name};
                    }
                    else
                    {
                        ret = GetType(typedefType.Decl.UnderlyingType, out _, ref flow, out var getTypeSuccess);
                        if (!getTypeSuccess)
                        {
                            ret = new Type {Name = typedefType.Decl.Name};
                        }
                        else if (ret.FunctionPointerSignature is not null)
                        {
                            var wrapper = GetFunctionPointerWrapperName(ret);
                            if (ret.Name == "Pfn" + wrapper)
                            {
                                // rename the struct as we've found a typedef for it, and we haven't found a better name
                                // already.
                                pfns[wrapper].NativeName = typedefType.Decl.Name;
                                var name = Naming.TranslateVariable
                                    (Naming.TrimName(pfns[wrapper].NativeName, task), task.FunctionPrefix);
                                if (name.ToLower().StartsWith("pfn"))
                                {
                                    name = name.Substring(3);
                                }
                                
                                var intrinsic = pfns[wrapper].Attributes.First(x => x.Name == "BuildToolsIntrinsic");
                                ret.Name = pfns[wrapper].Name =
                                    intrinsic.Arguments[2] = "Pfn" + (intrinsic.Arguments[1] = name);
                            }
                        }
                    }
                }
                else
                {
                    success = false;
                    Console.WriteLine($"Warning: Unsupported type \"{type.AsString}\": '{type.TypeClass}' ({type.GetType().Name}). Falling back '{ret}'.");
                    Console.WriteLine("To yield a successful mapping despite this, use this type via a typedef.");
                }

                ret.OriginalName = type.AsString.Replace("\\", "\\\\");
                return ret;
            }

            IEnumerable<Field> ConvertAll(RecordDecl recordDecl) => recordDecl.Fields.Select
            (
                x => new Field
                {
                    Name = Naming.TranslateLite
                        (Naming.TrimName(x.Name, task), task.FunctionPrefix),
                    NativeName = x.Name,
                    Type = GetType(x.Type, out var count, ref _f, out _),
                    NativeType = x.Type.AsString.Replace("\\", "\\\\"), Count = count,
                    Attributes = recordDecl.IsUnion
                        ? new List<Attribute>
                        {
                            new Attribute
                            {
                                Name = "FieldOffset",
                                Arguments = new List<string> {x.Handle.OffsetOfField.ToString()}
                            }
                        }
                        : new List<Attribute>()
                }
            );

            void VisitDecl(Decl decl, string typedef = null)
            {
                switch (decl.Kind)
                {
                    case CX_DeclKind.CX_DeclKind_AccessSpec:
                    {
                        // Access specifications are also exposed as a queryable property
                        // on the declarations they impact, so we don't need to do anything
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_Block:
                    // case CX_DeclKind.CX_DeclKind_Captured:
                    // case CX_DeclKind.CX_DeclKind_ClassScopeFunctionSpecialization:

                    case CX_DeclKind.CX_DeclKind_Empty:
                    {
                        // Nothing to generate for empty declarations
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_Export:
                    // case CX_DeclKind.CX_DeclKind_ExternCContext:
                    // case CX_DeclKind.CX_DeclKind_FileScopeAsm:
                    // case CX_DeclKind.CX_DeclKind_Friend:
                    // case CX_DeclKind.CX_DeclKind_FriendTemplate:
                    // case CX_DeclKind.CX_DeclKind_Import:

                    case CX_DeclKind.CX_DeclKind_LinkageSpec:
                    {
                        // Linkage specifications are also exposed as a queryable property
                        // on the declarations they impact, so we don't need to do anything
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_Label:
                    // case CX_DeclKind.CX_DeclKind_Namespace:
                    // case CX_DeclKind.CX_DeclKind_NamespaceAlias:
                    // case CX_DeclKind.CX_DeclKind_ObjCCompatibleAlias: // TODO
                    // case CX_DeclKind.CX_DeclKind_ObjCCategory: // TODO
                    // case CX_DeclKind.CX_DeclKind_ObjCCategoryImpl: // TODO
                    // case CX_DeclKind.CX_DeclKind_ObjCImplementation: // TODO
                    // case CX_DeclKind.CX_DeclKind_ObjCInterface: // TODO
                    // case CX_DeclKind.CX_DeclKind_ObjCProtocol: // TODO
                    // case CX_DeclKind.CX_DeclKind_ObjCMethod: // TODO
                    // case CX_DeclKind.CX_DeclKind_ObjCProperty: // TODO
                    // case CX_DeclKind.CX_DeclKind_BuiltinTemplate:
                    // case CX_DeclKind.CX_DeclKind_Concept:
                    // case CX_DeclKind.CX_DeclKind_ClassTemplate:
                    // case CX_DeclKind.CX_DeclKind_FunctionTemplate:

                    // case CX_DeclKind.CX_DeclKind_TypeAliasTemplate:
                    // case CX_DeclKind.CX_DeclKind_VarTemplate:
                    // case CX_DeclKind.CX_DeclKind_TemplateTemplateParm:

                    case CX_DeclKind.CX_DeclKind_Enum:
                    {
                        var enumDecl = (EnumDecl) decl;
                        var nativeName = enumDecl.Name;
                        if (string.IsNullOrWhiteSpace(nativeName))
                        {
                            nativeName = typedef ?? GetAnonymousName(enumDecl, "Enum");
                        }

                        var existing = enums.FirstOrDefault(x => x.NativeName == nativeName);
                        if (!(existing is null) && existing.ClangMetadata?[0] != enumDecl.Location.ToString())
                        {
                            Console.WriteLine("Warning: Existing enum with same native name.");
                            Console.WriteLine($"    Existing: {existing.NativeName}, {existing.ClangMetadata[0]}");
                            Console.WriteLine($"    New: {existing.NativeName}, {enumDecl.Location}");
                            Console.WriteLine("Skipping...");
                            break;
                        }

                        if (task.ExcludedNativeNames?.Contains(nativeName) ?? false)
                        {
                            break;
                        }

                        string name = null;
                        task.RenamedNativeNames.TryGetValue(nativeName, out name);
                        enums.Add
                        (
                            new Enum
                            {
                                Name = name ?? Naming.TranslateVariable
                                    (Naming.TrimName(nativeName, task), task.FunctionPrefix),
                                NativeName = nativeName,
                                ClangMetadata = new[] {enumDecl.Location.ToString()},
                                Tokens = enumDecl.Enumerators.Where
                                        (x => !(task.ExcludedNativeNames?.Contains(x.Name) ?? false))
                                    .Select
                                    (
                                        x => new Token
                                        {
                                            Name = Naming.Translate(Naming.TrimName(x.Name, task), task.FunctionPrefix),
                                            NativeName = x.Name,
                                            Value = x.InitVal.ToString("X")
                                        }
                                    )
                                    .ToList(),
                                EnumBaseType = GetType(enumDecl.IntegerType, out _, ref _f, out _)
                            }
                        );
                        break;
                    }

                    case CX_DeclKind.CX_DeclKind_Record:
                    case CX_DeclKind.CX_DeclKind_CXXRecord:
                    {
                        var recordDecl = (RecordDecl) decl;
                        var cxxRecordDecl = recordDecl as CXXRecordDecl;
                        var nativeName = recordDecl.Name;
                        if (string.IsNullOrWhiteSpace(nativeName))
                        {
                            nativeName = typedef ?? GetAnonymousName(recordDecl, "Record");
                        }
                        
                        var existing = structs.FirstOrDefault(x => x.NativeName == nativeName);
                        if (!(existing is null) && existing.ClangMetadata?[0] != recordDecl.Location.ToString())
                        {
                            Console.WriteLine("Warning: Existing struct with same native name.");
                            Console.WriteLine($"    Existing: {existing.NativeName}, {existing.ClangMetadata[0]}");
                            Console.WriteLine($"    New: {existing.NativeName}, {recordDecl.Location}");
                            if (existing.Fields.Count == 0 && (recordDecl.Fields.Count > 0 || !(cxxRecordDecl is null)))
                            {
                                Console.WriteLine("Preferring new definition as the existing one is opaque.");
                                structs.Remove(existing);
                            }
                            else
                            {
                                Console.WriteLine("Skipping...");
                                break;
                            }
                        }

                        if (task.ExcludedNativeNames?.Contains(nativeName) ?? false)
                        {
                            break;
                        }

                        string name = null;
                        task.RenamedNativeNames.TryGetValue(nativeName, out name);

                        var attrs = new List<Attribute>();
                        if (recordDecl.IsUnion)
                        {
                            attrs.Add
                            (
                                new Attribute
                                {
                                    Name = "StructLayout", Arguments = new List<string> {"LayoutKind.Explicit"}
                                }
                            );
                        }

                        if (TryGetUuid(recordDecl, out var uuid))
                        {
                            attrs.Add(new Attribute{Name = "Guid", Arguments = new List<string>{$"\"{uuid}\""}});
                        }

                        Struct @struct;
                        structs.Add
                        (
                            @struct = new Struct
                            {
                                Name = name ?? Naming.TranslateVariable
                                    (Naming.TrimName(nativeName, task), task.FunctionPrefix),
                                NativeName = nativeName,
                                ClangMetadata = new[] {recordDecl.Location.ToString()},
                                Fields = ConvertAll(recordDecl).ToList(),
                                Attributes = attrs
                            }
                        );

                        AddVtblIfNecessary(recordDecl, @struct);
                        
                        if (!(cxxRecordDecl is null))
                        {
                            foreach (var cxxBaseSpecifier in cxxRecordDecl.Bases)
                            {
                                var baseCxxRecordDecl = GetRecordDeclForBaseSpecifier(cxxBaseSpecifier);
                                @struct.Fields.InsertRange
                                (
                                    0,
                                    ConvertAll(baseCxxRecordDecl)
                                );
                            }
                        }
                        
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_ClassTemplateSpecialization:
                    // case CX_DeclKind.CX_DeclKind_ClassTemplatePartialSpecialization:
                    // case CX_DeclKind.CX_DeclKind_TemplateTypeParm:
                    // case CX_DeclKind.CX_DeclKind_ObjCTypeParam:
                    // case CX_DeclKind.CX_DeclKind_TypeAlias:

                    case CX_DeclKind.CX_DeclKind_Typedef:
                    {
                        var typedefDecl = (TypedefDecl) decl;
                        VisitTypedefDecl(typedefDecl);
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_UnresolvedUsingTypename:

                    case CX_DeclKind.CX_DeclKind_Using:
                    {
                        // Using declarations only introduce existing members into
                        // the current scope. There isn't an easy way to translate
                        // this to C#, so we will ignore them for now.
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_UsingDirective:
                    // case CX_DeclKind.CX_DeclKind_UsingPack:
                    // case CX_DeclKind.CX_DeclKind_UsingShadow:
                    // case CX_DeclKind.CX_DeclKind_ConstructorUsingShadow:
                    // case CX_DeclKind.CX_DeclKind_Binding:

                    // case CX_DeclKind.CX_DeclKind_Field:
                    // {
                    //     VisitFieldDecl((FieldDecl) decl);
                    //     break;
                    // }

                    // case CX_DeclKind.CX_DeclKind_ObjCAtDefsField:
                    // case CX_DeclKind.CX_DeclKind_ObjCIvar:

                    case CX_DeclKind.CX_DeclKind_Function:
                    {
                        var functionDecl = (FunctionDecl) decl;
                        if (functionDecl.IsInlined)
                        {
                            break;
                        }

                        if (task.ExcludedNativeNames?.Contains(functionDecl.Name) ?? false)
                        {
                            break;
                        }

                        string name = null;
                        task.RenamedNativeNames.TryGetValue(functionDecl.Name, out name);

                        functions.Add
                        (
                            new Function
                            {
                                Name = name ?? Naming.TranslateLite
                                    (Naming.TrimName(functionDecl.Name, task), task.FunctionPrefix),
                                NativeName = functionDecl.Name,
                                Convention = GetCallingConvention
                                (
                                    functionDecl.Type is AttributedType attributedType
                                        ? attributedType.Handle.FunctionTypeCallingConv
                                        : ((FunctionType) functionDecl.Type).CallConv
                                ),
                                Parameters = functionDecl.Parameters.Select
                                    (
                                        (x, i) =>
                                        {
                                            var parameterFlow = FlowDirection.Undefined;
                                            return new Parameter
                                            {
                                                Name = string.IsNullOrWhiteSpace(x.Name) ? $"arg{i}" : x.Name,
                                                Type = GetType(x.Type, out var count, ref parameterFlow, out _),
                                                Flow = parameterFlow,
                                                Count = count
                                            };
                                        }
                                    )
                                    .ToList(),
                                ReturnType = GetType(functionDecl.ReturnType, out _, ref _f, out _),
                                Attributes = new List<Attribute>
                                {
                                    new Attribute
                                    {
                                        Name = "NativeName",
                                        Arguments = new List<string>
                                        {
                                            "\"Src\"",
                                            $"\"{functionDecl.Location}\"".Replace("\\", "\\\\")
                                        }
                                    }
                                }
                            }
                        );
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_CXXDeductionGuide:

                    // TODO case CX_DeclKind.CX_DeclKind_CXXMethod:
                    // TODO case CX_DeclKind.CX_DeclKind_CXXConstructor:
                    // TODO case CX_DeclKind.CX_DeclKind_CXXDestructor:
                    // TODO case CX_DeclKind.CX_DeclKind_CXXConversion:
                    // TODO {
                    // TODO     VisitFunctionDecl((CXXMethodDecl) decl, (CXXRecordDecl) decl.DeclContext);
                    // TODO     break;
                    // TODO }

                    // case CX_DeclKind.CX_DeclKind_MSProperty:
                    // case CX_DeclKind.CX_DeclKind_NonTypeTemplateParm:

                    // case CX_DeclKind.CX_DeclKind_Var:
                    // {
                    //     VisitVarDecl((VarDecl) decl);
                    //     break;
                    // }

                    // case CX_DeclKind.CX_DeclKind_Decomposition:
                    // case CX_DeclKind.CX_DeclKind_ImplicitParam:
                    // case CX_DeclKind.CX_DeclKind_OMPCapturedExpr:

                    // case CX_DeclKind.CX_DeclKind_ParmVar:
                    // {
                    //     VisitParmVarDecl((ParmVarDecl) decl);
                    //     break;
                    // }

                    // case CX_DeclKind.CX_DeclKind_VarTemplateSpecialization:
                    // case CX_DeclKind.CX_DeclKind_VarTemplatePartialSpecialization:

                    // BUG constants don't work. if we ever need enum constants that aren't in an enum, uncomment & fix
                    // case CX_DeclKind.CX_DeclKind_EnumConstant:
                    // {
                    //     var constantDecl = (EnumConstantDecl) decl;
                    //     constants.Add
                    //     (
                    //         new Constant
                    //         {
                    //             Name = constantDecl.Name, NativeName = constantDecl.Name,
                    //             Type = GetType(constantDecl.Type, out _, out _),
                    //             Value = "0x" + constantDecl.InitVal.ToString("X")
                    //         }
                    //     );
                    //     break;
                    // }

                    // case CX_DeclKind.CX_DeclKind_IndirectField:
                    // case CX_DeclKind.CX_DeclKind_OMPDeclareMapper:
                    // case CX_DeclKind.CX_DeclKind_OMPDeclareReduction:
                    // case CX_DeclKind.CX_DeclKind_UnresolvedUsingValue:
                    // case CX_DeclKind.CX_DeclKind_OMPAllocate:
                    // case CX_DeclKind.CX_DeclKind_OMPRequires:
                    // case CX_DeclKind.CX_DeclKind_OMPThreadPrivate:
                    // case CX_DeclKind.CX_DeclKind_ObjCPropertyImpl:
                    // case CX_DeclKind.CX_DeclKind_PragmaComment:
                    // case CX_DeclKind.CX_DeclKind_PragmaDetectMismatch:

                    case CX_DeclKind.CX_DeclKind_StaticAssert:
                    {
                        // Static asserts can't be easily modeled in C#
                        // We'll ignore them for now.
                        break;
                    }

                    // case CX_DeclKind.CX_DeclKind_TranslationUnit:

                    default:
                    {
                        //Console.WriteLine($"Warning: {decl.Kind} is not supported. Bindings may be incomplete.");
                        break;
                    }
                }

                visitedDecls.Add(decl);

                if (decl is IDeclContext declContext)
                {
                    VisitDecls(declContext.Decls);
                }
            }
            
            CXXRecordDecl GetRecordDeclForBaseSpecifier(CXXBaseSpecifier cxxBaseSpecifier)
            {
                ClangSharp.Type baseType = cxxBaseSpecifier.Type;

                while (!(baseType is RecordType))
                {
                    if (baseType is AttributedType attributedType)
                    {
                        baseType = attributedType.ModifiedType;
                    }
                    else if (baseType is ElaboratedType elaboratedType)
                    {
                        baseType = elaboratedType.CanonicalType;
                    }
                    else if (baseType is TypedefType typedefType)
                    {
                        baseType = typedefType.Decl.UnderlyingType;
                    }
                    else
                    {
                        break;
                    }
                }

                var baseRecordType = (RecordType)baseType;
                return (CXXRecordDecl)baseRecordType.Decl;
            }

            bool HasVtbl(CXXRecordDecl cxxRecordDecl)
            {
                var hasDirectVtbl = cxxRecordDecl.Methods.Any((method) => method.IsVirtual);
                var indirectVtblCount = 0;

                foreach (var cxxBaseSpecifier in cxxRecordDecl.Bases)
                {
                    var baseCxxRecordDecl = GetRecordDeclForBaseSpecifier(cxxBaseSpecifier);

                    if (HasVtbl(baseCxxRecordDecl))
                    {
                        indirectVtblCount++;
                    }
                }

                if (indirectVtblCount > 1)
                {
                    Console.WriteLine
                    (
                        "Warning: Unsupported cxx record declaration: 'multiple virtual bases'. Generated bindings " +
                        "may be incomplete. " + cxxRecordDecl
                    );
                }

                return hasDirectVtbl || (indirectVtblCount != 0);
            }
            
            void OutputVtblHelperMethod(CXXMethodDecl cxxMethodDecl,
                ref int vtblIndex,
                Struct @struct)
            {
                if (!cxxMethodDecl.IsVirtual)
                {
                    return;
                }

                if (@struct.Vtbl.Any(x => x.NativeName == cxxMethodDecl.Name))
                {
                    return;
                }

                if (task.ExcludedNativeNames.Contains(cxxMethodDecl.Name))
                {
                    vtblIndex += 1;
                    return;
                }

                string name = null;
                task.RenamedNativeNames.TryGetValue(cxxMethodDecl.Name, out name);

                @struct.Vtbl.Add
                (
                    new Function
                    {
                        Accessibility = cxxMethodDecl.Access switch
                        {
                            CX_CXXAccessSpecifier.CX_CXXInvalidAccessSpecifier => Accessibility.Public,
                            CX_CXXAccessSpecifier.CX_CXXPublic => Accessibility.Public,
                            CX_CXXAccessSpecifier.CX_CXXProtected => Accessibility.Protected,
                            CX_CXXAccessSpecifier.CX_CXXPrivate => Accessibility.Private,
                            _ => Accessibility.Internal
                        },
                        Attributes = new List<Attribute>(),
                        Convention = GetCallingConvention
                            ((cxxMethodDecl.Type as FunctionType)?.CallConv ?? CXCallingConv.CXCallingConv_C),
                        Name = name ?? Naming.TranslateLite
                            (Naming.TrimName(cxxMethodDecl.Name, task), task.FunctionPrefix),
                        NativeName = cxxMethodDecl.Name,
                        VtblIndex = vtblIndex,
                        ReturnType = GetType(cxxMethodDecl.ReturnType, out _, ref _f, out _),
                        Parameters = cxxMethodDecl.Parameters.Select
                            (
                                (x, i) =>
                                {
                                    var parameterFlow = FlowDirection.Undefined;
                                    return new Parameter
                                    {
                                        Name = string.IsNullOrWhiteSpace(x.Name) ? $"arg{i}" : x.Name,
                                        Type = GetType(x.Type, out var count, ref parameterFlow, out _),
                                        Flow = parameterFlow,
                                        Count = count
                                    };
                                }
                            )
                            .ToList()
                    }
                );
                vtblIndex += 1;
            }
            
            void OutputVtblHelperMethods(CXXRecordDecl cxxRecordDecl,
                ref int vtblIndex,
                Struct @struct)
            {
                foreach (var cxxBaseSpecifier in cxxRecordDecl.Bases)
                {
                    var baseCxxRecordDecl = GetRecordDeclForBaseSpecifier(cxxBaseSpecifier);
                    @struct.ComBases.Add(baseCxxRecordDecl.Name);
                    OutputVtblHelperMethods(baseCxxRecordDecl, ref vtblIndex, @struct);
                }

                var cxxMethodDecls = cxxRecordDecl.Methods;

                foreach (var cxxMethodDecl in cxxMethodDecls)
                {
                    OutputVtblHelperMethod(cxxMethodDecl, ref vtblIndex, @struct);
                }
            }

            void AddVtblIfNecessary(RecordDecl recordDecl, Struct @struct)
            {
                var i = 0;
                var cxxRecordDecl = recordDecl as CXXRecordDecl;
                var hasVtbl = false;

                if (cxxRecordDecl != null)
                {
                    hasVtbl = HasVtbl(cxxRecordDecl);
                }

                if (!hasVtbl)
                {
                    return;
                }

                @struct.Fields.Add
                    (new Field {Name = "LpVtbl", Type = new Type {Name = "void", IndirectionLevels = 2}, NativeName = "lpVtbl"});
                OutputVtblHelperMethods(cxxRecordDecl, ref i, @struct);
            }
        }
    }
}
