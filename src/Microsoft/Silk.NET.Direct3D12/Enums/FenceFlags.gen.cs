// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FENCE_FLAGS")]
    public enum FenceFlags : int
    {
        [NativeName("Name", "D3D12_FENCE_FLAG_NONE")]
        FenceFlagNone = 0x0,
        [NativeName("Name", "D3D12_FENCE_FLAG_SHARED")]
        FenceFlagShared = 0x1,
        [NativeName("Name", "D3D12_FENCE_FLAG_SHARED_CROSS_ADAPTER")]
        FenceFlagSharedCrossAdapter = 0x2,
        [NativeName("Name", "D3D12_FENCE_FLAG_NON_MONITORED")]
        FenceFlagNonMonitored = 0x4,
    }
}
