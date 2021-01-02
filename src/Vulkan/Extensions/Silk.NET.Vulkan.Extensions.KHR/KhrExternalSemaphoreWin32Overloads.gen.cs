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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    public static class KhrExternalSemaphoreWin32Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreWin32Handle(this KhrExternalSemaphoreWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] SemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<nint> pHandle)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreWin32Handle(device, pGetWin32HandleInfo, out pHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreWin32Handle(this KhrExternalSemaphoreWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SemaphoreGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] nint* pHandle)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), pHandle);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetSemaphoreWin32Handle(this KhrExternalSemaphoreWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SemaphoreGetWin32HandleInfoKHR> pGetWin32HandleInfo, [Count(Count = 0), Flow(FlowDirection.Out)] Span<nint> pHandle)
        {
            // SpanOverloader
            return thisApi.GetSemaphoreWin32Handle(device, in pGetWin32HandleInfo.GetPinnableReference(), out pHandle.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ImportSemaphoreWin32Handle(this KhrExternalSemaphoreWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<ImportSemaphoreWin32HandleInfoKHR> pImportSemaphoreWin32HandleInfo)
        {
            // SpanOverloader
            return thisApi.ImportSemaphoreWin32Handle(device, in pImportSemaphoreWin32HandleInfo.GetPinnableReference());
        }

    }
}

