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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIS
{
    public static class SgisFogFunctionOverloads
    {
        public static unsafe void FogFunc(this SgisFogFunction thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<float> points)
        {
            // SpanOverloader
            thisApi.FogFunc(n, in points.GetPinnableReference());
        }

        public static unsafe void GetFogFunc(this SgisFogFunction thisApi, [Count(Count = 0), Flow(FlowDirection.Out)] Span<float> points)
        {
            // SpanOverloader
            thisApi.GetFogFunc(out points.GetPinnableReference());
        }

    }
}

