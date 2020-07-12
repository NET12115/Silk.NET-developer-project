// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkDeviceOrHostAddressConstKHR")]
    public unsafe partial struct DeviceOrHostAddressConstKHR
    {
        public DeviceOrHostAddressConstKHR
        (
            ulong deviceAddress = default,
            void* hostAddress = default
        )
        {
            DeviceAddress = deviceAddress;
            HostAddress = hostAddress;
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "deviceAddress")]
        public ulong DeviceAddress;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "hostAddress")]
        public void* HostAddress;
    }
}
