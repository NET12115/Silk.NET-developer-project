// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
