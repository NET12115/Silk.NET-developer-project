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

namespace Silk.NET.OpenGLES.Extensions.ANGLE
{
    public static class AngleTranslatedShaderSourceOverloads
    {
        public static unsafe void GetTranslatedShaderSource(this AngleTranslatedShaderSource thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out)] Span<byte> source)
        {
            // SpanOverloader
            thisApi.GetTranslatedShaderSource(shader, bufSize, length, out source.GetPinnableReference());
        }

        public static unsafe void GetTranslatedShaderSource(this AngleTranslatedShaderSource thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Flow(FlowDirection.Out)] byte* source)
        {
            // SpanOverloader
            thisApi.GetTranslatedShaderSource(shader, bufSize, out length.GetPinnableReference(), source);
        }

        public static unsafe void GetTranslatedShaderSource(this AngleTranslatedShaderSource thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Flow(FlowDirection.Out)] Span<byte> source)
        {
            // SpanOverloader
            thisApi.GetTranslatedShaderSource(shader, bufSize, out length.GetPinnableReference(), out source.GetPinnableReference());
        }

        public static unsafe void GetTranslatedShaderSource(this AngleTranslatedShaderSource thisApi, [Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Flow(FlowDirection.Out)] string source)
        {
            // SpanOverloader
            thisApi.GetTranslatedShaderSource(shader, bufSize, out length.GetPinnableReference(), source);
        }

    }
}

