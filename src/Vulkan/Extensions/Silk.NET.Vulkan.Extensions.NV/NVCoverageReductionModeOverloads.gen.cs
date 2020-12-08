// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVCoverageReductionModeOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(this NVCoverageReductionMode thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pCombinationCount, [Count(Computed = "pCombinationCount"), Flow(FlowDirection.Out)] Span<FramebufferMixedSamplesCombinationNV> pCombinations)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(physicalDevice, pCombinationCount, out pCombinations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(this NVCoverageReductionMode thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pCombinationCount, [Count(Computed = "pCombinationCount"), Flow(FlowDirection.Out)] FramebufferMixedSamplesCombinationNV* pCombinations)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(physicalDevice, ref pCombinationCount.GetPinnableReference(), pCombinations);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(this NVCoverageReductionMode thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pCombinationCount, [Count(Computed = "pCombinationCount"), Flow(FlowDirection.Out)] Span<FramebufferMixedSamplesCombinationNV> pCombinations)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(physicalDevice, ref pCombinationCount.GetPinnableReference(), out pCombinations.GetPinnableReference());
        }

    }
}

