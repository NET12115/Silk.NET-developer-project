// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE")]
    public enum RaytracingAccelerationStructureCopyMode : int
    {
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_CLONE")]
        RaytracingAccelerationStructureCopyModeClone = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_COMPACT")]
        RaytracingAccelerationStructureCopyModeCompact = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_VISUALIZATION_DECODE_FOR_TOOLS")]
        RaytracingAccelerationStructureCopyModeVisualizationDecodeForTools = 0x2,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_SERIALIZE")]
        RaytracingAccelerationStructureCopyModeSerialize = 0x3,
        [NativeName("Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_COPY_MODE_DESERIALIZE")]
        RaytracingAccelerationStructureCopyModeDeserialize = 0x4,
    }
}
