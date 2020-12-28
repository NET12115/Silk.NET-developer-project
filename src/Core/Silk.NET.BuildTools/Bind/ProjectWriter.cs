﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.IO;
using System.Linq;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.Bind
{
    public static class ProjectWriter
    {
        /// <summary>
        /// Writes this project in the given folder, with the given settings and parent subsystem.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder to write this project to.</param>
        /// <param name="profile">The parent subsystem.</param>
        public static void Write(this Project project, string folder, Profile profile, BindState task)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (!Directory.Exists(Path.Combine(folder, ProfileWriter.EnumsSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, ProfileWriter.EnumsSubfolder));
            }

            if (!Directory.Exists(Path.Combine(folder, ProfileWriter.StructsSubfolder)))
            {
                Directory.CreateDirectory(Path.Combine(folder, ProfileWriter.StructsSubfolder));
            }

            project.WriteProjectFile(folder, profile, task);

            project.Structs.ForEach
            (
                x => x.WriteStruct
                (
                    Path.Combine(folder, ProfileWriter.StructsSubfolder, $"{x.Name}.gen.cs"), profile, project, task
                )
            );

            project.Enums.ForEach
            (
                x => x.WriteEnum
                    (Path.Combine(folder, ProfileWriter.EnumsSubfolder, $"{x.Name}.gen.cs"), profile, project, task)
            );

            project.WriteMixedModeClasses(profile, folder, task);
        }

        /// <summary>
        /// Writes the project file to the given folder.
        /// </summary>
        /// <param name="project">The project to write.</param>
        /// <param name="folder">The folder that should contain the project file.</param>
        /// <param name="prof">The parent profile.</param>
        private static void WriteProjectFile(this Project project, string folder, Profile prof, BindState task)
        {
            if (File.Exists(Path.Combine(folder, $"{project.GetProjectName(task.Task)}.csproj")) ||
                task.Task.Controls.Contains("no-csproj"))
            {
                return;
            }

            var csproj = new StreamWriter(Path.Combine(folder, $"{project.GetProjectName(task.Task)}.csproj"));
            csproj.WriteLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
            csproj.WriteLine();
            csproj.WriteLine("  <PropertyGroup>");
            csproj.WriteLine
                ("    <TargetFrameworks>netstandard2.0;netstandard2.1;netcoreapp3.1;net5.0</TargetFrameworks>");
            csproj.WriteLine("    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
            csproj.WriteLine("    <LangVersion>preview</LangVersion>");
            csproj.WriteLine("  </PropertyGroup>");
            csproj.WriteLine();
            csproj.WriteLine("  <ItemGroup>");
            if (!project.IsRoot)
            {
                var core = Path.GetRelativePath
                (
                    folder,
                    Path.Combine
                    (
                        task.Task.OutputOpts.Folder,
                        prof.Projects["Core"].GetProjectName(task.Task),
                        $"{prof.Projects["Core"].GetProjectName(task.Task)}.csproj"
                    )
                );
                csproj.WriteLine($"    <ProjectReference Include=\"{core}\" />");
            }

            csproj.WriteLine("  </ItemGroup>");
            csproj.WriteLine();
            csproj.WriteLine($"  <Import Project=\"{Path.GetRelativePath(folder, task.Task.OutputOpts.Props)}\" />");
            csproj.WriteLine("</Project>");
            csproj.Flush();
            csproj.Dispose();
        }
    }
}
