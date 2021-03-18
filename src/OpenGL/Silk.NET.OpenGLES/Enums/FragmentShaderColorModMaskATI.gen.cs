// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FragmentShaderColorModMaskATI")]
    public enum FragmentShaderColorModMaskATI : int
    {
        [NativeName("Name", "GL_COMP_BIT_ATI")]
        CompBitAti = 0x2,
        [NativeName("Name", "GL_NEGATE_BIT_ATI")]
        NegateBitAti = 0x4,
        [NativeName("Name", "GL_BIAS_BIT_ATI")]
        BiasBitAti = 0x8,
    }
}
