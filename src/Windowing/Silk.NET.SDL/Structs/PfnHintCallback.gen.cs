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

namespace Silk.NET.SDL
{
    public unsafe readonly struct PfnHintCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> Handle => (delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void>) _handle;
        public PfnHintCallback
        (
            delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> ptr
        ) => _handle = ptr;

        public PfnHintCallback
        (
             HintCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnHintCallback From(HintCallback proc) => new PfnHintCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnHintCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnHintCallback(nint pfn)
            => new PfnHintCallback((delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void>) pfn);

        public static implicit operator PfnHintCallback(HintCallback proc)
            => new PfnHintCallback(proc);

        public static explicit operator HintCallback(PfnHintCallback pfn)
            => SilkMarshal.PtrToDelegate<HintCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void>(PfnHintCallback pfn) => pfn.Handle;
        public static implicit operator PfnHintCallback(delegate* unmanaged[Cdecl]<void*, byte*, byte*, byte*, void> ptr) => new PfnHintCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void HintCallback(void* arg0, byte* arg1, byte* arg2, byte* arg3);
}

