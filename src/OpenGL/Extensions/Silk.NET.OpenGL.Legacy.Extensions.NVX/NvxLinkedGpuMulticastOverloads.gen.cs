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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    public static class NvxLinkedGpuMulticastOverloads
    {
        public static unsafe void LgpunamedBufferSubData<T0>(this NvxLinkedGpuMulticast thisApi, [Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LgpunamedBufferSubData(gpuMask, buffer, offset, size, in data.GetPinnableReference());
        }

    }
}

