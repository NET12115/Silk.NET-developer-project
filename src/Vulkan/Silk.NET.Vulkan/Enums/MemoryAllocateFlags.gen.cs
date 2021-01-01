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
    [NativeName("Name", "VkMemoryAllocateFlags")]
    public enum MemoryAllocateFlags : int
    {
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_MASK_BIT")]
        MemoryAllocateDeviceMaskBit = 1,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT_KHR")]
        MemoryAllocateDeviceAddressBitKhr = 2,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT_KHR")]
        MemoryAllocateDeviceAddressCaptureReplayBitKhr = 4,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT")]
        MemoryAllocateDeviceAddressBit = 2,
        [NativeName("Name", "VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_CAPTURE_REPLAY_BIT")]
        MemoryAllocateDeviceAddressCaptureReplayBit = 4,
    }
}
