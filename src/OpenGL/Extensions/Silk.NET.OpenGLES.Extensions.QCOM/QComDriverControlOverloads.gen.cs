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

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    public static class QComDriverControlOverloads
    {
        public static unsafe void GetDriverControl(this QComDriverControl thisApi, [Flow(FlowDirection.Out)] int* num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<uint> driverControls)
        {
            // SpanOverloader
            thisApi.GetDriverControl(num, size, out driverControls.GetPinnableReference());
        }

        public static unsafe void GetDriverControl(this QComDriverControl thisApi, [Flow(FlowDirection.Out)] Span<int> num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] uint* driverControls)
        {
            // SpanOverloader
            thisApi.GetDriverControl(out num.GetPinnableReference(), size, driverControls);
        }

        public static unsafe void GetDriverControl(this QComDriverControl thisApi, [Flow(FlowDirection.Out)] Span<int> num, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.Out)] Span<uint> driverControls)
        {
            // SpanOverloader
            thisApi.GetDriverControl(out num.GetPinnableReference(), size, out driverControls.GetPinnableReference());
        }

        public static unsafe void GetDriverControlString(this QComDriverControl thisApi, [Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> driverControlString)
        {
            // SpanOverloader
            thisApi.GetDriverControlString(driverControl, bufSize, length, out driverControlString.GetPinnableReference());
        }

        public static unsafe void GetDriverControlString(this QComDriverControl thisApi, [Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> driverControlString)
        {
            // SpanOverloader
            thisApi.GetDriverControlString(driverControl, bufSize, length, out driverControlString.GetPinnableReference());
        }

        public static unsafe void GetDriverControlString(this QComDriverControl thisApi, [Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* driverControlString)
        {
            // SpanOverloader
            thisApi.GetDriverControlString(driverControl, bufSize, out length.GetPinnableReference(), driverControlString);
        }

        public static unsafe void GetDriverControlString(this QComDriverControl thisApi, [Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> driverControlString)
        {
            // SpanOverloader
            thisApi.GetDriverControlString(driverControl, bufSize, out length.GetPinnableReference(), out driverControlString.GetPinnableReference());
        }

        public static unsafe void GetDriverControlString(this QComDriverControl thisApi, [Flow(FlowDirection.In)] uint driverControl, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<string> driverControlString)
        {
            // SpanOverloader
            thisApi.GetDriverControlString(driverControl, bufSize, out length.GetPinnableReference(), out driverControlString.GetPinnableReference());
        }

    }
}

