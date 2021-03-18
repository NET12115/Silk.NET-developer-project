// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_FLAG")]
    public enum CheckMultisampleQualityLevelsFlag : int
    {
        [NativeName("Name", "D3D11_CHECK_MULTISAMPLE_QUALITY_LEVELS_TILED_RESOURCE")]
        CheckMultisampleQualityLevelsTiledResource = 0x1,
    }
}
