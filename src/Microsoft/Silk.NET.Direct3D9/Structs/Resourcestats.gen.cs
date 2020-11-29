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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRESOURCESTATS")]
    public unsafe partial struct Resourcestats
    {
        public Resourcestats
        (
            int? bThrashing = null,
            uint? approxBytesDownloaded = null,
            uint? numEvicts = null,
            uint? numVidCreates = null,
            uint? lastPri = null,
            uint? numUsed = null,
            uint? numUsedInVidMem = null,
            uint? workingSet = null,
            uint? workingSetBytes = null,
            uint? totalManaged = null,
            uint? totalBytes = null
        ) : this()
        {
            if (bThrashing is not null)
            {
                BThrashing = bThrashing.Value;
            }

            if (approxBytesDownloaded is not null)
            {
                ApproxBytesDownloaded = approxBytesDownloaded.Value;
            }

            if (numEvicts is not null)
            {
                NumEvicts = numEvicts.Value;
            }

            if (numVidCreates is not null)
            {
                NumVidCreates = numVidCreates.Value;
            }

            if (lastPri is not null)
            {
                LastPri = lastPri.Value;
            }

            if (numUsed is not null)
            {
                NumUsed = numUsed.Value;
            }

            if (numUsedInVidMem is not null)
            {
                NumUsedInVidMem = numUsedInVidMem.Value;
            }

            if (workingSet is not null)
            {
                WorkingSet = workingSet.Value;
            }

            if (workingSetBytes is not null)
            {
                WorkingSetBytes = workingSetBytes.Value;
            }

            if (totalManaged is not null)
            {
                TotalManaged = totalManaged.Value;
            }

            if (totalBytes is not null)
            {
                TotalBytes = totalBytes.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bThrashing")]
        public int BThrashing;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ApproxBytesDownloaded")]
        public uint ApproxBytesDownloaded;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumEvicts")]
        public uint NumEvicts;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumVidCreates")]
        public uint NumVidCreates;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LastPri")]
        public uint LastPri;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumUsed")]
        public uint NumUsed;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumUsedInVidMem")]
        public uint NumUsedInVidMem;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WorkingSet")]
        public uint WorkingSet;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WorkingSetBytes")]
        public uint WorkingSetBytes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TotalManaged")]
        public uint TotalManaged;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TotalBytes")]
        public uint TotalBytes;
    }
}
