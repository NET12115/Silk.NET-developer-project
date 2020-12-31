// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGLES
{
    public unsafe partial class GL : NativeAPI
    {

        [NativeApi(EntryPoint = "glBlendBarrier")]
        public partial void BlendBarrier();

        [NativeApi(EntryPoint = "glBlendEquationi")]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendEquationi")]
        public partial void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparatei")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum src, [Flow(FlowDirection.In)] GLEnum dst);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] GLEnum dst);

        [NativeApi(EntryPoint = "glBlendFunci")]
        public partial void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] GLEnum srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] GLEnum dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] GLEnum srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] GLEnum dstAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparatei")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glColorMaski")]
        public partial void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] GLEnum srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] GLEnum dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] GLEnum srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] GLEnum dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glCopyImageSubData")]
        public partial void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyImageSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyImageSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public unsafe partial void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public partial void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] in T0 userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] in byte buf);

        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glDisablei")]
        public partial void Disable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisablei")]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glEnablei")]
        public partial void Enable([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnablei")]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture")]
        public partial void FramebufferTexture([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] GLEnum* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out GLEnum severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSource sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugType types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out DebugSeverity severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetGraphicsResetStatus")]
        public partial GLEnum GetGraphicsResetStatus();

        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetnUniformfv")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetnUniformiv")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public unsafe partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetnUniformuiv")]
        public partial void GetnUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public unsafe partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public partial void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label);

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public unsafe partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public partial void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string label) where T0 : unmanaged;

        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [System.Obsolete("Deprecated in version 3.2")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public unsafe partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterIuiv")]
        public partial void GetSamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public unsafe partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetTexParameterIuiv")]
        public partial void GetTexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glIsEnabledi")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnabledi")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glMinSampleShading")]
        public partial void MinSampleShading([Flow(FlowDirection.In)] float value);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public unsafe partial void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] in byte label);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] GLEnum identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public unsafe partial void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] in byte label);

        [NativeApi(EntryPoint = "glObjectLabel")]
        public partial void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] in byte label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public unsafe partial void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public unsafe partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] byte* label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] in byte label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public partial void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] in T0 ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPatchParameteri")]
        public partial void PatchParameter([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameteri")]
        public partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPopDebugGroup")]
        public partial void PopDebugGroup();

        [NativeApi(EntryPoint = "glPrimitiveBoundingBox")]
        public partial void PrimitiveBoundingBox([Flow(FlowDirection.In)] float minX, [Flow(FlowDirection.In)] float minY, [Flow(FlowDirection.In)] float minZ, [Flow(FlowDirection.In)] float minW, [Flow(FlowDirection.In)] float maxX, [Flow(FlowDirection.In)] float maxY, [Flow(FlowDirection.In)] float maxZ, [Flow(FlowDirection.In)] float maxW);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public unsafe partial void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] byte* message);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] in byte message);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] GLEnum source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public unsafe partial void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] byte* message);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] in byte message);

        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public partial void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixels")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixels")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadnPixels")]
        public unsafe partial void ReadnPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* data);

        [NativeApi(EntryPoint = "glReadnPixels")]
        public partial void ReadnPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameterIiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public unsafe partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* param);

        [NativeApi(EntryPoint = "glSamplerParameterIuiv")]
        public partial void SamplerParameterI([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint param);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public partial void TexBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public partial void TexBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBuffer")]
        public partial void TexBuffer([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexBufferRange")]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameterIiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public unsafe partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] uint* @params);

        [NativeApi(EntryPoint = "glTexParameterIuiv")]
        public partial void TexParameterI([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in uint @params);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisample")]
        public partial void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glActiveShaderProgram")]
        public partial void ActiveShaderProgram([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] GLEnum access, [Flow(FlowDirection.In)] GLEnum format);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] GLEnum access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] GLEnum format);

        [NativeApi(EntryPoint = "glBindImageTexture")]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glBindProgramPipeline")]
        public partial void BindProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glBindVertexBuffer")]
        public partial void BindVertexBuffer([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** strings);

        [NativeApi(EntryPoint = "glCreateShaderProgramv")]
        public unsafe partial uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* strings);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public unsafe partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public unsafe partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ProgramPipeline* pipelines);

        [NativeApi(EntryPoint = "glDeleteProgramPipelines")]
        public partial void DeleteProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in ProgramPipeline pipelines);

        [NativeApi(EntryPoint = "glDispatchCompute")]
        public partial void DispatchCompute([Flow(FlowDirection.In)] uint num_groups_x, [Flow(FlowDirection.In)] uint num_groups_y, [Flow(FlowDirection.In)] uint num_groups_z);

        [NativeApi(EntryPoint = "glDispatchComputeIndirect")]
        public partial void DispatchComputeIndirect([Flow(FlowDirection.In)] IntPtr indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public unsafe partial void DrawArraysIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public partial void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public unsafe partial void DrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawArraysIndirect")]
        public partial void DrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public partial void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public partial void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public partial void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public unsafe partial void DrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] void* indirect);

        [NativeApi(EntryPoint = "glDrawElementsIndirect")]
        public partial void DrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] in T0 indirect) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glFramebufferParameteri")]
        public partial void FramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public unsafe partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public unsafe partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] ProgramPipeline* pipelines);

        [NativeApi(EntryPoint = "glGenProgramPipelines")]
        public partial void GenProgramPipelines([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out ProgramPipeline pipelines);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public partial void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleani_v")]
        public partial void GetBoolean([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferParameteriv")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public unsafe partial void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public partial void GetMultisample([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public unsafe partial void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* val);

        [NativeApi(EntryPoint = "glGetMultisamplefv")]
        public partial void GetMultisample([Flow(FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float val);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public unsafe partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramInterfaceiv")]
        public partial void GetProgramInterface([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] ProgramInterfacePName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public unsafe partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public unsafe partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineiv")]
        public partial void GetProgramPipeline([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] PipelineParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public unsafe partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramPipelineInfoLog")]
        public partial void GetProgramPipelineInfoLog([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] GLEnum* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in GLEnum props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] ProgramResourceProperty* props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public unsafe partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramResourceiv")]
        public partial void GetProgramResource([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint propCount, [Count(Parameter = "propCount"), Flow(FlowDirection.In)] in ProgramResourceProperty props, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public unsafe partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public unsafe partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceIndex")]
        public partial uint GetProgramResourceIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public unsafe partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public unsafe partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocation")]
        public partial int GetProgramResourceLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public unsafe partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceName")]
        public partial void GetProgramResourceName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameteriv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public unsafe partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexLevelParameterfv")]
        public partial void GetTexLevelParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glIsProgramPipeline")]
        public partial bool IsProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glMemoryBarrier")]
        public partial void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glMemoryBarrierByRegion")]
        public partial void MemoryBarrierByRegion([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glProgramUniform1i")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glProgramUniform1ui")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glProgramUniform1f")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform1iv")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform1uiv")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public unsafe partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform1fv")]
        public partial void ProgramUniform1([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform2i")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glProgramUniform2ui")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glProgramUniform2f")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform2iv")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform2uiv")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public unsafe partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform2fv")]
        public partial void ProgramUniform2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform3i")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glProgramUniform3ui")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glProgramUniform3f")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform3iv")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform3uiv")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public unsafe partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform3fv")]
        public partial void ProgramUniform3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniform4i")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glProgramUniform4ui")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glProgramUniform4f")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glProgramUniform4iv")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glProgramUniform4uiv")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public unsafe partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniform4fv")]
        public partial void ProgramUniform4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public unsafe partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2fv")]
        public partial void ProgramUniformMatrix2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public unsafe partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x3fv")]
        public partial void ProgramUniformMatrix2x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public unsafe partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix2x4fv")]
        public partial void ProgramUniformMatrix2x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public unsafe partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3fv")]
        public partial void ProgramUniformMatrix3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public unsafe partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x2fv")]
        public partial void ProgramUniformMatrix3x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public unsafe partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix3x4fv")]
        public partial void ProgramUniformMatrix3x4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public unsafe partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4fv")]
        public partial void ProgramUniformMatrix4([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public unsafe partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x2fv")]
        public partial void ProgramUniformMatrix4x2([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public unsafe partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glProgramUniformMatrix4x3fv")]
        public partial void ProgramUniformMatrix4x3([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glSampleMaski")]
        public partial void SampleMask([Flow(FlowDirection.In)] uint maskNumber, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage2DMultisample")]
        public partial void TexStorage2DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glUseProgramStages")]
        public partial void UseProgramStages([Flow(FlowDirection.In)] uint pipeline, [Flow(FlowDirection.In)] uint stages, [Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgramPipeline")]
        public partial void ValidateProgramPipeline([Flow(FlowDirection.In)] uint pipeline);

        [NativeApi(EntryPoint = "glVertexAttribBinding")]
        public partial void VertexAttribBinding([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] uint bindingindex);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribFormat")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexAttribIFormat")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint attribindex, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint relativeoffset);

        [NativeApi(EntryPoint = "glVertexBindingDivisor")]
        public partial void VertexBindingDivisor([Flow(FlowDirection.In)] uint bindingindex, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glBeginQuery")]
        public partial void BeginQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBeginQuery")]
        public partial void BeginQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] GLEnum primitiveMode);

        [NativeApi(EntryPoint = "glBeginTransformFeedback")]
        public partial void BeginTransformFeedback([Flow(FlowDirection.In)] PrimitiveType primitiveMode);

        [NativeApi(EntryPoint = "glBindBufferBase")]
        public partial void BindBufferBase([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferBase")]
        public partial void BindBufferBase([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBufferRange")]
        public partial void BindBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glBindBufferRange")]
        public partial void BindBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glBindSampler")]
        public partial void BindSampler([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindTransformFeedback")]
        public partial void BindTransformFeedback([Flow(FlowDirection.In)] BindTransformFeedbackTarget target, [Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glBindVertexArray")]
        public partial void BindVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public partial void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] GLEnum filter);

        [NativeApi(EntryPoint = "glBlitFramebuffer")]
        public partial void BlitFramebuffer([Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] BlitFramebufferFilter filter);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glClearBufferiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glClearBufferuiv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public unsafe partial void ClearBuffer([Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glClearBufferfv")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Count(Computed = "buffer"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glClearBufferfi")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] GLEnum buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClearBufferfi")]
        public partial void ClearBuffer([Flow(FlowDirection.In)] BufferKind buffer, [Flow(FlowDirection.In)] int drawbuffer, [Flow(FlowDirection.In)] float depth, [Flow(FlowDirection.In)] int stencil);

        [NativeApi(EntryPoint = "glClientWaitSync")]
        public partial GLEnum ClientWaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public unsafe partial void CompressedTexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage3D")]
        public partial void CompressedTexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public unsafe partial void CompressedTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage3D")]
        public partial void CompressedTexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] GLEnum readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] GLEnum writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyBufferSubData")]
        public partial void CopyBufferSubData([Flow(FlowDirection.In)] CopyBufferSubDataTarget readTarget, [Flow(FlowDirection.In)] CopyBufferSubDataTarget writeTarget, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public partial void CopyTexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTexSubImage3D")]
        public partial void CopyTexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public unsafe partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint ids);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public unsafe partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Query* ids);

        [NativeApi(EntryPoint = "glDeleteQueries")]
        public partial void DeleteQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Query ids);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public unsafe partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public unsafe partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Sampler* samplers);

        [NativeApi(EntryPoint = "glDeleteSamplers")]
        public partial void DeleteSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Sampler samplers);

        [NativeApi(EntryPoint = "glDeleteSync")]
        public partial void DeleteSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public unsafe partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public unsafe partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] TransformFeedback* ids);

        [NativeApi(EntryPoint = "glDeleteTransformFeedbacks")]
        public partial void DeleteTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in TransformFeedback ids);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public unsafe partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public unsafe partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] VertexArray* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays")]
        public partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in VertexArray arrays);

        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawArraysInstanced")]
        public partial void DrawArraysInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] GLEnum* bufs);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in GLEnum bufs);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public unsafe partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] DrawBufferMode* bufs);

        [NativeApi(EntryPoint = "glDrawBuffers")]
        public partial void DrawBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in DrawBufferMode bufs);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public unsafe partial void DrawElementsInstanced([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount);

        [NativeApi(EntryPoint = "glDrawElementsInstanced")]
        public partial void DrawElementsInstanced<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public unsafe partial void DrawRangeElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public partial void DrawRangeElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public unsafe partial void DrawRangeElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public partial void DrawRangeElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public unsafe partial void DrawRangeElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public partial void DrawRangeElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public unsafe partial void DrawRangeElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawRangeElements")]
        public partial void DrawRangeElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glEndQuery")]
        public partial void EndQuery([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glEndQuery")]
        public partial void EndQuery([Flow(FlowDirection.In)] QueryTarget target);

        [NativeApi(EntryPoint = "glEndTransformFeedback")]
        public partial void EndTransformFeedback();

        [NativeApi(EntryPoint = "glFenceSync")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] GLEnum condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFenceSync")]
        public partial IntPtr FenceSync([Flow(FlowDirection.In)] SyncCondition condition, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glFlushMappedBufferRange")]
        public partial void FlushMappedBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glFramebufferTextureLayer")]
        public partial void FramebufferTextureLayer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int layer);

        [NativeApi(EntryPoint = "glGenQueries")]
        public unsafe partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenQueries")]
        public partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glGenQueries")]
        public unsafe partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Query* ids);

        [NativeApi(EntryPoint = "glGenQueries")]
        public partial void GenQueries([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Query ids);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public unsafe partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out uint samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public unsafe partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Sampler* samplers);

        [NativeApi(EntryPoint = "glGenSamplers")]
        public partial void GenSamplers([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out Sampler samplers);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public unsafe partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public unsafe partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] TransformFeedback* ids);

        [NativeApi(EntryPoint = "glGenTransformFeedbacks")]
        public partial void GenTransformFeedbacks([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out TransformFeedback ids);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public unsafe partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public unsafe partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] VertexArray* arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays")]
        public partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out VertexArray arrays);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public unsafe partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public unsafe partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockiv")]
        public partial void GetActiveUniformBlock([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] UniformBlockPName pname, [Count(Computed = "program, uniformBlockIndex, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public unsafe partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public unsafe partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public unsafe partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public unsafe partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformBlockName")]
        public partial void GetActiveUniformBlockName([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string uniformBlockName);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] in uint uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] in uint uniformIndices, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] uint* uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public unsafe partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] in uint uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveUniformsiv")]
        public partial void GetActiveUniforms([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Parameter = "uniformCount"), Flow(FlowDirection.In)] in uint uniformIndices, [Flow(FlowDirection.In)] UniformPName pname, [Count(Computed = "uniformCount, pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteri64v")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetBufferPointerv")]
        public unsafe partial void GetBufferPointer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPointerNameARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public unsafe partial int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public partial int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetFragDataLocation")]
        public partial int GetFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public partial void GetInteger([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegeri_v")]
        public partial void GetInteger([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public unsafe partial void GetInteger64([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] long* data);

        [NativeApi(EntryPoint = "glGetInteger64i_v")]
        public partial void GetInteger64([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out long data);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public unsafe partial void GetProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] void* binary);

        [NativeApi(EntryPoint = "glGetProgramBinary")]
        public partial void GetProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum binaryFormat, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out T0 binary) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public partial void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public partial void GetQuery([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public unsafe partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetQueryiv")]
        public partial void GetQuery([Flow(FlowDirection.In)] QueryTarget target, [Flow(FlowDirection.In)] QueryParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public unsafe partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetQueryObjectuiv")]
        public partial void GetQueryObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameteriv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public unsafe partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetSamplerParameterfv")]
        public partial void GetSamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetStringi")]
        public unsafe partial byte* GetString([Flow(FlowDirection.In)] GLEnum name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetStringi")]
        public partial string GetStringS([Flow(FlowDirection.In)] GLEnum name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetStringi")]
        public unsafe partial byte* GetString([Flow(FlowDirection.In)] StringName name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetStringi")]
        public partial string GetStringS([Flow(FlowDirection.In)] StringName name, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public unsafe partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values);

        [NativeApi(EntryPoint = "glGetSynciv")]
        public partial void GetSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int values);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] uint* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public unsafe partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetTransformFeedbackVarying")]
        public partial void GetTransformFeedbackVarying([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out uint size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetUniformuiv")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public unsafe partial uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] byte* uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public partial uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Count(Count = 0), Flow(FlowDirection.In)] in byte uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformBlockIndex")]
        public partial uint GetUniformBlockIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string uniformBlockName);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public unsafe partial void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public unsafe partial void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] byte** uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public unsafe partial void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] in byte* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices);

        [NativeApi(EntryPoint = "glGetUniformIndices")]
        public unsafe partial void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] in byte* uniformNames, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuiv")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public unsafe partial void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public partial void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in GLEnum attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public unsafe partial void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public partial void InvalidateFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in InvalidateFramebufferAttachment attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public unsafe partial void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public partial void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in GLEnum attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public unsafe partial void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glInvalidateFramebuffer")]
        public partial void InvalidateFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in InvalidateFramebufferAttachment attachments);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public unsafe partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in GLEnum attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public unsafe partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in InvalidateFramebufferAttachment attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public unsafe partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] GLEnum* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in GLEnum attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public unsafe partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glInvalidateSubFramebuffer")]
        public partial void InvalidateSubFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] in InvalidateFramebufferAttachment attachments, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glIsQuery")]
        public partial bool IsQuery([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glIsSampler")]
        public partial bool IsSampler([Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glIsSync")]
        public partial bool IsSync([Flow(FlowDirection.In)] IntPtr sync);

        [NativeApi(EntryPoint = "glIsTransformFeedback")]
        public partial bool IsTransformFeedback([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glIsVertexArray")]
        public partial bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glMapBufferRange")]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glMapBufferRange")]
        public unsafe partial void* MapBufferRange([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr length, [Flow(FlowDirection.In)] uint access);

        [NativeApi(EntryPoint = "glPauseTransformFeedback")]
        public partial void PauseTransformFeedback();

        [NativeApi(EntryPoint = "glProgramBinary")]
        public unsafe partial void ProgramBinary([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glProgramBinary")]
        public partial void ProgramBinary<T0>([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glProgramParameteri")]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glProgramParameteri")]
        public partial void ProgramParameter([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramParameterPName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glReadBuffer")]
        public partial void ReadBuffer([Flow(FlowDirection.In)] GLEnum src);

        [NativeApi(EntryPoint = "glReadBuffer")]
        public partial void ReadBuffer([Flow(FlowDirection.In)] ReadBufferMode src);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisample")]
        public partial void RenderbufferStorageMultisample([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glResumeTransformFeedback")]
        public partial void ResumeTransformFeedback();

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteri")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* param);

        [NativeApi(EntryPoint = "glSamplerParameteriv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterf")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public unsafe partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* param);

        [NativeApi(EntryPoint = "glSamplerParameterfv")]
        public partial void SamplerParameter([Flow(FlowDirection.In)] uint sampler, [Flow(FlowDirection.In)] SamplerParameterF pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float param);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage3D")]
        public unsafe partial void TexImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage3D")]
        public partial void TexImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public partial void TexStorage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public partial void TexStorage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public partial void TexStorage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage2D")]
        public partial void TexStorage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public partial void TexStorage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public partial void TexStorage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public partial void TexStorage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTexStorage3D")]
        public partial void TexStorage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint levels, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public unsafe partial void TexSubImage3D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage3D")]
        public partial void TexSubImage3D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height, depth"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** varyings, [Flow(FlowDirection.In)] GLEnum bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* varyings, [Flow(FlowDirection.In)] GLEnum bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** varyings, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        [NativeApi(EntryPoint = "glTransformFeedbackVaryings")]
        public unsafe partial void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* varyings, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode);

        [NativeApi(EntryPoint = "glUniform1ui")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0);

        [NativeApi(EntryPoint = "glUniform1uiv")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform1uiv")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glUniform2ui")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1);

        [NativeApi(EntryPoint = "glUniform2uiv")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform2uiv")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glUniform3ui")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2);

        [NativeApi(EntryPoint = "glUniform3uiv")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform3uiv")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glUniform4ui")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint v0, [Flow(FlowDirection.In)] uint v1, [Flow(FlowDirection.In)] uint v2, [Flow(FlowDirection.In)] uint v3);

        [NativeApi(EntryPoint = "glUniform4uiv")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* value);

        [NativeApi(EntryPoint = "glUniform4uiv")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint value);

        [NativeApi(EntryPoint = "glUniformBlockBinding")]
        public partial void UniformBlockBinding([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformBlockIndex, [Flow(FlowDirection.In)] uint uniformBlockBinding);

        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public unsafe partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x3fv")]
        public partial void UniformMatrix2x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public unsafe partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2x4fv")]
        public partial void UniformMatrix2x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public unsafe partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x2fv")]
        public partial void UniformMatrix3x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public unsafe partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3x4fv")]
        public partial void UniformMatrix3x4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public unsafe partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x2fv")]
        public partial void UniformMatrix4x2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public unsafe partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4x3fv")]
        public partial void UniformMatrix4x3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public partial bool UnmapBuffer([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glUnmapBuffer")]
        public partial bool UnmapBuffer([Flow(FlowDirection.In)] BufferTargetARB target);

        [NativeApi(EntryPoint = "glVertexAttribDivisor")]
        public partial void VertexAttribDivisor([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint divisor);

        [NativeApi(EntryPoint = "glVertexAttribI4i")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexAttribI4ui")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI4iv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI4uiv")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in uint v);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public unsafe partial void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public partial void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public unsafe partial void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointer")]
        public partial void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glWaitSync")]
        public partial void WaitSync([Flow(FlowDirection.In)] IntPtr sync, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] ulong timeout);

        [NativeApi(EntryPoint = "glActiveTexture")]
        public partial void ActiveTexture([Flow(FlowDirection.In)] GLEnum texture);

        [NativeApi(EntryPoint = "glActiveTexture")]
        public partial void ActiveTexture([Flow(FlowDirection.In)] TextureUnit texture);

        [NativeApi(EntryPoint = "glAttachShader")]
        public partial void AttachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public unsafe partial void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public partial void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glBindAttribLocation")]
        public partial void BindAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBindBuffer")]
        public partial void BindBuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindBuffer")]
        public partial void BindBuffer([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public partial void BindFramebuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindFramebuffer")]
        public partial void BindFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public partial void BindRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBindRenderbuffer")]
        public partial void BindRenderbuffer([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glBindTexture")]
        public partial void BindTexture([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBindTexture")]
        public partial void BindTexture([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glBlendColor")]
        public partial void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public partial void BlendEquation([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public partial void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] GLEnum modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] GLEnum modeAlpha);

        [NativeApi(EntryPoint = "glBlendEquationSeparate")]
        public partial void BlendEquationSeparate([Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunc")]
        public partial void BlendFunc([Flow(FlowDirection.In)] GLEnum sfactor, [Flow(FlowDirection.In)] GLEnum dfactor);

        [NativeApi(EntryPoint = "glBlendFunc")]
        public partial void BlendFunc([Flow(FlowDirection.In)] GLEnum sfactor, [Flow(FlowDirection.In)] BlendingFactor dfactor);

        [NativeApi(EntryPoint = "glBlendFunc")]
        public partial void BlendFunc([Flow(FlowDirection.In)] BlendingFactor sfactor, [Flow(FlowDirection.In)] GLEnum dfactor);

        [NativeApi(EntryPoint = "glBlendFunc")]
        public partial void BlendFunc([Flow(FlowDirection.In)] BlendingFactor sfactor, [Flow(FlowDirection.In)] BlendingFactor dfactor);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] GLEnum sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] GLEnum dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] GLEnum sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] GLEnum dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparate")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBufferData")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferData")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferData")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] GLEnum usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] GLEnum usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferData")]
        public unsafe partial void BufferData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data, [Flow(FlowDirection.In)] BufferUsageARB usage);

        [NativeApi(EntryPoint = "glBufferData")]
        public partial void BufferData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data, [Flow(FlowDirection.In)] BufferUsageARB usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubData")]
        public unsafe partial void BufferSubData([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubData")]
        public partial void BufferSubData<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBufferSubData")]
        public unsafe partial void BufferSubData([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glBufferSubData")]
        public partial void BufferSubData<T0>([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public partial GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glCheckFramebufferStatus")]
        public partial GLEnum CheckFramebufferStatus([Flow(FlowDirection.In)] FramebufferTarget target);

        [NativeApi(EntryPoint = "glClear")]
        public partial void Clear([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glClearColor")]
        public partial void ClearColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glClearDepthf")]
        public partial void ClearDepth([Flow(FlowDirection.In)] float d);

        [NativeApi(EntryPoint = "glClearStencil")]
        public partial void ClearStencil([Flow(FlowDirection.In)] int s);

        [NativeApi(EntryPoint = "glColorMask")]
        public partial void ColorMask([Flow(FlowDirection.In)] bool red, [Flow(FlowDirection.In)] bool green, [Flow(FlowDirection.In)] bool blue, [Flow(FlowDirection.In)] bool alpha);

        [NativeApi(EntryPoint = "glCompileShader")]
        public partial void CompileShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public unsafe partial void CompressedTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public partial void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public unsafe partial void CompressedTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public partial void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public unsafe partial void CompressedTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public partial void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public unsafe partial void CompressedTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexImage2D")]
        public partial void CompressedTexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public unsafe partial void CompressedTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public partial void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public unsafe partial void CompressedTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public partial void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public unsafe partial void CompressedTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public partial void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public unsafe partial void CompressedTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glCompressedTexSubImage2D")]
        public partial void CompressedTexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] uint imageSize, [Count(Parameter = "imageSize"), Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public partial void CopyTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public partial void CopyTexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public partial void CopyTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexImage2D")]
        public partial void CopyTexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border);

        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public partial void CopyTexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCopyTexSubImage2D")]
        public partial void CopyTexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glCreateProgram")]
        public partial uint CreateProgram();

        [NativeApi(EntryPoint = "glCreateShader")]
        public partial uint CreateShader([Flow(FlowDirection.In)] GLEnum type);

        [NativeApi(EntryPoint = "glCreateShader")]
        public partial uint CreateShader([Flow(FlowDirection.In)] ShaderType type);

        [NativeApi(EntryPoint = "glCullFace")]
        public partial void CullFace([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glCullFace")]
        public partial void CullFace([Flow(FlowDirection.In)] CullFaceMode mode);

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public unsafe partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint buffers);

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public unsafe partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Buffer* buffers);

        [NativeApi(EntryPoint = "glDeleteBuffers")]
        public partial void DeleteBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Buffer buffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public unsafe partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public unsafe partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Framebuffer* framebuffers);

        [NativeApi(EntryPoint = "glDeleteFramebuffers")]
        public partial void DeleteFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Framebuffer framebuffers);

        [NativeApi(EntryPoint = "glDeleteProgram")]
        public partial void DeleteProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public unsafe partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public unsafe partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Renderbuffer* renderbuffers);

        [NativeApi(EntryPoint = "glDeleteRenderbuffers")]
        public partial void DeleteRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Renderbuffer renderbuffers);

        [NativeApi(EntryPoint = "glDeleteShader")]
        public partial void DeleteShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public unsafe partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* textures);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint textures);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public unsafe partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Texture* textures);

        [NativeApi(EntryPoint = "glDeleteTextures")]
        public partial void DeleteTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in Texture textures);

        [NativeApi(EntryPoint = "glDepthFunc")]
        public partial void DepthFunc([Flow(FlowDirection.In)] GLEnum func);

        [NativeApi(EntryPoint = "glDepthFunc")]
        public partial void DepthFunc([Flow(FlowDirection.In)] DepthFunction func);

        [NativeApi(EntryPoint = "glDepthMask")]
        public partial void DepthMask([Flow(FlowDirection.In)] bool flag);

        [NativeApi(EntryPoint = "glDepthRangef")]
        public partial void DepthRange([Flow(FlowDirection.In)] float n, [Flow(FlowDirection.In)] float f);

        [NativeApi(EntryPoint = "glDetachShader")]
        public partial void DetachShader([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glDisable")]
        public partial void Disable([Flow(FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glDisable")]
        public partial void Disable([Flow(FlowDirection.In)] EnableCap cap);

        [NativeApi(EntryPoint = "glDisableVertexAttribArray")]
        public partial void DisableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDrawArrays")]
        public partial void DrawArrays([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawArrays")]
        public partial void DrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElements")]
        public unsafe partial void DrawElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public partial void DrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElements")]
        public unsafe partial void DrawElements([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public partial void DrawElements<T0>([Flow(FlowDirection.In)] GLEnum mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElements")]
        public unsafe partial void DrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public partial void DrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElements")]
        public unsafe partial void DrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices);

        [NativeApi(EntryPoint = "glDrawElements")]
        public partial void DrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glEnable")]
        public partial void Enable([Flow(FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glEnable")]
        public partial void Enable([Flow(FlowDirection.In)] EnableCap cap);

        [NativeApi(EntryPoint = "glEnableVertexAttribArray")]
        public partial void EnableVertexAttribArray([Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glFinish")]
        public partial void Finish();

        [NativeApi(EntryPoint = "glFlush")]
        public partial void Flush();

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferRenderbuffer")]
        public partial void FramebufferRenderbuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] RenderbufferTarget renderbuffertarget, [Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFramebufferTexture2D")]
        public partial void FramebufferTexture2D([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] TextureTarget textarget, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "glFrontFace")]
        public partial void FrontFace([Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glFrontFace")]
        public partial void FrontFace([Flow(FlowDirection.In)] FrontFaceDirection mode);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public unsafe partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* buffers);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint buffers);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public unsafe partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Buffer* buffers);

        [NativeApi(EntryPoint = "glGenBuffers")]
        public partial void GenBuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Buffer buffers);

        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public partial void GenerateMipmap([Flow(FlowDirection.In)] GLEnum target);

        [NativeApi(EntryPoint = "glGenerateMipmap")]
        public partial void GenerateMipmap([Flow(FlowDirection.In)] TextureTarget target);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public unsafe partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public unsafe partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Framebuffer* framebuffers);

        [NativeApi(EntryPoint = "glGenFramebuffers")]
        public partial void GenFramebuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Framebuffer framebuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public unsafe partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public unsafe partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Renderbuffer* renderbuffers);

        [NativeApi(EntryPoint = "glGenRenderbuffers")]
        public partial void GenRenderbuffers([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Renderbuffer renderbuffers);

        [NativeApi(EntryPoint = "glGenTextures")]
        public unsafe partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* textures);

        [NativeApi(EntryPoint = "glGenTextures")]
        public partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint textures);

        [NativeApi(EntryPoint = "glGenTextures")]
        public unsafe partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Texture* textures);

        [NativeApi(EntryPoint = "glGenTextures")]
        public partial void GenTextures([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out Texture textures);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] AttributeType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public unsafe partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveAttrib")]
        public partial void GetActiveAttrib([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out AttributeType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] GLEnum* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out GLEnum type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] int* size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] UniformType* type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public unsafe partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte name);

        [NativeApi(EntryPoint = "glGetActiveUniform")]
        public partial void GetActiveUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Count = 1), Flow(FlowDirection.Out)] out int size, [Count(Count = 1), Flow(FlowDirection.Out)] out UniformType type, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string name);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public unsafe partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public unsafe partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out uint shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public unsafe partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] uint* shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out uint shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public unsafe partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Shader* shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public unsafe partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out Shader shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public unsafe partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] Shader* shaders);

        [NativeApi(EntryPoint = "glGetAttachedShaders")]
        public partial void GetAttachedShaders([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(FlowDirection.Out)] out uint count, [Count(Parameter = "maxCount"), Flow(FlowDirection.Out)] out Shader shaders);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public unsafe partial int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public partial int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetAttribLocation")]
        public partial int GetAttribLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public unsafe partial void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleanv")]
        public partial void GetBoolean([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public unsafe partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetBufferParameteriv")]
        public partial void GetBufferParameter([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] BufferPNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetError")]
        public partial GLEnum GetError();

        [NativeApi(EntryPoint = "glGetFloatv")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public partial void GetFloat([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public unsafe partial void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* data);

        [NativeApi(EntryPoint = "glGetFloatv")]
        public partial void GetFloat([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float data);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] GLEnum attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public unsafe partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetFramebufferAttachmentParameteriv")]
        public partial void GetFramebufferAttachmentParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachment attachment, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public partial void GetInteger([Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public unsafe partial void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerv")]
        public partial void GetInteger([Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public unsafe partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetProgramiv")]
        public partial void GetProgram([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramPropertyARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public unsafe partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public unsafe partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public unsafe partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public unsafe partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetProgramInfoLog")]
        public partial void GetProgramInfoLog([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public unsafe partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetRenderbufferParameteriv")]
        public partial void GetRenderbufferParameter([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] RenderbufferParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public unsafe partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public unsafe partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetShaderiv")]
        public partial void GetShader([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] ShaderParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public unsafe partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public unsafe partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public unsafe partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public unsafe partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte infoLog);

        [NativeApi(EntryPoint = "glGetShaderInfoLog")]
        public partial void GetShaderInfoLog([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string infoLog);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] GLEnum shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] GLEnum precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] int* range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public unsafe partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] int* precision);

        [NativeApi(EntryPoint = "glGetShaderPrecisionFormat")]
        public partial void GetShaderPrecisionFormat([Flow(FlowDirection.In)] ShaderType shadertype, [Flow(FlowDirection.In)] PrecisionType precisiontype, [Count(Count = 2), Flow(FlowDirection.Out)] out int range, [Count(Count = 1), Flow(FlowDirection.Out)] out int precision);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public unsafe partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out byte source);

        [NativeApi(EntryPoint = "glGetShaderSource")]
        public partial void GetShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string source);

        [NativeApi(EntryPoint = "glGetString")]
        public unsafe partial byte* GetString([Flow(FlowDirection.In)] GLEnum name);

        [NativeApi(EntryPoint = "glGetString")]
        public partial string GetStringS([Flow(FlowDirection.In)] GLEnum name);

        [NativeApi(EntryPoint = "glGetString")]
        public unsafe partial byte* GetString([Flow(FlowDirection.In)] StringName name);

        [NativeApi(EntryPoint = "glGetString")]
        public partial string GetStringS([Flow(FlowDirection.In)] StringName name);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetTexParameterfv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public unsafe partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetTexParameteriv")]
        public partial void GetTexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GetTextureParameter pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformfv")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetUniformfv")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetUniformiv")]
        public unsafe partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetUniformiv")]
        public partial void GetUniform([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Count(Computed = "program, location"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public unsafe partial int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public partial int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetUniformLocation")]
        public partial int GetUniformLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribfv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public unsafe partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribiv")]
        public partial void GetVertexAttrib([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPropertyARB pname, [Count(Count = 4), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] GLEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** pointer);

        [NativeApi(EntryPoint = "glGetVertexAttribPointerv")]
        public unsafe partial void GetVertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribPointerPropertyARB pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* pointer);

        [NativeApi(EntryPoint = "glHint")]
        public partial void Hint([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glHint")]
        public partial void Hint([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] HintMode mode);

        [NativeApi(EntryPoint = "glHint")]
        public partial void Hint([Flow(FlowDirection.In)] HintTarget target, [Flow(FlowDirection.In)] GLEnum mode);

        [NativeApi(EntryPoint = "glHint")]
        public partial void Hint([Flow(FlowDirection.In)] HintTarget target, [Flow(FlowDirection.In)] HintMode mode);

        [NativeApi(EntryPoint = "glIsBuffer")]
        public partial bool IsBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glIsEnabled")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] GLEnum cap);

        [NativeApi(EntryPoint = "glIsEnabled")]
        public partial bool IsEnabled([Flow(FlowDirection.In)] EnableCap cap);

        [NativeApi(EntryPoint = "glIsFramebuffer")]
        public partial bool IsFramebuffer([Flow(FlowDirection.In)] uint framebuffer);

        [NativeApi(EntryPoint = "glIsProgram")]
        public partial bool IsProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glIsRenderbuffer")]
        public partial bool IsRenderbuffer([Flow(FlowDirection.In)] uint renderbuffer);

        [NativeApi(EntryPoint = "glIsShader")]
        public partial bool IsShader([Flow(FlowDirection.In)] uint shader);

        [NativeApi(EntryPoint = "glIsTexture")]
        public partial bool IsTexture([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glLineWidth")]
        public partial void LineWidth([Flow(FlowDirection.In)] float width);

        [NativeApi(EntryPoint = "glLinkProgram")]
        public partial void LinkProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glPixelStorei")]
        public partial void PixelStore([Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPixelStorei")]
        public partial void PixelStore([Flow(FlowDirection.In)] PixelStoreParameter pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPolygonOffset")]
        public partial void PolygonOffset([Flow(FlowDirection.In)] float factor, [Flow(FlowDirection.In)] float units);

        [NativeApi(EntryPoint = "glReadPixels")]
        public unsafe partial void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public partial void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadPixels")]
        public unsafe partial void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public partial void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadPixels")]
        public unsafe partial void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public partial void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReadPixels")]
        public unsafe partial void ReadPixels([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] void* pixels);

        [NativeApi(EntryPoint = "glReadPixels")]
        public partial void ReadPixels<T0>([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.Out)] out T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glReleaseShaderCompiler")]
        public partial void ReleaseShaderCompiler();

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] GLEnum internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorage")]
        public partial void RenderbufferStorage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glSampleCoverage")]
        public partial void SampleCoverage([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        [NativeApi(EntryPoint = "glScissor")]
        public partial void Scissor([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in uint shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] GLEnum binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Shader* shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderBinary")]
        public unsafe partial void ShaderBinary([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* binary, [Flow(FlowDirection.In)] uint length);

        [NativeApi(EntryPoint = "glShaderBinary")]
        public partial void ShaderBinary<T0>([Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in Shader shaders, [Flow(FlowDirection.In)] ShaderBinaryFormat binaryFormat, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 binary, [Flow(FlowDirection.In)] uint length) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glShaderSource")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glShaderSource")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int length);

        [NativeApi(EntryPoint = "glShaderSource")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glShaderSource")]
        public unsafe partial void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in byte* @string, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int length);

        [NativeApi(EntryPoint = "glStencilFunc")]
        public partial void StencilFunc([Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFunc")]
        public partial void StencilFunc([Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] GLEnum func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparate")]
        public partial void StencilFuncSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilFunction func, [Flow(FlowDirection.In)] int @ref, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMask")]
        public partial void StencilMask([Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public partial void StencilMaskSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilMaskSeparate")]
        public partial void StencilMaskSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] GLEnum zpass);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] StencilOp zpass);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] GLEnum zpass);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] GLEnum fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] StencilOp zpass);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] GLEnum zpass);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] GLEnum zfail, [Flow(FlowDirection.In)] StencilOp zpass);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] GLEnum zpass);

        [NativeApi(EntryPoint = "glStencilOp")]
        public partial void StencilOp([Flow(FlowDirection.In)] StencilOp fail, [Flow(FlowDirection.In)] StencilOp zfail, [Flow(FlowDirection.In)] StencilOp zpass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] GLEnum face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] GLEnum sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] GLEnum dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] GLEnum dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparate")]
        public partial void StencilOpSeparate([Flow(FlowDirection.In)] StencilFaceDirection face, [Flow(FlowDirection.In)] StencilOp sfail, [Flow(FlowDirection.In)] StencilOp dpfail, [Flow(FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexImage2D")]
        public unsafe partial void TexImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexImage2D")]
        public partial void TexImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] int border, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexParameterf")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterf")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterf")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterf")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] float param);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glTexParameterfv")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteri")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public partial void TexParameter([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] GLEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public unsafe partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glTexParameteriv")]
        public partial void TexParameter([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] TextureParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] GLEnum target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] GLEnum format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] GLEnum type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public unsafe partial void TexSubImage2D([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] void* pixels);

        [NativeApi(EntryPoint = "glTexSubImage2D")]
        public partial void TexSubImage2D<T0>([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width, height"), Flow(FlowDirection.In)] in T0 pixels) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUniform1f")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0);

        [NativeApi(EntryPoint = "glUniform1fv")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform1fv")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniform1i")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0);

        [NativeApi(EntryPoint = "glUniform1iv")]
        public unsafe partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform1iv")]
        public partial void Uniform1([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glUniform2f")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1);

        [NativeApi(EntryPoint = "glUniform2fv")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform2fv")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniform2i")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1);

        [NativeApi(EntryPoint = "glUniform2iv")]
        public unsafe partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform2iv")]
        public partial void Uniform2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glUniform3f")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2);

        [NativeApi(EntryPoint = "glUniform3fv")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform3fv")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniform3i")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2);

        [NativeApi(EntryPoint = "glUniform3iv")]
        public unsafe partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform3iv")]
        public partial void Uniform3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glUniform4f")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] float v0, [Flow(FlowDirection.In)] float v1, [Flow(FlowDirection.In)] float v2, [Flow(FlowDirection.In)] float v3);

        [NativeApi(EntryPoint = "glUniform4fv")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniform4fv")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniform4i")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] int v0, [Flow(FlowDirection.In)] int v1, [Flow(FlowDirection.In)] int v2, [Flow(FlowDirection.In)] int v3);

        [NativeApi(EntryPoint = "glUniform4iv")]
        public unsafe partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* value);

        [NativeApi(EntryPoint = "glUniform4iv")]
        public partial void Uniform4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int value);

        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public unsafe partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix2fv")]
        public partial void UniformMatrix2([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public unsafe partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix3fv")]
        public partial void UniformMatrix3([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public unsafe partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glUniformMatrix4fv")]
        public partial void UniformMatrix4([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] bool transpose, [Count(Parameter = "count"), Flow(FlowDirection.In)] in float value);

        [NativeApi(EntryPoint = "glUseProgram")]
        public partial void UseProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glValidateProgram")]
        public partial void ValidateProgram([Flow(FlowDirection.In)] uint program);

        [NativeApi(EntryPoint = "glVertexAttrib1f")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x);

        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public unsafe partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib1fv")]
        public partial void VertexAttrib1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib2f")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public unsafe partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib2fv")]
        public partial void VertexAttrib2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib3f")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public unsafe partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib3fv")]
        public partial void VertexAttrib3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttrib4f")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public unsafe partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glVertexAttrib4fv")]
        public partial void VertexAttrib4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public unsafe partial void VertexAttribPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribPointer")]
        public partial void VertexAttribPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glViewport")]
        public partial void Viewport([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [System.Obsolete("Deprecated in version 3.2")]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] GLEnum type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            SilkMarshal.Free((IntPtr) strings);
            return ret;
        }

        public unsafe uint CreateShaderProgram([Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] stringsSa)
        {
            // StringArrayOverloader
            var strings = (byte**) SilkMarshal.StringArrayToPtr(stringsSa);
            var ret = CreateShaderProgram(type, count, strings);
            SilkMarshal.CopyPtrToStringArray((IntPtr) strings, stringsSa);
            SilkMarshal.Free((IntPtr) strings);
            return ret;
        }

        public unsafe void DeleteProgramPipeline([Count(Parameter = "n"), Flow(FlowDirection.In)] uint pipelines)
        {
            // ArrayParameterOverloader
            DeleteProgramPipelines(1, &pipelines);
        }

        public unsafe uint GenProgramPipeline()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenProgramPipelines(n, &ret);
            return ret;
        }

        public unsafe void DeleteQuery([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteQueries(1, &ids);
        }

        public unsafe void DeleteSampler([Count(Parameter = "count"), Flow(FlowDirection.In)] uint samplers)
        {
            // ArrayParameterOverloader
            DeleteSamplers(1, &samplers);
        }

        public unsafe void DeleteTransformFeedback([Count(Parameter = "n"), Flow(FlowDirection.In)] uint ids)
        {
            // ArrayParameterOverloader
            DeleteTransformFeedbacks(1, &ids);
        }

        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        public unsafe uint GenQuery()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenQueries(n, &ret);
            return ret;
        }

        public unsafe uint GenSampler()
        {
            const uint count = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenSamplers(count, &ret);
            return ret;
        }

        public unsafe uint GenTransformFeedback()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTransformFeedbacks(n, &ret);
            return ret;
        }

        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public unsafe long GetInteger64([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            long ret = default;
            GetInteger64(pname, &ret);
            return ret;
        }

        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] uint* uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (byte**) SilkMarshal.StringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
            SilkMarshal.CopyPtrToStringArray((IntPtr) uniformNames, uniformNamesSa);
            SilkMarshal.Free((IntPtr) uniformNames);
        }

        public unsafe void GetUniformIndices([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint uniformCount, [Count(Computed = "uniformCount"), Flow(FlowDirection.In)] string[] uniformNamesSa, [Count(Computed = "uniformCount"), Flow(FlowDirection.Out)] out uint uniformIndices)
        {
            // StringArrayOverloader
            var uniformNames = (byte**) SilkMarshal.StringArrayToPtr(uniformNamesSa);
            GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices);
            SilkMarshal.CopyPtrToStringArray((IntPtr) uniformNames, uniformNamesSa);
            SilkMarshal.Free((IntPtr) uniformNames);
        }

        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] GLEnum bufferMode)
        {
            // StringArrayOverloader
            var varyings = (byte**) SilkMarshal.StringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
            SilkMarshal.Free((IntPtr) varyings);
        }

        public unsafe void TransformFeedbackVaryings([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] varyingsSa, [Flow(FlowDirection.In)] TransformFeedbackBufferMode bufferMode)
        {
            // StringArrayOverloader
            var varyings = (byte**) SilkMarshal.StringArrayToPtr(varyingsSa);
            TransformFeedbackVaryings(program, count, varyings, bufferMode);
            SilkMarshal.CopyPtrToStringArray((IntPtr) varyings, varyingsSa);
            SilkMarshal.Free((IntPtr) varyings);
        }

        public unsafe void DeleteBuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint buffers)
        {
            // ArrayParameterOverloader
            DeleteBuffers(1, &buffers);
        }

        public unsafe void DeleteFramebuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint framebuffers)
        {
            // ArrayParameterOverloader
            DeleteFramebuffers(1, &framebuffers);
        }

        public unsafe void DeleteRenderbuffer([Count(Parameter = "n"), Flow(FlowDirection.In)] uint renderbuffers)
        {
            // ArrayParameterOverloader
            DeleteRenderbuffers(1, &renderbuffers);
        }

        public unsafe void DeleteTexture([Count(Parameter = "n"), Flow(FlowDirection.In)] uint textures)
        {
            // ArrayParameterOverloader
            DeleteTextures(1, &textures);
        }

        public unsafe uint GenBuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenBuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenFramebuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFramebuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenRenderbuffer()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenRenderbuffers(n, &ret);
            return ret;
        }

        public unsafe uint GenTexture()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenTextures(n, &ret);
            return ret;
        }

        public unsafe bool GetBoolean([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            bool ret = default;
            GetBoolean(pname, &ret);
            return ret;
        }

        public unsafe float GetFloat([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            float ret = default;
            GetFloat(pname, &ret);
            return ret;
        }

        public unsafe int GetInteger([Flow(FlowDirection.In)] GLEnum pname)
        {
            // ReturnTypeOverloader
            int ret = default;
            GetInteger(pname, &ret);
            return ret;
        }

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.StringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
            SilkMarshal.Free((IntPtr) @string);
        }

        public unsafe void ShaderSource([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] @stringSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] in int length)
        {
            // StringArrayOverloader
            var @string = (byte**) SilkMarshal.StringArrayToPtr(@stringSa);
            ShaderSource(shader, count, @string, in length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) @string, @stringSa);
            SilkMarshal.Free((IntPtr) @string);
        }


        public GL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

