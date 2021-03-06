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
    public unsafe readonly struct PfnReallocFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, nuint, void*> Handle => (delegate* unmanaged[Cdecl]<void*, nuint, void*>) _handle;
        public PfnReallocFunc
        (
            delegate* unmanaged[Cdecl]<void*, nuint, void*> ptr
        ) => _handle = ptr;

        public PfnReallocFunc
        (
             ReallocFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnReallocFunc From(ReallocFunc proc) => new PfnReallocFunc(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnReallocFunc pfn) => (nint) pfn.Handle;
        public static explicit operator PfnReallocFunc(nint pfn)
            => new PfnReallocFunc((delegate* unmanaged[Cdecl]<void*, nuint, void*>) pfn);

        public static implicit operator PfnReallocFunc(ReallocFunc proc)
            => new PfnReallocFunc(proc);

        public static explicit operator ReallocFunc(PfnReallocFunc pfn)
            => SilkMarshal.PtrToDelegate<ReallocFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, nuint, void*>(PfnReallocFunc pfn) => pfn.Handle;
        public static implicit operator PfnReallocFunc(delegate* unmanaged[Cdecl]<void*, nuint, void*> ptr) => new PfnReallocFunc(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* ReallocFunc(void* arg0, nuint arg1);
}

