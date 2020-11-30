// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_CROSS_NODE")]
    public unsafe partial struct FeatureDataCrossNode
    {
        public FeatureDataCrossNode
        (
            CrossNodeSharingTier? sharingTier = null,
            int? atomicShaderInstructions = null
        ) : this()
        {
            if (sharingTier is not null)
            {
                SharingTier = sharingTier.Value;
            }

            if (atomicShaderInstructions is not null)
            {
                AtomicShaderInstructions = atomicShaderInstructions.Value;
            }
        }


        [NativeName("Type", "D3D12_CROSS_NODE_SHARING_TIER")]
        [NativeName("Type.Name", "D3D12_CROSS_NODE_SHARING_TIER")]
        [NativeName("Name", "SharingTier")]
        public CrossNodeSharingTier SharingTier;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AtomicShaderInstructions")]
        public int AtomicShaderInstructions;
    }
}
