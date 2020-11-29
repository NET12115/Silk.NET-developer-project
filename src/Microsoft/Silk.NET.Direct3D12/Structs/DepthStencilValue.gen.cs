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
    [NativeName("Name", "D3D12_DEPTH_STENCIL_VALUE")]
    public unsafe partial struct DepthStencilValue
    {
        public DepthStencilValue
        (
            float? depth = null,
            byte? stencil = null
        ) : this()
        {
            if (depth is not null)
            {
                Depth = depth.Value;
            }

            if (stencil is not null)
            {
                Stencil = stencil.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Depth")]
        public float Depth;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "Stencil")]
        public byte Stencil;
    }
}
