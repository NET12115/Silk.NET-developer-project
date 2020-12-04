// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.INTEL
{
    public static class IntelPerformanceQueryOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result AcquirePerformanceConfiguration(this IntelPerformanceQuery thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] PerformanceConfigurationAcquireInfoINTEL* pAcquireInfo, [Count(Count = 0)] Span<PerformanceConfigurationINTEL> pConfiguration)
        {
            // SpanOverloader
            return thisApi.AcquirePerformanceConfiguration(device, pAcquireInfo, ref pConfiguration.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result AcquirePerformanceConfiguration(this IntelPerformanceQuery thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PerformanceConfigurationAcquireInfoINTEL> pAcquireInfo, [Count(Count = 0)] PerformanceConfigurationINTEL* pConfiguration)
        {
            // SpanOverloader
            return thisApi.AcquirePerformanceConfiguration(device, in pAcquireInfo.GetPinnableReference(), pConfiguration);
        }

        /// <summary>To be added.</summary>
        public static unsafe Result AcquirePerformanceConfiguration(this IntelPerformanceQuery thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PerformanceConfigurationAcquireInfoINTEL> pAcquireInfo, [Count(Count = 0)] Span<PerformanceConfigurationINTEL> pConfiguration)
        {
            // SpanOverloader
            return thisApi.AcquirePerformanceConfiguration(device, in pAcquireInfo.GetPinnableReference(), ref pConfiguration.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CmdSetPerformanceMarker(this IntelPerformanceQuery thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PerformanceMarkerInfoINTEL> pMarkerInfo)
        {
            // SpanOverloader
            return thisApi.CmdSetPerformanceMarker(commandBuffer, in pMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CmdSetPerformanceOverride(this IntelPerformanceQuery thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PerformanceOverrideInfoINTEL> pOverrideInfo)
        {
            // SpanOverloader
            return thisApi.CmdSetPerformanceOverride(commandBuffer, in pOverrideInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result CmdSetPerformanceStreamMarker(this IntelPerformanceQuery thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<PerformanceStreamMarkerInfoINTEL> pMarkerInfo)
        {
            // SpanOverloader
            return thisApi.CmdSetPerformanceStreamMarker(commandBuffer, in pMarkerInfo.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result GetPerformanceParameter(this IntelPerformanceQuery thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] PerformanceParameterTypeINTEL parameter, [Count(Count = 0), Flow(FlowDirection.Out)] Span<PerformanceValueINTEL> pValue)
        {
            // SpanOverloader
            return thisApi.GetPerformanceParameter(device, parameter, out pValue.GetPinnableReference());
        }

        /// <summary>To be added.</summary>
        public static unsafe Result InitializePerformanceAp(this IntelPerformanceQuery thisApi, [Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ReadOnlySpan<InitializePerformanceApiInfoINTEL> pInitializeInfo)
        {
            // SpanOverloader
            return thisApi.InitializePerformanceAp(device, in pInitializeInfo.GetPinnableReference());
        }

    }
}

