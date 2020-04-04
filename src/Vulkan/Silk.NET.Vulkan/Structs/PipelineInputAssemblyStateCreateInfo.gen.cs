// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct PipelineInputAssemblyStateCreateInfo
    {
        public PipelineInputAssemblyStateCreateInfo
        (
            StructureType sType = StructureType.PipelineInputAssemblyStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            PrimitiveTopology topology = default,
            Bool32 primitiveRestartEnable = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Topology = topology;
           PrimitiveRestartEnable = primitiveRestartEnable;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public PrimitiveTopology Topology;
/// <summary></summary>
        public Bool32 PrimitiveRestartEnable;
    }
}
