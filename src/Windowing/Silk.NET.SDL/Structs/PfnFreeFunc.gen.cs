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

namespace Silk.NET.SDL
{
    public unsafe readonly struct PfnFreeFunc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void> Handle => (delegate* unmanaged[Cdecl]<void*, void>) _handle;
        public PfnFreeFunc
        (
            delegate* unmanaged[Cdecl]<void*, void> ptr
        ) => _handle = ptr;

        public PfnFreeFunc
        (
             FreeFunc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFreeFunc From(FreeFunc proc) => new PfnFreeFunc(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnFreeFunc pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnFreeFunc(IntPtr pfn)
            => new PfnFreeFunc((delegate* unmanaged[Cdecl]<void*, void>) pfn);

        public static implicit operator PfnFreeFunc(FreeFunc proc)
            => new PfnFreeFunc(proc);

        public static explicit operator FreeFunc(PfnFreeFunc pfn)
            => SilkMarshal.PtrToDelegate<FreeFunc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void>(PfnFreeFunc pfn) => pfn.Handle;
        public static implicit operator PfnFreeFunc(delegate* unmanaged[Cdecl]<void*, void> ptr) => new PfnFreeFunc(ptr);
    }

    public unsafe delegate void FreeFunc(void* arg0);
}

