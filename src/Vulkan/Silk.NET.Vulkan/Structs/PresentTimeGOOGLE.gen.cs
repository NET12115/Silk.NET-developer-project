// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPresentTimeGOOGLE")]
    public unsafe partial struct PresentTimeGOOGLE
    {
        public PresentTimeGOOGLE
        (
            uint? presentID = null,
            ulong? desiredPresentTime = null
        ) : this()
        {
            if (presentID is not null)
            {
                PresentID = presentID.Value;
            }

            if (desiredPresentTime is not null)
            {
                DesiredPresentTime = desiredPresentTime.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "presentID")]
        public uint PresentID;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "desiredPresentTime")]
        public ulong DesiredPresentTime;
    }
}
