// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FogMode")]
    public enum FogMode : int
    {
        [NativeName("Name", "GL_EXP")]
        Exp = 0x800,
        [NativeName("Name", "GL_EXP2")]
        Exp2 = 0x801,
        [NativeName("Name", "GL_LINEAR")]
        Linear = 0x2601,
        [NativeName("Name", "GL_FOG_FUNC_SGIS")]
        FogFuncSgis = 0x812A,
    }
}
