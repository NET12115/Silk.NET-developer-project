// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum ClearBufferMask
    {
        DepthBufferBit = 0x100,
        AccumBufferBit = 0x200,
        StencilBufferBit = 0x400,
        ColorBufferBit = 0x4000,
        CoverageBufferBitNV = 0x8000,
    }
}
