// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ColorTableTarget")]
    public enum ColorTableTarget : int
    {
        [NativeName("Name", "GL_COLOR_TABLE")]
        ColorTable = 0x80D0,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE")]
        PostConvolutionColorTable = 0x80D1,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE")]
        PostColorMatrixColorTable = 0x80D2,
        [NativeName("Name", "GL_PROXY_COLOR_TABLE")]
        ProxyColorTable = 0x80D3,
        [NativeName("Name", "GL_PROXY_POST_CONVOLUTION_COLOR_TABLE")]
        ProxyPostConvolutionColorTable = 0x80D4,
        [NativeName("Name", "GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE")]
        ProxyPostColorMatrixColorTable = 0x80D5,
    }
}
