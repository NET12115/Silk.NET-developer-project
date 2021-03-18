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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    public static class AtiDrawBuffersOverloads
    {
        public static unsafe void DrawBuffers(this AtiDrawBuffers thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<ATI> bufs)
        {
            // SpanOverloader
            thisApi.DrawBuffers(n, in bufs.GetPinnableReference());
        }

        public static unsafe void DrawBuffers(this AtiDrawBuffers thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<DrawBufferMode> bufs)
        {
            // SpanOverloader
            thisApi.DrawBuffers(n, in bufs.GetPinnableReference());
        }

    }
}

