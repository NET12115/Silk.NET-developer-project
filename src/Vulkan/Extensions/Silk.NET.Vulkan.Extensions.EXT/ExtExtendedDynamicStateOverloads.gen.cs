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
    public static class ExtExtendedDynamicStateOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] Buffer* pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, pBuffers, in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), pOffsets, in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), pSizes, in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ulong* pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), pStrides);
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdBindVertexBuffers2(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstBinding, [Count(Count = 0)] uint bindingCount, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<Buffer> pBuffers, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pOffsets, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pSizes, [Count(Computed = "bindingCount"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> pStrides)
        {
            // SpanOverloader
            thisApi.CmdBindVertexBuffers2(commandBuffer, firstBinding, bindingCount, in pBuffers.GetPinnableReference(), in pOffsets.GetPinnableReference(), in pSizes.GetPinnableReference(), in pStrides.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetScissorWithCount(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint scissorCount, [Count(Computed = "scissorCount"), Flow(FlowDirection.In)] ReadOnlySpan<Rect2D> pScissors)
        {
            // SpanOverloader
            thisApi.CmdSetScissorWithCount(commandBuffer, scissorCount, in pScissors.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetViewportWithCount(this ExtExtendedDynamicState thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ReadOnlySpan<Viewport> pViewports)
        {
            // SpanOverloader
            thisApi.CmdSetViewportWithCount(commandBuffer, viewportCount, in pViewports.GetPinnableReference());
        }

    }
}

