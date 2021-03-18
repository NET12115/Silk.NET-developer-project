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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixReferencePlaneOverloads
    {
        public static unsafe void ReferencePlane(this SgixReferencePlane thisApi, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<double> equation)
        {
            // SpanOverloader
            thisApi.ReferencePlane(in equation.GetPinnableReference());
        }

    }
}

