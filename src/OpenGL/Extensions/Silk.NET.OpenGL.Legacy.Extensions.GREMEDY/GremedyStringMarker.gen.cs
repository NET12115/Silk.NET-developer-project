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

namespace Silk.NET.OpenGL.Legacy.Extensions.GREMEDY
{
    [Extension("GREMEDY_string_marker")]
    public unsafe partial class GremedyStringMarker : NativeExtension<GL>
    {
        public const string ExtensionName = "GREMEDY_string_marker";
        [NativeApi(EntryPoint = "glStringMarkerGREMEDY")]
        public unsafe partial void StringMarker([Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string);

        [NativeApi(EntryPoint = "glStringMarkerGREMEDY")]
        public partial void StringMarker<T0>([Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] in T0 @string) where T0 : unmanaged;

        public GremedyStringMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

