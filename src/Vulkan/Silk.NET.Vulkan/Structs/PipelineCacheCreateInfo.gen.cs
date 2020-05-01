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
    public unsafe struct PipelineCacheCreateInfo
    {
        public PipelineCacheCreateInfo
        (
            StructureType sType = StructureType.PipelineCacheCreateInfo,
            void* pNext = default,
            PipelineCacheCreateFlags flags = default,
            UIntPtr initialDataSize = default,
            void* pInitialData = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           InitialDataSize = initialDataSize;
           PInitialData = pInitialData;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PipelineCacheCreateFlags Flags;
/// <summary></summary>
        public UIntPtr InitialDataSize;
/// <summary></summary>
        public void* PInitialData;
    }
}
