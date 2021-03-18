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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbDrawInstancedOverloads
    {
        public static unsafe void DrawElementsInstanced<T0>(this ArbDrawInstanced thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ArbDrawInstanced thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ArbDrawInstanced thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

        public static unsafe void DrawElementsInstanced<T0>(this ArbDrawInstanced thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstanced(mode, count, type, in indices.GetPinnableReference(), primcount);
        }

    }
}

