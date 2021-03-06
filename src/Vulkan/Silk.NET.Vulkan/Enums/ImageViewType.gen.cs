// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageViewType")]
    public enum ImageViewType : int
    {
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_1D")]
        ImageViewType1D = 0,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_2D")]
        ImageViewType2D = 1,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_3D")]
        ImageViewType3D = 2,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_CUBE")]
        Cube = 3,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_1D_ARRAY")]
        ImageViewType1DArray = 4,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_2D_ARRAY")]
        ImageViewType2DArray = 5,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_CUBE_ARRAY")]
        CubeArray = 6,
    }
}
