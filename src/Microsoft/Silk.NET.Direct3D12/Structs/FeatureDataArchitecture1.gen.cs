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
    [NativeName("Name", "D3D12_FEATURE_DATA_ARCHITECTURE1")]
    public unsafe partial struct FeatureDataArchitecture1
    {
        public FeatureDataArchitecture1
        (
            uint? nodeIndex = null,
            int? tileBasedRenderer = null,
            int? uMA = null,
            int? cacheCoherentUMA = null,
            int? isolatedMMU = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (tileBasedRenderer is not null)
            {
                TileBasedRenderer = tileBasedRenderer.Value;
            }

            if (uMA is not null)
            {
                UMA = uMA.Value;
            }

            if (cacheCoherentUMA is not null)
            {
                CacheCoherentUMA = cacheCoherentUMA.Value;
            }

            if (isolatedMMU is not null)
            {
                IsolatedMMU = isolatedMMU.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "TileBasedRenderer")]
        public int TileBasedRenderer;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "UMA")]
        public int UMA;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "CacheCoherentUMA")]
        public int CacheCoherentUMA;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "IsolatedMMU")]
        public int IsolatedMMU;
    }
}
