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
    [NativeName("Name", "D3D11_RASTERIZER_DESC2")]
    public unsafe partial struct RasterizerDesc2
    {
        public RasterizerDesc2
        (
            FillMode? fillMode = null,
            CullMode? cullMode = null,
            int? frontCounterClockwise = null,
            int? depthBias = null,
            float? depthBiasClamp = null,
            float? slopeScaledDepthBias = null,
            int? depthClipEnable = null,
            int? scissorEnable = null,
            int? multisampleEnable = null,
            int? antialiasedLineEnable = null,
            uint? forcedSampleCount = null,
            ConservativeRasterizationMode? conservativeRaster = null
        ) : this()
        {
            if (fillMode is not null)
            {
                FillMode = fillMode.Value;
            }

            if (cullMode is not null)
            {
                CullMode = cullMode.Value;
            }

            if (frontCounterClockwise is not null)
            {
                FrontCounterClockwise = frontCounterClockwise.Value;
            }

            if (depthBias is not null)
            {
                DepthBias = depthBias.Value;
            }

            if (depthBiasClamp is not null)
            {
                DepthBiasClamp = depthBiasClamp.Value;
            }

            if (slopeScaledDepthBias is not null)
            {
                SlopeScaledDepthBias = slopeScaledDepthBias.Value;
            }

            if (depthClipEnable is not null)
            {
                DepthClipEnable = depthClipEnable.Value;
            }

            if (scissorEnable is not null)
            {
                ScissorEnable = scissorEnable.Value;
            }

            if (multisampleEnable is not null)
            {
                MultisampleEnable = multisampleEnable.Value;
            }

            if (antialiasedLineEnable is not null)
            {
                AntialiasedLineEnable = antialiasedLineEnable.Value;
            }

            if (forcedSampleCount is not null)
            {
                ForcedSampleCount = forcedSampleCount.Value;
            }

            if (conservativeRaster is not null)
            {
                ConservativeRaster = conservativeRaster.Value;
            }
        }


        [NativeName("Type", "D3D11_FILL_MODE")]
        [NativeName("Type.Name", "D3D11_FILL_MODE")]
        [NativeName("Name", "FillMode")]
        public FillMode FillMode;

        [NativeName("Type", "D3D11_CULL_MODE")]
        [NativeName("Type.Name", "D3D11_CULL_MODE")]
        [NativeName("Name", "CullMode")]
        public CullMode CullMode;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FrontCounterClockwise")]
        public int FrontCounterClockwise;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "DepthBias")]
        public int DepthBias;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "DepthBiasClamp")]
        public float DepthBiasClamp;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "SlopeScaledDepthBias")]
        public float SlopeScaledDepthBias;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DepthClipEnable")]
        public int DepthClipEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ScissorEnable")]
        public int ScissorEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "MultisampleEnable")]
        public int MultisampleEnable;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AntialiasedLineEnable")]
        public int AntialiasedLineEnable;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ForcedSampleCount")]
        public uint ForcedSampleCount;

        [NativeName("Type", "D3D11_CONSERVATIVE_RASTERIZATION_MODE")]
        [NativeName("Type.Name", "D3D11_CONSERVATIVE_RASTERIZATION_MODE")]
        [NativeName("Name", "ConservativeRaster")]
        public ConservativeRasterizationMode ConservativeRaster;
    }
}
