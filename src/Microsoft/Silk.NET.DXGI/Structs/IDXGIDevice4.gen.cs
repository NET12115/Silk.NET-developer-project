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

namespace Silk.NET.DXGI
{
    [Guid("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10")]
    [NativeName("Name", "IDXGIDevice4")]
    public unsafe partial struct IDXGIDevice4
    {
        public static readonly Guid Guid = new("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10");

        public static implicit operator IDXGIDevice3(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIDevice3>(ref val);

        public static implicit operator IDXGIDevice2(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIDevice2>(ref val);

        public static implicit operator IDXGIDevice1(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIDevice1>(ref val);

        public static implicit operator IDXGIDevice(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIDevice>(ref val);

        public static implicit operator IDXGIObject(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIDevice4 val)
            => Unsafe.As<IDXGIDevice4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIDevice4
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
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapter(Silk.NET.DXGI.IDXGIAdapter** pAdapter)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[7])(@this, pAdapter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAdapter(ref Silk.NET.DXGI.IDXGIAdapter* pAdapter)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGIAdapter** pAdapterPtr = &pAdapter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Silk.NET.DXGI.IDXGIAdapter**, int>)LpVtbl[7])(@this, pAdapterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(SurfaceDesc* pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
            {
                fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDesc, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, SharedResource* pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResource, ppSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, IDXGISurface** ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurface);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSurface(ref SurfaceDesc pDesc, uint NumSurfaces, uint Usage, ref SharedResource pSharedResource, ref IDXGISurface* ppSurface)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SurfaceDesc* pDescPtr = &pDesc)
            {
                fixed (SharedResource* pSharedResourcePtr = &pSharedResource)
                {
                    fixed (IDXGISurface** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, SurfaceDesc*, uint, uint, SharedResource*, IDXGISurface**, int>)LpVtbl[8])(@this, pDescPtr, NumSurfaces, Usage, pSharedResourcePtr, ppSurfacePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(Silk.NET.Core.Native.IUnknown** ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResources, pResidencyStatus, NumResources);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(Silk.NET.Core.Native.IUnknown** ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResources, pResidencyStatusPtr, NumResources);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(ref Silk.NET.Core.Native.IUnknown* ppResources, Residency* pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatus, NumResources);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryResourceResidency(ref Silk.NET.Core.Native.IUnknown* ppResources, ref Residency pResidencyStatus, uint NumResources)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown** ppResourcesPtr = &ppResources)
            {
                fixed (Residency* pResidencyStatusPtr = &pResidencyStatus)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, Silk.NET.Core.Native.IUnknown**, Residency*, uint, int>)LpVtbl[9])(@this, ppResourcesPtr, pResidencyStatusPtr, NumResources);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGPUThreadPriority(int Priority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, int, int>)LpVtbl[10])(@this, Priority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGPUThreadPriority(int* pPriority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, int*, int>)LpVtbl[11])(@this, pPriority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGPUThreadPriority(ref int pPriority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pPriorityPtr = &pPriority)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, int*, int>)LpVtbl[11])(@this, pPriorityPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaximumFrameLatency(uint MaxLatency)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, int>)LpVtbl[12])(@this, MaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint*, int>)LpVtbl[13])(@this, pMaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxLatencyPtr = &pMaxLatency)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint*, int>)LpVtbl[13])(@this, pMaxLatencyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, int>)LpVtbl[14])(@this, NumResources, ppResources, Priority);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources(uint NumResources, ref IDXGIResource* ppResources, OfferResourcePriority Priority)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, int>)LpVtbl[14])(@this, NumResources, ppResourcesPtr, Priority);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, IDXGIResource** ppResources, int* pDiscarded)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResources, pDiscarded);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, IDXGIResource** ppResources, ref int pDiscarded)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pDiscardedPtr = &pDiscarded)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResources, pDiscardedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, ref IDXGIResource* ppResources, int* pDiscarded)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscarded);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources(uint NumResources, ref IDXGIResource* ppResources, ref int pDiscarded)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                fixed (int* pDiscardedPtr = &pDiscarded)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, int*, int>)LpVtbl[15])(@this, NumResources, ppResourcesPtr, pDiscardedPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnqueueSetEvent(void* hEvent)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, void*, int>)LpVtbl[16])(@this, hEvent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnqueueSetEvent<T0>(ref T0 hEvent) where T0 : unmanaged
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hEventPtr = &hEvent)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, void*, int>)LpVtbl[16])(@this, hEventPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Trim()
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIDevice4*, void>)LpVtbl[17])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources1(uint NumResources, IDXGIResource** ppResources, OfferResourcePriority Priority, uint Flags)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, uint, int>)LpVtbl[18])(@this, NumResources, ppResources, Priority, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OfferResources1(uint NumResources, ref IDXGIResource* ppResources, OfferResourcePriority Priority, uint Flags)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, OfferResourcePriority, uint, int>)LpVtbl[18])(@this, NumResources, ppResourcesPtr, Priority, Flags);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources1(uint NumResources, IDXGIResource** ppResources, ReclaimResourceResults* pResults)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)LpVtbl[19])(@this, NumResources, ppResources, pResults);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources1(uint NumResources, IDXGIResource** ppResources, ref ReclaimResourceResults pResults)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ReclaimResourceResults* pResultsPtr = &pResults)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)LpVtbl[19])(@this, NumResources, ppResources, pResultsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources1(uint NumResources, ref IDXGIResource* ppResources, ReclaimResourceResults* pResults)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)LpVtbl[19])(@this, NumResources, ppResourcesPtr, pResults);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReclaimResources1(uint NumResources, ref IDXGIResource* ppResources, ref ReclaimResourceResults pResults)
        {
            var @this = (IDXGIDevice4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppResourcesPtr = &ppResources)
            {
                fixed (ReclaimResourceResults* pResultsPtr = &pResults)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIDevice4*, uint, IDXGIResource**, ReclaimResourceResults*, int>)LpVtbl[19])(@this, NumResources, ppResourcesPtr, pResultsPtr);
                }
            }
            return ret;
        }

    }
}
