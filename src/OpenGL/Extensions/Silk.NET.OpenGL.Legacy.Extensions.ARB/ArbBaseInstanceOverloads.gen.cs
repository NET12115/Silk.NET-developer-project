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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbBaseInstanceOverloads
    {
        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ArbBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

    }
}

