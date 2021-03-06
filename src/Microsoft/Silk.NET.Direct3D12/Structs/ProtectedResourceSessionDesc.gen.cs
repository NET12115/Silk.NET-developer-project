// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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
    [NativeName("Name", "D3D12_PROTECTED_RESOURCE_SESSION_DESC")]
    public unsafe partial struct ProtectedResourceSessionDesc
    {
        public ProtectedResourceSessionDesc
        (
            uint? nodeMask = null,
            ProtectedResourceSessionFlags? flags = null
        ) : this()
        {
            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "D3D12_PROTECTED_RESOURCE_SESSION_FLAGS")]
        [NativeName("Type.Name", "D3D12_PROTECTED_RESOURCE_SESSION_FLAGS")]
        [NativeName("Name", "Flags")]
        public ProtectedResourceSessionFlags Flags;
    }
}
