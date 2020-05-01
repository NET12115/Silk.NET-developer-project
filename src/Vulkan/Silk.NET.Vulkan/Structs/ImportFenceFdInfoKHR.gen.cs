// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct ImportFenceFdInfoKHR
    {
        public ImportFenceFdInfoKHR
        (
            StructureType sType = StructureType.ImportFenceFDInfoKhr,
            void* pNext = default,
            Fence fence = default,
            FenceImportFlags flags = default,
            ExternalFenceHandleTypeFlags handleType = default,
            int fd = default
        )
        {
           SType = sType;
           PNext = pNext;
           Fence = fence;
           Flags = flags;
           HandleType = handleType;
           Fd = fd;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Fence Fence;
/// <summary></summary>
        public FenceImportFlags Flags;
/// <summary></summary>
        public ExternalFenceHandleTypeFlags HandleType;
/// <summary></summary>
        public int Fd;
    }
}
