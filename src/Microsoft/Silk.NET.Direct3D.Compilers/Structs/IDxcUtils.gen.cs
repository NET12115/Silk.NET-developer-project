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
    [Guid("4605c4cb-2019-492a-ada4-65f20bb7d67f")]
    [NativeName("Name", "IDxcUtils")]
    public unsafe partial struct IDxcUtils
    {
        public static readonly Guid Guid = new("4605c4cb-2019-492a-ada4-65f20bb7d67f");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcUtils val)
            => Unsafe.As<IDxcUtils, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcUtils
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
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[3])(@this, pBlob, offset, length, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[3])(@this, pBlob, offset, length, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[3])(@this, pBlobPtr, offset, length, ppResult);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(ref IDxcBlob pBlob, uint offset, uint length, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlob** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)LpVtbl[3])(@this, pBlobPtr, offset, length, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromPinned(void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[4])(@this, pData, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromPinned(void* pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[4])(@this, pData, size, codePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromPinned<T0>(ref T0 pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[4])(@this, pDataPtr, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromPinned<T0>(ref T0 pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[4])(@this, pDataPtr, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob(void* pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pData, pIMalloc, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob(void* pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pData, pIMalloc, size, codePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob(void* pData, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pData, pIMallocPtr, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob(void* pData, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMalloc* pIMallocPtr = &pIMalloc)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pData, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob<T0>(ref T0 pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pDataPtr, pIMalloc, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob<T0>(ref T0 pData, IMalloc* pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pDataPtr, pIMalloc, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob<T0>(ref T0 pData, ref IMalloc pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pDataPtr, pIMallocPtr, size, codePage, pBlobEncoding);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob<T0>(ref T0 pData, ref IMalloc pIMalloc, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (IMalloc* pIMallocPtr = &pIMalloc)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pDataPtr, pIMallocPtr, size, codePage, pBlobEncodingPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlob(void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pData, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlob(void* pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pData, size, codePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlob<T0>(ref T0 pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pDataPtr, size, codePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlob<T0>(ref T0 pData, uint size, uint codePage, ref IDxcBlobEncoding* pBlobEncoding) where T0 : unmanaged
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)LpVtbl[6])(@this, pDataPtr, size, codePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(char* pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileName, pCodePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(char* pFileName, uint* pCodePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileName, pCodePage, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(char* pFileName, ref uint pCodePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileName, pCodePagePtr, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(char* pFileName, ref uint pCodePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileName, pCodePagePtr, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(ref char pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(ref char pFileName, uint* pCodePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(ref char pFileName, ref uint pCodePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (uint* pCodePagePtr = &pCodePage)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncoding);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile(ref char pFileName, ref uint pCodePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pFileNamePtr = &pFileName)
            {
                fixed (uint* pCodePagePtr = &pCodePage)
                {
                    fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncodingPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncoding);
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, uint* pCodePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePage, pBlobEncodingPtr);
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint pCodePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncoding);
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pFileName, ref uint pCodePage, ref IDxcBlobEncoding* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPWStr);
            fixed (uint* pCodePagePtr = &pCodePage)
            {
                fixed (IDxcBlobEncoding** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, uint*, IDxcBlobEncoding**, int>)LpVtbl[7])(@this, pFileNamePtr, pCodePagePtr, pBlobEncodingPtr);
                }
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReadOnlyStreamFromBlob(IDxcBlob* pBlob, void** ppStream)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, void**, int>)LpVtbl[8])(@this, pBlob, ppStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReadOnlyStreamFromBlob(IDxcBlob* pBlob, ref void* ppStream)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppStreamPtr = &ppStream)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, void**, int>)LpVtbl[8])(@this, pBlob, ppStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReadOnlyStreamFromBlob(ref IDxcBlob pBlob, void** ppStream)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, void**, int>)LpVtbl[8])(@this, pBlobPtr, ppStream);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReadOnlyStreamFromBlob(ref IDxcBlob pBlob, ref void* ppStream)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (void** ppStreamPtr = &ppStream)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, void**, int>)LpVtbl[8])(@this, pBlobPtr, ppStreamPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDefaultIncludeHandler(IDxcIncludeHandler** ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDefaultIncludeHandler(ref IDxcIncludeHandler* ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcIncludeHandler** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcIncludeHandler**, int>)LpVtbl[9])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)LpVtbl[10])(@this, pBlob, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, ref IDxcBlobUtf8* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobUtf8** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)LpVtbl[10])(@this, pBlob, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, IDxcBlobUtf8** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)LpVtbl[10])(@this, pBlobPtr, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(ref IDxcBlob pBlob, ref IDxcBlobUtf8* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobUtf8** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)LpVtbl[10])(@this, pBlobPtr, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, IDxcBlobUtf16** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)LpVtbl[11])(@this, pBlob, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, ref IDxcBlobUtf16* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobUtf16** pBlobEncodingPtr = &pBlobEncoding)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)LpVtbl[11])(@this, pBlob, pBlobEncodingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, IDxcBlobUtf16** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncoding);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(ref IDxcBlob pBlob, ref IDxcBlobUtf16* pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pBlobPtr = &pBlob)
            {
                fixed (IDxcBlobUtf16** pBlobEncodingPtr = &pBlobEncoding)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)LpVtbl[11])(@this, pBlobPtr, pBlobEncodingPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, ref uint pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPartDataPtr = &ppPartData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShader, DxcPart, ppPartDataPtr, pPartSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] Buffer* pShader, uint DxcPart, ref void* ppPartData, ref uint pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppPartDataPtr = &ppPartData)
            {
                fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShader, DxcPart, ppPartDataPtr, pPartSizeInBytesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pShaderPtr = &pShader)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartData, pPartSizeInBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, void** ppPartData, ref uint pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pShaderPtr = &pShader)
            {
                fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartData, pPartSizeInBytesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, ref void* ppPartData, uint* pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pShaderPtr = &pShader)
            {
                fixed (void** ppPartDataPtr = &ppPartData)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartDataPtr, pPartSizeInBytes);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(FlowDirection.In)] in Buffer pShader, uint DxcPart, ref void* ppPartData, ref uint pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pShaderPtr = &pShader)
            {
                fixed (void** ppPartDataPtr = &ppPartData)
                {
                    fixed (uint* pPartSizeInBytesPtr = &pPartSizeInBytes)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)LpVtbl[12])(@this, pShaderPtr, DxcPart, ppPartDataPtr, pPartSizeInBytesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] Buffer* pData, Guid* iid, void** ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pData, iid, ppvReflection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] Buffer* pData, Guid* iid, ref void* ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvReflectionPtr = &ppvReflection)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pData, iid, ppvReflectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] Buffer* pData, ref Guid iid, void** ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pData, iidPtr, ppvReflection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] Buffer* pData, ref Guid iid, ref void* ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvReflectionPtr = &ppvReflection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pData, iidPtr, ppvReflectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] in Buffer pData, Guid* iid, void** ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pDataPtr, iid, ppvReflection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] in Buffer pData, Guid* iid, ref void* ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pDataPtr = &pData)
            {
                fixed (void** ppvReflectionPtr = &ppvReflection)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pDataPtr, iid, ppvReflectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] in Buffer pData, ref Guid iid, void** ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pDataPtr = &pData)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pDataPtr, iidPtr, ppvReflection);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(FlowDirection.In)] in Buffer pData, ref Guid iid, ref void* ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pDataPtr = &pData)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** ppvReflectionPtr = &ppvReflection)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, Buffer*, Guid*, void**, int>)LpVtbl[13])(@this, pDataPtr, iidPtr, ppvReflectionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(char* pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceName, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
                    fixed (char* pTargetProfilePtr = &pTargetProfile)
                    {
                        fixed (char** pArgumentsPtr = &pArguments)
                        {
                            fixed (Define* pDefinesPtr = &pDefines)
                            {
                                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                                {
                                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
                fixed (char* pEntryPointPtr = &pEntryPoint)
                {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
            SilkMarshal.Free((nint)pTargetProfilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments(ref char pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pSourceNamePtr = &pSourceName)
            {
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, char*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, char* pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPoint, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
                fixed (char* pTargetProfilePtr = &pTargetProfile)
                {
                    fixed (char** pArgumentsPtr = &pArguments)
                    {
                        fixed (Define* pDefinesPtr = &pDefines)
                        {
                            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                            }
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, ref char pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            fixed (char* pEntryPointPtr = &pEntryPoint)
            {
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, char*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            }
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, char* pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfile, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, ref char pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            fixed (char* pTargetProfilePtr = &pTargetProfile)
            {
                fixed (char** pArgumentsPtr = &pArguments)
                {
                    fixed (Define* pDefinesPtr = &pDefines)
                    {
                        fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                        }
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgs);
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefines, defineCount, ppArgsPtr);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, char** pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (Define* pDefinesPtr = &pDefines)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArguments, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgs);
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] Define* pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefines, defineCount, ppArgsPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgs);
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pSourceName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pEntryPoint, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pTargetProfile, ref char* pArguments, uint argCount, [Flow(FlowDirection.In)] in Define pDefines, uint defineCount, ref IDxcCompilerArgs* ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSourceNamePtr = (byte*) SilkMarshal.StringToPtr(pSourceName, NativeStringEncoding.LPWStr);
            var pEntryPointPtr = (byte*) SilkMarshal.StringToPtr(pEntryPoint, NativeStringEncoding.LPWStr);
            var pTargetProfilePtr = (byte*) SilkMarshal.StringToPtr(pTargetProfile, NativeStringEncoding.LPWStr);
            fixed (char** pArgumentsPtr = &pArguments)
            {
                fixed (Define* pDefinesPtr = &pDefines)
                {
                    fixed (IDxcCompilerArgs** ppArgsPtr = &ppArgs)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, byte*, byte*, byte*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)LpVtbl[14])(@this, pSourceNamePtr, pEntryPointPtr, pTargetProfilePtr, pArgumentsPtr, argCount, pDefinesPtr, defineCount, ppArgsPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pTargetProfilePtr);
            SilkMarshal.Free((nint)pEntryPointPtr);
            SilkMarshal.Free((nint)pSourceNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(IDxcBlob* pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppContainerPtr = &ppContainer)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(IDxcBlob* pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppHashPtr = &ppHash)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlob, ppHashPtr, ppContainer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(IDxcBlob* pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppHashPtr = &ppHash)
            {
                fixed (IDxcBlob** ppContainerPtr = &ppContainer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlob, ppHashPtr, ppContainerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(ref IDxcBlob pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlobPtr, ppHash, ppContainer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(ref IDxcBlob pPDBBlob, IDxcBlob** ppHash, ref IDxcBlob* ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
            {
                fixed (IDxcBlob** ppContainerPtr = &ppContainer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlobPtr, ppHash, ppContainerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(ref IDxcBlob pPDBBlob, ref IDxcBlob* ppHash, IDxcBlob** ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
            {
                fixed (IDxcBlob** ppHashPtr = &ppHash)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlobPtr, ppHashPtr, ppContainer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(ref IDxcBlob pPDBBlob, ref IDxcBlob* ppHash, ref IDxcBlob* ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPDBBlobPtr = &pPDBBlob)
            {
                fixed (IDxcBlob** ppHashPtr = &ppHash)
                {
                    fixed (IDxcBlob** ppContainerPtr = &ppContainer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)LpVtbl[15])(@this, pPDBBlobPtr, ppHashPtr, ppContainerPtr);
                    }
                }
            }
            return ret;
        }

    }
}
