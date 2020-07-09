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
    [NativeName("Name", "VkXlibSurfaceCreateInfoKHR")]
    public unsafe struct XlibSurfaceCreateInfoKHR
    {
        public XlibSurfaceCreateInfoKHR
        (
            StructureType sType = StructureType.XlibSurfaceCreateInfoKhr,
            void* pNext = default,
            uint flags = default,
            IntPtr* dpy = default,
            IntPtr window = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Dpy = dpy;
           Window = window;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkXlibSurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkXlibSurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "Display*")]
        [NativeName("Type.Name", "Display")]
        [NativeName("Name", "dpy")]
        public IntPtr* Dpy;
/// <summary></summary>
        [NativeName("Type", "Window")]
        [NativeName("Type.Name", "Window")]
        [NativeName("Name", "window")]
        public IntPtr Window;
    }
}
