// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandJointsMotionRangeEXT")]
    public enum HandJointsMotionRangeEXT : int
    {
        [NativeName("Name", "XR_HAND_JOINTS_MOTION_RANGE_UNOBSTRUCTED_EXT")]
        HandJointsMotionRangeUnobstructedExt = 1,
        [NativeName("Name", "XR_HAND_JOINTS_MOTION_RANGE_CONFORMING_TO_CONTROLLER_EXT")]
        HandJointsMotionRangeConformingToControllerExt = 2,
    }
}
