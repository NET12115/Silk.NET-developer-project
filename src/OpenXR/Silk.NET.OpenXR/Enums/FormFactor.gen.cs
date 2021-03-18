// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFormFactor")]
    public enum FormFactor : int
    {
        [NativeName("Name", "XR_FORM_FACTOR_HEAD_MOUNTED_DISPLAY")]
        HeadMountedDisplay = 1,
        [NativeName("Name", "XR_FORM_FACTOR_HANDHELD_DISPLAY")]
        HandheldDisplay = 2,
    }
}
