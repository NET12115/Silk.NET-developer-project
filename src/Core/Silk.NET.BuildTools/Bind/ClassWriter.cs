﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.IO;
using System.Linq;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading;

namespace Silk.NET.BuildTools.Bind
{
    public static class ClassWriter
    {
        /// <summary>
        /// Create a class that extends SearchPathContainer.
        /// </summary>
        /// <param name="project">The current project.</param>
        /// <param name="profile">The profile to write the object for.</param>
        /// <param name="file">The file to write the class to.</param>
        public static void WriteNameContainer(this Project project, Profile profile, string file, BindState task)
        {
            if (File.Exists(file) || task.Task.Controls.Contains("no-name-container"))
            {
                return;
            }
            
            using var sw = new StreamWriter(file);
            
            sw.WriteLine(task.LicenseText());
            sw.WriteLine("using Silk.NET.Core.Loader;");
            sw.WriteLine();
            sw.WriteLine($"namespace {task.Task.Namespace}{project.Namespace}");
            sw.WriteLine("{");
            sw.WriteLine("    /// <summary>");
            sw.WriteLine($"    /// Contains the library name of {profile.Name}.");
            sw.WriteLine("    /// </summary>");
            sw.WriteLine($"    internal class {task.Task.NameContainer.ClassName} : SearchPathContainer");
            sw.WriteLine("    {");
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Linux => \"{task.Task.NameContainer.Linux}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string MacOS => \"{task.Task.NameContainer.MacOS}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Android => \"{task.Task.NameContainer.Android}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string IOS => \"{task.Task.NameContainer.IOS}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Windows64 => \"{task.Task.NameContainer.Windows64}\";");
            sw.WriteLine();
            sw.WriteLine("        /// <inheritdoc />");
            sw.WriteLine($"        public override string Windows86 => \"{task.Task.NameContainer.Windows86}\";");
            sw.WriteLine("    }");
            sw.WriteLine("}");
        }

        /// <summary>
        /// Write mixed-mode (partial) classes.
        /// </summary>
        /// <param name="project">The current project.</param>
        /// <param name="profile">The profile to write mixed-mode classes for.</param>
        /// <param name="folder">The folder to store the generated classes in.</param>
        public static void WriteMixedModeClasses(this Project project, Profile profile, string folder, BindState task)
        {
            // public abstract class MixedModeClass : IMixedModeClass
            // {
            // }
            foreach (var @class in project.Classes)
            {
                if ((@class.NativeApis.Values.Sum(x => x.Functions.Count) + @class.Functions.Count) == 0)
                {
                    Console.WriteLine($"Warning: No functions, writing of class \"{@class.ClassName}\" skipped...");
                    continue;
                }
            
                if (project.IsRoot)
                {
                    var sw = new StreamWriter(Path.Combine(folder, $"{@class.ClassName}.gen.cs"));
                    StreamWriter? swOverloads = null;
                    sw.Write(task.LicenseText());
                    sw.WriteCoreUsings();
                    sw.WriteLine();
                    sw.WriteLine("#pragma warning disable 1591");
                    sw.WriteLine();
                    sw.WriteLine($"namespace {task.Task.Namespace}{project.Namespace}");
                    sw.WriteLine("{");
                    sw.WriteLine
                        ($"    public unsafe partial class {@class.ClassName} : NativeAPI");
                    sw.WriteLine("    {");
                    foreach (var constant in @class.Constants)
                    {
                        sw.WriteLine($"        [NativeName(\"Type\", \"{constant.Type.OriginalName}\")]");
                        sw.WriteLine($"        [NativeName(\"Name\", \"{constant.NativeName}\")]");
                        sw.WriteLine($"        public const {constant.Type} {constant.Name} = {constant.Value};");
                    }

                    sw.WriteLine();

                    var allFunctions = @class.NativeApis.SelectMany
                            (x => x.Value.Functions)
                        .RemoveDuplicates()
                        .ToArray();
                    foreach (var function in allFunctions)
                    {
                        if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                        {
                            sw.WriteLine($"#if {function.PreprocessorConditions}");
                        }

                        using (var sr = new StringReader(function.Doc))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {line}");
                            }
                        }

                        foreach (var attr in function.Attributes)
                        {
                            sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                        }

                        sw.WriteLine($"        [NativeApi(EntryPoint = \"{function.NativeName}\")]");
                        using (var sr = new StringReader(function.ToString(null, true, true)))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine($"        {line}");
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                        {
                            sw.WriteLine("#endif");
                        }

                        sw.WriteLine();
                    }

                    foreach (var overload in Overloader.GetOverloads(allFunctions, profile.Projects["Core"]))
                    {
                        var sw2u = overload.Signature.Kind == SignatureKind.PotentiallyConflictingOverload
                            ? swOverloads ??= CreateOverloadsFile(folder, @class.ClassName, false)
                            : sw;
                        if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                        {
                            sw2u.WriteLine($"#if {overload.Base.PreprocessorConditions}");
                        }

                        if (sw2u == swOverloads)
                        {
                            overload.Signature.Parameters.Insert
                            (
                                0,
                                new Parameter
                                {
                                    Name = "thisApi",
                                    Type = new Common.Functions.Type {Name = @class.ClassName, IsThis = true}
                                }
                            );
                        }

                        using (var sr = new StringReader(overload.Signature.Doc))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw2u.WriteLine($"        {line}");
                            }
                        }

                        foreach (var attr in overload.Signature.Attributes)
                        {
                            sw2u.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                        }

                        sw2u.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe, @static: sw2u == swOverloads).TrimEnd(';')}");
                        sw2u.WriteLine("        {");
                        foreach (var line in overload.Body)
                        {
                            sw2u.WriteLine($"            {line}");
                        }

                        sw2u.WriteLine("        }");
                        
                        if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                        {
                            sw2u.WriteLine($"#endif");
                        }
                        
                        sw2u.WriteLine();
                    }

                    sw.WriteLine();
                    sw.WriteLine($"        public {@class.ClassName}(INativeContext ctx)");
                    sw.WriteLine("            : base(ctx)");
                    sw.WriteLine("        {");
                    sw.WriteLine("        }");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    sw.WriteLine();
                    FinishOverloadsFile(swOverloads);
                    sw.Flush();
                    sw.Dispose();
                    if (!File.Exists(Path.Combine(folder, $"{@class.ClassName}.cs")))
                    {
                        sw = new StreamWriter(Path.Combine(folder, $"{@class.ClassName}.cs"));
                        sw.WriteCoreUsings();
                        sw.WriteLine();
                        sw.WriteLine("#pragma warning disable 1591");
                        sw.WriteLine();
                        sw.WriteLine($"namespace {task.Task.Namespace}{project.Namespace}");
                        sw.WriteLine("{");
                        sw.WriteLine($"    public partial class {@class.ClassName}");
                        sw.WriteLine("    {");
                        sw.WriteLine($"        public static {@class.ClassName} GetApi()");
                        sw.WriteLine("        {");
                        if (!(task.Task.NameContainer is null))
                        {
                            sw.WriteLine
                            (
                                $"             return new {@class.ClassName}(CreateDefaultContext" +
                                $"(new {task.Task.NameContainer.ClassName}().GetLibraryName()));"
                            );
                        }
                        else
                        {
                            sw.WriteLine("             throw new NotImplementedException();");
                        }
                        sw.WriteLine("        }");
                        sw.WriteLine();
                        sw.WriteLine("        public bool TryGetExtension<T>(out T ext)");
                        sw.WriteLine($"            where T:NativeExtension<{@class.ClassName}>");
                        sw.WriteLine("        {");
                        sw.WriteLine("             ext = IsExtensionPresent(" +
                                     "ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)");
                        sw.WriteLine("                 ? (T) Activator.CreateInstance(typeof(T), Context)");
                        sw.WriteLine("                 : null;");
                        sw.WriteLine("             return ext is not null;");
                        sw.WriteLine("        }");
                        sw.WriteLine();
                        sw.WriteLine("        public override bool IsExtensionPresent(string extension)");
                        sw.WriteLine("        {");
                        sw.WriteLine("            throw new NotImplementedException();");
                        sw.WriteLine("        }");
                        sw.WriteLine("    }");
                        sw.WriteLine("}");
                        sw.WriteLine();
                        sw.Flush();
                        sw.Dispose();
                    }

                    if (!(task.Task.NameContainer is null))
                    {
                        project.WriteNameContainer
                            (profile, Path.Combine(folder, $"{task.Task.NameContainer.ClassName}.cs"), task);
                    }
                }
                else
                {
                    foreach (var (key, i) in @class.NativeApis)
                    {
                        var name = i.Name.Substring(1);
                        var sw = new StreamWriter(Path.Combine(folder, $"{name}.gen.cs"));
                        StreamWriter? swOverloads = null;
                        sw.Write(task.LicenseText());
                        sw.WriteCoreUsings();
                        sw.WriteLine($"using {profile.Projects["Core"].GetNamespace(task.Task)};");
                        sw.WriteLine("using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;");
                        sw.WriteLine();
                        sw.WriteLine("#pragma warning disable 1591");
                        sw.WriteLine();
                        sw.WriteLine($"namespace {task.Task.ExtensionsNamespace}{project.Namespace}");
                        sw.WriteLine("{");
                        sw.WriteLine($"    [Extension(\"{key}\")]");
                        sw.WriteLine
                        (
                            $"    public unsafe partial class {name} : NativeExtension<{@class.ClassName}>"
                        );
                        sw.WriteLine("    {");
                        sw.WriteLine($"        public const string ExtensionName = \"{key}\";");
                        foreach (var function in i.Functions)
                        {
                            if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                            {
                                sw.WriteLine($"#if {function.PreprocessorConditions}");
                            }

                            using (var sr = new StringReader(function.Doc))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw.WriteLine($"        {line}");
                                }
                            }

                            foreach (var attr in function.Attributes)
                            {
                                sw.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                            }

                            sw.WriteLine($"        [NativeApi(EntryPoint = \"{function.NativeName}\")]");
                            using (var sr = new StringReader(function.ToString(null, true, true)))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw.WriteLine($"        {line}");
                                }
                            }
                            
                            if (!string.IsNullOrWhiteSpace(function.PreprocessorConditions))
                            {
                                sw.WriteLine($"#endif");
                            }

                            sw.WriteLine();
                        }

                        foreach (var overload in Overloader.GetOverloads(i.Functions, profile.Projects["Core"]))
                        {
                            var sw2u = overload.Signature.Kind == SignatureKind.PotentiallyConflictingOverload
                                ? swOverloads ??= CreateOverloadsFile(folder, name, true)
                                : sw;
                            if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                            {
                                sw2u.WriteLine($"#if {overload.Base.PreprocessorConditions}");
                            }

                            if (sw2u == swOverloads)
                            {
                                overload.Signature.Parameters.Insert
                                (
                                    0,
                                    new Parameter
                                    {
                                        Name = "thisApi",
                                        Type = new Common.Functions.Type {Name = name, IsThis = true}
                                    }
                                );
                            }

                            using (var sr = new StringReader(overload.Signature.Doc))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    sw2u.WriteLine($"        {line}");
                                }
                            }

                            foreach (var attr in overload.Signature.Attributes)
                            {
                                sw2u.WriteLine($"        [{attr.Name}({string.Join(", ", attr.Arguments)})]");
                            }

                            sw2u.WriteLine($"        public {overload.Signature.ToString(overload.IsUnsafe, @static: sw2u == swOverloads).TrimEnd(';')}");
                            sw2u.WriteLine("        {");
                            foreach (var line in overload.Body)
                            {
                                sw2u.WriteLine($"            {line}");
                            }

                            sw2u.WriteLine("        }");
                            
                            if (!string.IsNullOrWhiteSpace(overload.Base.PreprocessorConditions))
                            {
                                sw2u.WriteLine($"#endif");
                            }

                            sw2u.WriteLine();
                        }

                        sw.WriteLine($"        public {name}(INativeContext ctx)");
                        sw.WriteLine("            : base(ctx)");
                        sw.WriteLine("        {");
                        sw.WriteLine("        }");
                        sw.WriteLine("    }");
                        sw.WriteLine("}");
                        sw.WriteLine();
                        sw.Flush();
                        FinishOverloadsFile(swOverloads);
                    }
                }
            }

            StreamWriter CreateOverloadsFile(string folder, string @class, bool isExtension)
            {
                var ns = isExtension ? task.Task.ExtensionsNamespace : task.Task.Namespace;
                var swOverloads = new StreamWriter(Path.Combine(folder, $"{@class}Overloads.gen.cs"));
                swOverloads.Write(task.LicenseText());
                swOverloads.WriteCoreUsings();
                swOverloads.WriteLine();
                swOverloads.WriteLine("#pragma warning disable 1591");
                swOverloads.WriteLine();
                swOverloads.WriteLine($"namespace {ns}{project.Namespace}");
                swOverloads.WriteLine("{");
                swOverloads.WriteLine($"    public static class {@class}Overloads");
                swOverloads.WriteLine("    {");
                return swOverloads;
            }

            static void FinishOverloadsFile(StreamWriter? swOverloads)
            {
                swOverloads?.WriteLine("    }");
                swOverloads?.WriteLine("}");
                swOverloads?.WriteLine();
                swOverloads?.Flush();
                swOverloads?.Dispose();
            }
        }
    }
}
