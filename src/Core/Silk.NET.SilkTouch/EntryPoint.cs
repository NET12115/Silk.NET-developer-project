// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch
{
    public readonly struct EntryPoint
    {
        public readonly string Name;
        public readonly CallingConvention CallingConvention;
        public readonly TypeSyntax[] LoadTypes;
        public readonly IMethodSymbol SourceSymbol;
        
        public EntryPoint(string name, CallingConvention callingConvention, TypeSyntax[] loadTypes, IMethodSymbol sourceSymbol)
        {
            Name = name;
            CallingConvention = callingConvention;
            LoadTypes = loadTypes;
            SourceSymbol = sourceSymbol;
        }
    }
}
