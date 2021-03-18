// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "LightModelColorControl")]
    public enum LightModelColorControl : int
    {
        [NativeName("Name", "GL_SINGLE_COLOR_EXT")]
        SingleColorExt = 0x81F9,
        [NativeName("Name", "GL_SEPARATE_SPECULAR_COLOR_EXT")]
        SeparateSpecularColorExt = 0x81FA,
    }
}
