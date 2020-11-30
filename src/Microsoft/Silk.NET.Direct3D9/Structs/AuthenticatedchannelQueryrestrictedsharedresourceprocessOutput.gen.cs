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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryrestrictedsharedresourceprocessOutput
    {
        public AuthenticatedchannelQueryrestrictedsharedresourceprocessOutput
        (
            AuthenticatedchannelQueryOutput? output = null,
            uint? processIndex = null,
            AuthenticatedchannelProcessidentifiertype? processIdentifer = null,
            void* processHandle = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (processIndex is not null)
            {
                ProcessIndex = processIndex.Value;
            }

            if (processIdentifer is not null)
            {
                ProcessIdentifer = processIdentifer.Value;
            }

            if (processHandle is not null)
            {
                ProcessHandle = processHandle;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProcessIndex")]
        public uint ProcessIndex;

        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE")]
        [NativeName("Name", "ProcessIdentifer")]
        public AuthenticatedchannelProcessidentifiertype ProcessIdentifer;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "ProcessHandle")]
        public void* ProcessHandle;
    }
}
