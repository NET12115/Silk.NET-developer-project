// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SpriteParameterNameSGIX")]
    public enum SpriteParameterNameSGIX : int
    {
        [NativeName("Name", "GL_SPRITE_MODE_SGIX")]
        SpriteModeSgix = 0x8149,
    }
}
