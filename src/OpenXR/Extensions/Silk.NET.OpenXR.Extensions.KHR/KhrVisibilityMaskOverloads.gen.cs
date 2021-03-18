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

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrVisibilityMaskOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetVisibilityMask(this KhrVisibilityMask thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] ViewConfigurationType viewConfigurationType, [Count(Count = 0)] uint viewIndex, [Count(Count = 0)] VisibilityMaskTypeKHR visibilityMaskType, [Count(Count = 0)] Span<VisibilityMaskKHR> visibilityMask)
        {
            // SpanOverloader
            return thisApi.GetVisibilityMask(session, viewConfigurationType, viewIndex, visibilityMaskType, ref visibilityMask.GetPinnableReference());
        }

    }
}

