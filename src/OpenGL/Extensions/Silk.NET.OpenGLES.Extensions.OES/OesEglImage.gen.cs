// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_EGL_image")]
    public abstract unsafe partial class OesEglImage : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_EGL_image";
        [NativeApi(EntryPoint = "glEGLImageTargetRenderbufferStorageOES")]
        public abstract void EglimageTargetRenderbufferStorage([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] IntPtr image);

        [NativeApi(EntryPoint = "glEGLImageTargetTexture2DOES")]
        public abstract void EglimageTargetTexture2D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] IntPtr image);

        public unsafe void EglimageTargetRenderbufferStorage([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int image)
        {
            // IntPtrOverloader
            EglimageTargetRenderbufferStorage(target, new IntPtr(image));
        }

        public unsafe void EglimageTargetTexture2D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int image)
        {
            // IntPtrOverloader
            EglimageTargetTexture2D(target, new IntPtr(image));
        }

        public OesEglImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

