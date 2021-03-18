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

namespace Silk.NET.OpenXR.Extensions.MSFT
{
    public static class MsftSpatialGraphBridgeOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialGraphNodeSpaceMsft(this MsftSpatialGraphBridge thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] SpatialGraphNodeSpaceCreateInfoMSFT* createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateSpatialGraphNodeSpaceMsft(session, createInfo, ref space.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialGraphNodeSpaceMsft(this MsftSpatialGraphBridge thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SpatialGraphNodeSpaceCreateInfoMSFT> createInfo, [Count(Count = 0)] Space* space)
        {
            // SpanOverloader
            return thisApi.CreateSpatialGraphNodeSpaceMsft(session, in createInfo.GetPinnableReference(), space);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateSpatialGraphNodeSpaceMsft(this MsftSpatialGraphBridge thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<SpatialGraphNodeSpaceCreateInfoMSFT> createInfo, [Count(Count = 0)] Span<Space> space)
        {
            // SpanOverloader
            return thisApi.CreateSpatialGraphNodeSpaceMsft(session, in createInfo.GetPinnableReference(), ref space.GetPinnableReference());
        }

    }
}

