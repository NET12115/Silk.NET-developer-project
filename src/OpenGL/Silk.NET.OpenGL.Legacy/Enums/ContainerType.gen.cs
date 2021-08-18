// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ContainerType")]
    public enum ContainerType : int
    {
        [NativeName("Name", "GL_PROGRAM_OBJECT_ARB")]
        ProgramObjectArb = 0x8B40,
        [NativeName("Name", "GL_PROGRAM_OBJECT_EXT")]
        ProgramObjectExt = 0x8B40,
    }
}
