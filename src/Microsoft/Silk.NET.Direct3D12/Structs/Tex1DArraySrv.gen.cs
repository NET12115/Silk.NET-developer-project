// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEX1D_ARRAY_SRV")]
    public unsafe partial struct Tex1DArraySrv
    {
        public Tex1DArraySrv
        (
            uint? mostDetailedMip = null,
            uint? mipLevels = null,
            uint? firstArraySlice = null,
            uint? arraySize = null,
            float? resourceMinLODClamp = null
        ) : this()
        {
            if (mostDetailedMip is not null)
            {
                MostDetailedMip = mostDetailedMip.Value;
            }

            if (mipLevels is not null)
            {
                MipLevels = mipLevels.Value;
            }

            if (firstArraySlice is not null)
            {
                FirstArraySlice = firstArraySlice.Value;
            }

            if (arraySize is not null)
            {
                ArraySize = arraySize.Value;
            }

            if (resourceMinLODClamp is not null)
            {
                ResourceMinLODClamp = resourceMinLODClamp.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MostDetailedMip")]
        public uint MostDetailedMip;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipLevels")]
        public uint MipLevels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstArraySlice")]
        public uint FirstArraySlice;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArraySize")]
        public uint ArraySize;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "ResourceMinLODClamp")]
        public float ResourceMinLODClamp;
    }
}
