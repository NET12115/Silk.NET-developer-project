// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFragmentShadingRateTypeNV")]
    public enum FragmentShadingRateTypeNV : int
    {
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_TYPE_FRAGMENT_SIZE_NV")]
        FragmentShadingRateTypeFragmentSizeNV = 0,
        [NativeName("Name", "VK_FRAGMENT_SHADING_RATE_TYPE_ENUMS_NV")]
        FragmentShadingRateTypeEnumsNV = 1,
    }
}
