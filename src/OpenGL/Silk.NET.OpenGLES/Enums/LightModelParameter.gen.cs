// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "LightModelParameter")]
    public enum LightModelParameter : int
    {
        [NativeName("Name", "GL_LIGHT_MODEL_LOCAL_VIEWER")]
        LightModelLocalViewer = 0xB51,
        [NativeName("Name", "GL_LIGHT_MODEL_TWO_SIDE")]
        LightModelTwoSide = 0xB52,
        [NativeName("Name", "GL_LIGHT_MODEL_AMBIENT")]
        LightModelAmbient = 0xB53,
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL")]
        LightModelColorControl = 0x81F8,
        [NativeName("Name", "GL_LIGHT_MODEL_COLOR_CONTROL_EXT")]
        LightModelColorControlExt = 0x81F8,
    }
}
