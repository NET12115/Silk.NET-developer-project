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
    [NativeName("Name", "_D3DDEVINFO_VCACHE")]
    public unsafe partial struct DevinfoVcache
    {
        public DevinfoVcache
        (
            uint? pattern = null,
            uint? optMethod = null,
            uint? cacheSize = null,
            uint? magicNumber = null
        ) : this()
        {
            if (pattern is not null)
            {
                Pattern = pattern.Value;
            }

            if (optMethod is not null)
            {
                OptMethod = optMethod.Value;
            }

            if (cacheSize is not null)
            {
                CacheSize = cacheSize.Value;
            }

            if (magicNumber is not null)
            {
                MagicNumber = magicNumber.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Pattern")]
        public uint Pattern;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "OptMethod")]
        public uint OptMethod;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "CacheSize")]
        public uint CacheSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MagicNumber")]
        public uint MagicNumber;
    }
}
