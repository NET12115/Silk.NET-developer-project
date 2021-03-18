// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "GetTexBumpParameterATI")]
    public enum GetTexBumpParameterATI : int
    {
        [NativeName("Name", "GL_BUMP_ROT_MATRIX_ATI")]
        BumpRotMatrixAti = 0x8775,
        [NativeName("Name", "GL_BUMP_ROT_MATRIX_SIZE_ATI")]
        BumpRotMatrixSizeAti = 0x8776,
        [NativeName("Name", "GL_BUMP_NUM_TEX_UNITS_ATI")]
        BumpNumTexUnitsAti = 0x8777,
        [NativeName("Name", "GL_BUMP_TEX_UNITS_ATI")]
        BumpTexUnitsAti = 0x8778,
    }
}
