// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureMemoryRequirementsTypeNV")]
    public enum AccelerationStructureMemoryRequirementsTypeNV : int
    {
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_OBJECT_NV")]
        AccelerationStructureMemoryRequirementsTypeObjectNV = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_BUILD_SCRATCH_NV")]
        AccelerationStructureMemoryRequirementsTypeBuildScratchNV = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_MEMORY_REQUIREMENTS_TYPE_UPDATE_SCRATCH_NV")]
        AccelerationStructureMemoryRequirementsTypeUpdateScratchNV = 2,
    }
}
