// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_REGISTER_COMPONENT_TYPE")]
    public enum D3DRegisterComponentType : int
    {
        [NativeName("Name", "D3D_REGISTER_COMPONENT_UNKNOWN")]
        D3DRegisterComponentUnknown = 0x0,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_UINT32")]
        D3DRegisterComponentUint32 = 0x1,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_SINT32")]
        D3DRegisterComponentSint32 = 0x2,
        [NativeName("Name", "D3D_REGISTER_COMPONENT_FLOAT32")]
        D3DRegisterComponentFloat32 = 0x3,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_UNKNOWN")]
        D3D10RegisterComponentUnknown = 0x0,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_UINT32")]
        D3D10RegisterComponentUint32 = 0x1,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_SINT32")]
        D3D10RegisterComponentSint32 = 0x2,
        [NativeName("Name", "D3D10_REGISTER_COMPONENT_FLOAT32")]
        D3D10RegisterComponentFloat32 = 0x3,
    }
}
