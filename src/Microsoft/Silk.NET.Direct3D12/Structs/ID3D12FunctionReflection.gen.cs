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

namespace Silk.NET.Direct3D12
{
    [Guid("1108795c-2772-4ba9-b2a8-d464dc7e2799")]
    [NativeName("Name", "ID3D12FunctionReflection")]
    public unsafe partial struct ID3D12FunctionReflection
    {
        public static readonly Guid Guid = new("1108795c-2772-4ba9-b2a8-d464dc7e2799");

        public ID3D12FunctionReflection
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
        public readonly unsafe int GetDesc(FunctionDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref FunctionDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FunctionDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(ref byte Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(ref byte Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName(ref byte Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12FunctionParameterReflection* ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            return ret;
        }

    }
}
