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
    [NativeName("Name", "VkAttachmentDescriptionFlags")]
    public enum AttachmentDescriptionFlags : int
    {
        [NativeName("Name", "VK_ATTACHMENT_DESCRIPTION_MAY_ALIAS_BIT")]
        AttachmentDescriptionMayAliasBit = 1,
    }
}
