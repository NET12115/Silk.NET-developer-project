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

namespace Silk.NET.Direct3D9
{
    [Guid("187aeb13-aaf5-4c59-876d-e059088c0df8")]
    [NativeName("Name", "IDirect3D9ExOverlayExtension")]
    public unsafe partial struct IDirect3D9ExOverlayExtension
    {
        public static readonly Guid Guid = new("187aeb13-aaf5-4c59-876d-e059088c0df8");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3D9ExOverlayExtension val)
            => Unsafe.As<IDirect3D9ExOverlayExtension, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3D9ExOverlayExtension
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
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckDeviceOverlayType(uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, Displaymodeex* pDisplayMode, Displayrotation DisplayRotation, Overlaycaps* pOverlayCaps)
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckDeviceOverlayType(uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, Displaymodeex* pDisplayMode, Displayrotation DisplayRotation, ref Overlaycaps pOverlayCaps)
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Overlaycaps* pOverlayCapsPtr = &pOverlayCaps)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayMode, DisplayRotation, pOverlayCapsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckDeviceOverlayType(uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, ref Displaymodeex pDisplayMode, Displayrotation DisplayRotation, Overlaycaps* pOverlayCaps)
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pDisplayModePtr = &pDisplayMode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayModePtr, DisplayRotation, pOverlayCaps);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckDeviceOverlayType(uint Adapter, Devtype DevType, uint OverlayWidth, uint OverlayHeight, Format OverlayFormat, ref Displaymodeex pDisplayMode, Displayrotation DisplayRotation, ref Overlaycaps pOverlayCaps)
        {
            var @this = (IDirect3D9ExOverlayExtension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Displaymodeex* pDisplayModePtr = &pDisplayMode)
            {
                fixed (Overlaycaps* pOverlayCapsPtr = &pOverlayCaps)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3D9ExOverlayExtension*, uint, Devtype, uint, uint, Format, Displaymodeex*, Displayrotation, Overlaycaps*, int>)LpVtbl[3])(@this, Adapter, DevType, OverlayWidth, OverlayHeight, OverlayFormat, pDisplayModePtr, DisplayRotation, pOverlayCapsPtr);
                }
            }
            return ret;
        }

    }
}
