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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVSHADERCAPS2_0")]
    public unsafe partial struct Vshadercaps20
    {
        public Vshadercaps20
        (
            uint? caps = null,
            int? dynamicFlowControlDepth = null,
            int? numTemps = null,
            int? staticFlowControlDepth = null
        ) : this()
        {
            if (caps is not null)
            {
                Caps = caps.Value;
            }

            if (dynamicFlowControlDepth is not null)
            {
                DynamicFlowControlDepth = dynamicFlowControlDepth.Value;
            }

            if (numTemps is not null)
            {
                NumTemps = numTemps.Value;
            }

            if (staticFlowControlDepth is not null)
            {
                StaticFlowControlDepth = staticFlowControlDepth.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps")]
        public uint Caps;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "DynamicFlowControlDepth")]
        public int DynamicFlowControlDepth;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "NumTemps")]
        public int NumTemps;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "StaticFlowControlDepth")]
        public int StaticFlowControlDepth;
    }
}
