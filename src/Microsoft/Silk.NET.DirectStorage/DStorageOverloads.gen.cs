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

namespace Silk.NET.DirectStorage
{
    public static class DStorageOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 849, Column 9 in C:\\Users\\perks\\AppData\\Local\\Temp\\nmukg0we.mp0\\Include\\DirectStorage\\dstorage.h")]
        public static unsafe int SetConfiguration(this DStorage thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Configuration> configuration)
        {
            // SpanOverloader
            return thisApi.SetConfiguration(in configuration.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 859, Column 9 in C:\\Users\\perks\\AppData\\Local\\Temp\\nmukg0we.mp0\\Include\\DirectStorage\\dstorage.h")]
        public static unsafe int GetFactory(this DStorage thisApi, Span<Guid> riid, void** ppv)
        {
            // SpanOverloader
            return thisApi.GetFactory(ref riid.GetPinnableReference(), ppv);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 859, Column 9 in C:\\Users\\perks\\AppData\\Local\\Temp\\nmukg0we.mp0\\Include\\DirectStorage\\dstorage.h")]
        public static unsafe int GetFactory(this DStorage thisApi, Span<Guid> riid, ref void* ppv)
        {
            // SpanOverloader
            return thisApi.GetFactory(ref riid.GetPinnableReference(), ref ppv);
        }

    }
}

