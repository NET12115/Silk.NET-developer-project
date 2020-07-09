// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "ContextProfileMask")]
    public enum ContextProfileMask
    {
        [NativeName("Name", "GL_CONTEXT_CORE_PROFILE_BIT")]
        ContextCoreProfileBit = 0x1,
        [NativeName("Name", "GL_CONTEXT_COMPATIBILITY_PROFILE_BIT")]
        ContextCompatibilityProfileBit = 0x2,
    }
}
