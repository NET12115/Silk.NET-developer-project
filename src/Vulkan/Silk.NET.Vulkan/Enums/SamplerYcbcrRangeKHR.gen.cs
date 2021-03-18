// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerYcbcrRangeKHR")]
    public enum SamplerYcbcrRangeKHR : int
    {
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_FULL")]
        SamplerYcbcrRangeItuFull = 0,
        [NativeName("Name", "VK_SAMPLER_YCBCR_RANGE_ITU_NARROW")]
        SamplerYcbcrRangeItuNarrow = 1,
    }
}
