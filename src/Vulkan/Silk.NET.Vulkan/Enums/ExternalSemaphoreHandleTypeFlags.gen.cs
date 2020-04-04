// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Vulkan
{
    [Flags()]
    public enum ExternalSemaphoreHandleTypeFlags
    {
        ExternalSemaphoreHandleTypeOpaqueFDBit = 1,
        ExternalSemaphoreHandleTypeOpaqueWin32Bit = 2,
        ExternalSemaphoreHandleTypeOpaqueWin32KmtBit = 4,
        ExternalSemaphoreHandleTypeD3D12FenceBit = 8,
        ExternalSemaphoreHandleTypeSyncFDBit = 16,
    }
}
