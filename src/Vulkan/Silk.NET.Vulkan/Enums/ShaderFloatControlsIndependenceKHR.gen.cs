// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkShaderFloatControlsIndependenceKHR")]
    public enum ShaderFloatControlsIndependenceKHR : int
    {
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_32_BIT_ONLY")]
        ShaderFloatControlsIndependence32BitOnly = 0,
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_ALL")]
        ShaderFloatControlsIndependenceAll = 1,
        [NativeName("Name", "VK_SHADER_FLOAT_CONTROLS_INDEPENDENCE_NONE")]
        ShaderFloatControlsIndependenceNone = 2,
    }
}
