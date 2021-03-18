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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_texture_buffer")]
    public unsafe partial class ExtTextureBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_texture_buffer";
        [NativeApi(EntryPoint = "glTexBufferEXT")]
        public partial void TexBuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferEXT")]
        public partial void TexBuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferEXT")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferEXT")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferRangeEXT")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRangeEXT")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRangeEXT")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] EXT internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRangeEXT")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        public ExtTextureBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

