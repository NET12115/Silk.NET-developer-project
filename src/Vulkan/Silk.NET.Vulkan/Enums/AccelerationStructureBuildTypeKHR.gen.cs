// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureBuildTypeKHR")]
    public enum AccelerationStructureBuildTypeKHR : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR")]
        AccelerationStructureBuildTypeHostKhr = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR")]
        AccelerationStructureBuildTypeDeviceKhr = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR")]
        AccelerationStructureBuildTypeHostOrDeviceKhr = 2,
    }
}
