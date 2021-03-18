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

namespace Silk.NET.OpenGL.Legacy.Extensions.OES
{
    public static class OesQueryMatrixOverloads
    {
        public static unsafe uint QueryMatrixx(this OesQueryMatrix thisApi, [Count(Count = 16), Flow(FlowDirection.Out)] int* mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] Span<int> exponent)
        {
            // SpanOverloader
            return thisApi.QueryMatrixx(mantissa, out exponent.GetPinnableReference());
        }

        public static unsafe uint QueryMatrixx(this OesQueryMatrix thisApi, [Count(Count = 16), Flow(FlowDirection.Out)] Span<int> mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] int* exponent)
        {
            // SpanOverloader
            return thisApi.QueryMatrixx(out mantissa.GetPinnableReference(), exponent);
        }

        public static unsafe uint QueryMatrixx(this OesQueryMatrix thisApi, [Count(Count = 16), Flow(FlowDirection.Out)] Span<int> mantissa, [Count(Count = 16), Flow(FlowDirection.Out)] Span<int> exponent)
        {
            // SpanOverloader
            return thisApi.QueryMatrixx(out mantissa.GetPinnableReference(), out exponent.GetPinnableReference());
        }

    }
}

