// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_FEATURE")]
    public enum Feature : int
    {
        [NativeName("Name", "DXGI_FEATURE_PRESENT_ALLOW_TEARING")]
        FeaturePresentAllowTearing = 0x0,
    }
}
