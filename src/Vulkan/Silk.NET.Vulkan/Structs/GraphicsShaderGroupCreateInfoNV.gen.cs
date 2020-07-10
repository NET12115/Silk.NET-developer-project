// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkGraphicsShaderGroupCreateInfoNV")]
    public unsafe partial struct GraphicsShaderGroupCreateInfoNV
    {
        public GraphicsShaderGroupCreateInfoNV
        (
            StructureType sType = StructureType.GraphicsShaderGroupCreateInfoNV,
            void* pNext = default,
            uint stageCount = default,
            PipelineShaderStageCreateInfo* pStages = default,
            PipelineVertexInputStateCreateInfo* pVertexInputState = default,
            PipelineTessellationStateCreateInfo* pTessellationState = default
        )
        {
            SType = sType;
            PNext = pNext;
            StageCount = stageCount;
            PStages = pStages;
            PVertexInputState = pVertexInputState;
            PTessellationState = pTessellationState;
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
        [NativeName("Name", "stageCount")]
        public uint StageCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineShaderStageCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineShaderStageCreateInfo")]
        [NativeName("Name", "pStages")]
        public PipelineShaderStageCreateInfo* PStages;
/// <summary></summary>
        [NativeName("Type", "VkPipelineVertexInputStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineVertexInputStateCreateInfo")]
        [NativeName("Name", "pVertexInputState")]
        public PipelineVertexInputStateCreateInfo* PVertexInputState;
/// <summary></summary>
        [NativeName("Type", "VkPipelineTessellationStateCreateInfo*")]
        [NativeName("Type.Name", "VkPipelineTessellationStateCreateInfo")]
        [NativeName("Name", "pTessellationState")]
        public PipelineTessellationStateCreateInfo* PTessellationState;
    }
}
