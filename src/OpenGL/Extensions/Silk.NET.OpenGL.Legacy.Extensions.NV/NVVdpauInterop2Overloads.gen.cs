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
    public static class NVVdpauInterop2Overloads
    {
        public static unsafe nint VdpauregisterVideoSurfaceWithPictureStructure(this NVVdpauInterop2 thisApi, [Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames, [Flow(FlowDirection.In)] bool isFrameStructure)
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurfaceWithPictureStructure(vdpSurface, target, numTextureNames, in textureNames.GetPinnableReference(), isFrameStructure);
        }

        public static unsafe nint VdpauregisterVideoSurfaceWithPictureStructure<T0>(this NVVdpauInterop2 thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames, [Flow(FlowDirection.In)] bool isFrameStructure) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurfaceWithPictureStructure(in vdpSurface.GetPinnableReference(), target, numTextureNames, textureNames, isFrameStructure);
        }

        public static unsafe nint VdpauregisterVideoSurfaceWithPictureStructure<T0>(this NVVdpauInterop2 thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames, [Flow(FlowDirection.In)] bool isFrameStructure) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurfaceWithPictureStructure(in vdpSurface.GetPinnableReference(), target, numTextureNames, in textureNames.GetPinnableReference(), isFrameStructure);
        }

        public static unsafe nint VdpauregisterVideoSurfaceWithPictureStructure(this NVVdpauInterop2 thisApi, [Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames, [Flow(FlowDirection.In)] Boolean isFrameStructure)
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurfaceWithPictureStructure(vdpSurface, target, numTextureNames, in textureNames.GetPinnableReference(), isFrameStructure);
        }

        public static unsafe nint VdpauregisterVideoSurfaceWithPictureStructure<T0>(this NVVdpauInterop2 thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames, [Flow(FlowDirection.In)] Boolean isFrameStructure) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurfaceWithPictureStructure(in vdpSurface.GetPinnableReference(), target, numTextureNames, textureNames, isFrameStructure);
        }

        public static unsafe nint VdpauregisterVideoSurfaceWithPictureStructure<T0>(this NVVdpauInterop2 thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames, [Flow(FlowDirection.In)] Boolean isFrameStructure) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurfaceWithPictureStructure(in vdpSurface.GetPinnableReference(), target, numTextureNames, in textureNames.GetPinnableReference(), isFrameStructure);
        }

    }
}

