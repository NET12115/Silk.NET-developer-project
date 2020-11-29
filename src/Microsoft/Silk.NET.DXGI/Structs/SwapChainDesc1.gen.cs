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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_CHAIN_DESC1")]
    public unsafe partial struct SwapChainDesc1
    {
        public SwapChainDesc1
        (
            uint? width = null,
            uint? height = null,
            Silk.NET.DXGI.Format? format = null,
            int? stereo = null,
            SampleDesc? sampleDesc = null,
            uint? bufferUsage = null,
            uint? bufferCount = null,
            Scaling? scaling = null,
            SwapEffect? swapEffect = null,
            AlphaMode? alphaMode = null,
            uint? flags = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (stereo is not null)
            {
                Stereo = stereo.Value;
            }

            if (sampleDesc is not null)
            {
                SampleDesc = sampleDesc.Value;
            }

            if (bufferUsage is not null)
            {
                BufferUsage = bufferUsage.Value;
            }

            if (bufferCount is not null)
            {
                BufferCount = bufferCount.Value;
            }

            if (scaling is not null)
            {
                Scaling = scaling.Value;
            }

            if (swapEffect is not null)
            {
                SwapEffect = swapEffect.Value;
            }

            if (alphaMode is not null)
            {
                AlphaMode = alphaMode.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Stereo")]
        public int Stereo;

        [NativeName("Type", "DXGI_SAMPLE_DESC")]
        [NativeName("Type.Name", "DXGI_SAMPLE_DESC")]
        [NativeName("Name", "SampleDesc")]
        public SampleDesc SampleDesc;

        [NativeName("Type", "DXGI_USAGE")]
        [NativeName("Type.Name", "DXGI_USAGE")]
        [NativeName("Name", "BufferUsage")]
        public uint BufferUsage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BufferCount")]
        public uint BufferCount;

        [NativeName("Type", "DXGI_SCALING")]
        [NativeName("Type.Name", "DXGI_SCALING")]
        [NativeName("Name", "Scaling")]
        public Scaling Scaling;

        [NativeName("Type", "DXGI_SWAP_EFFECT")]
        [NativeName("Type.Name", "DXGI_SWAP_EFFECT")]
        [NativeName("Name", "SwapEffect")]
        public SwapEffect SwapEffect;

        [NativeName("Type", "DXGI_ALPHA_MODE")]
        [NativeName("Type.Name", "DXGI_ALPHA_MODE")]
        [NativeName("Name", "AlphaMode")]
        public AlphaMode AlphaMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
