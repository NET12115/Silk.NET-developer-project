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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_discard_framebuffer")]
    public abstract unsafe partial class ExtDiscardFramebuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_discard_framebuffer";
        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public abstract unsafe void DiscardFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] EXT* attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public abstract void DiscardFramebuffer([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<EXT> attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public abstract unsafe void DiscardFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] InvalidateFramebufferAttachment* attachments);

        [NativeApi(EntryPoint = "glDiscardFramebufferEXT")]
        public abstract void DiscardFramebuffer([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numAttachments, [Count(Parameter = "numAttachments"), Flow(FlowDirection.In)] Span<InvalidateFramebufferAttachment> attachments);

        public ExtDiscardFramebuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

