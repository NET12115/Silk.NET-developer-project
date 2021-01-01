// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_DEPTH_WRITE_MASK")]
    public enum DepthWriteMask : int
    {
        [NativeName("Name", "D3D11_DEPTH_WRITE_MASK_ZERO")]
        DepthWriteMaskZero = 0x0,
        [NativeName("Name", "D3D11_DEPTH_WRITE_MASK_ALL")]
        DepthWriteMaskAll = 0x1,
    }
}
