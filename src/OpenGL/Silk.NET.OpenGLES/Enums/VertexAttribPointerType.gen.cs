// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexAttribPointerType")]
    public enum VertexAttribPointerType : int
    {
        [NativeName("Name", "GL_BYTE")]
        Byte = 0x1400,
        [NativeName("Name", "GL_UNSIGNED_BYTE")]
        UnsignedByte = 0x1401,
        [NativeName("Name", "GL_SHORT")]
        Short = 0x1402,
        [NativeName("Name", "GL_UNSIGNED_SHORT")]
        UnsignedShort = 0x1403,
        [NativeName("Name", "GL_INT")]
        Int = 0x1404,
        [NativeName("Name", "GL_UNSIGNED_INT")]
        UnsignedInt = 0x1405,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [NativeName("Name", "GL_DOUBLE")]
        Double = 0x140A,
        [NativeName("Name", "GL_HALF_FLOAT")]
        HalfFloat = 0x140B,
        [NativeName("Name", "GL_FIXED")]
        Fixed = 0x140C,
        [NativeName("Name", "GL_INT64_ARB")]
        Int64Arb = 0x140E,
        [NativeName("Name", "GL_INT64_NV")]
        Int64NV = 0x140E,
        [NativeName("Name", "GL_UNSIGNED_INT64_ARB")]
        UnsignedInt64Arb = 0x140F,
        [NativeName("Name", "GL_UNSIGNED_INT64_NV")]
        UnsignedInt64NV = 0x140F,
        [NativeName("Name", "GL_UNSIGNED_INT_2_10_10_10_REV")]
        UnsignedInt2101010Rev = 0x8368,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV")]
        UnsignedInt10f11f11fRev = 0x8C3B,
        [NativeName("Name", "GL_INT_2_10_10_10_REV")]
        Int2101010Rev = 0x8D9F,
    }
}
