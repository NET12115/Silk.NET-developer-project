// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "CullParameterEXT")]
    public enum CullParameterEXT : int
    {
        [NativeName("Name", "GL_CULL_VERTEX_EYE_POSITION_EXT")]
        CullVertexEyePositionExt = 0x81AB,
        [NativeName("Name", "GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
        CullVertexObjectPositionExt = 0x81AC,
    }
}
