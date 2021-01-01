// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "LightName")]
    public enum LightName : int
    {
        [NativeName("Name", "GL_LIGHT0")]
        Light0 = 0x4000,
        [NativeName("Name", "GL_LIGHT1")]
        Light1 = 0x4001,
        [NativeName("Name", "GL_LIGHT2")]
        Light2 = 0x4002,
        [NativeName("Name", "GL_LIGHT3")]
        Light3 = 0x4003,
        [NativeName("Name", "GL_LIGHT4")]
        Light4 = 0x4004,
        [NativeName("Name", "GL_LIGHT5")]
        Light5 = 0x4005,
        [NativeName("Name", "GL_LIGHT6")]
        Light6 = 0x4006,
        [NativeName("Name", "GL_LIGHT7")]
        Light7 = 0x4007,
        [NativeName("Name", "GL_FRAGMENT_LIGHT0_SGIX")]
        FragmentLight0Sgix = 0x840C,
        [NativeName("Name", "GL_FRAGMENT_LIGHT1_SGIX")]
        FragmentLight1Sgix = 0x840D,
        [NativeName("Name", "GL_FRAGMENT_LIGHT2_SGIX")]
        FragmentLight2Sgix = 0x840E,
        [NativeName("Name", "GL_FRAGMENT_LIGHT3_SGIX")]
        FragmentLight3Sgix = 0x840F,
        [NativeName("Name", "GL_FRAGMENT_LIGHT4_SGIX")]
        FragmentLight4Sgix = 0x8410,
        [NativeName("Name", "GL_FRAGMENT_LIGHT5_SGIX")]
        FragmentLight5Sgix = 0x8411,
        [NativeName("Name", "GL_FRAGMENT_LIGHT6_SGIX")]
        FragmentLight6Sgix = 0x8412,
        [NativeName("Name", "GL_FRAGMENT_LIGHT7_SGIX")]
        FragmentLight7Sgix = 0x8413,
    }
}
