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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_PROCESSOR_SIZE")]
    public unsafe partial struct FeatureDataVideoProcessorSize
    {
        public FeatureDataVideoProcessorSize
        (
            uint? nodeMask = null,
            VideoProcessOutputStreamDesc* pOutputStreamDesc = null,
            uint? numInputStreamDescs = null,
            VideoProcessInputStreamDesc* pInputStreamDescs = null,
            ulong? memoryPoolL0Size = null,
            ulong? memoryPoolL1Size = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (pOutputStreamDesc is not null)
            {
                POutputStreamDesc = pOutputStreamDesc;
            }

            if (numInputStreamDescs is not null)
            {
                NumInputStreamDescs = numInputStreamDescs.Value;
            }

            if (pInputStreamDescs is not null)
            {
                PInputStreamDescs = pInputStreamDescs;
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


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC *")]
        [NativeName("Name", "pOutputStreamDesc")]
        public VideoProcessOutputStreamDesc* POutputStreamDesc;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumInputStreamDescs")]
        public uint NumInputStreamDescs;

        [NativeName("Type", "const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
        [NativeName("Type.Name", "const D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC *")]
        [NativeName("Name", "pInputStreamDescs")]
        public VideoProcessInputStreamDesc* PInputStreamDescs;

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
