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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_framebuffer_multisample_coverage")]
    public unsafe partial class NVFramebufferMultisampleCoverage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_multisample_coverage";
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV")]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV")]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV")]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleCoverageNV")]
        public partial void RenderbufferStorageMultisampleCoverage([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint coverageSamples, [Flow(FlowDirection.In)] uint colorSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public NVFramebufferMultisampleCoverage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

