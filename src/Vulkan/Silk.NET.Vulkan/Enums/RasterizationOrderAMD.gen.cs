// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRasterizationOrderAMD")]
    public enum RasterizationOrderAMD : int
    {
        [NativeName("Name", "VK_RASTERIZATION_ORDER_STRICT_AMD")]
        RasterizationOrderStrictAmd = 0,
        [NativeName("Name", "VK_RASTERIZATION_ORDER_RELAXED_AMD")]
        RasterizationOrderRelaxedAmd = 1,
    }
}
