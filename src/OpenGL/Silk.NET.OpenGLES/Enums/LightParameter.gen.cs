// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "LightParameter")]
    public enum LightParameter : int
    {
        [NativeName("Name", "GL_POSITION")]
        Position = 0x1203,
        [NativeName("Name", "GL_SPOT_DIRECTION")]
        SpotDirection = 0x1204,
        [NativeName("Name", "GL_SPOT_EXPONENT")]
        SpotExponent = 0x1205,
        [NativeName("Name", "GL_SPOT_CUTOFF")]
        SpotCutoff = 0x1206,
        [NativeName("Name", "GL_CONSTANT_ATTENUATION")]
        ConstantAttenuation = 0x1207,
        [NativeName("Name", "GL_LINEAR_ATTENUATION")]
        LinearAttenuation = 0x1208,
        [NativeName("Name", "GL_QUADRATIC_ATTENUATION")]
        QuadraticAttenuation = 0x1209,
    }
}
