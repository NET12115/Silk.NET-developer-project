// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "TransformFeedbackBufferMode")]
    public enum TransformFeedbackBufferMode : int
    {
        [NativeName("Name", "GL_INTERLEAVED_ATTRIBS")]
        InterleavedAttribs = 0x8C8C,
        [NativeName("Name", "GL_SEPARATE_ATTRIBS")]
        SeparateAttribs = 0x8C8D,
    }
}
