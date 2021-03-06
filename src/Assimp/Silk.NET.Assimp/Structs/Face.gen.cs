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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiFace")]
    public unsafe partial struct Face
    {
        public Face
        (
            uint? mNumIndices = null,
            uint* mIndices = null
        ) : this()
        {
            if (mNumIndices is not null)
            {
                MNumIndices = mNumIndices.Value;
            }

            if (mIndices is not null)
            {
                MIndices = mIndices;
            }
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumIndices")]
        public uint MNumIndices;

        [NativeName("Type", "unsigned int *")]
        [NativeName("Type.Name", "unsigned int *")]
        [NativeName("Name", "mIndices")]
        public uint* MIndices;
    }
}
