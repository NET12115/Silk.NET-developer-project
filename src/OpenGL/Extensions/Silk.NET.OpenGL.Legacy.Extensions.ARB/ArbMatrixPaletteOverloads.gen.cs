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
    public static class ArbMatrixPaletteOverloads
    {
        public static unsafe void MatrixIndex(this ArbMatrixPalette thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<byte> indices)
        {
            // SpanOverloader
            thisApi.MatrixIndex(size, in indices.GetPinnableReference());
        }

        public static unsafe void MatrixIndex(this ArbMatrixPalette thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<ushort> indices)
        {
            // SpanOverloader
            thisApi.MatrixIndex(size, in indices.GetPinnableReference());
        }

        public static unsafe void MatrixIndex(this ArbMatrixPalette thisApi, [Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // SpanOverloader
            thisApi.MatrixIndex(size, in indices.GetPinnableReference());
        }

        public static unsafe void MatrixIndexPointer<T0>(this ArbMatrixPalette thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MatrixIndexPointer(size, type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void MatrixIndexPointer<T0>(this ArbMatrixPalette thisApi, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] MatrixIndexPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MatrixIndexPointer(size, type, stride, in pointer.GetPinnableReference());
        }

    }
}

