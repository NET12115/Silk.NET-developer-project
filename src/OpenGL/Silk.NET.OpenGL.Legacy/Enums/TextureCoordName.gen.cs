// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "TextureCoordName")]
    public enum TextureCoordName : int
    {
        [NativeName("Name", "GL_S")]
        S = 0x2000,
        [NativeName("Name", "GL_T")]
        T = 0x2001,
        [NativeName("Name", "GL_R")]
        R = 0x2002,
        [NativeName("Name", "GL_Q")]
        Q = 0x2003,
    }
}
