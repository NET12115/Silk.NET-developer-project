// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DPOOL")]
    public enum Pool : int
    {
        [NativeName("Name", "D3DPOOL_DEFAULT")]
        PoolDefault = 0x0,
        [NativeName("Name", "D3DPOOL_MANAGED")]
        PoolManaged = 0x1,
        [NativeName("Name", "D3DPOOL_SYSTEMMEM")]
        PoolSystemmem = 0x2,
        [NativeName("Name", "D3DPOOL_SCRATCH")]
        PoolScratch = 0x3,
        [NativeName("Name", "D3DPOOL_FORCE_DWORD")]
        PoolForceDword = 0x7FFFFFFF,
    }
}
