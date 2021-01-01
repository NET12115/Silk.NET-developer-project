// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SamplerParameterF")]
    public enum SamplerParameterF : int
    {
        [NativeName("Name", "GL_TEXTURE_BORDER_COLOR")]
        TextureBorderColor = 0x1004,
        [NativeName("Name", "GL_TEXTURE_MIN_LOD")]
        TextureMinLod = 0x813A,
        [NativeName("Name", "GL_TEXTURE_MAX_LOD")]
        TextureMaxLod = 0x813B,
        [NativeName("Name", "GL_TEXTURE_MAX_ANISOTROPY")]
        TextureMaxAnisotropy = 0x84FE,
        [NativeName("Name", "GL_TEXTURE_LOD_BIAS")]
        TextureLodBias = 0x8501,
        [NativeName("Name", "GL_TEXTURE_UNNORMALIZED_COORDINATES_ARM")]
        TextureUnnormalizedCoordinatesArm = 0x8F6A,
    }
}
