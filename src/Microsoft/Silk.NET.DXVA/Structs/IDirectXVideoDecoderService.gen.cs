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

namespace Silk.NET.DXVA
{
    [Guid("fc51a551-d5e7-11d9-af55-00054e43ff02")]
    [NativeName("Name", "IDirectXVideoDecoderService")]
    public unsafe partial struct IDirectXVideoDecoderService
    {
        public static readonly Guid Guid = new("fc51a551-d5e7-11d9-af55-00054e43ff02");

        public static implicit operator IDirectXVideoAccelerationService(IDirectXVideoDecoderService val)
            => Unsafe.As<IDirectXVideoDecoderService, IDirectXVideoAccelerationService>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirectXVideoDecoderService val)
            => Unsafe.As<IDirectXVideoDecoderService, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirectXVideoDecoderService
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
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDirectXVideoDecoderService*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, void** pSharedHandle)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, Silk.NET.Direct3D9.IDirect3DSurface9** ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurface, pSharedHandlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, void** pSharedHandle)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(uint Width, uint Height, uint BackBuffers, Silk.NET.Direct3D9.Format Format, Silk.NET.Direct3D9.Pool Pool, uint Usage, uint DxvaType, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppSurface, ref void* pSharedHandle)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppSurfacePtr = &ppSurface)
            {
                fixed (void** pSharedHandlePtr = &pSharedHandle)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint, uint, uint, Silk.NET.Direct3D9.Format, Silk.NET.Direct3D9.Pool, uint, uint, Silk.NET.Direct3D9.IDirect3DSurface9**, void**, int>)LpVtbl[3])(@this, Width, Height, BackBuffers, Format, Pool, Usage, DxvaType, ppSurfacePtr, pSharedHandlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderDeviceGuids(uint* pCount, Guid** pGuids)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint*, Guid**, int>)LpVtbl[4])(@this, pCount, pGuids);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderDeviceGuids(uint* pCount, ref Guid* pGuids)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid** pGuidsPtr = &pGuids)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint*, Guid**, int>)LpVtbl[4])(@this, pCount, pGuidsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderDeviceGuids(ref uint pCount, Guid** pGuids)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint*, Guid**, int>)LpVtbl[4])(@this, pCountPtr, pGuids);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderDeviceGuids(ref uint pCount, ref Guid* pGuids)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Guid** pGuidsPtr = &pGuids)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, uint*, Guid**, int>)LpVtbl[4])(@this, pCountPtr, pGuidsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(Guid* Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, Guid, pCount, pFormats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(Guid* Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, Guid, pCount, pFormatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(Guid* Guid, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, Guid, pCountPtr, pFormats);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(Guid* Guid, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, Guid, pCountPtr, pFormatsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(ref Guid Guid, uint* pCount, Silk.NET.Direct3D9.Format** pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, GuidPtr, pCount, pFormats);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(ref Guid Guid, uint* pCount, ref Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, GuidPtr, pCount, pFormatsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(ref Guid Guid, ref uint pCount, Silk.NET.Direct3D9.Format** pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, GuidPtr, pCountPtr, pFormats);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderRenderTargets(ref Guid Guid, ref uint pCount, ref Silk.NET.Direct3D9.Format* pFormats)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (Silk.NET.Direct3D9.Format** pFormatsPtr = &pFormats)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, uint*, Silk.NET.Direct3D9.Format**, int>)LpVtbl[5])(@this, GuidPtr, pCountPtr, pFormatsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCount, ppConfigs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCount, ppConfigsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCountPtr, ppConfigs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReserved, pCountPtr, ppConfigsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pReservedPtr = &pReserved)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCount, ppConfigs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCount, ppConfigsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCountPtr, ppConfigs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pReservedPtr = &pReserved)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDesc, pReservedPtr, pCountPtr, ppConfigsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCount, ppConfigs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCount, ppConfigsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCountPtr, ppConfigs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReserved, pCountPtr, ppConfigsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCount, ppConfigs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCount, ppConfigsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, Guid, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCount, ppConfigs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCount, ppConfigsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCountPtr, ppConfigs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (uint* pCountPtr = &pCount)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReserved, pCountPtr, ppConfigsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCount, ppConfigs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCount, ppConfigsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCountPtr, ppConfigs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (void* pReservedPtr = &pReserved)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDesc, pReservedPtr, pCountPtr, ppConfigsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCount, ppConfigs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCount, ppConfigsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCountPtr, ppConfigs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, void* pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (uint* pCountPtr = &pCount)
                    {
                        fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReserved, pCountPtr, ppConfigsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (void* pReservedPtr = &pReserved)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCount, ppConfigs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, uint* pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (void* pReservedPtr = &pReserved)
                    {
                        fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCount, ppConfigsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, DXVA2ConfigPictureDecode** ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (void* pReservedPtr = &pReserved)
                    {
                        fixed (uint* pCountPtr = &pCount)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigs);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderConfigurations<T0>(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref T0 pReserved, ref uint pCount, ref DXVA2ConfigPictureDecode* ppConfigs) where T0 : unmanaged
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (void* pReservedPtr = &pReserved)
                    {
                        fixed (uint* pCountPtr = &pCount)
                        {
                            fixed (DXVA2ConfigPictureDecode** ppConfigsPtr = &ppConfigs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, void*, uint*, DXVA2ConfigPictureDecode**, int>)LpVtbl[6])(@this, GuidPtr, pVideoDescPtr, pReservedPtr, pCountPtr, ppConfigsPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(Guid* Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, Guid, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, DXVA2VideoDesc* pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDesc, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, DXVA2ConfigPictureDecode* pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                    {
                        fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfig, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecode);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargets, NumRenderTargets, ppDecodePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, IDirectXVideoDecoder** ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecode);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVideoDecoder(ref Guid Guid, ref DXVA2VideoDesc pVideoDesc, ref DXVA2ConfigPictureDecode pConfig, ref Silk.NET.Direct3D9.IDirect3DSurface9* ppDecoderRenderTargets, uint NumRenderTargets, ref IDirectXVideoDecoder* ppDecode)
        {
            var @this = (IDirectXVideoDecoderService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* GuidPtr = &Guid)
            {
                fixed (DXVA2VideoDesc* pVideoDescPtr = &pVideoDesc)
                {
                    fixed (DXVA2ConfigPictureDecode* pConfigPtr = &pConfig)
                    {
                        fixed (Silk.NET.Direct3D9.IDirect3DSurface9** ppDecoderRenderTargetsPtr = &ppDecoderRenderTargets)
                        {
                            fixed (IDirectXVideoDecoder** ppDecodePtr = &ppDecode)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDirectXVideoDecoderService*, Guid*, DXVA2VideoDesc*, DXVA2ConfigPictureDecode*, Silk.NET.Direct3D9.IDirect3DSurface9**, uint, IDirectXVideoDecoder**, int>)LpVtbl[7])(@this, GuidPtr, pVideoDescPtr, pConfigPtr, ppDecoderRenderTargetsPtr, NumRenderTargets, ppDecodePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

    }
}
