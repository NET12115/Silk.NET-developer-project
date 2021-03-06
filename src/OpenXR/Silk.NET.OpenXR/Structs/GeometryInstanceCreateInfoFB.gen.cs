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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGeometryInstanceCreateInfoFB")]
    public unsafe partial struct GeometryInstanceCreateInfoFB
    {
        public GeometryInstanceCreateInfoFB
        (
            StructureType? type = StructureType.TypeGeometryInstanceCreateInfoFB,
            void* next = null,
            PassthroughLayerFB? layer = null,
            TriangleMeshFB? mesh = null,
            Space? baseSpace = null,
            Posef? pose = null,
            Vector3f? scale = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (layer is not null)
            {
                Layer = layer.Value;
            }

            if (mesh is not null)
            {
                Mesh = mesh.Value;
            }

            if (baseSpace is not null)
            {
                BaseSpace = baseSpace.Value;
            }

            if (pose is not null)
            {
                Pose = pose.Value;
            }

            if (scale is not null)
            {
                Scale = scale.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughLayerFB")]
        [NativeName("Type.Name", "XrPassthroughLayerFB")]
        [NativeName("Name", "layer")]
        public PassthroughLayerFB Layer;
/// <summary></summary>
        [NativeName("Type", "XrTriangleMeshFB")]
        [NativeName("Type.Name", "XrTriangleMeshFB")]
        [NativeName("Name", "mesh")]
        public TriangleMeshFB Mesh;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "baseSpace")]
        public Space BaseSpace;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "pose")]
        public Posef Pose;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "scale")]
        public Vector3f Scale;
    }
}
