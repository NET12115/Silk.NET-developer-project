// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVBindlessMultiDrawIndirectCountOverloads
    {
        public static unsafe void MultiDrawArraysIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectBindlessCount(mode, in indirect.GetPinnableReference(), drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawArraysIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectBindlessCount(mode, in indirect.GetPinnableReference(), drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindlessCount(mode, type, in indirect.GetPinnableReference(), drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] NV mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindlessCount(mode, type, in indirect.GetPinnableReference(), drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindlessCount(mode, type, in indirect.GetPinnableReference(), drawCount, maxDrawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindlessCount<T0>(this NVBindlessMultiDrawIndirectCount thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint drawCount, [Flow(FlowDirection.In)] uint maxDrawCount, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindlessCount(mode, type, in indirect.GetPinnableReference(), drawCount, maxDrawCount, stride, vertexBufferCount);
        }

    }
}

