// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


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

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_CREATEFILE2_EXTENDED_PARAMETERS")]
    public unsafe partial struct Createfile2ExtendedParameters
    {
        public Createfile2ExtendedParameters
        (
            uint? dwSize = null,
            uint? dwFileAttributes = null,
            uint? dwFileFlags = null,
            uint? dwSecurityQosFlags = null,
            Silk.NET.Core.Native.SecurityAttributes* lpSecurityAttributes = null,
            void* hTemplateFile = null
        ) : this()
        {
            if (dwSize is not null)
            {
                DwSize = dwSize.Value;
            }

            if (dwFileAttributes is not null)
            {
                DwFileAttributes = dwFileAttributes.Value;
            }

            if (dwFileFlags is not null)
            {
                DwFileFlags = dwFileFlags.Value;
            }

            if (dwSecurityQosFlags is not null)
            {
                DwSecurityQosFlags = dwSecurityQosFlags.Value;
            }

            if (lpSecurityAttributes is not null)
            {
                LpSecurityAttributes = lpSecurityAttributes;
            }

            if (hTemplateFile is not null)
            {
                HTemplateFile = hTemplateFile;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwSize")]
        public uint DwSize;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwFileAttributes")]
        public uint DwFileAttributes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwFileFlags")]
        public uint DwFileFlags;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwSecurityQosFlags")]
        public uint DwSecurityQosFlags;

        [NativeName("Type", "LPSECURITY_ATTRIBUTES")]
        [NativeName("Type.Name", "LPSECURITY_ATTRIBUTES")]
        [NativeName("Name", "lpSecurityAttributes")]
        public Silk.NET.Core.Native.SecurityAttributes* LpSecurityAttributes;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hTemplateFile")]
        public void* HTemplateFile;
    }
}
