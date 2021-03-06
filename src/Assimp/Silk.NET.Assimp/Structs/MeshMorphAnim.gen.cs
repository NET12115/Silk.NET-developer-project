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
    [NativeName("Name", "aiMeshMorphAnim")]
    public unsafe partial struct MeshMorphAnim
    {
        public MeshMorphAnim
        (
            AssimpString? mName = null,
            uint? mNumKeys = null,
            MeshMorphKey* mKeys = null
        ) : this()
        {
            if (mName is not null)
            {
                MName = mName.Value;
            }

            if (mNumKeys is not null)
            {
                MNumKeys = mNumKeys.Value;
            }

            if (mKeys is not null)
            {
                MKeys = mKeys;
            }
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mName")]
        public AssimpString MName;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumKeys")]
        public uint MNumKeys;

        [NativeName("Type", "aiMeshMorphKey *")]
        [NativeName("Type.Name", "aiMeshMorphKey *")]
        [NativeName("Name", "mKeys")]
        public MeshMorphKey* MKeys;
    }
}
