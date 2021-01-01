// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPerformanceCounterScopeKHR")]
    public enum PerformanceCounterScopeKHR : int
    {
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR")]
        PerformanceCounterScopeCommandBufferKhr = 0,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR")]
        PerformanceCounterScopeRenderPassKhr = 1,
        [NativeName("Name", "VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR")]
        PerformanceCounterScopeCommandKhr = 2,
        [NativeName("Name", "VK_QUERY_SCOPE_COMMAND_BUFFER_KHR")]
        QueryScopeCommandBufferKhr = 0,
        [NativeName("Name", "VK_QUERY_SCOPE_RENDER_PASS_KHR")]
        QueryScopeRenderPassKhr = 1,
        [NativeName("Name", "VK_QUERY_SCOPE_COMMAND_KHR")]
        QueryScopeCommandKhr = 2,
    }
}
