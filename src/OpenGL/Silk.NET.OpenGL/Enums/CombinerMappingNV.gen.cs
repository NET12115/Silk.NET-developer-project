// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "CombinerMappingNV")]
    public enum CombinerMappingNV : int
    {
        [NativeName("Name", "GL_UNSIGNED_IDENTITY_NV")]
        UnsignedIdentityNV = 0x8536,
        [NativeName("Name", "GL_UNSIGNED_INVERT_NV")]
        UnsignedInvertNV = 0x8537,
        [NativeName("Name", "GL_EXPAND_NORMAL_NV")]
        ExpandNormalNV = 0x8538,
        [NativeName("Name", "GL_EXPAND_NEGATE_NV")]
        ExpandNegateNV = 0x8539,
        [NativeName("Name", "GL_HALF_BIAS_NORMAL_NV")]
        HalfBiasNormalNV = 0x853A,
        [NativeName("Name", "GL_HALF_BIAS_NEGATE_NV")]
        HalfBiasNegateNV = 0x853B,
        [NativeName("Name", "GL_SIGNED_IDENTITY_NV")]
        SignedIdentityNV = 0x853C,
        [NativeName("Name", "GL_SIGNED_NEGATE_NV")]
        SignedNegateNV = 0x853D,
    }
}
