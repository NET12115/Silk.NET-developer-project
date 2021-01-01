// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "InterleavedArrayFormat")]
    public enum InterleavedArrayFormat : int
    {
        [NativeName("Name", "GL_V2F")]
        V2f = 0x2A20,
        [NativeName("Name", "GL_V3F")]
        V3f = 0x2A21,
        [NativeName("Name", "GL_C4UB_V2F")]
        C4UBV2f = 0x2A22,
        [NativeName("Name", "GL_C4UB_V3F")]
        C4UBV3f = 0x2A23,
        [NativeName("Name", "GL_C3F_V3F")]
        C3fV3f = 0x2A24,
        [NativeName("Name", "GL_N3F_V3F")]
        N3fV3f = 0x2A25,
        [NativeName("Name", "GL_C4F_N3F_V3F")]
        C4fN3fV3f = 0x2A26,
        [NativeName("Name", "GL_T2F_V3F")]
        T2fV3f = 0x2A27,
        [NativeName("Name", "GL_T4F_V4F")]
        T4fV4f = 0x2A28,
        [NativeName("Name", "GL_T2F_C4UB_V3F")]
        T2fC4UBV3f = 0x2A29,
        [NativeName("Name", "GL_T2F_C3F_V3F")]
        T2fC3fV3f = 0x2A2A,
        [NativeName("Name", "GL_T2F_N3F_V3F")]
        T2fN3fV3f = 0x2A2B,
        [NativeName("Name", "GL_T2F_C4F_N3F_V3F")]
        T2fC4fN3fV3f = 0x2A2C,
        [NativeName("Name", "GL_T4F_C4F_N3F_V4F")]
        T4fC4fN3fV4f = 0x2A2D,
    }
}
