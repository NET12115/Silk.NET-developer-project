// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TextureEnvTarget")]
    public enum TextureEnvTarget : int
    {
        [NativeName("Name", "GL_TEXTURE_ENV")]
        TextureEnv = 0x2300,
    }
}
