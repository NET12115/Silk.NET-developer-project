// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrAndroidThreadTypeKHR")]
    public enum AndroidThreadTypeKHR : int
    {
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_APPLICATION_MAIN_KHR")]
        AndroidThreadTypeApplicationMainKhr = 1,
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_APPLICATION_WORKER_KHR")]
        AndroidThreadTypeApplicationWorkerKhr = 2,
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_RENDERER_MAIN_KHR")]
        AndroidThreadTypeRendererMainKhr = 3,
        [NativeName("Name", "XR_ANDROID_THREAD_TYPE_RENDERER_WORKER_KHR")]
        AndroidThreadTypeRendererWorkerKhr = 4,
    }
}
