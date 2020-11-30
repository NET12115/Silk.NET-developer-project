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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_DEPTH_STENCIL_DESC")]
    public unsafe partial struct DepthStencilDesc
    {
        public DepthStencilDesc
        (
            int? depthEnable = null,
            DepthWriteMask? depthWriteMask = null,
            ComparisonFunc? depthFunc = null,
            int? stencilEnable = null,
            byte? stencilReadMask = null,
            byte? stencilWriteMask = null,
            DepthStencilopDesc? frontFace = null,
            DepthStencilopDesc? backFace = null
        ) : this()
        {
            if (depthEnable is not null)
            {
                DepthEnable = depthEnable.Value;
            }

            if (depthWriteMask is not null)
            {
                DepthWriteMask = depthWriteMask.Value;
            }

            if (depthFunc is not null)
            {
                DepthFunc = depthFunc.Value;
            }

            if (stencilEnable is not null)
            {
                StencilEnable = stencilEnable.Value;
            }

            if (stencilReadMask is not null)
            {
                StencilReadMask = stencilReadMask.Value;
            }

            if (stencilWriteMask is not null)
            {
                StencilWriteMask = stencilWriteMask.Value;
            }

            if (frontFace is not null)
            {
                FrontFace = frontFace.Value;
            }

            if (backFace is not null)
            {
                BackFace = backFace.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthEnable")]
        public int DepthEnable;

        [NativeName("Type", "D3D11_DEPTH_WRITE_MASK")]
        [NativeName("Type.Name", "D3D11_DEPTH_WRITE_MASK")]
        [NativeName("Name", "DepthWriteMask")]
        public DepthWriteMask DepthWriteMask;

        [NativeName("Type", "D3D11_COMPARISON_FUNC")]
        [NativeName("Type.Name", "D3D11_COMPARISON_FUNC")]
        [NativeName("Name", "DepthFunc")]
        public ComparisonFunc DepthFunc;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "StencilEnable")]
        public int StencilEnable;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilReadMask")]
        public byte StencilReadMask;

        [NativeName("Type", "UINT8")]
        [NativeName("Type.Name", "UINT8")]
        [NativeName("Name", "StencilWriteMask")]
        public byte StencilWriteMask;

        [NativeName("Type", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Type.Name", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Name", "FrontFace")]
        public DepthStencilopDesc FrontFace;

        [NativeName("Type", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Type.Name", "D3D11_DEPTH_STENCILOP_DESC")]
        [NativeName("Name", "BackFace")]
        public DepthStencilopDesc BackFace;
    }
}
