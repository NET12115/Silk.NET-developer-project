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
    [NativeName("Name", "D3D12_DEPTH_STENCILOP_DESC")]
    public unsafe partial struct DepthStencilopDesc
    {
        public DepthStencilopDesc
        (
            StencilOp? stencilFailOp = null,
            StencilOp? stencilDepthFailOp = null,
            StencilOp? stencilPassOp = null,
            ComparisonFunc? stencilFunc = null
        ) : this()
        {
            if (stencilFailOp is not null)
            {
                StencilFailOp = stencilFailOp.Value;
            }

            if (stencilDepthFailOp is not null)
            {
                StencilDepthFailOp = stencilDepthFailOp.Value;
            }

            if (stencilPassOp is not null)
            {
                StencilPassOp = stencilPassOp.Value;
            }

            if (stencilFunc is not null)
            {
                StencilFunc = stencilFunc.Value;
            }
        }


        [NativeName("Type", "D3D12_STENCIL_OP")]
        [NativeName("Type.Name", "D3D12_STENCIL_OP")]
        [NativeName("Name", "StencilFailOp")]
        public StencilOp StencilFailOp;

        [NativeName("Type", "D3D12_STENCIL_OP")]
        [NativeName("Type.Name", "D3D12_STENCIL_OP")]
        [NativeName("Name", "StencilDepthFailOp")]
        public StencilOp StencilDepthFailOp;

        [NativeName("Type", "D3D12_STENCIL_OP")]
        [NativeName("Type.Name", "D3D12_STENCIL_OP")]
        [NativeName("Name", "StencilPassOp")]
        public StencilOp StencilPassOp;

        [NativeName("Type", "D3D12_COMPARISON_FUNC")]
        [NativeName("Type.Name", "D3D12_COMPARISON_FUNC")]
        [NativeName("Name", "StencilFunc")]
        public ComparisonFunc StencilFunc;
    }
}
