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
    [NativeName("Name", "D3D11_TILE_REGION_SIZE")]
    public unsafe partial struct TileRegionSize
    {
        public TileRegionSize
        (
            uint? numTiles = null,
            int? bUseBox = null,
            uint? width = null,
            ushort? height = null,
            ushort? depth = null
        ) : this()
        {
            if (numTiles is not null)
            {
                NumTiles = numTiles.Value;
            }

            if (bUseBox is not null)
            {
                BUseBox = bUseBox.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (depth is not null)
            {
                Depth = depth.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumTiles")]
        public uint NumTiles;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bUseBox")]
        public int BUseBox;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "Height")]
        public ushort Height;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "Depth")]
        public ushort Depth;
    }
}
