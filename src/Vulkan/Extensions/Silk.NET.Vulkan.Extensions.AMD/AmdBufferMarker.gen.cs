// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_buffer_marker")]
    public unsafe partial class AmdBufferMarker : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_buffer_marker";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteBufferMarkerAMD")]
        public partial void CmdWriteBufferMarker([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags pipelineStage, [Count(Count = 0)] Buffer dstBuffer, [Count(Count = 0)] ulong dstOffset, [Count(Count = 0)] uint marker);

        public AmdBufferMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

