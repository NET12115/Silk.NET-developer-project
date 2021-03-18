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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM")]
    public unsafe partial struct VideoProcessOutputStream
    {
        public VideoProcessOutputStream
        (
            ID3D12Resource* pTexture2D = null,
            uint? subresource = null
        ) : this()
        {
            if (pTexture2D is not null)
            {
                PTexture2D = pTexture2D;
            }

            if (subresource is not null)
            {
                Subresource = subresource.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pTexture2D")]
        public ID3D12Resource* PTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Subresource")]
        public uint Subresource;
    }
}
