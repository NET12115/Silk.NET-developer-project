// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ErrorCode")]
    public enum ErrorCode : int
    {
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_INVALID_ENUM")]
        InvalidEnum = 0x500,
        [NativeName("Name", "GL_INVALID_VALUE")]
        InvalidValue = 0x501,
        [NativeName("Name", "GL_INVALID_OPERATION")]
        InvalidOperation = 0x502,
        [NativeName("Name", "GL_OUT_OF_MEMORY")]
        OutOfMemory = 0x505,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION")]
        InvalidFramebufferOperation = 0x506,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION_EXT")]
        InvalidFramebufferOperationExt = 0x506,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION_OES")]
        InvalidFramebufferOperationOes = 0x506,
        [NativeName("Name", "GL_TABLE_TOO_LARGE_EXT")]
        TableTooLargeExt = 0x8031,
        [NativeName("Name", "GL_TABLE_TOO_LARGE")]
        TableTooLarge = 0x8031,
        [NativeName("Name", "GL_TEXTURE_TOO_LARGE_EXT")]
        TextureTooLargeExt = 0x8065,
    }
}
