// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.REND
{
    [NativeName("Name", "GLenum")]
    public enum REND : int
    {
        [NativeName("Name", "GL_SCREEN_COORDINATES_REND")]
        ScreenCoordinatesRend = 0x8490,
        [NativeName("Name", "GL_INVERTED_SCREEN_W_REND")]
        InvertedScreenWRend = 0x8491,
    }
}
