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
    [NativeName("Name", "VkVideoSessionCreateInfoKHR")]
    public unsafe partial struct VideoSessionCreateInfoKHR : IChainable
    {
        public VideoSessionCreateInfoKHR
        (
            StructureType? sType = StructureType.VideoSessionCreateInfoKhr,
            void* pNext = null,
            uint? queueFamilyIndex = null,
            VideoSessionCreateFlagsKHR? flags = null,
            VideoProfileKHR* pVideoProfile = null,
            Format? pictureFormat = null,
            Extent2D? maxCodedExtent = null,
            Format? referencePicturesFormat = null,
            uint? maxReferencePicturesSlotsCount = null,
            uint? maxReferencePicturesActiveCount = null,
            ExtensionProperties* pStdHeaderVersion = null
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

            if (queueFamilyIndex is not null)
            {
                QueueFamilyIndex = queueFamilyIndex.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pVideoProfile is not null)
            {
                PVideoProfile = pVideoProfile;
            }

            if (pictureFormat is not null)
            {
                PictureFormat = pictureFormat.Value;
            }

            if (maxCodedExtent is not null)
            {
                MaxCodedExtent = maxCodedExtent.Value;
            }

            if (referencePicturesFormat is not null)
            {
                ReferencePicturesFormat = referencePicturesFormat.Value;
            }

            if (maxReferencePicturesSlotsCount is not null)
            {
                MaxReferencePicturesSlotsCount = maxReferencePicturesSlotsCount.Value;
            }

            if (maxReferencePicturesActiveCount is not null)
            {
                MaxReferencePicturesActiveCount = maxReferencePicturesActiveCount.Value;
            }

            if (pStdHeaderVersion is not null)
            {
                PStdHeaderVersion = pStdHeaderVersion;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndex")]
        public uint QueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "VkVideoSessionCreateFlagsKHR")]
        [NativeName("Type.Name", "VkVideoSessionCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoSessionCreateFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkVideoProfileKHR*")]
        [NativeName("Type.Name", "VkVideoProfileKHR")]
        [NativeName("Name", "pVideoProfile")]
        public VideoProfileKHR* PVideoProfile;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "pictureFormat")]
        public Format PictureFormat;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxCodedExtent")]
        public Extent2D MaxCodedExtent;
/// <summary></summary>
        [NativeName("Type", "VkFormat")]
        [NativeName("Type.Name", "VkFormat")]
        [NativeName("Name", "referencePicturesFormat")]
        public Format ReferencePicturesFormat;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxReferencePicturesSlotsCount")]
        public uint MaxReferencePicturesSlotsCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxReferencePicturesActiveCount")]
        public uint MaxReferencePicturesActiveCount;
/// <summary></summary>
        [NativeName("Type", "VkExtensionProperties*")]
        [NativeName("Type.Name", "VkExtensionProperties")]
        [NativeName("Name", "pStdHeaderVersion")]
        public ExtensionProperties* PStdHeaderVersion;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoSessionCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
