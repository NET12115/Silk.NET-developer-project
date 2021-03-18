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
    public static class ArbTessellationShaderOverloads
    {
        public static unsafe void PatchParameter(this ArbTessellationShader thisApi, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.PatchParameter(pname, in values.GetPinnableReference());
        }

        public static unsafe void PatchParameter(this ArbTessellationShader thisApi, [Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.PatchParameter(pname, in values.GetPinnableReference());
        }

    }
}

