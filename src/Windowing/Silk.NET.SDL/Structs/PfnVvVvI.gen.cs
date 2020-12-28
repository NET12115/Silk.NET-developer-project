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
    public unsafe readonly struct PfnVvVvI : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<void*, void*, int> Handle => (delegate* unmanaged[Cdecl]<void*, void*, int>) _handle;
        public PfnVvVvI
        (
            delegate* unmanaged[Cdecl]<void*, void*, int> ptr
        ) => _handle = ptr;

        public PfnVvVvI
        (
             VvVvIProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnVvVvI From(VvVvIProc proc) => new PfnVvVvI(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnVvVvI pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnVvVvI(IntPtr pfn)
            => new PfnVvVvI((delegate* unmanaged[Cdecl]<void*, void*, int>) pfn);

        public static implicit operator PfnVvVvI(VvVvIProc proc)
            => new PfnVvVvI(proc);

        public static explicit operator VvVvIProc(PfnVvVvI pfn)
            => SilkMarshal.PtrToDelegate<VvVvIProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<void*, void*, int>(PfnVvVvI pfn) => pfn.Handle;
        public static implicit operator PfnVvVvI(delegate* unmanaged[Cdecl]<void*, void*, int> ptr) => new PfnVvVvI(ptr);
    }

    public unsafe delegate int VvVvIProc(void* arg0, void* arg1);
}

