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
    [NativeName("Name", "VkDebugUtilsObjectNameInfoEXT")]
    public unsafe partial struct DebugUtilsObjectNameInfoEXT
    {
        public DebugUtilsObjectNameInfoEXT
        (
            StructureType sType = StructureType.DebugUtilsObjectNameInfoExt,
            void* pNext = default,
            ObjectType objectType = default,
            ulong objectHandle = default,
            byte* pObjectName = default
        )
        {
            SType = sType;
            PNext = pNext;
            ObjectType = objectType;
            ObjectHandle = objectHandle;
            PObjectName = pObjectName;
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
        [NativeName("Type", "VkObjectType")]
        [NativeName("Type.Name", "VkObjectType")]
        [NativeName("Name", "objectType")]
        public ObjectType ObjectType;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "objectHandle")]
        public ulong ObjectHandle;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pObjectName")]
        public byte* PObjectName;
    }
}
