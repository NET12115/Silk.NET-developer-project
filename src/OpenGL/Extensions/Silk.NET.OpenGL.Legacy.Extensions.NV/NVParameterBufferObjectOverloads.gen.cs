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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVParameterBufferObjectOverloads
    {
        public static unsafe void ProgramBufferParameters(this NVParameterBufferObject thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramBufferParameters(target, bindingIndex, wordIndex, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramBufferParameters(this NVParameterBufferObject thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ProgramBufferParameters(target, bindingIndex, wordIndex, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramBufferParametersI(this NVParameterBufferObject thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramBufferParametersI(target, bindingIndex, wordIndex, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramBufferParametersI(this NVParameterBufferObject thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramBufferParametersI(target, bindingIndex, wordIndex, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramBufferParametersI(this NVParameterBufferObject thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramBufferParametersI(target, bindingIndex, wordIndex, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramBufferParametersI(this NVParameterBufferObject thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint bindingIndex, [Flow(FlowDirection.In)] uint wordIndex, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramBufferParametersI(target, bindingIndex, wordIndex, count, in @params.GetPinnableReference());
        }

    }
}

