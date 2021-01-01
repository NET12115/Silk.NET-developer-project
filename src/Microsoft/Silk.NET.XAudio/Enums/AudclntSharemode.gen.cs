// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.XAudio
{
    [NativeName("Name", "_AUDCLNT_SHAREMODE")]
    public enum AudclntSharemode : int
    {
        [NativeName("Name", "AUDCLNT_SHAREMODE_SHARED")]
        AudclntSharemodeShared = 0x0,
        [NativeName("Name", "AUDCLNT_SHAREMODE_EXCLUSIVE")]
        AudclntSharemodeExclusive = 0x1,
    }
}
