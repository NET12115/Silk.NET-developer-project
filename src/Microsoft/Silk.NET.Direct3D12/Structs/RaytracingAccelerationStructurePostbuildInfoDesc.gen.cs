// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_DESC")]
    public unsafe partial struct RaytracingAccelerationStructurePostbuildInfoDesc
    {
        public RaytracingAccelerationStructurePostbuildInfoDesc
        (
            ulong? destBuffer = null,
            RaytracingAccelerationStructurePostbuildInfoType? infoType = null
        ) : this()
        {
            if (destBuffer is not null)
            {
                DestBuffer = destBuffer.Value;
            }

            if (infoType is not null)
            {
                InfoType = infoType.Value;
            }
        }


        [NativeName("Type", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Type.Name", "D3D12_GPU_VIRTUAL_ADDRESS")]
        [NativeName("Name", "DestBuffer")]
        public ulong DestBuffer;

        [NativeName("Type", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TYPE")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_POSTBUILD_INFO_TYPE")]
        [NativeName("Name", "InfoType")]
        public RaytracingAccelerationStructurePostbuildInfoType InfoType;
    }
}
