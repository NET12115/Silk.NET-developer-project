// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkDependencyFlags")]
    public enum DependencyFlags
    {
        [NativeName("Name", "VK_DEPENDENCY_BY_REGION_BIT")]
        DependencyByRegionBit = 1,
        [NativeName("Name", "VK_DEPENDENCY_VIEW_LOCAL_BIT_KHR")]
        DependencyViewLocalBitKhr = 2,
        [NativeName("Name", "VK_DEPENDENCY_DEVICE_GROUP_BIT_KHR")]
        DependencyDeviceGroupBitKhr = 4,
        [NativeName("Name", "VK_DEPENDENCY_DEVICE_GROUP_BIT")]
        DependencyDeviceGroupBit = 4,
        [NativeName("Name", "VK_DEPENDENCY_VIEW_LOCAL_BIT")]
        DependencyViewLocalBit = 2,
    }
}
