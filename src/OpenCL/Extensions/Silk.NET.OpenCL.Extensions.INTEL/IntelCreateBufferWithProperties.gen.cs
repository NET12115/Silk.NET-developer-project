// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
<<<<<<< HEAD
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenCL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;
=======
using System.Text;
using Silk.NET.OpenCL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;
>>>>>>> master

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    [Extension("INTEL_create_buffer_with_properties")]
<<<<<<< HEAD
    public unsafe partial class IntelCreateBufferWithProperties : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_create_buffer_with_properties";
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public unsafe partial IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public unsafe partial IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public unsafe partial IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public unsafe partial IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public unsafe partial IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public unsafe partial IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public unsafe partial IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret) where T0 : unmanaged;

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public partial IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] in INTEL properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] out T0 host_ptr, [Flow(FlowDirection.Out)] out int errcode_ret) where T0 : unmanaged;

        public IntelCreateBufferWithProperties(INativeContext ctx)
            : base(ctx)
=======
    public abstract unsafe partial class IntelCreateBufferWithProperties : NativeExtension<CL>
    {
        public const string ExtensionName = "INTEL_create_buffer_with_properties";
        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public abstract unsafe IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret);

        [NativeApi(EntryPoint = "clCreateBufferWithPropertiesINTEL")]
        public abstract IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] IntPtr context, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged;

        public unsafe IntPtr CreateBufferWithProperties([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] INTEL* properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* host_ptr, [Flow(FlowDirection.Out)] int* errcode_ret)
        {
            // IntPtrOverloader
            return CreateBufferWithProperties(new IntPtr(context), properties, flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        public unsafe IntPtr CreateBufferWithProperties<T0>([Flow(FlowDirection.In)] int context, [Flow(FlowDirection.In)] Span<INTEL> properties, [Flow(FlowDirection.In)] INTEL flags, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> host_ptr, [Flow(FlowDirection.Out)] Span<int> errcode_ret) where T0 : unmanaged
        {
            // IntPtrOverloader
            return CreateBufferWithProperties(new IntPtr(context), properties, flags, new UIntPtr(size), host_ptr, errcode_ret);
        }

        public IntelCreateBufferWithProperties(ref NativeApiContext ctx)
            : base(ref ctx)
>>>>>>> master
        {
        }
    }
}

