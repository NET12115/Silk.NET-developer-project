// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Vulkan
{
    public unsafe delegate void DeviceMemoryReportCallbackEXT
    (
        DeviceMemoryReportCallbackDataEXT* pCallbackData,
        void* pUserData
    );
}
