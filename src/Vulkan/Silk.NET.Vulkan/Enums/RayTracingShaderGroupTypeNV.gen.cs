// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRayTracingShaderGroupTypeNV")]
    public enum RayTracingShaderGroupTypeNV : int
    {
        [NativeName("Name", "VK_RAY_TRACING_SHADER_GROUP_TYPE_GENERAL_KHR")]
        RayTracingShaderGroupTypeGeneralKhr = 0,
        [NativeName("Name", "VK_RAY_TRACING_SHADER_GROUP_TYPE_TRIANGLES_HIT_GROUP_KHR")]
        RayTracingShaderGroupTypeTrianglesHitGroupKhr = 1,
        [NativeName("Name", "VK_RAY_TRACING_SHADER_GROUP_TYPE_PROCEDURAL_HIT_GROUP_KHR")]
        RayTracingShaderGroupTypeProceduralHitGroupKhr = 2,
    }
}
