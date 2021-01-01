// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FragmentShaderDestModMaskATI")]
    public enum FragmentShaderDestModMaskATI : int
    {
        [NativeName("Name", "GL_2X_BIT_ATI")]
        Gl2XBitAti = 0x1,
        [NativeName("Name", "GL_4X_BIT_ATI")]
        Gl4XBitAti = 0x2,
        [NativeName("Name", "GL_8X_BIT_ATI")]
        Gl8XBitAti = 0x4,
        [NativeName("Name", "GL_HALF_BIT_ATI")]
        HalfBitAti = 0x8,
        [NativeName("Name", "GL_QUARTER_BIT_ATI")]
        QuarterBitAti = 0x10,
        [NativeName("Name", "GL_EIGHTH_BIT_ATI")]
        EighthBitAti = 0x20,
        [NativeName("Name", "GL_SATURATE_BIT_ATI")]
        SaturateBitAti = 0x40,
    }
}
