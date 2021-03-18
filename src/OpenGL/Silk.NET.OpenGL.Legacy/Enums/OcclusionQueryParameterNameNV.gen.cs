// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "OcclusionQueryParameterNameNV")]
    public enum OcclusionQueryParameterNameNV : int
    {
        [NativeName("Name", "GL_PIXEL_COUNT_NV")]
        PixelCountNV = 0x8866,
        [NativeName("Name", "GL_PIXEL_COUNT_AVAILABLE_NV")]
        PixelCountAvailableNV = 0x8867,
    }
}
