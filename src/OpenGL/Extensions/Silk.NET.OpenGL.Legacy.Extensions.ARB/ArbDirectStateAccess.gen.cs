// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_direct_state_access")]
    public abstract unsafe partial class ArbDirectStateAccess : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindTextureUnit")]
        public abstract void BindTextureUnit([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public abstract void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] ARB filter);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public abstract ARB CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyNamedBufferSubData")]
        public abstract void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage1D")]
        public abstract void CopyTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage2D")]
        public abstract void CopyTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCopyTextureSubImage3D")]
        public abstract void CopyTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateBuffers")]
        public abstract unsafe void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateBuffers")]
        public abstract void CreateBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> buffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public abstract unsafe void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateFramebuffers")]
        public abstract void CreateFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> framebuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public abstract unsafe void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateProgramPipelines")]
        public abstract void CreateProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> pipelines);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract unsafe void CreateQueries([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract void CreateQueries([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public abstract unsafe void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateRenderbuffers")]
        public abstract void CreateRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> renderbuffers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateSamplers")]
        public abstract unsafe void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateSamplers")]
        public abstract void CreateSamplers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> samplers);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract unsafe void CreateTextures([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract void CreateTextures([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public abstract unsafe void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTransformFeedbacks")]
        public abstract void CreateTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public abstract unsafe void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateVertexArrays")]
        public abstract void CreateVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDisableVertexArrayAttrib")]
        public abstract void DisableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEnableVertexArrayAttrib")]
        public abstract void EnableVertexArrayAttrib([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFlushMappedNamedBufferRange")]
        public abstract void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenerateTextureMipmap")]
        public abstract void GenerateTextureMipmap([Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public abstract unsafe void GetCompressedTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetCompressedTextureImage")]
        public abstract void GetCompressedTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public abstract unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferSubData")]
        public abstract void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public abstract void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract unsafe void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] ARB* attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<ARB> attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] ARB* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<ARB> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBufferRange")]
        public abstract unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public abstract unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferStorage")]
        public abstract void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public abstract unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferSubData")]
        public abstract void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public abstract void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ARB* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ARB> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public abstract void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB src);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] ARB renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ARB attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBuffer")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterf")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] float* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<float> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteri")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackBufferBase")]
        public abstract void TransformFeedbackBufferBase([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTransformFeedbackBufferRange")]
        public abstract void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUnmapNamedBuffer")]
        public abstract bool UnmapNamedBuffer([Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribBinding")]
        public abstract void VertexArrayAttribBinding([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public abstract void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public abstract void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public abstract void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayBindingDivisor")]
        public abstract void VertexArrayBindingDivisor([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayElementBuffer")]
        public abstract void VertexArrayElementBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffer")]
        public abstract void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public abstract unsafe void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint* buffers, [Flow(FlowDirection.In)] IntPtr* offsets, [Flow(FlowDirection.In)] uint* strides);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayVertexBuffers")]
        public abstract void VertexArrayVertexBuffers([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<uint> buffers, [Flow(FlowDirection.In)] Span<IntPtr> offsets, [Flow(FlowDirection.In)] Span<uint> strides);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlitNamedFramebuffer")]
        public abstract void BlitNamedFramebuffer([Flow(FlowDirection.In)] uint readFramebuffer, [Flow(FlowDirection.In)] uint drawFramebuffer, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCheckNamedFramebufferStatus")]
        public abstract ARB CheckNamedFramebufferStatus([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferTarget target);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract unsafe void ClearNamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferData")]
        public abstract void ClearNamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedBufferSubData")]
        public abstract void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] int* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<int> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] uint* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferuiv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<uint> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract unsafe void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float* value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfv")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] Span<float> value);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glClearNamedFramebufferfi")]
        public abstract void ClearNamedFramebuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] Buffer buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract unsafe void CompressedTextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage1D")]
        public abstract void CompressedTextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract unsafe void CompressedTextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage2D")]
        public abstract void CompressedTextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract unsafe void CompressedTextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCompressedTextureSubImage3D")]
        public abstract void CompressedTextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract unsafe void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateQueries")]
        public abstract void CreateQueries([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract unsafe void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreateTextures")]
        public abstract void CreateTextures([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> textures);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteriv")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract unsafe void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferParameteri64v")]
        public abstract void GetNamedBufferParameter([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedBufferPointerv")]
        public abstract unsafe void GetNamedBufferPointer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] VertexBufferObjectParameter pname, [Flow(FlowDirection.Out)] void** @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract unsafe void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferAttachmentParameteriv")]
        public abstract void GetNamedFramebufferAttachmentParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameteriv")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] GetFramebufferParameter pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract unsafe void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNamedRenderbufferParameteriv")]
        public abstract void GetNamedRenderbufferParameter([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetQueryBufferObjecti64v")]
        public abstract void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract unsafe void GetTextureImage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureImage")]
        public abstract void GetTextureImage<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameterfv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract unsafe void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureLevelParameteriv")]
        public abstract void GetTextureLevelParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterfv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<float> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract unsafe void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameteriv")]
        public abstract void GetTextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract unsafe void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTextureParameterIuiv")]
        public abstract void GetTextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] GetTextureParameter pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbackiv")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract unsafe void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki_v")]
        public abstract void GetTransformFeedback([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract unsafe void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetTransformFeedbacki64_v")]
        public abstract void GetTransformFeedbacki64_([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] TransformFeedbackPName pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract unsafe void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayiv")]
        public abstract void GetVertexArray([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract unsafe void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexediv")]
        public abstract void GetVertexArrayIndexed([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract unsafe void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] long* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexArrayIndexed64iv")]
        public abstract void GetVertexArrayIndexed64([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexArrayPName pname, [Flow(FlowDirection.Out)] Span<long> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract unsafe void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferData")]
        public abstract void InvalidateNamedFramebufferData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract unsafe void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] FramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glInvalidateNamedFramebufferSubData")]
        public abstract void InvalidateNamedFramebufferSubData([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numAttachments, [Flow(FlowDirection.In)] Span<FramebufferAttachment> attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMapNamedBuffer")]
        public abstract unsafe void* MapNamedBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] BufferAccessARB access);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedBufferData")]
        public abstract void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffer")]
        public abstract void NamedFramebufferDrawBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer buf);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract unsafe void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] ColorBuffer* bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferDrawBuffers")]
        public abstract void NamedFramebufferDrawBuffers([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint n, [Flow(FlowDirection.In)] Span<ColorBuffer> bufs);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferParameteri")]
        public abstract void NamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferReadBuffer")]
        public abstract void NamedFramebufferReadBuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] ColorBuffer src);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferRenderbuffer")]
        public abstract void NamedFramebufferRenderbuffer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTexture")]
        public abstract void NamedFramebufferTexture([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedFramebufferTextureLayer")]
        public abstract void NamedFramebufferTextureLayer([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorage")]
        public abstract void NamedRenderbufferStorage([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisample")]
        public abstract void NamedRenderbufferStorageMultisample([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBuffer")]
        public abstract void TextureBuffer([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureBufferRange")]
        public abstract void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterf")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterfv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<float> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteri")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract unsafe void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameteriv")]
        public abstract void TextureParameter([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> param);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract unsafe void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureParameterIuiv")]
        public abstract void TextureParameterI([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage1D")]
        public abstract void TextureStorage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2D")]
        public abstract void TextureStorage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage2DMultisample")]
        public abstract void TextureStorage2DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3D")]
        public abstract void TextureStorage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureStorage3DMultisample")]
        public abstract void TextureStorage3DMultisample([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract unsafe void TextureSubImage1D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage1D")]
        public abstract void TextureSubImage1D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract unsafe void TextureSubImage2D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage2D")]
        public abstract void TextureSubImage2D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract unsafe void TextureSubImage3D([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* pixels);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTextureSubImage3D")]
        public abstract void TextureSubImage3D<T0>([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> pixels) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribFormat")]
        public abstract void VertexArrayAttribFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribIFormat")]
        public abstract void VertexArrayAttribIFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexArrayAttribLFormat")]
        public abstract void VertexArrayAttribLFormat([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint relativeoffset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] ARB format, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readBuffer">
        /// To be added.
        /// </param>
        /// <param name="writeBuffer">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void CopyNamedBufferSubData([Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            CopyNamedBufferSubData(readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="buffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateBuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="framebuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateFramebuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="pipelines">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateProgramPipelines(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="renderbuffers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateRenderbuffers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="samplers">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateSampler()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateSamplers(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateTransformFeedbacks(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="n">
        /// To be added.
        /// </param>
        /// <param name="arrays">
        /// To be added.
        /// This parameter's element count is taken from n.
        /// </param>
        public unsafe uint CreateVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreateVertexArrays(n, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        public unsafe void FlushMappedNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            FlushMappedNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void GetNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] void* data)
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void GetNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            GetNamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="access">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe void* MapNamedBufferRange([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] uint access)
        {
            // IntPtrOverloader
            return MapNamedBufferRange(buffer, new IntPtr(offset), new UIntPtr(length), access);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] ARB usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] ARB usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferStorage([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is taken from size.
        /// </param>
        /// <param name="flags">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferStorage<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] uint flags) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferStorage(buffer, new UIntPtr(size), data, flags);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void NamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from size.
        /// </param>
        public unsafe void NamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Count(Computed = "size"), Flow(FlowDirection.In)] ref T0 data) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferSubData(buffer, new IntPtr(offset), new UIntPtr(size), ref data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="xfb">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TransformFeedbackBufferRange([Flow(FlowDirection.In)] uint xfb, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TransformFeedbackBufferRange(xfb, index, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="vaobj">
        /// To be added.
        /// </param>
        /// <param name="bindingindex">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        public unsafe void VertexArrayVertexBuffer([Flow(FlowDirection.In)] uint vaobj, [Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint stride)
        {
            // IntPtrOverloader
            VertexArrayVertexBuffer(vaobj, bindingindex, buffer, new IntPtr(offset), stride);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="format">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void ClearNamedBufferSubData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            ClearNamedBufferSubData(buffer, internalformat, new IntPtr(offset), new UIntPtr(size), format, type, data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        public unsafe void GetQueryBufferObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            GetQueryBufferObject(id, buffer, pname, new IntPtr(offset));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage)
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        /// <param name="usage">
        /// To be added.
        /// </param>
        public unsafe void NamedBufferData<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data, [Flow(FlowDirection.In)] VertexBufferObjectUsage usage) where T0 : unmanaged
        {
            // IntPtrOverloader
            NamedBufferData(buffer, new UIntPtr(size), data, usage);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void TextureBufferRange([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            TextureBufferRange(texture, internalformat, buffer, new IntPtr(offset), new UIntPtr(size));
        }

        public ArbDirectStateAccess(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

