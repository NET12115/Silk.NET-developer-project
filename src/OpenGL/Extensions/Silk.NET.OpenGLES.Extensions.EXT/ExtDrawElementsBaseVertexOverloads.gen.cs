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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtDrawElementsBaseVertexOverloads
    {
        public static unsafe void DrawElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsBaseVertex(mode, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawElementsInstancedBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertex(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void DrawRangeElementsBaseVertex<T0>(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawRangeElementsBaseVertex(mode, start, end, count, type, in indices.GetPinnableReference(), basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, count, type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, indices, drawcount, in basevertex.GetPinnableReference());
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, basevertex);
        }

        public static unsafe void MultiDrawElementsBaseVertex(this ExtDrawElementsBaseVertex thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<uint> count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] ReadOnlySpan<int> basevertex)
        {
            // SpanOverloader
            thisApi.MultiDrawElementsBaseVertex(mode, in count.GetPinnableReference(), type, in indices, drawcount, in basevertex.GetPinnableReference());
        }

    }
}

