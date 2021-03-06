// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    public static class ExtThermalQueryOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, notificationLevel, tempHeadroom, ref tempSlope.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] float* tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, notificationLevel, ref tempHeadroom.GetPinnableReference(), tempSlope);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] PerfSettingsNotificationLevelEXT* notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, notificationLevel, ref tempHeadroom.GetPinnableReference(), ref tempSlope.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] float* tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), tempHeadroom, tempSlope);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] float* tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), tempHeadroom, ref tempSlope.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] float* tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), ref tempHeadroom.GetPinnableReference(), tempSlope);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ThermalGetTemperatureTrend(this ExtThermalQuery thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] PerfSettingsDomainEXT domain, [Count(Count = 0)] Span<PerfSettingsNotificationLevelEXT> notificationLevel, [Count(Count = 0)] Span<float> tempHeadroom, [Count(Count = 0)] Span<float> tempSlope)
        {
            // SpanOverloader
            return thisApi.ThermalGetTemperatureTrend(session, domain, ref notificationLevel.GetPinnableReference(), ref tempHeadroom.GetPinnableReference(), ref tempSlope.GetPinnableReference());
        }

    }
}

