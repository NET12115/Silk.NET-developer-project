// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_vertex_array_lists")]
    public unsafe partial class IbmVertexArrayLists : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_vertex_array_lists";
        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        public unsafe partial void ColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        public unsafe partial void ColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM")]
        public unsafe partial void EdgeFlagPointerList([Flow(FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] bool** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM")]
        public unsafe partial void EdgeFlagPointerList([Flow(FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] ref bool* pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        public unsafe partial void FogCoordPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        public unsafe partial void FogCoordPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        public unsafe partial void IndexPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        public unsafe partial void IndexPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        public unsafe partial void NormalPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        public unsafe partial void NormalPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        public unsafe partial void SecondaryColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        public unsafe partial void SecondaryColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        public unsafe partial void TexCoordPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        public unsafe partial void TexCoordPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        public unsafe partial void VertexPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        public unsafe partial void VertexPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        public unsafe partial void ColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        public unsafe partial void ColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        public unsafe partial void FogCoordPointerList([Flow(FlowDirection.In)] FogPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        public unsafe partial void FogCoordPointerList<T0>([Flow(FlowDirection.In)] FogPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        public unsafe partial void IndexPointerList([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        public unsafe partial void IndexPointerList<T0>([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        public unsafe partial void NormalPointerList([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        public unsafe partial void NormalPointerList<T0>([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        public unsafe partial void SecondaryColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        public unsafe partial void SecondaryColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        public unsafe partial void TexCoordPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        public unsafe partial void TexCoordPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        public unsafe partial void VertexPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        public unsafe partial void VertexPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        public IbmVertexArrayLists(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

