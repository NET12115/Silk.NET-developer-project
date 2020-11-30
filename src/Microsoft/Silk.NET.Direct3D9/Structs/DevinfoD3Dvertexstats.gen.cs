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
    [NativeName("Name", "_D3DDEVINFO_D3DVERTEXSTATS")]
    public unsafe partial struct DevinfoD3Dvertexstats
    {
        public DevinfoD3Dvertexstats
        (
            uint? numRenderedTriangles = null,
            uint? numExtraClippingTriangles = null
        ) : this()
        {
            if (numRenderedTriangles is not null)
            {
                NumRenderedTriangles = numRenderedTriangles.Value;
            }

            if (numExtraClippingTriangles is not null)
            {
                NumExtraClippingTriangles = numExtraClippingTriangles.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumRenderedTriangles")]
        public uint NumRenderedTriangles;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumExtraClippingTriangles")]
        public uint NumExtraClippingTriangles;
    }
}
