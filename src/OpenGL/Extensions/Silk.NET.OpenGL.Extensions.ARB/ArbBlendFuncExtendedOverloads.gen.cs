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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbBlendFuncExtendedOverloads
    {
        public static unsafe void BindFragDataLocationIndexed(this ArbBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocationIndexed(program, colorNumber, index, in name.GetPinnableReference());
        }

        public static unsafe int GetFragDataIndex(this ArbBlendFuncExtended thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetFragDataIndex(program, in name.GetPinnableReference());
        }

    }
}

