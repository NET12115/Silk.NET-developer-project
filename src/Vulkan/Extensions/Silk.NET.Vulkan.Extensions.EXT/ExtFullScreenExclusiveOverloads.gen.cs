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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtFullScreenExclusiveOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceGroupSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DeviceGroupPresentModeFlagsKHR> pModes)
        {
            // SpanOverloader
            return thisApi.GetDeviceGroupSurfacePresentModes2(device, pSurfaceInfo, out pModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceGroupSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] DeviceGroupPresentModeFlagsKHR* pModes)
        {
            // SpanOverloader
            return thisApi.GetDeviceGroupSurfacePresentModes2(device, in pSurfaceInfo.GetPinnableReference(), pModes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetDeviceGroupSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<DeviceGroupPresentModeFlagsKHR> pModes)
        {
            // SpanOverloader
            return thisApi.GetDeviceGroupSurfacePresentModes2(device, in pSurfaceInfo.GetPinnableReference(), out pModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] Span<PresentModeKHR> pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes2(physicalDevice, pSurfaceInfo, pPresentModeCount, out pPresentModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] Span<uint> pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] PresentModeKHR* pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes2(physicalDevice, pSurfaceInfo, ref pPresentModeCount.GetPinnableReference(), pPresentModes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSurfaceInfo2KHR* pSurfaceInfo, [Count(Count = 0)] Span<uint> pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] Span<PresentModeKHR> pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes2(physicalDevice, pSurfaceInfo, ref pPresentModeCount.GetPinnableReference(), out pPresentModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] PresentModeKHR* pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), pPresentModeCount, pPresentModes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] uint* pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] Span<PresentModeKHR> pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), pPresentModeCount, out pPresentModes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] Span<uint> pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] PresentModeKHR* pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), ref pPresentModeCount.GetPinnableReference(), pPresentModes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSurfacePresentModes2(this ExtFullScreenExclusive thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PhysicalDeviceSurfaceInfo2KHR> pSurfaceInfo, [Count(Count = 0)] Span<uint> pPresentModeCount, [Count(Computed = "pPresentModeCount"), Flow(FlowDirection.Out)] Span<PresentModeKHR> pPresentModes)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSurfacePresentModes2(physicalDevice, in pSurfaceInfo.GetPinnableReference(), ref pPresentModeCount.GetPinnableReference(), out pPresentModes.GetPinnableReference());
        }

    }
}

