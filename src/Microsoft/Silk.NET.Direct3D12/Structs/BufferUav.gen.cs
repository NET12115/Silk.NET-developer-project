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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BUFFER_UAV")]
    public unsafe partial struct BufferUav
    {
        public BufferUav
        (
            ulong? firstElement = null,
            uint? numElements = null,
            uint? structureByteStride = null,
            ulong? counterOffsetInBytes = null,
            BufferUavFlags? flags = null
        ) : this()
        {
            if (firstElement is not null)
            {
                FirstElement = firstElement.Value;
            }

            if (numElements is not null)
            {
                NumElements = numElements.Value;
            }

            if (structureByteStride is not null)
            {
                StructureByteStride = structureByteStride.Value;
            }

            if (counterOffsetInBytes is not null)
            {
                CounterOffsetInBytes = counterOffsetInBytes.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "FirstElement")]
        public ulong FirstElement;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumElements")]
        public uint NumElements;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StructureByteStride")]
        public uint StructureByteStride;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "CounterOffsetInBytes")]
        public ulong CounterOffsetInBytes;

        [NativeName("Type", "D3D12_BUFFER_UAV_FLAGS")]
        [NativeName("Type.Name", "D3D12_BUFFER_UAV_FLAGS")]
        [NativeName("Name", "Flags")]
        public BufferUavFlags Flags;
    }
}
