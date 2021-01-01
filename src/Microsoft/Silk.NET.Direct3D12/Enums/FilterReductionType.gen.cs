// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FILTER_REDUCTION_TYPE")]
    public enum FilterReductionType : int
    {
        [NativeName("Name", "D3D12_FILTER_REDUCTION_TYPE_STANDARD")]
        FilterReductionTypeStandard = 0x0,
        [NativeName("Name", "D3D12_FILTER_REDUCTION_TYPE_COMPARISON")]
        FilterReductionTypeComparison = 0x1,
        [NativeName("Name", "D3D12_FILTER_REDUCTION_TYPE_MINIMUM")]
        FilterReductionTypeMinimum = 0x2,
        [NativeName("Name", "D3D12_FILTER_REDUCTION_TYPE_MAXIMUM")]
        FilterReductionTypeMaximum = 0x3,
    }
}
