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
    [NativeName("Name", "VkExternalMemoryFeatureFlags")]
    public enum ExternalMemoryFeatureFlags : int
    {
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_DEDICATED_ONLY_BIT")]
        ExternalMemoryFeatureDedicatedOnlyBit = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_EXPORTABLE_BIT")]
        ExternalMemoryFeatureExportableBit = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_FEATURE_IMPORTABLE_BIT")]
        ExternalMemoryFeatureImportableBit = 4,
    }
}
