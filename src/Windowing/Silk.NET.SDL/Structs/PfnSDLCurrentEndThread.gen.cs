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
    public unsafe readonly struct PfnSDLCurrentEndThread : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, void> Handle => (delegate* unmanaged[Cdecl]<uint, void>) _handle;
        public PfnSDLCurrentEndThread
        (
            delegate* unmanaged[Cdecl]<uint, void> ptr
        ) => _handle = ptr;

        public PfnSDLCurrentEndThread
        (
             SDLCurrentEndThread proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnSDLCurrentEndThread From(SDLCurrentEndThread proc) => new PfnSDLCurrentEndThread(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnSDLCurrentEndThread pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnSDLCurrentEndThread(IntPtr pfn)
            => new PfnSDLCurrentEndThread((delegate* unmanaged[Cdecl]<uint, void>) pfn);

        public static implicit operator PfnSDLCurrentEndThread(SDLCurrentEndThread proc)
            => new PfnSDLCurrentEndThread(proc);

        public static explicit operator SDLCurrentEndThread(PfnSDLCurrentEndThread pfn)
            => SilkMarshal.PtrToDelegate<SDLCurrentEndThread>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, void>(PfnSDLCurrentEndThread pfn) => pfn.Handle;
        public static implicit operator PfnSDLCurrentEndThread(delegate* unmanaged[Cdecl]<uint, void> ptr) => new PfnSDLCurrentEndThread(ptr);
    }

    public delegate void SDLCurrentEndThread(uint arg0);
}

