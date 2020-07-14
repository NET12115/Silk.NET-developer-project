// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSystemGetInfo")]
    public unsafe partial struct SystemGetInfo
    {
        public SystemGetInfo
        (
            StructureType type = StructureType.TypeSystemGetInfo,
            void* next = default,
            FormFactor formFactor = default
        )
        {
            Type = type;
            Next = next;
            FormFactor = formFactor;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrFormFactor")]
        [NativeName("Type.Name", "XrFormFactor")]
        [NativeName("Name", "formFactor")]
        public FormFactor FormFactor;
    }
}
