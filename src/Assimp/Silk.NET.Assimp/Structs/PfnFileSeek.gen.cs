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
    public unsafe readonly struct PfnFileSeek : IDisposable
    {
        private readonly void* _handle;
        public delegate* unmanaged[Cdecl]<File*, uint, Origin, Return> Handle => (delegate* unmanaged[Cdecl]<File*, uint, Origin, Return>) _handle;
        public PfnFileSeek
        (
            delegate* unmanaged[Cdecl]<File*, uint, Origin, Return> ptr
        ) => _handle = ptr;

        public PfnFileSeek
        (
             FileSeek proc
        ) => _handle = (void*) SilkMarshal.DelegateToPtr(proc);

        public static PfnFileSeek From(FileSeek proc) => new PfnFileSeek(proc);
        public void Dispose() => SilkMarshal.Free((IntPtr) _handle);

        public static implicit operator IntPtr(PfnFileSeek pfn) => (IntPtr) pfn.Handle;
        public static explicit operator PfnFileSeek(IntPtr pfn)
            => new PfnFileSeek((delegate* unmanaged[Cdecl]<File*, uint, Origin, Return>) pfn);

        public static implicit operator PfnFileSeek(FileSeek proc)
            => new PfnFileSeek(proc);

        public static explicit operator FileSeek(PfnFileSeek pfn)
            => SilkMarshal.PtrToDelegate<FileSeek>(pfn);

        public static implicit operator delegate* unmanaged[Cdecl]<File*, uint, Origin, Return>(PfnFileSeek pfn) => pfn.Handle;
        public static implicit operator PfnFileSeek(delegate* unmanaged[Cdecl]<File*, uint, Origin, Return> ptr) => new PfnFileSeek(ptr);
    }

    public unsafe delegate Return FileSeek(File* arg0, uint arg1, Origin arg2);
}

