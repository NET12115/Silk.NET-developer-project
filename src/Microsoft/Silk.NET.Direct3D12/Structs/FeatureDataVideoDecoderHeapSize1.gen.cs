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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_DECODER_HEAP_SIZE1")]
    public unsafe partial struct FeatureDataVideoDecoderHeapSize1
    {
        public FeatureDataVideoDecoderHeapSize1
        (
            VideoDecoderHeapDesc? videoDecoderHeapDesc = null,
            int? @protected = null,
            ulong? memoryPoolL0Size = null,
            ulong? memoryPoolL1Size = null
        ) : this()
        {
            if (videoDecoderHeapDesc is not null)
            {
                VideoDecoderHeapDesc = videoDecoderHeapDesc.Value;
            }

            if (@protected is not null)
            {
                Protected = @protected.Value;
            }

            if (memoryPoolL0Size is not null)
            {
                MemoryPoolL0Size = memoryPoolL0Size.Value;
            }

            if (memoryPoolL1Size is not null)
            {
                MemoryPoolL1Size = memoryPoolL1Size.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_DECODER_HEAP_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_DECODER_HEAP_DESC")]
        [NativeName("Name", "VideoDecoderHeapDesc")]
        public VideoDecoderHeapDesc VideoDecoderHeapDesc;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Protected")]
        public int Protected;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MemoryPoolL0Size")]
        public ulong MemoryPoolL0Size;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MemoryPoolL1Size")]
        public ulong MemoryPoolL1Size;
    }
}
