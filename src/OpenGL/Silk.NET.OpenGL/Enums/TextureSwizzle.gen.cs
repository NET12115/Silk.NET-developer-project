// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureSwizzle")]
    public enum TextureSwizzle : int
    {
        [NativeName("Name", "GL_ZERO")]
        Zero = 0x0,
        [NativeName("Name", "GL_ONE")]
        One = 0x1,
        [NativeName("Name", "GL_RED")]
        Red = 0x1903,
        [NativeName("Name", "GL_GREEN")]
        Green = 0x1904,
        [NativeName("Name", "GL_BLUE")]
        Blue = 0x1905,
        [NativeName("Name", "GL_ALPHA")]
        Alpha = 0x1906,
    }
}
