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

namespace Silk.NET.Direct3D11
{
    [Guid("bb2c6faa-b5fb-4082-8e6b-388b8cfa90e1")]
    [NativeName("Name", "ID3D11DeviceContext1")]
    public unsafe partial struct ID3D11DeviceContext1
    {
        public static readonly Guid Guid = new("bb2c6faa-b5fb-4082-8e6b-388b8cfa90e1");

        public static implicit operator ID3D11DeviceContext(ID3D11DeviceContext1 val)
            => Unsafe.As<ID3D11DeviceContext1, ID3D11DeviceContext>(ref val);

        public static implicit operator ID3D11DeviceChild(ID3D11DeviceContext1 val)
            => Unsafe.As<ID3D11DeviceContext1, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11DeviceContext1 val)
            => Unsafe.As<ID3D11DeviceContext1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11DeviceContext1
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
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[7])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[8])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ID3D11PixelShader* pPixelShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstances, NumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ID3D11PixelShader* pPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstancesPtr, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstancesPtr, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShader, ppClassInstancesPtr, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ref ID3D11PixelShader pPixelShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstances, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstances, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstances, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetShader(ref ID3D11PixelShader pPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader* pPixelShaderPtr = &pPixelShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstancesPtr, NumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[9])(@this, pPixelShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[10])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ID3D11VertexShader* pVertexShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstances, NumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ID3D11VertexShader* pVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstancesPtr, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstancesPtr, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShader, ppClassInstancesPtr, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ref ID3D11VertexShader pVertexShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstances, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstances, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstances, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShader(ref ID3D11VertexShader pVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader* pVertexShaderPtr = &pVertexShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstancesPtr, NumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[11])(@this, pVertexShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexed(uint IndexCount, uint StartIndexLocation, int BaseVertexLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, int, void>)LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, int, void>)LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, int, void>)LpVtbl[12])(@this, IndexCount, StartIndexLocation, BaseVertexLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void Draw(uint VertexCount, uint StartVertexLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, void>)LpVtbl[13])(@this, VertexCount, StartVertexLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, void>)LpVtbl[13])(@this, VertexCount, StartVertexLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, void>)LpVtbl[13])(@this, VertexCount, StartVertexLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResource);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(ID3D11Resource* pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResourcePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResource, Subresource, MapType, MapFlags, pMappedResourcePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Map(ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, MappedSubresource* pMappedResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResource);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResource);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResource);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Map(ref ID3D11Resource pResource, uint Subresource, Map MapType, uint MapFlags, ref MappedSubresource pMappedResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
                fixed (MappedSubresource* pMappedResourcePtr = &pMappedResource)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResourcePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResourcePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Map, uint, MappedSubresource*, int>)LpVtbl[14])(@this, pResourcePtr, Subresource, MapType, MapFlags, pMappedResourcePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Unmap(ID3D11Resource* pResource, uint Subresource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResource, Subresource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResource, Subresource);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResource, Subresource);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void Unmap(ref ID3D11Resource pResource, uint Subresource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResourcePtr, Subresource);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResourcePtr, Subresource);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, void>)LpVtbl[15])(@this, pResourcePtr, Subresource);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[16])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetInputLayout(ID3D11InputLayout* pInputLayout)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayout);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayout);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayout);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetInputLayout(ref ID3D11InputLayout pInputLayout)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11InputLayout* pInputLayoutPtr = &pInputLayout)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayoutPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayoutPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11InputLayout*, void>)LpVtbl[17])(@this, pInputLayoutPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[18])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetIndexBuffer(ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBuffer, Format, Offset);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetIndexBuffer(ref ID3D11Buffer pIndexBuffer, Silk.NET.DXGI.Format Format, uint Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pIndexBufferPtr = &pIndexBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBufferPtr, Format, Offset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBufferPtr, Format, Offset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, Silk.NET.DXGI.Format, uint, void>)LpVtbl[19])(@this, pIndexBufferPtr, Format, Offset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, uint, int, uint, void>)LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, int, uint, void>)LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, uint, int, uint, void>)LpVtbl[20])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, uint, uint, void>)LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, uint, void>)LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, uint, uint, void>)LpVtbl[21])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[22])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ID3D11GeometryShader* pShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstances, NumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ID3D11GeometryShader* pShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstancesPtr, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstancesPtr, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShader, ppClassInstancesPtr, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ref ID3D11GeometryShader pShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstances, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstances, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstances, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShader(ref ID3D11GeometryShader pShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader* pShaderPtr = &pShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstancesPtr, NumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[23])(@this, pShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology Topology)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)LpVtbl[24])(@this, Topology);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)LpVtbl[24])(@this, Topology);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)LpVtbl[24])(@this, Topology);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[25])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[26])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Begin(ID3D11Asynchronous* pAsync)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsync);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsync);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsync);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void Begin(ref ID3D11Asynchronous pAsync)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsyncPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsyncPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[27])(@this, pAsyncPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void End(ID3D11Asynchronous* pAsync)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsync);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsync);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsync);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void End(ref ID3D11Asynchronous pAsync)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsyncPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsyncPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void>)LpVtbl[28])(@this, pAsyncPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(ID3D11Asynchronous* pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pData, DataSize, GetDataFlags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData<T0>(ID3D11Asynchronous* pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pDataPtr, DataSize, GetDataFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pDataPtr, DataSize, GetDataFlags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsync, pDataPtr, DataSize, GetDataFlags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetData(ref ID3D11Asynchronous pAsync, void* pData, uint DataSize, uint GetDataFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pData, DataSize, GetDataFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pData, DataSize, GetDataFlags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pData, DataSize, GetDataFlags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetData<T0>(ref ID3D11Asynchronous pAsync, ref T0 pData, uint DataSize, uint GetDataFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Asynchronous* pAsyncPtr = &pAsync)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pDataPtr, DataSize, GetDataFlags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pDataPtr, DataSize, GetDataFlags);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Asynchronous*, void*, uint, uint, int>)LpVtbl[29])(@this, pAsyncPtr, pDataPtr, DataSize, GetDataFlags);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D11Predicate* pPredicate, int PredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicate, PredicateValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicate, PredicateValue);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicate, PredicateValue);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D11Predicate pPredicate, int PredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Predicate* pPredicatePtr = &pPredicate)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicatePtr, PredicateValue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicatePtr, PredicateValue);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Predicate*, int, void>)LpVtbl[30])(@this, pPredicatePtr, PredicateValue);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[31])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[32])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilView);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilViewPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilViewPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViews, pDepthStencilViewPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilView);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilView);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilView);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilViewPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilViewPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, void>)LpVtbl[33])(@this, NumViews, ppRenderTargetViewsPtr, pDepthStencilViewPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViews, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView* pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView pDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
                        fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[34])(@this, NumRTVs, ppRenderTargetViewsPtr, pDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState(ID3D11BlendState* pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactor, SampleMask);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState(ID3D11BlendState* pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactorPtr, SampleMask);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactorPtr, SampleMask);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendState, BlendFactorPtr, SampleMask);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendState(ref ID3D11BlendState pBlendState, [Count(Count = 4)] float* BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactor, SampleMask);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactor, SampleMask);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactor, SampleMask);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetBlendState(ref ID3D11BlendState pBlendState, [Count(Count = 4)] ref float BlendFactor, uint SampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState* pBlendStatePtr = &pBlendState)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactorPtr, SampleMask);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactorPtr, SampleMask);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState*, float*, uint, void>)LpVtbl[35])(@this, pBlendStatePtr, BlendFactorPtr, SampleMask);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetDepthStencilState(ID3D11DepthStencilState* pDepthStencilState, uint StencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilState, StencilRef);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilState, StencilRef);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilState, StencilRef);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetDepthStencilState(ref ID3D11DepthStencilState pDepthStencilState, uint StencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilState* pDepthStencilStatePtr = &pDepthStencilState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilStatePtr, StencilRef);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilStatePtr, StencilRef);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilState*, uint, void>)LpVtbl[36])(@this, pDepthStencilStatePtr, StencilRef);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsets);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsetsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsetsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargets, pOffsetsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, ref ID3D11Buffer* ppSOTargets, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsets);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsets);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsets);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint NumBuffers, ref ID3D11Buffer* ppSOTargets, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsetsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsetsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, uint*, void>)LpVtbl[37])(@this, NumBuffers, ppSOTargetsPtr, pOffsetsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawAuto()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)LpVtbl[38])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawIndexedInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstancedIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[39])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInstancedIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstancedIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[40])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, uint, void>)LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, uint, void>)LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, uint, void>)LpVtbl[41])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DispatchIndirect(ID3D11Buffer* pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgs, AlignedByteOffsetForArgs);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void DispatchIndirect(ref ID3D11Buffer pBufferForArgs, uint AlignedByteOffsetForArgs)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pBufferForArgsPtr = &pBufferForArgs)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, void>)LpVtbl[42])(@this, pBufferForArgsPtr, AlignedByteOffsetForArgs);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetState(ID3D11RasterizerState* pRasterizerState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerState);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerState);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerState);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetState(ref ID3D11RasterizerState pRasterizerState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RasterizerState* pRasterizerStatePtr = &pRasterizerState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerStatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerStatePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RasterizerState*, void>)LpVtbl[43])(@this, pRasterizerStatePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetViewports(uint NumViewports, Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewports);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewports);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewports);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetViewports(uint NumViewports, ref Viewport pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewportsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewportsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, Viewport*, void>)LpVtbl[44])(@this, NumViewports, pViewportsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetScissorRects(uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[45])(@this, NumRects, pRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[45])(@this, NumRects, pRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[45])(@this, NumRects, pRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetScissorRects(uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[45])(@this, NumRects, pRectsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[45])(@this, NumRects, pRectsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[45])(@this, NumRects, pRectsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, void>)LpVtbl[46])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D11Resource* pDstResource, ID3D11Resource* pSrcResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResource);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResource);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D11Resource* pDstResource, ref ID3D11Resource pSrcResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResourcePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResource, pSrcResourcePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ref ID3D11Resource pDstResource, ID3D11Resource* pSrcResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResource);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResource);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResource);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource(ref ID3D11Resource pDstResource, ref ID3D11Resource pSrcResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResourcePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResourcePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, ID3D11Resource*, void>)LpVtbl[47])(@this, pDstResourcePtr, pSrcResourcePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<T0>(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<T0>(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateSubresource<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    fixed (void* pSrcDataPtr = &pSrcData)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, void>)LpVtbl[48])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcView);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyStructureCount(ID3D11Buffer* pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcViewPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcViewPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBuffer, DstAlignedByteOffset, pSrcViewPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyStructureCount(ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ID3D11UnorderedAccessView* pSrcView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcView);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcView);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcView);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyStructureCount(ref ID3D11Buffer pDstBuffer, uint DstAlignedByteOffset, ref ID3D11UnorderedAccessView pSrcView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D11UnorderedAccessView* pSrcViewPtr = &pSrcView)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcViewPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcViewPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer*, uint, ID3D11UnorderedAccessView*, void>)LpVtbl[49])(@this, pDstBufferPtr, DstAlignedByteOffset, pSrcViewPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBA);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(ID3D11RenderTargetView* pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBAPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBAPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetView, ColorRGBAPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] float* ColorRGBA)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBA);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBA);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBA);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRenderTargetView(ref ID3D11RenderTargetView pRenderTargetView, [Count(Count = 4)] ref float ColorRGBA)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView* pRenderTargetViewPtr = &pRenderTargetView)
            {
                fixed (float* ColorRGBAPtr = &ColorRGBA)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBAPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBAPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RenderTargetView*, float*, void>)LpVtbl[50])(@this, pRenderTargetViewPtr, ColorRGBAPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] uint* Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, Values);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, Values);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, Values);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* ValuesPtr = &Values)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, ValuesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, ValuesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessView, ValuesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] uint* Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, Values);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, Values);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, Values);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewUint(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref uint Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
                fixed (uint* ValuesPtr = &Values)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, ValuesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, uint*, void>)LpVtbl[51])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] float* Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, Values);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, Values);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, Values);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(ID3D11UnorderedAccessView* pUnorderedAccessView, [Count(Count = 4)] ref float Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ValuesPtr = &Values)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, ValuesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, ValuesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessView, ValuesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] float* Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, Values);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, Values);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, Values);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewFloat(ref ID3D11UnorderedAccessView pUnorderedAccessView, [Count(Count = 4)] ref float Values)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView* pUnorderedAccessViewPtr = &pUnorderedAccessView)
            {
                fixed (float* ValuesPtr = &Values)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, ValuesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11UnorderedAccessView*, float*, void>)LpVtbl[52])(@this, pUnorderedAccessViewPtr, ValuesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearDepthStencilView(ID3D11DepthStencilView* pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilView, ClearFlags, Depth, Stencil);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearDepthStencilView(ref ID3D11DepthStencilView pDepthStencilView, uint ClearFlags, float Depth, byte Stencil)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView* pDepthStencilViewPtr = &pDepthStencilView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilViewPtr, ClearFlags, Depth, Stencil);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilViewPtr, ClearFlags, Depth, Stencil);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilView*, uint, float, byte, void>)LpVtbl[53])(@this, pDepthStencilViewPtr, ClearFlags, Depth, Stencil);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GenerateMips(ID3D11ShaderResourceView* pShaderResourceView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceView);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceView);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceView);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GenerateMips(ref ID3D11ShaderResourceView pShaderResourceView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView* pShaderResourceViewPtr = &pShaderResourceView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceViewPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceViewPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ShaderResourceView*, void>)LpVtbl[54])(@this, pShaderResourceViewPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetResourceMinLOD(ID3D11Resource* pResource, float MinLOD)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResource, MinLOD);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResource, MinLOD);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResource, MinLOD);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetResourceMinLOD(ref ID3D11Resource pResource, float MinLOD)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResourcePtr, MinLOD);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResourcePtr, MinLOD);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, float, void>)LpVtbl[55])(@this, pResourcePtr, MinLOD);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe float GetResourceMinLOD(ID3D11Resource* pResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResource);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResource);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly float GetResourceMinLOD(ref ID3D11Resource pResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            float ret = default;
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResourcePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, float>)LpVtbl[56])(@this, pResourcePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D11Resource* pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ID3D11Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource(ref ID3D11Resource pDstResource, uint DstSubresource, ref ID3D11Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, ID3D11Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[57])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteCommandList(ID3D11CommandList* pCommandList, int RestoreContextState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandList, RestoreContextState);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandList, RestoreContextState);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandList, RestoreContextState);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteCommandList(ref ID3D11CommandList pCommandList, int RestoreContextState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CommandList* pCommandListPtr = &pCommandList)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandListPtr, RestoreContextState);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandListPtr, RestoreContextState);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11CommandList*, int, void>)LpVtbl[58])(@this, pCommandListPtr, RestoreContextState);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[59])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ID3D11HullShader* pHullShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstances, NumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ID3D11HullShader* pHullShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstancesPtr, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstancesPtr, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShader, ppClassInstancesPtr, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ref ID3D11HullShader pHullShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstances, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstances, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstances, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetShader(ref ID3D11HullShader pHullShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader* pHullShaderPtr = &pHullShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstancesPtr, NumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[60])(@this, pHullShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[61])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[62])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[63])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ID3D11DomainShader* pDomainShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstances, NumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ID3D11DomainShader* pDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstancesPtr, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstancesPtr, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShader, ppClassInstancesPtr, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ref ID3D11DomainShader pDomainShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstances, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstances, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstances, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetShader(ref ID3D11DomainShader pDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader* pDomainShaderPtr = &pDomainShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstancesPtr, NumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[64])(@this, pDomainShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[65])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[66])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[67])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCounts);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews, pUAVInitialCountsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, uint* pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCounts);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews, ref uint pUAVInitialCounts)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
                fixed (uint* pUAVInitialCountsPtr = &pUAVInitialCounts)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, uint*, void>)LpVtbl[68])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr, pUAVInitialCountsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ID3D11ComputeShader* pComputeShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstances, NumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ID3D11ComputeShader* pComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstancesPtr, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstancesPtr, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShader, ppClassInstancesPtr, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ref ID3D11ComputeShader pComputeShader, ID3D11ClassInstance** ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstances, NumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstances, NumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstances, NumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetShader(ref ID3D11ComputeShader pComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint NumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader* pComputeShaderPtr = &pComputeShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstancesPtr, NumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader*, ID3D11ClassInstance**, uint, void>)LpVtbl[69])(@this, pComputeShaderPtr, ppClassInstancesPtr, NumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[70])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[71])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[72])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[73])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstancesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstancesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstances, pNumClassInstancesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ID3D11PixelShader** ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetShader(ref ID3D11PixelShader* ppPixelShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11PixelShader** ppPixelShaderPtr = &ppPixelShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11PixelShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[74])(@this, ppPixelShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[75])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstancesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstancesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstances, pNumClassInstancesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ID3D11VertexShader** ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShader(ref ID3D11VertexShader* ppVertexShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VertexShader** ppVertexShaderPtr = &ppVertexShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11VertexShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[76])(@this, ppVertexShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[77])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetInputLayout(ID3D11InputLayout** ppInputLayout)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayout);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayout);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayout);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetInputLayout(ref ID3D11InputLayout* ppInputLayout)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11InputLayout** ppInputLayoutPtr = &ppInputLayout)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayoutPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayoutPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11InputLayout**, void>)LpVtbl[78])(@this, ppInputLayoutPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsets);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pOffsetsPtr = &pOffsets)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStrides, pOffsetsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsets);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStridesPtr = &pStrides)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffers, pStridesPtr, pOffsetsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsets);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, uint* pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pOffsetsPtr = &pOffsets)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStrides, pOffsetsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, uint* pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsets);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetVertexBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppVertexBuffers, ref uint pStrides, ref uint pOffsets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppVertexBuffersPtr = &ppVertexBuffers)
            {
                fixed (uint* pStridesPtr = &pStrides)
                {
                    fixed (uint* pOffsetsPtr = &pOffsets)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[79])(@this, StartSlot, NumBuffers, ppVertexBuffersPtr, pStridesPtr, pOffsetsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, Offset);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* OffsetPtr = &Offset)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, OffsetPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, OffsetPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, Format, OffsetPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, Offset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, Offset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, Offset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ID3D11Buffer** pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
            {
                fixed (uint* OffsetPtr = &Offset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, OffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, OffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBuffer, FormatPtr, OffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, Offset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, Offset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, Offset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, Silk.NET.DXGI.Format* Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
                fixed (uint* OffsetPtr = &Offset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, OffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, OffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, Format, OffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, uint* Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
                fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, Offset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, Offset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, Offset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetIndexBuffer(ref ID3D11Buffer* pIndexBuffer, ref Silk.NET.DXGI.Format Format, ref uint Offset)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** pIndexBufferPtr = &pIndexBuffer)
            {
                fixed (Silk.NET.DXGI.Format* FormatPtr = &Format)
                {
                    fixed (uint* OffsetPtr = &Offset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, OffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, OffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Buffer**, Silk.NET.DXGI.Format*, uint*, void>)LpVtbl[80])(@this, pIndexBufferPtr, FormatPtr, OffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[81])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstancesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstancesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstances, pNumClassInstancesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ID3D11GeometryShader** ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShader(ref ID3D11GeometryShader* ppGeometryShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11GeometryShader** ppGeometryShaderPtr = &ppGeometryShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11GeometryShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[82])(@this, ppGeometryShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IAGetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology* pTopology)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopology);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopology);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopology);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void IAGetPrimitiveTopology(ref Silk.NET.Core.Native.D3DPrimitiveTopology pTopology)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Core.Native.D3DPrimitiveTopology* pTopologyPtr = &pTopology)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopologyPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopologyPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, Silk.NET.Core.Native.D3DPrimitiveTopology*, void>)LpVtbl[83])(@this, pTopologyPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[84])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[85])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ID3D11Predicate** ppPredicate, int* pPredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValue);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValue);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ID3D11Predicate** ppPredicate, ref int pPredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pPredicateValuePtr = &pPredicateValue)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValuePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicate, pPredicateValuePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ref ID3D11Predicate* ppPredicate, int* pPredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValue);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValue);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetPredication(ref ID3D11Predicate* ppPredicate, ref int pPredicateValue)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Predicate** ppPredicatePtr = &ppPredicate)
            {
                fixed (int* pPredicateValuePtr = &pPredicateValue)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValuePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Predicate**, int*, void>)LpVtbl[86])(@this, ppPredicatePtr, pPredicateValuePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[87])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[88])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilView);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilViewPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilViewPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViews, ppDepthStencilViewPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilView);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilView);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilView);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargets(uint NumViews, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilViewPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilViewPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, void>)LpVtbl[89])(@this, NumViews, ppRenderTargetViewsPtr, ppDepthStencilViewPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ID3D11RenderTargetView** ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViews, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ID3D11DepthStencilView** ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilView, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViews);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetRenderTargetsAndUnorderedAccessViews(uint NumRTVs, ref ID3D11RenderTargetView* ppRenderTargetViews, ref ID3D11DepthStencilView* ppDepthStencilView, uint UAVStartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RenderTargetView** ppRenderTargetViewsPtr = &ppRenderTargetViews)
            {
                fixed (ID3D11DepthStencilView** ppDepthStencilViewPtr = &ppDepthStencilView)
                {
                    fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11RenderTargetView**, ID3D11DepthStencilView**, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[90])(@this, NumRTVs, ppRenderTargetViewsPtr, ppDepthStencilViewPtr, UAVStartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMask);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pSampleMaskPtr = &pSampleMask)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMaskPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMaskPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactor, pSampleMaskPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMask);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMask);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMask);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ID3D11BlendState** ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
                fixed (uint* pSampleMaskPtr = &pSampleMask)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMaskPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMaskPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendState, BlendFactorPtr, pSampleMaskPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMask);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMask);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMask);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] float* BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
                fixed (uint* pSampleMaskPtr = &pSampleMask)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMaskPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMaskPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactor, pSampleMaskPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, uint* pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMask);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMask);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMask);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetBlendState(ref ID3D11BlendState* ppBlendState, [Count(Count = 4)] ref float BlendFactor, ref uint pSampleMask)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11BlendState** ppBlendStatePtr = &ppBlendState)
            {
                fixed (float* BlendFactorPtr = &BlendFactor)
                {
                    fixed (uint* pSampleMaskPtr = &pSampleMask)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMaskPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMaskPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11BlendState**, float*, uint*, void>)LpVtbl[91])(@this, ppBlendStatePtr, BlendFactorPtr, pSampleMaskPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, uint* pStencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRef);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ID3D11DepthStencilState** ppDepthStencilState, ref uint pStencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStencilRefPtr = &pStencilRef)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRefPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRefPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilState, pStencilRefPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ref ID3D11DepthStencilState* ppDepthStencilState, uint* pStencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRef);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRef);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRef);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMGetDepthStencilState(ref ID3D11DepthStencilState* ppDepthStencilState, ref uint pStencilRef)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DepthStencilState** ppDepthStencilStatePtr = &ppDepthStencilState)
            {
                fixed (uint* pStencilRefPtr = &pStencilRef)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRefPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRefPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DepthStencilState**, uint*, void>)LpVtbl[92])(@this, ppDepthStencilStatePtr, pStencilRefPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOGetTargets(uint NumBuffers, ID3D11Buffer** ppSOTargets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargets);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargets);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargets);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOGetTargets(uint NumBuffers, ref ID3D11Buffer* ppSOTargets)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppSOTargetsPtr = &ppSOTargets)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargetsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargetsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, ID3D11Buffer**, void>)LpVtbl[93])(@this, NumBuffers, ppSOTargetsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetState(ID3D11RasterizerState** ppRasterizerState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerState);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerState);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerState);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetState(ref ID3D11RasterizerState* ppRasterizerState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11RasterizerState** ppRasterizerStatePtr = &ppRasterizerState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerStatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerStatePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11RasterizerState**, void>)LpVtbl[94])(@this, ppRasterizerStatePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetViewports(uint* pNumViewports, Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewports);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewports);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewports);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetViewports(uint* pNumViewports, ref Viewport pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewportsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewportsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewports, pViewportsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetViewports(ref uint pNumViewports, Viewport* pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumViewportsPtr = &pNumViewports)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewports);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewports);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewports);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void RSGetViewports(ref uint pNumViewports, ref Viewport pViewports)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumViewportsPtr = &pNumViewports)
            {
                fixed (Viewport* pViewportsPtr = &pViewports)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewportsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewportsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Viewport*, void>)LpVtbl[95])(@this, pNumViewportsPtr, pViewportsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetScissorRects(uint* pNumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRects, pRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRects, pRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRects, pRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetScissorRects(uint* pNumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRects, pRectsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRects, pRectsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRects, pRectsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSGetScissorRects(ref uint pNumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRectsPtr = &pNumRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void RSGetScissorRects(ref uint pNumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumRectsPtr = &pNumRects)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRectsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRectsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[96])(@this, pNumRectsPtr, pRectsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[97])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstancesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstancesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstances, pNumClassInstancesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ID3D11HullShader** ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetShader(ref ID3D11HullShader* ppHullShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11HullShader** ppHullShaderPtr = &ppHullShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11HullShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[98])(@this, ppHullShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[99])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[100])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[101])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstancesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstancesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstances, pNumClassInstancesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ID3D11DomainShader** ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetShader(ref ID3D11DomainShader* ppDomainShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11DomainShader** ppDomainShaderPtr = &ppDomainShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11DomainShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[102])(@this, ppDomainShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[103])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[104])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShaderResources(uint StartSlot, uint NumViews, ID3D11ShaderResourceView** ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShaderResources(uint StartSlot, uint NumViews, ref ID3D11ShaderResourceView* ppShaderResourceViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ShaderResourceView** ppShaderResourceViewsPtr = &ppShaderResourceViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11ShaderResourceView**, void>)LpVtbl[105])(@this, StartSlot, NumViews, ppShaderResourceViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ID3D11UnorderedAccessView** ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetUnorderedAccessViews(uint StartSlot, uint NumUAVs, ref ID3D11UnorderedAccessView* ppUnorderedAccessViews)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11UnorderedAccessView** ppUnorderedAccessViewsPtr = &ppUnorderedAccessViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11UnorderedAccessView**, void>)LpVtbl[106])(@this, StartSlot, NumUAVs, ppUnorderedAccessViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstances);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstancesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstancesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstances, pNumClassInstancesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ID3D11ComputeShader** ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShader, ppClassInstancesPtr, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstances);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstances);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstances);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ID3D11ClassInstance** ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
                fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstancesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstances, pNumClassInstancesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, uint* pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstances);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstances);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetShader(ref ID3D11ComputeShader* ppComputeShader, ref ID3D11ClassInstance* ppClassInstances, ref uint pNumClassInstances)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11ComputeShader** ppComputeShaderPtr = &ppComputeShader)
            {
                fixed (ID3D11ClassInstance** ppClassInstancesPtr = &ppClassInstances)
                {
                    fixed (uint* pNumClassInstancesPtr = &pNumClassInstances)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11ComputeShader**, ID3D11ClassInstance**, uint*, void>)LpVtbl[107])(@this, ppComputeShaderPtr, ppClassInstancesPtr, pNumClassInstancesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetSamplers(uint StartSlot, uint NumSamplers, ID3D11SamplerState** ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetSamplers(uint StartSlot, uint NumSamplers, ref ID3D11SamplerState* ppSamplers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11SamplerState** ppSamplersPtr = &ppSamplers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11SamplerState**, void>)LpVtbl[108])(@this, StartSlot, NumSamplers, ppSamplersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, void>)LpVtbl[109])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)LpVtbl[110])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void Flush()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, void>)LpVtbl[111])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly DeviceContextType GetType()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DeviceContextType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, DeviceContextType>)LpVtbl[112])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetContextFlags()
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint>)LpVtbl[113])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishCommandList(int RestoreDeferredContextState, ID3D11CommandList** ppCommandList)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11DeviceContext1*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandList);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishCommandList(int RestoreDeferredContextState, ref ID3D11CommandList* ppCommandList)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CommandList** ppCommandListPtr = &ppCommandList)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11DeviceContext1*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandListPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandListPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, int, ID3D11CommandList**, int>)LpVtbl[114])(@this, RestoreDeferredContextState, ppCommandListPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ID3D11Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResource, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBox, CopyFlags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ID3D11Resource* pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResource, SrcSubresource, pSrcBoxPtr, CopyFlags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, Box* pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBox, CopyFlags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopySubresourceRegion1(ref ID3D11Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, uint DstZ, ref ID3D11Resource pSrcResource, uint SrcSubresource, ref Box pSrcBox, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D11Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, uint, uint, uint, ID3D11Resource*, uint, Box*, uint, void>)LpVtbl[115])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, DstZ, pSrcResourcePtr, SrcSubresource, pSrcBoxPtr, CopyFlags);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<T0>(ID3D11Resource* pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<T0>(ID3D11Resource* pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pDstBoxPtr = &pDstBox)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResource, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, Box* pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (void* pSrcDataPtr = &pSrcData)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBox, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void UpdateSubresource1(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, void* pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcData, SrcRowPitch, SrcDepthPitch, CopyFlags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void UpdateSubresource1<T0>(ref ID3D11Resource pDstResource, uint DstSubresource, ref Box pDstBox, ref T0 pSrcData, uint SrcRowPitch, uint SrcDepthPitch, uint CopyFlags) where T0 : unmanaged
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Box* pDstBoxPtr = &pDstBox)
                {
                    fixed (void* pSrcDataPtr = &pSrcData)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, uint, Box*, void*, uint, uint, uint, void>)LpVtbl[116])(@this, pDstResourcePtr, DstSubresource, pDstBoxPtr, pSrcDataPtr, SrcRowPitch, SrcDepthPitch, CopyFlags);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D11Resource* pResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResource);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResource);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D11Resource pResource)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResourcePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11Resource*, void>)LpVtbl[117])(@this, pResourcePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView(ID3D11View* pResourceView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceView);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceView);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceView);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardView(ref ID3D11View pResourceView)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pResourceViewPtr = &pResourceView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceViewPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceViewPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, void>)LpVtbl[118])(@this, pResourceViewPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[119])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[120])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[121])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[122])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[123])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSSetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[124])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[125])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void HSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[126])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[127])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[128])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[129])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstants);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pNumConstantsPtr = &pNumConstants)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstant, pNumConstantsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ID3D11Buffer** ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pFirstConstantPtr = &pFirstConstant)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffers, pFirstConstantPtr, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstants);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, uint* pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pNumConstantsPtr = &pNumConstants)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstant, pNumConstantsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, uint* pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstants);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CSGetConstantBuffers1(uint StartSlot, uint NumBuffers, ref ID3D11Buffer* ppConstantBuffers, ref uint pFirstConstant, ref uint pNumConstants)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Buffer** ppConstantBuffersPtr = &ppConstantBuffers)
            {
                fixed (uint* pFirstConstantPtr = &pFirstConstant)
                {
                    fixed (uint* pNumConstantsPtr = &pNumConstants)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, uint, uint, ID3D11Buffer**, uint*, uint*, void>)LpVtbl[130])(@this, StartSlot, NumBuffers, ppConstantBuffersPtr, pFirstConstantPtr, pNumConstantsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ID3DDeviceContextState* pState, ID3DDeviceContextState** ppPreviousState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousState);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousState);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousState);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ID3DDeviceContextState* pState, ref ID3DDeviceContextState* ppPreviousState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousStatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousStatePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pState, ppPreviousStatePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ref ID3DDeviceContextState pState, ID3DDeviceContextState** ppPreviousState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3DDeviceContextState* pStatePtr = &pState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousState);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousState);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousState);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SwapDeviceContextState(ref ID3DDeviceContextState pState, ref ID3DDeviceContextState* ppPreviousState)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3DDeviceContextState* pStatePtr = &pState)
            {
                fixed (ID3DDeviceContextState** ppPreviousStatePtr = &ppPreviousState)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousStatePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousStatePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3DDeviceContextState*, ID3DDeviceContextState**, void>)LpVtbl[131])(@this, pStatePtr, ppPreviousStatePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] float* Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, Color, pRect, NumRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, Color, pRect, NumRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, Color, pRect, NumRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] float* Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, Color, pRectPtr, NumRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, Color, pRectPtr, NumRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, Color, pRectPtr, NumRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] ref float Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorPtr = &Color)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRect, NumRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRect, NumRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRect, NumRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ID3D11View* pView, [Count(Count = 4)] ref float Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorPtr = &Color)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRectPtr, NumRects);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRectPtr, NumRects);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pView, ColorPtr, pRectPtr, NumRects);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] float* Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRect, NumRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRect, NumRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRect, NumRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] float* Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRectPtr, NumRects);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRectPtr, NumRects);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, Color, pRectPtr, NumRects);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearView(ref ID3D11View pView, [Count(Count = 4)] ref float Color, Silk.NET.Maths.Rectangle<int>* pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
                fixed (float* ColorPtr = &Color)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRect, NumRects);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRect, NumRects);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRect, NumRects);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearView(ref ID3D11View pView, [Count(Count = 4)] ref float Color, ref Silk.NET.Maths.Rectangle<int> pRect, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pViewPtr = &pView)
            {
                fixed (float* ColorPtr = &Color)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRectPtr, NumRects);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRectPtr, NumRects);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, float*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[132])(@this, pViewPtr, ColorPtr, pRectPtr, NumRects);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1(ID3D11View* pResourceView, Silk.NET.Maths.Rectangle<int>* pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceView, pRects, NumRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceView, pRects, NumRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceView, pRects, NumRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1(ID3D11View* pResourceView, ref Silk.NET.Maths.Rectangle<int> pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceView, pRectsPtr, NumRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceView, pRectsPtr, NumRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceView, pRectsPtr, NumRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardView1(ref ID3D11View pResourceView, Silk.NET.Maths.Rectangle<int>* pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pResourceViewPtr = &pResourceView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRects, NumRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRects, NumRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRects, NumRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardView1(ref ID3D11View pResourceView, ref Silk.NET.Maths.Rectangle<int> pRects, uint NumRects)
        {
            var @this = (ID3D11DeviceContext1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11View* pResourceViewPtr = &pResourceView)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRectsPtr, NumRects);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRectsPtr, NumRects);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11DeviceContext1*, ID3D11View*, Silk.NET.Maths.Rectangle<int>*, uint, void>)LpVtbl[133])(@this, pResourceViewPtr, pRectsPtr, NumRects);
                    }
            #endif
                }
            }
        }

    }
}
