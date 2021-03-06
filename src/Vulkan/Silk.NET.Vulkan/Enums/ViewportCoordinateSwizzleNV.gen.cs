// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkViewportCoordinateSwizzleNV")]
    public enum ViewportCoordinateSwizzleNV : int
    {
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_X_NV")]
        ViewportCoordinateSwizzlePositiveXNV = 0,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_X_NV")]
        ViewportCoordinateSwizzleNegativeXNV = 1,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Y_NV")]
        ViewportCoordinateSwizzlePositiveYNV = 2,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Y_NV")]
        ViewportCoordinateSwizzleNegativeYNV = 3,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_Z_NV")]
        ViewportCoordinateSwizzlePositiveZNV = 4,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_Z_NV")]
        ViewportCoordinateSwizzleNegativeZNV = 5,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_POSITIVE_W_NV")]
        ViewportCoordinateSwizzlePositiveWNV = 6,
        [NativeName("Name", "VK_VIEWPORT_COORDINATE_SWIZZLE_NEGATIVE_W_NV")]
        ViewportCoordinateSwizzleNegativeWNV = 7,
    }
}
