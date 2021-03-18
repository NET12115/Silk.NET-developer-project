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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_debug_marker")]
    public unsafe partial class ExtDebugMarker : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_debug_marker";
        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        public unsafe partial void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* marker);

        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        public partial void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte marker);

        [NativeApi(EntryPoint = "glInsertEventMarkerEXT")]
        public partial void InsertEventMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string marker);

        [NativeApi(EntryPoint = "glPopGroupMarkerEXT")]
        public partial void PopGroupMarker();

        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        public unsafe partial void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] byte* marker);

        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        public partial void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] in byte marker);

        [NativeApi(EntryPoint = "glPushGroupMarkerEXT")]
        public partial void PushGroupMarker([Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string marker);

        public ExtDebugMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

