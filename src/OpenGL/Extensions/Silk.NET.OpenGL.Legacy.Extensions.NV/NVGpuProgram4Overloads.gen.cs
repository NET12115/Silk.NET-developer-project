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
    public static class NVGpuProgram4Overloads
    {
        public static unsafe void GetProgramEnvParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramEnvParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetProgramEnvParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void GetProgramLocalParameterI(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetProgramLocalParameterI(target, index, out @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParametersI4(target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParametersI4(target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParametersI4(target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramEnvParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramEnvParametersI4(target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParameterI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParameterI4(target, index, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParametersI4(target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParametersI4(target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParametersI4(target, index, count, in @params.GetPinnableReference());
        }

        public static unsafe void ProgramLocalParametersI4(this NVGpuProgram4 thisApi, [Flow(FlowDirection.In)] ProgramTarget target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<uint> @params)
        {
            // SpanOverloader
            thisApi.ProgramLocalParametersI4(target, index, count, in @params.GetPinnableReference());
        }

    }
}

