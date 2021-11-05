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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("5e13e843-9d25-473c-9ad2-03b2d0b44b1e")]
    [NativeName("Name", "IDxcVersionInfo3")]
    public unsafe partial struct IDxcVersionInfo3
    {
        public static readonly Guid Guid = new("5e13e843-9d25-473c-9ad2-03b2d0b44b1e");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcVersionInfo3 val)
            => Unsafe.As<IDxcVersionInfo3, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcVersionInfo3
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo3*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo3*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustomVersionString(byte** pVersionString)
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, byte**, int>)LpVtbl[3])(@this, pVersionString);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustomVersionString(ref byte* pVersionString)
        {
            var @this = (IDxcVersionInfo3*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** pVersionStringPtr = &pVersionString)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcVersionInfo3*, byte**, int>)LpVtbl[3])(@this, pVersionStringPtr);
            }
            return ret;
        }

    }
}
