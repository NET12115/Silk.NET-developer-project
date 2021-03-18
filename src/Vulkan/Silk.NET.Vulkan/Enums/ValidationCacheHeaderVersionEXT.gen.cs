// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkValidationCacheHeaderVersionEXT")]
    public enum ValidationCacheHeaderVersionEXT : int
    {
        [NativeName("Name", "VK_VALIDATION_CACHE_HEADER_VERSION_ONE_EXT")]
        ValidationCacheHeaderVersionOneExt = 1,
    }
}
