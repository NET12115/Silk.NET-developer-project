// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDescriptorUpdateTemplateTypeKHR")]
    public enum DescriptorUpdateTemplateTypeKHR : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET")]
        DescriptorUpdateTemplateTypeDescriptorSet = 0,
    }
}
