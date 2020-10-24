// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_D3D11_enable")]
    public unsafe partial class KhrD3D11Enable : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_D3D11_enable";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetD3D11GraphicsRequirementsKHR")]
        public unsafe partial Result GetD3D11GraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsD3D11KHR* graphicsRequirements);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrGetD3D11GraphicsRequirementsKHR")]
        public partial Result GetD3D11GraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsD3D11KHR graphicsRequirements);

        public KhrD3D11Enable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

