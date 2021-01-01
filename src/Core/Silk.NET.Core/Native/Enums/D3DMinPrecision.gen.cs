// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_MIN_PRECISION")]
    public enum D3DMinPrecision : int
    {
        [NativeName("Name", "D3D_MIN_PRECISION_DEFAULT")]
        D3DMinPrecisionDefault = 0x0,
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_16")]
        D3DMinPrecisionFloat16 = 0x1,
        [NativeName("Name", "D3D_MIN_PRECISION_FLOAT_2_8")]
        D3DMinPrecisionFloat28 = 0x2,
        [NativeName("Name", "D3D_MIN_PRECISION_RESERVED")]
        D3DMinPrecisionReserved = 0x3,
        [NativeName("Name", "D3D_MIN_PRECISION_SINT_16")]
        D3DMinPrecisionSint16 = 0x4,
        [NativeName("Name", "D3D_MIN_PRECISION_UINT_16")]
        D3DMinPrecisionUint16 = 0x5,
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_16")]
        D3DMinPrecisionAny16 = 0xF0,
        [NativeName("Name", "D3D_MIN_PRECISION_ANY_10")]
        D3DMinPrecisionAny10 = 0xF1,
    }
}
