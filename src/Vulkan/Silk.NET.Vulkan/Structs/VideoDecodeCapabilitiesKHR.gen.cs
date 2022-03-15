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

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoDecodeCapabilitiesKHR")]
    public unsafe partial struct VideoDecodeCapabilitiesKHR : IChainStart, IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoDecodeCapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoDecodeCapabilitiesKhr,
            void* pNext = null,
            VideoDecodeCapabilityFlagsKHR? flags = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkVideoDecodeCapabilityFlagsKHR")]
        [NativeName("Type.Name", "VkVideoDecodeCapabilityFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoDecodeCapabilityFlagsKHR Flags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeCapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref VideoDecodeCapabilitiesKHR Chain(
            out VideoDecodeCapabilitiesKHR capture)
        {
            capture = new VideoDecodeCapabilitiesKHR(StructureType.VideoDecodeCapabilitiesKhr);
            return ref capture;
        }
    }
}
