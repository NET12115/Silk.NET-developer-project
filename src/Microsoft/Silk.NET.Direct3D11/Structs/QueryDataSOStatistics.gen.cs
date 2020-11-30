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
    [NativeName("Name", "D3D11_QUERY_DATA_SO_STATISTICS")]
    public unsafe partial struct QueryDataSOStatistics
    {
        public QueryDataSOStatistics
        (
            ulong? numPrimitivesWritten = null,
            ulong? primitivesStorageNeeded = null
        ) : this()
        {
            if (numPrimitivesWritten is not null)
            {
                NumPrimitivesWritten = numPrimitivesWritten.Value;
            }

            if (primitivesStorageNeeded is not null)
            {
                PrimitivesStorageNeeded = primitivesStorageNeeded.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "NumPrimitivesWritten")]
        public ulong NumPrimitivesWritten;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "PrimitivesStorageNeeded")]
        public ulong PrimitivesStorageNeeded;
    }
}
