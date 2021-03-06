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
    public unsafe readonly struct PfnTimerCallback : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<uint, void*, uint> Handle => (delegate* unmanaged[Cdecl]<uint, void*, uint>) _handle;
        public PfnTimerCallback
        (
            delegate* unmanaged[Cdecl]<uint, void*, uint> ptr
        ) => _handle = ptr;

        public PfnTimerCallback
        (
             TimerCallback proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnTimerCallback From(TimerCallback proc) => new PfnTimerCallback(proc);
        public void Dispose() => SilkMarshal.Free((nint) _handle);

        public static implicit operator nint(PfnTimerCallback pfn) => (nint) pfn.Handle;
        public static explicit operator PfnTimerCallback(nint pfn)
            => new PfnTimerCallback((delegate* unmanaged[Cdecl]<uint, void*, uint>) pfn);

        public static implicit operator PfnTimerCallback(TimerCallback proc)
            => new PfnTimerCallback(proc);

        public static explicit operator TimerCallback(PfnTimerCallback pfn)
            => SilkMarshal.PtrToDelegate<TimerCallback>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<uint, void*, uint>(PfnTimerCallback pfn) => pfn.Handle;
        public static implicit operator PfnTimerCallback(delegate* unmanaged[Cdecl]<uint, void*, uint> ptr) => new PfnTimerCallback(ptr);
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate uint TimerCallback(uint arg0, void* arg1);
}

