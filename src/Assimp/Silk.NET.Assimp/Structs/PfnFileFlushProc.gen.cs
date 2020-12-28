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

namespace Silk.NET.Assimp
{
    public unsafe readonly struct PfnFileFlushProc : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<File*, void> Handle => (delegate* unmanaged[Cdecl]<File*, void>) _handle;
        public PfnFileFlushProc
        (
            delegate* unmanaged[Cdecl]<File*, void> ptr
        ) => _handle = ptr;

        public PfnFileFlushProc
        (
             FileFlushProc proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileFlushProc From(FileFlushProc proc) => new PfnFileFlushProc(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnFileFlushProc pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnFileFlushProc(IntPtr pfn)
            => new PfnFileFlushProc((delegate* unmanaged[Cdecl]<File*, void>) pfn);

        public static implicit operator PfnFileFlushProc(FileFlushProc proc)
            => new PfnFileFlushProc(proc);

        public static explicit operator FileFlushProc(PfnFileFlushProc pfn)
            => SilkMarshal.PtrToDelegate<FileFlushProc>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<File*, void>(PfnFileFlushProc pfn) => pfn.Handle;
        public static implicit operator PfnFileFlushProc(delegate* unmanaged[Cdecl]<File*, void> ptr) => new PfnFileFlushProc(ptr);
    }

    public unsafe delegate void FileFlushProc(File* arg0);
}

