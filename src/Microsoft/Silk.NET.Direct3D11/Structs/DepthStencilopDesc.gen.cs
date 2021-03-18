// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_DEPTH_STENCILOP_DESC")]
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


        [NativeName("Type", "D3D11_STENCIL_OP")]
        [NativeName("Type.Name", "D3D11_STENCIL_OP")]
        [NativeName("Name", "StencilFailOp")]
        public StencilOp StencilFailOp;

        [NativeName("Type", "D3D11_STENCIL_OP")]
        [NativeName("Type.Name", "D3D11_STENCIL_OP")]
        [NativeName("Name", "StencilDepthFailOp")]
        public StencilOp StencilDepthFailOp;

        [NativeName("Type", "D3D11_STENCIL_OP")]
        [NativeName("Type.Name", "D3D11_STENCIL_OP")]
        [NativeName("Name", "StencilPassOp")]
        public StencilOp StencilPassOp;

        [NativeName("Type", "D3D11_COMPARISON_FUNC")]
        [NativeName("Type.Name", "D3D11_COMPARISON_FUNC")]
        [NativeName("Name", "StencilFunc")]
        public ComparisonFunc StencilFunc;
    }
}
