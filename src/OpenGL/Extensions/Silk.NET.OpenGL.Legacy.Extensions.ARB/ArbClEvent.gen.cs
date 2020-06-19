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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_cl_event")]
    public abstract unsafe partial class ArbClEvent : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_cl_event";
        [NativeApi(EntryPoint = "glCreateSyncFromCLeventARB")]
        public abstract unsafe IntPtr CreateSyncFromCLevent([Flow(FlowDirection.Out)] IntPtr* context, [Flow(FlowDirection.Out)] IntPtr* @event, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glCreateSyncFromCLeventARB")]
        public abstract IntPtr CreateSyncFromCLevent([Flow(FlowDirection.Out)] Span<IntPtr> context, [Flow(FlowDirection.Out)] Span<IntPtr> @event, [Flow(FlowDirection.In)] uint flags);

        public ArbClEvent(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

