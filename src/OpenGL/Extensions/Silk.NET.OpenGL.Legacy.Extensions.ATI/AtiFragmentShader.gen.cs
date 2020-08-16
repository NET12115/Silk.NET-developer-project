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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_fragment_shader")]
    public unsafe partial class AtiFragmentShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_fragment_shader";
        [NativeApi(EntryPoint = "glAlphaFragmentOp1ATI")]
        public partial void AlphaFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        [NativeApi(EntryPoint = "glAlphaFragmentOp2ATI")]
        public partial void AlphaFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        [NativeApi(EntryPoint = "glAlphaFragmentOp3ATI")]
        public partial void AlphaFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        [NativeApi(EntryPoint = "glBeginFragmentShaderATI")]
        public partial void BeginFragmentShader();

        [NativeApi(EntryPoint = "glBindFragmentShaderATI")]
        public partial void BindFragmentShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glColorFragmentOp1ATI")]
        public partial void ColorFragmentOp1([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        [NativeApi(EntryPoint = "glColorFragmentOp2ATI")]
        public partial void ColorFragmentOp2([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        [NativeApi(EntryPoint = "glColorFragmentOp3ATI")]
        public partial void ColorFragmentOp3([Flow(FlowDirection.In)] ATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        [NativeApi(EntryPoint = "glDeleteFragmentShaderATI")]
        public partial void DeleteFragmentShader([Flow(FlowDirection.In)] uint id);

        [NativeApi(EntryPoint = "glEndFragmentShaderATI")]
        public partial void EndFragmentShader();

        [NativeApi(EntryPoint = "glGenFragmentShadersATI")]
        public partial uint GenFragmentShaders([Flow(FlowDirection.In)] uint range);

        [NativeApi(EntryPoint = "glPassTexCoordATI")]
        public partial void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] ATI swizzle);

        [NativeApi(EntryPoint = "glSampleMapATI")]
        public partial void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] ATI swizzle);

        [NativeApi(EntryPoint = "glSetFragmentShaderConstantATI")]
        public unsafe partial void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] float* value);

        [NativeApi(EntryPoint = "glSetFragmentShaderConstantATI")]
        public partial void SetFragmentShaderConstant([Flow(FlowDirection.In)] uint dst, [Count(Count = 4), Flow(FlowDirection.In)] Span<float> value);

        [NativeApi(EntryPoint = "glAlphaFragmentOp1ATI")]
        public partial void AlphaFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        [NativeApi(EntryPoint = "glAlphaFragmentOp2ATI")]
        public partial void AlphaFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        [NativeApi(EntryPoint = "glAlphaFragmentOp3ATI")]
        public partial void AlphaFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        [NativeApi(EntryPoint = "glColorFragmentOp1ATI")]
        public partial void ColorFragmentOp1([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod);

        [NativeApi(EntryPoint = "glColorFragmentOp2ATI")]
        public partial void ColorFragmentOp2([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod);

        [NativeApi(EntryPoint = "glColorFragmentOp3ATI")]
        public partial void ColorFragmentOp3([Flow(FlowDirection.In)] FragmentOpATI op, [Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint dstMask, [Flow(FlowDirection.In)] uint dstMod, [Flow(FlowDirection.In)] uint arg1, [Flow(FlowDirection.In)] uint arg1Rep, [Flow(FlowDirection.In)] uint arg1Mod, [Flow(FlowDirection.In)] uint arg2, [Flow(FlowDirection.In)] uint arg2Rep, [Flow(FlowDirection.In)] uint arg2Mod, [Flow(FlowDirection.In)] uint arg3, [Flow(FlowDirection.In)] uint arg3Rep, [Flow(FlowDirection.In)] uint arg3Mod);

        [NativeApi(EntryPoint = "glPassTexCoordATI")]
        public partial void PassTexCoord([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint coord, [Flow(FlowDirection.In)] SwizzleOpATI swizzle);

        [NativeApi(EntryPoint = "glSampleMapATI")]
        public partial void SampleMap([Flow(FlowDirection.In)] uint dst, [Flow(FlowDirection.In)] uint interp, [Flow(FlowDirection.In)] SwizzleOpATI swizzle);

        public AtiFragmentShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

