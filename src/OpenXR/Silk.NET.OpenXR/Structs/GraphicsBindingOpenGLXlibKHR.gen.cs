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
    [NativeName("Name", "XrGraphicsBindingOpenGLXlibKHR")]
    public unsafe partial struct GraphicsBindingOpenGLXlibKHR
    {
        public GraphicsBindingOpenGLXlibKHR
        (
            StructureType? type = StructureType.TypeGraphicsBindingOpenglXlibKhr,
            void* next = null,
            IntPtr* xDisplay = null,
            uint? visualid = null,
            IntPtr? glxFbconfig = null,
            IntPtr? glxDrawable = null,
            IntPtr? glxContext = null
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

            if (xDisplay is not null)
            {
                XDisplay = xDisplay;
            }

            if (visualid is not null)
            {
                Visualid = visualid.Value;
            }

            if (glxFbconfig is not null)
            {
                GlxFbconfig = glxFbconfig.Value;
            }

            if (glxDrawable is not null)
            {
                GlxDrawable = glxDrawable.Value;
            }

            if (glxContext is not null)
            {
                GlxContext = glxContext.Value;
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
        [NativeName("Type", "Display*")]
        [NativeName("Type.Name", "Display")]
        [NativeName("Name", "xDisplay")]
        public IntPtr* XDisplay;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "visualid")]
        public uint Visualid;
/// <summary></summary>
        [NativeName("Type", "GLXFBConfig")]
        [NativeName("Type.Name", "GLXFBConfig")]
        [NativeName("Name", "glxFBConfig")]
        public IntPtr GlxFbconfig;
/// <summary></summary>
        [NativeName("Type", "GLXDrawable")]
        [NativeName("Type.Name", "GLXDrawable")]
        [NativeName("Name", "glxDrawable")]
        public IntPtr GlxDrawable;
/// <summary></summary>
        [NativeName("Type", "GLXContext")]
        [NativeName("Type.Name", "GLXContext")]
        [NativeName("Name", "glxContext")]
        public IntPtr GlxContext;
    }
}
