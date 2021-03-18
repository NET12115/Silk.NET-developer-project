// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtBaseInstanceOverloads
    {
        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

    }
}

