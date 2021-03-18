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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtFogCoordOverloads
    {
        public static unsafe void FogCoord(this ExtFogCoord thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<float> coord)
        {
            // SpanOverloader
            thisApi.FogCoord(in coord.GetPinnableReference());
        }

        public static unsafe void FogCoord(this ExtFogCoord thisApi, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<double> coord)
        {
            // SpanOverloader
            thisApi.FogCoord(in coord.GetPinnableReference());
        }

        public static unsafe void FogCoordPointer<T0>(this ExtFogCoord thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FogCoordPointer(type, stride, in pointer.GetPinnableReference());
        }

        public static unsafe void FogCoordPointer<T0>(this ExtFogCoord thisApi, [Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.FogCoordPointer(type, stride, in pointer.GetPinnableReference());
        }

    }
}

