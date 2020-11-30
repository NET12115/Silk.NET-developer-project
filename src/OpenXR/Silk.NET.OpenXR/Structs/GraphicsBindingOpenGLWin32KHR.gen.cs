// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsBindingOpenGLWin32KHR")]
    public unsafe partial struct GraphicsBindingOpenGLWin32KHR
    {
        public GraphicsBindingOpenGLWin32KHR
        (
            StructureType? type = StructureType.TypeGraphicsBindingOpenglWin32Khr,
            void* next = null,
            IntPtr? hDC = null,
            IntPtr? hGlrc = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (hDC is not null)
            {
                HDC = hDC.Value;
            }

            if (hGlrc is not null)
            {
                HGlrc = hGlrc.Value;
            }
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
        [NativeName("Type", "HDC")]
        [NativeName("Type.Name", "HDC")]
        [NativeName("Name", "hDC")]
        public IntPtr HDC;
/// <summary></summary>
        [NativeName("Type", "HGLRC")]
        [NativeName("Type.Name", "HGLRC")]
        [NativeName("Name", "hGLRC")]
        public IntPtr HGlrc;
    }
}
