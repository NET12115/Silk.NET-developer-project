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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbIndirectParametersOverloads
    {
        public static unsafe void MultiDrawArraysIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectCount(mode, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawArraysIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectCount(mode, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] nint drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

    }
}

