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
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYOUTPUTID_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryoutputidOutput
    {
        public AuthenticatedchannelQueryoutputidOutput
        (
            AuthenticatedchannelQueryOutput? output = null,
            void* deviceHandle = null,
            void* cryptoSessionHandle = null,
            uint? outputIDIndex = null,
            ulong? outputID = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (deviceHandle is not null)
            {
                DeviceHandle = deviceHandle;
            }

            if (cryptoSessionHandle is not null)
            {
                CryptoSessionHandle = cryptoSessionHandle;
            }

            if (outputIDIndex is not null)
            {
                OutputIDIndex = outputIDIndex.Value;
            }

            if (outputID is not null)
            {
                OutputID = outputID.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DeviceHandle")]
        public void* DeviceHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "CryptoSessionHandle")]
        public void* CryptoSessionHandle;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputIDIndex")]
        public uint OutputIDIndex;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "OutputID")]
        public ulong OutputID;
    }
}
