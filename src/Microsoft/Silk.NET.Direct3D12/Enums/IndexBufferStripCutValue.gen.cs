// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE")]
    public enum IndexBufferStripCutValue : int
    {
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_DISABLED")]
        IndexBufferStripCutValueDisabled = 0x0,
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFF")]
        IndexBufferStripCutValue0xFfff = 0x1,
        [NativeName("Name", "D3D12_INDEX_BUFFER_STRIP_CUT_VALUE_0xFFFFFFFF")]
        IndexBufferStripCutValue0xFfffffff = 0x2,
    }
}
