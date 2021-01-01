// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAGS")]
    public enum MultipleFenceWaitFlags : int
    {
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_NONE")]
        MultipleFenceWaitFlagNone = 0x0,
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ANY")]
        MultipleFenceWaitFlagAny = 0x1,
        [NativeName("Name", "D3D12_MULTIPLE_FENCE_WAIT_FLAG_ALL")]
        MultipleFenceWaitFlagAll = 0x0,
    }
}
