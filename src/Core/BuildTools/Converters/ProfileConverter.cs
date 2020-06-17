// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Converters.Constructors;
using Silk.NET.BuildTools.Converters.Readers;

namespace Silk.NET.BuildTools.Converters
{
    public static class ProfileConverter
    {
        public static IEnumerable<Profile> ReadProfiles
            (IReader reader, IConstructor ctor, Stream input, ProfileConverterOptions opts, BindTask task)
        {
            var obj = reader.Load(input);
            Console.WriteLine("Reading enums...");
            var enums = reader.ReadEnums(obj, opts).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Reading functions...");
            var functions = reader.ReadFunctions(obj, opts).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Reading structs...");
            var structs = reader.ReadStructs(obj, opts).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Reading constants...");
            var constants = reader.ReadConstants(obj, opts).OrderBy(x => x.Name).ToArray();
            Console.WriteLine("Creating profiles...");
            var profiles = enums.Select(x => (x.ProfileName, x.ProfileVersion))
                .Concat(functions.Select(x => (x.ProfileName, x.ProfileVersion)))
                .Concat(structs.Select(x => (x.ProfileName, x.ProfileVersion)))
                .Distinct()
                .Select(x => CreateBlankProfile(x.ProfileName, x.ProfileVersion, opts));

            foreach (var profile in profiles)
            {
                ctor.WriteEnums(profile, enums, opts, task);
                ctor.WriteFunctions(profile, functions, opts, task);
                ctor.WriteStructs(profile, structs, opts, task);
                ctor.WriteConstants(profile, constants, opts, task);
                foreach (var typeMap in task.TypeMaps)
                {
                    TypeMapper.Map
                    (
                        typeMap,
                        profile.Projects.Values.SelectMany(x => x.Classes.SelectMany(y => y.NativeApis.Values))
                            .SelectMany(x => x.Functions)
                    );
                }

                foreach (var typeMap in task.TypeMaps)
                {
                    TypeMapper.Map(typeMap, structs);
                }

                foreach (var kvp in profile.Projects)
                {
                    foreach (var @class in kvp.Value.Classes)
                    {
                        foreach (var constant in @class.Constants)
                        {
                            constant.Type = TypeMapper.MapOne(task.TypeMaps, constant.Type);
                        }
                    }
                }

                Console.WriteLine($"Created profile \"{profile.Name}\" version {profile.Version}");

                yield return profile;
            }
        }

        private static Stream OpenPath(string path)
        {
            if (path.StartsWith("http://") || path.StartsWith("https://"))
            {
                // Download from the specified url into a temporary file
                using var wb = new HttpClient();
                return wb.GetStreamAsync(path).GetAwaiter().GetResult();
            }

            return File.OpenRead(path);
        }

        public static void WriteProfiles(CommandLineOptions opts, BindTask task)
        {
            if (!Directory.Exists(opts.OutputFolder))
            {
                Directory.CreateDirectory(opts.OutputFolder);
            }

            var reader = opts.Reader.ToLower() switch
            {
                "gl" => (IReader) new OpenGLReader(),
                "cl" => (IReader) new OpenCLReader(),
                "vk" => (IReader) new VulkanReader(),
                _ => throw new ArgumentException("Couldn't find a reader with that name")
            };

            var constructor = opts.Constructor.ToLower() switch
            {
                "gl" => (IConstructor) new OpenGLConstructor(),
                "cl" => (IConstructor) new OpenCLConstructor(),
                "vk" => (IConstructor) new VulkanConstructor(),
                _ => throw new ArgumentException("Couldn't find a constructor with that name")
            };

            foreach (var file in opts.InputFiles.Select(OpenPath))
            {
                foreach (var profile in ReadProfiles
                (
                    reader, constructor, file,
                    new ProfileConverterOptions
                    {
                        Prefix = opts.Prefix,
                        TypeMaps = opts.Typemap.Select(File.ReadAllText)
                            .Select(JsonConvert.DeserializeObject<Dictionary<string, string>>)
                            .ToList()
                    }, task
                ))
                {
                    using var outStream = opts.OutputFolder == null
                        ? Console.Out
                        : new StreamWriter
                        (
                            Path.Combine
                            (
                                opts.OutputFolder,
                                $"api-{profile.Name}{(!string.IsNullOrEmpty(profile.Version) ? $"-{profile.Version}" : null)}.json"
                            )
                        );
                    outStream.Write
                    (
                        JsonConvert.SerializeObject(profile, opts.PrettyPrinted ? Formatting.Indented : Formatting.None)
                    );
                    outStream.Flush();
                }
            }
        }

        private static Profile CreateBlankProfile(string name, Version version, ProfileConverterOptions opts)
        {
            return new Profile
            {
                Name = name,
                Version = version?.ToString(2)
            };
        }
    }
}
