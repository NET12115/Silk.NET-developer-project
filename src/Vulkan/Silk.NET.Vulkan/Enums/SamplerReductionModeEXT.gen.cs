// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSamplerReductionModeEXT")]
    public enum SamplerReductionModeEXT : int
    {
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_WEIGHTED_AVERAGE")]
        SamplerReductionModeWeightedAverage = 0,
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_MIN")]
        SamplerReductionModeMin = 1,
        [NativeName("Name", "VK_SAMPLER_REDUCTION_MODE_MAX")]
        SamplerReductionModeMax = 2,
    }
}
