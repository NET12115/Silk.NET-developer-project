// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "MapQuery")]
    public enum MapQuery : int
    {
        [NativeName("Name", "GL_COEFF")]
        Coeff = 0xA00,
        [NativeName("Name", "GL_ORDER")]
        Order = 0xA01,
        [NativeName("Name", "GL_DOMAIN")]
        Domain = 0xA02,
    }
}
