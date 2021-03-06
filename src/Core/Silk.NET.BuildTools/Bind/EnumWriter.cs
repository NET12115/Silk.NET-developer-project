// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Bind
{
    public static class EnumWriter
    {
        /// <summary>
        /// Writes this enum to a file.
        /// </summary>
        /// <param name="enum">The enum to write.</param>
        /// <param name="file">The file to write to.</param>
        /// <param name="profile">The subsystem containing this enum.</param>
        /// <param name="project">The project containing this enum.</param>
        public static void WriteEnum(this Enum @enum, string file, Profile profile, Project project, BindState task)
        {
            var sw = new StreamWriter(file) {NewLine = "\n"};
            sw.WriteLine(task.LicenseText());
            sw.WriteLine();
            var ns = project.IsRoot ? task.Task.Namespace : task.Task.ExtensionsNamespace;
            sw.WriteLine("using System;");
            sw.WriteLine("using Silk.NET.Core.Attributes;");
            sw.WriteLine();
            sw.WriteLine("#pragma warning disable 1591");
            sw.WriteLine();
            sw.WriteLine($"namespace {ns}{project.Namespace}");
            sw.WriteLine("{");
            foreach (var attr in @enum.Attributes)
            {
                sw.WriteLine($"    {attr}");
            }

            sw.WriteLine($"    [NativeName(\"Name\", \"{@enum.NativeName}\")]");
            sw.WriteLine($"    public enum {@enum.Name} : {@enum.EnumBaseType}");
            sw.WriteLine("    {");
            for (var index = 0; index < @enum.Tokens.Count; index++)
            {
                var token = @enum.Tokens[index];
                sw.WriteLine($"        [NativeName(\"Name\", \"{token.NativeName}\")]");
                sw.Write($"        {token.Name} = {MakeUnchecked(token.Value, @enum.EnumBaseType)}");
                sw.WriteLine($"{(index != @enum.Tokens.Count ? "," : string.Empty)}");
            }

            sw.WriteLine("    }");
            sw.WriteLine("}");
            sw.Flush();
            sw.Dispose();
        }

        private static string MakeUnchecked(string value, Type enumBaseType) => value.Contains("unchecked")
            ? value
            : enumBaseType.Name switch
            {
                "sbyte" => Utilities.ParseSbyte(value) is null ? $"unchecked((sbyte) {value})" : value,
                "byte" => Utilities.ParseByte(value) is null ? $"unchecked((byte) {value})" : value,
                "short" => Utilities.ParseShort(value) is null ? $"unchecked((short) {value})" : value,
                "ushort" => Utilities.ParseUshort(value) is null ? $"unchecked((ushort) {value})" : value,
                "int" => Utilities.ParseInt(value) is null ? $"unchecked((int) {value})" : value,
                "uint" => Utilities.ParseUint(value) is null ? $"unchecked((uint) {value})" : value,
                "long" => Utilities.ParseLong(value) is null ? $"unchecked((long) {value})" : value,
                "ulong" => Utilities.ParseUlong(value) is null ? $"unchecked((ulong) {value})" : value,
                _ => value
            };
    }
}
