// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
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
