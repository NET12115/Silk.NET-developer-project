// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [NativeName("Name", "GLenum")]
    public enum ARB : int
    {
        [NativeName("Name", "GL_UNSIGNED_INT64_ARB")]
        UnsignedInt64Arb = 0x140F,
        [NativeName("Name", "GL_SRC1_COLOR")]
        Src1Color = 0x88F9,
        [NativeName("Name", "GL_SRC1_ALPHA")]
        Src1Alpha = 0x8589,
        [NativeName("Name", "GL_ONE_MINUS_SRC1_COLOR")]
        OneMinusSrc1Color = 0x88FA,
        [NativeName("Name", "GL_ONE_MINUS_SRC1_ALPHA")]
        OneMinusSrc1Alpha = 0x88FB,
        [NativeName("Name", "GL_MAX_DUAL_SOURCE_DRAW_BUFFERS")]
        MaxDualSourceDrawBuffers = 0x88FC,
        [NativeName("Name", "GL_MAP_READ_BIT")]
        MapReadBit = 0x1,
        [NativeName("Name", "GL_MAP_WRITE_BIT")]
        MapWriteBit = 0x2,
        [NativeName("Name", "GL_MAP_PERSISTENT_BIT")]
        MapPersistentBit = 0x40,
        [NativeName("Name", "GL_MAP_COHERENT_BIT")]
        MapCoherentBit = 0x80,
        [NativeName("Name", "GL_DYNAMIC_STORAGE_BIT")]
        DynamicStorageBit = 0x100,
        [NativeName("Name", "GL_CLIENT_STORAGE_BIT")]
        ClientStorageBit = 0x200,
        [NativeName("Name", "GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT")]
        ClientMappedBufferBarrierBit = 0x4000,
        [NativeName("Name", "GL_BUFFER_IMMUTABLE_STORAGE")]
        BufferImmutableStorage = 0x821F,
        [NativeName("Name", "GL_BUFFER_STORAGE_FLAGS")]
        BufferStorageFlags = 0x8220,
        [NativeName("Name", "GL_CLEAR_TEXTURE")]
        ClearTexture = 0x9365,
        [NativeName("Name", "GL_SYNC_CL_EVENT_ARB")]
        SyncCLEventArb = 0x8240,
        [NativeName("Name", "GL_SYNC_CL_EVENT_COMPLETE_ARB")]
        SyncCLEventCompleteArb = 0x8241,
        [NativeName("Name", "GL_LOWER_LEFT")]
        LowerLeft = 0x8CA1,
        [NativeName("Name", "GL_UPPER_LEFT")]
        UpperLeft = 0x8CA2,
        [NativeName("Name", "GL_NEGATIVE_ONE_TO_ONE")]
        NegativeOneToOne = 0x935E,
        [NativeName("Name", "GL_ZERO_TO_ONE")]
        ZeroToOne = 0x935F,
        [NativeName("Name", "GL_CLIP_ORIGIN")]
        ClipOrigin = 0x935C,
        [NativeName("Name", "GL_CLIP_DEPTH_MODE")]
        ClipDepthMode = 0x935D,
        [NativeName("Name", "GL_RGBA_FLOAT_MODE_ARB")]
        RgbaFloatModeArb = 0x8820,
        [NativeName("Name", "GL_CLAMP_VERTEX_COLOR_ARB")]
        ClampVertexColorArb = 0x891A,
        [NativeName("Name", "GL_CLAMP_FRAGMENT_COLOR_ARB")]
        ClampFragmentColorArb = 0x891B,
        [NativeName("Name", "GL_CLAMP_READ_COLOR_ARB")]
        ClampReadColorArb = 0x891C,
        [NativeName("Name", "GL_FIXED_ONLY_ARB")]
        FixedOnlyArb = 0x891D,
        [NativeName("Name", "GL_UNPACK_COMPRESSED_BLOCK_WIDTH")]
        UnpackCompressedBlockWidth = 0x9127,
        [NativeName("Name", "GL_UNPACK_COMPRESSED_BLOCK_HEIGHT")]
        UnpackCompressedBlockHeight = 0x9128,
        [NativeName("Name", "GL_UNPACK_COMPRESSED_BLOCK_DEPTH")]
        UnpackCompressedBlockDepth = 0x9129,
        [NativeName("Name", "GL_UNPACK_COMPRESSED_BLOCK_SIZE")]
        UnpackCompressedBlockSize = 0x912A,
        [NativeName("Name", "GL_PACK_COMPRESSED_BLOCK_WIDTH")]
        PackCompressedBlockWidth = 0x912B,
        [NativeName("Name", "GL_PACK_COMPRESSED_BLOCK_HEIGHT")]
        PackCompressedBlockHeight = 0x912C,
        [NativeName("Name", "GL_PACK_COMPRESSED_BLOCK_DEPTH")]
        PackCompressedBlockDepth = 0x912D,
        [NativeName("Name", "GL_PACK_COMPRESSED_BLOCK_SIZE")]
        PackCompressedBlockSize = 0x912E,
        [NativeName("Name", "GL_COMPUTE_SHADER")]
        ComputeShader = 0x91B9,
        [NativeName("Name", "GL_MAX_COMPUTE_UNIFORM_BLOCKS")]
        MaxComputeUniformBlocks = 0x91BB,
        [NativeName("Name", "GL_MAX_COMPUTE_TEXTURE_IMAGE_UNITS")]
        MaxComputeTextureImageUnits = 0x91BC,
        [NativeName("Name", "GL_MAX_COMPUTE_IMAGE_UNIFORMS")]
        MaxComputeImageUniforms = 0x91BD,
        [NativeName("Name", "GL_MAX_COMPUTE_SHARED_MEMORY_SIZE")]
        MaxComputeSharedMemorySize = 0x8262,
        [NativeName("Name", "GL_MAX_COMPUTE_UNIFORM_COMPONENTS")]
        MaxComputeUniformComponents = 0x8263,
        [NativeName("Name", "GL_MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS")]
        MaxComputeAtomicCounterBuffers = 0x8264,
        [NativeName("Name", "GL_MAX_COMPUTE_ATOMIC_COUNTERS")]
        MaxComputeAtomicCounters = 0x8265,
        [NativeName("Name", "GL_MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS")]
        MaxCombinedComputeUniformComponents = 0x8266,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_INVOCATIONS")]
        MaxComputeWorkGroupInvocations = 0x90EB,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_COUNT")]
        MaxComputeWorkGroupCount = 0x91BE,
        [NativeName("Name", "GL_MAX_COMPUTE_WORK_GROUP_SIZE")]
        MaxComputeWorkGroupSize = 0x91BF,
        [NativeName("Name", "GL_COMPUTE_WORK_GROUP_SIZE")]
        ComputeWorkGroupSize = 0x8267,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER")]
        UniformBlockReferencedByComputeShader = 0x90EC,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
        AtomicCounterBufferReferencedByComputeShader = 0x90ED,
        [NativeName("Name", "GL_DISPATCH_INDIRECT_BUFFER")]
        DispatchIndirectBuffer = 0x90EE,
        [NativeName("Name", "GL_DISPATCH_INDIRECT_BUFFER_BINDING")]
        DispatchIndirectBufferBinding = 0x90EF,
        [NativeName("Name", "GL_COMPUTE_SHADER_BIT")]
        ComputeShaderBit = 0x20,
        [NativeName("Name", "GL_MAX_COMPUTE_VARIABLE_GROUP_INVOCATIONS_ARB")]
        MaxComputeVariableGroupInvocationsArb = 0x9344,
        [NativeName("Name", "GL_MAX_COMPUTE_FIXED_GROUP_INVOCATIONS_ARB")]
        MaxComputeFixedGroupInvocationsArb = 0x90EB,
        [NativeName("Name", "GL_MAX_COMPUTE_VARIABLE_GROUP_SIZE_ARB")]
        MaxComputeVariableGroupSizeArb = 0x9345,
        [NativeName("Name", "GL_MAX_COMPUTE_FIXED_GROUP_SIZE_ARB")]
        MaxComputeFixedGroupSizeArb = 0x91BF,
        [NativeName("Name", "GL_QUERY_WAIT_INVERTED")]
        QueryWaitInverted = 0x8E17,
        [NativeName("Name", "GL_QUERY_NO_WAIT_INVERTED")]
        QueryNoWaitInverted = 0x8E18,
        [NativeName("Name", "GL_QUERY_BY_REGION_WAIT_INVERTED")]
        QueryByRegionWaitInverted = 0x8E19,
        [NativeName("Name", "GL_QUERY_BY_REGION_NO_WAIT_INVERTED")]
        QueryByRegionNoWaitInverted = 0x8E1A,
        [NativeName("Name", "GL_COPY_READ_BUFFER")]
        CopyReadBuffer = 0x8F36,
        [NativeName("Name", "GL_COPY_WRITE_BUFFER")]
        CopyWriteBuffer = 0x8F37,
        [NativeName("Name", "GL_MAX_CULL_DISTANCES")]
        MaxCullDistances = 0x82F9,
        [NativeName("Name", "GL_MAX_COMBINED_CLIP_AND_CULL_DISTANCES")]
        MaxCombinedClipAndCullDistances = 0x82FA,
        [NativeName("Name", "GL_DEBUG_OUTPUT_SYNCHRONOUS_ARB")]
        DebugOutputSynchronousArb = 0x8242,
        [NativeName("Name", "GL_DEBUG_NEXT_LOGGED_MESSAGE_LENGTH_ARB")]
        DebugNextLoggedMessageLengthArb = 0x8243,
        [NativeName("Name", "GL_DEBUG_CALLBACK_FUNCTION_ARB")]
        DebugCallbackFunctionArb = 0x8244,
        [NativeName("Name", "GL_DEBUG_CALLBACK_USER_PARAM_ARB")]
        DebugCallbackUserParamArb = 0x8245,
        [NativeName("Name", "GL_DEBUG_SOURCE_API_ARB")]
        DebugSourceApiArb = 0x8246,
        [NativeName("Name", "GL_DEBUG_SOURCE_WINDOW_SYSTEM_ARB")]
        DebugSourceWindowSystemArb = 0x8247,
        [NativeName("Name", "GL_DEBUG_SOURCE_SHADER_COMPILER_ARB")]
        DebugSourceShaderCompilerArb = 0x8248,
        [NativeName("Name", "GL_DEBUG_SOURCE_THIRD_PARTY_ARB")]
        DebugSourceThirdPartyArb = 0x8249,
        [NativeName("Name", "GL_DEBUG_SOURCE_APPLICATION_ARB")]
        DebugSourceApplicationArb = 0x824A,
        [NativeName("Name", "GL_DEBUG_SOURCE_OTHER_ARB")]
        DebugSourceOtherArb = 0x824B,
        [NativeName("Name", "GL_DEBUG_TYPE_ERROR_ARB")]
        DebugTypeErrorArb = 0x824C,
        [NativeName("Name", "GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR_ARB")]
        DebugTypeDeprecatedBehaviorArb = 0x824D,
        [NativeName("Name", "GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR_ARB")]
        DebugTypeUndefinedBehaviorArb = 0x824E,
        [NativeName("Name", "GL_DEBUG_TYPE_PORTABILITY_ARB")]
        DebugTypePortabilityArb = 0x824F,
        [NativeName("Name", "GL_DEBUG_TYPE_PERFORMANCE_ARB")]
        DebugTypePerformanceArb = 0x8250,
        [NativeName("Name", "GL_DEBUG_TYPE_OTHER_ARB")]
        DebugTypeOtherArb = 0x8251,
        [NativeName("Name", "GL_MAX_DEBUG_MESSAGE_LENGTH_ARB")]
        MaxDebugMessageLengthArb = 0x9143,
        [NativeName("Name", "GL_MAX_DEBUG_LOGGED_MESSAGES_ARB")]
        MaxDebugLoggedMessagesArb = 0x9144,
        [NativeName("Name", "GL_DEBUG_LOGGED_MESSAGES_ARB")]
        DebugLoggedMessagesArb = 0x9145,
        [NativeName("Name", "GL_DEBUG_SEVERITY_HIGH_ARB")]
        DebugSeverityHighArb = 0x9146,
        [NativeName("Name", "GL_DEBUG_SEVERITY_MEDIUM_ARB")]
        DebugSeverityMediumArb = 0x9147,
        [NativeName("Name", "GL_DEBUG_SEVERITY_LOW_ARB")]
        DebugSeverityLowArb = 0x9148,
        [NativeName("Name", "GL_DEPTH_COMPONENT32F")]
        DepthComponent32f = 0x8CAC,
        [NativeName("Name", "GL_DEPTH32F_STENCIL8")]
        Depth32fStencil8 = 0x8CAD,
        [NativeName("Name", "GL_FLOAT_32_UNSIGNED_INT_24_8_REV")]
        Float32UnsignedInt248Rev = 0x8DAD,
        [NativeName("Name", "GL_DEPTH_CLAMP")]
        DepthClamp = 0x864F,
        [NativeName("Name", "GL_DEPTH_COMPONENT16_ARB")]
        DepthComponent16Arb = 0x81A5,
        [NativeName("Name", "GL_DEPTH_COMPONENT24_ARB")]
        DepthComponent24Arb = 0x81A6,
        [NativeName("Name", "GL_DEPTH_COMPONENT32_ARB")]
        DepthComponent32Arb = 0x81A7,
        [NativeName("Name", "GL_TEXTURE_DEPTH_SIZE_ARB")]
        TextureDepthSizeArb = 0x884A,
        [NativeName("Name", "GL_DEPTH_TEXTURE_MODE_ARB")]
        DepthTextureModeArb = 0x884B,
        [NativeName("Name", "GL_TEXTURE_TARGET")]
        TextureTarget = 0x1006,
        [NativeName("Name", "GL_QUERY_TARGET")]
        QueryTarget = 0x82EA,
        [NativeName("Name", "GL_TEXTURE_BINDING_1D")]
        TextureBinding1D = 0x8068,
        [NativeName("Name", "GL_TEXTURE_BINDING_1D_ARRAY")]
        TextureBinding1DArray = 0x8C1C,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D")]
        TextureBinding2D = 0x8069,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_ARRAY")]
        TextureBinding2DArray = 0x8C1D,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_MULTISAMPLE")]
        TextureBinding2DMultisample = 0x9104,
        [NativeName("Name", "GL_TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY")]
        TextureBinding2DMultisampleArray = 0x9105,
        [NativeName("Name", "GL_TEXTURE_BINDING_3D")]
        TextureBinding3D = 0x806A,
        [NativeName("Name", "GL_TEXTURE_BINDING_BUFFER")]
        TextureBindingBuffer = 0x8C2C,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP")]
        TextureBindingCubeMap = 0x8514,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_ARRAY")]
        TextureBindingCubeMapArray = 0x900A,
        [NativeName("Name", "GL_TEXTURE_BINDING_RECTANGLE")]
        TextureBindingRectangle = 0x84F6,
        [NativeName("Name", "GL_MAX_DRAW_BUFFERS_ARB")]
        MaxDrawBuffersArb = 0x8824,
        [NativeName("Name", "GL_DRAW_BUFFER0_ARB")]
        DrawBuffer0Arb = 0x8825,
        [NativeName("Name", "GL_DRAW_BUFFER1_ARB")]
        DrawBuffer1Arb = 0x8826,
        [NativeName("Name", "GL_DRAW_BUFFER2_ARB")]
        DrawBuffer2Arb = 0x8827,
        [NativeName("Name", "GL_DRAW_BUFFER3_ARB")]
        DrawBuffer3Arb = 0x8828,
        [NativeName("Name", "GL_DRAW_BUFFER4_ARB")]
        DrawBuffer4Arb = 0x8829,
        [NativeName("Name", "GL_DRAW_BUFFER5_ARB")]
        DrawBuffer5Arb = 0x882A,
        [NativeName("Name", "GL_DRAW_BUFFER6_ARB")]
        DrawBuffer6Arb = 0x882B,
        [NativeName("Name", "GL_DRAW_BUFFER7_ARB")]
        DrawBuffer7Arb = 0x882C,
        [NativeName("Name", "GL_DRAW_BUFFER8_ARB")]
        DrawBuffer8Arb = 0x882D,
        [NativeName("Name", "GL_DRAW_BUFFER9_ARB")]
        DrawBuffer9Arb = 0x882E,
        [NativeName("Name", "GL_DRAW_BUFFER10_ARB")]
        DrawBuffer10Arb = 0x882F,
        [NativeName("Name", "GL_DRAW_BUFFER11_ARB")]
        DrawBuffer11Arb = 0x8830,
        [NativeName("Name", "GL_DRAW_BUFFER12_ARB")]
        DrawBuffer12Arb = 0x8831,
        [NativeName("Name", "GL_DRAW_BUFFER13_ARB")]
        DrawBuffer13Arb = 0x8832,
        [NativeName("Name", "GL_DRAW_BUFFER14_ARB")]
        DrawBuffer14Arb = 0x8833,
        [NativeName("Name", "GL_DRAW_BUFFER15_ARB")]
        DrawBuffer15Arb = 0x8834,
        [NativeName("Name", "GL_DRAW_INDIRECT_BUFFER")]
        DrawIndirectBuffer = 0x8F3F,
        [NativeName("Name", "GL_DRAW_INDIRECT_BUFFER_BINDING")]
        DrawIndirectBufferBinding = 0x8F43,
        [NativeName("Name", "GL_LOCATION_COMPONENT")]
        LocationComponent = 0x934A,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER")]
        TransformFeedbackBuffer = 0x8C8E,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_INDEX")]
        TransformFeedbackBufferIndex = 0x934B,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_STRIDE")]
        TransformFeedbackBufferStride = 0x934C,
        [NativeName("Name", "GL_FIXED")]
        Fixed = 0x140C,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_TYPE")]
        ImplementationColorReadType = 0x8B9A,
        [NativeName("Name", "GL_IMPLEMENTATION_COLOR_READ_FORMAT")]
        ImplementationColorReadFormat = 0x8B9B,
        [NativeName("Name", "GL_LOW_FLOAT")]
        LowFloat = 0x8DF0,
        [NativeName("Name", "GL_MEDIUM_FLOAT")]
        MediumFloat = 0x8DF1,
        [NativeName("Name", "GL_HIGH_FLOAT")]
        HighFloat = 0x8DF2,
        [NativeName("Name", "GL_LOW_INT")]
        LowInt = 0x8DF3,
        [NativeName("Name", "GL_MEDIUM_INT")]
        MediumInt = 0x8DF4,
        [NativeName("Name", "GL_HIGH_INT")]
        HighInt = 0x8DF5,
        [NativeName("Name", "GL_SHADER_COMPILER")]
        ShaderCompiler = 0x8DFA,
        [NativeName("Name", "GL_SHADER_BINARY_FORMATS")]
        ShaderBinaryFormats = 0x8DF8,
        [NativeName("Name", "GL_NUM_SHADER_BINARY_FORMATS")]
        NumShaderBinaryFormats = 0x8DF9,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_VECTORS")]
        MaxVertexUniformVectors = 0x8DFB,
        [NativeName("Name", "GL_MAX_VARYING_VECTORS")]
        MaxVaryingVectors = 0x8DFC,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_VECTORS")]
        MaxFragmentUniformVectors = 0x8DFD,
        [NativeName("Name", "GL_RGB565")]
        Rgb565 = 0x8D62,
        [NativeName("Name", "GL_BACK")]
        Back = 0x405,
        [NativeName("Name", "GL_PRIMITIVE_BOUNDING_BOX_ARB")]
        PrimitiveBoundingBoxArb = 0x92BE,
        [NativeName("Name", "GL_MULTISAMPLE_LINE_WIDTH_RANGE_ARB")]
        MultisampleLineWidthRangeArb = 0x9381,
        [NativeName("Name", "GL_MULTISAMPLE_LINE_WIDTH_GRANULARITY_ARB")]
        MultisampleLineWidthGranularityArb = 0x9382,
        [NativeName("Name", "GL_COMPRESSED_RGB8_ETC2")]
        CompressedRgb8Etc2 = 0x9274,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ETC2")]
        CompressedSrgb8Etc2 = 0x9275,
        [NativeName("Name", "GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2")]
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
        [NativeName("Name", "GL_COMPRESSED_RGBA8_ETC2_EAC")]
        CompressedRgba8Etc2Eac = 0x9278,
        [NativeName("Name", "GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC")]
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
        [NativeName("Name", "GL_COMPRESSED_R11_EAC")]
        CompressedR11Eac = 0x9270,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_R11_EAC")]
        CompressedSignedR11Eac = 0x9271,
        [NativeName("Name", "GL_COMPRESSED_RG11_EAC")]
        CompressedRG11Eac = 0x9272,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RG11_EAC")]
        CompressedSignedRG11Eac = 0x9273,
        [NativeName("Name", "GL_PRIMITIVE_RESTART_FIXED_INDEX")]
        PrimitiveRestartFixedIndex = 0x8D69,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED_CONSERVATIVE")]
        AnySamplesPassedConservative = 0x8D6A,
        [NativeName("Name", "GL_MAX_ELEMENT_INDEX")]
        MaxElementIndex = 0x8D6B,
        [NativeName("Name", "GL_MAX_UNIFORM_LOCATIONS")]
        MaxUniformLocations = 0x826E,
        [NativeName("Name", "GL_FRAGMENT_PROGRAM_ARB")]
        FragmentProgramArb = 0x8804,
        [NativeName("Name", "GL_PROGRAM_FORMAT_ASCII_ARB")]
        ProgramFormatAsciiArb = 0x8875,
        [NativeName("Name", "GL_PROGRAM_LENGTH_ARB")]
        ProgramLengthArb = 0x8627,
        [NativeName("Name", "GL_PROGRAM_FORMAT_ARB")]
        ProgramFormatArb = 0x8876,
        [NativeName("Name", "GL_PROGRAM_BINDING_ARB")]
        ProgramBindingArb = 0x8677,
        [NativeName("Name", "GL_PROGRAM_INSTRUCTIONS_ARB")]
        ProgramInstructionsArb = 0x88A0,
        [NativeName("Name", "GL_MAX_PROGRAM_INSTRUCTIONS_ARB")]
        MaxProgramInstructionsArb = 0x88A1,
        [NativeName("Name", "GL_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
        ProgramNativeInstructionsArb = 0x88A2,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_INSTRUCTIONS_ARB")]
        MaxProgramNativeInstructionsArb = 0x88A3,
        [NativeName("Name", "GL_PROGRAM_TEMPORARIES_ARB")]
        ProgramTemporariesArb = 0x88A4,
        [NativeName("Name", "GL_MAX_PROGRAM_TEMPORARIES_ARB")]
        MaxProgramTemporariesArb = 0x88A5,
        [NativeName("Name", "GL_PROGRAM_NATIVE_TEMPORARIES_ARB")]
        ProgramNativeTemporariesArb = 0x88A6,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_TEMPORARIES_ARB")]
        MaxProgramNativeTemporariesArb = 0x88A7,
        [NativeName("Name", "GL_PROGRAM_PARAMETERS_ARB")]
        ProgramParametersArb = 0x88A8,
        [NativeName("Name", "GL_MAX_PROGRAM_PARAMETERS_ARB")]
        MaxProgramParametersArb = 0x88A9,
        [NativeName("Name", "GL_PROGRAM_NATIVE_PARAMETERS_ARB")]
        ProgramNativeParametersArb = 0x88AA,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_PARAMETERS_ARB")]
        MaxProgramNativeParametersArb = 0x88AB,
        [NativeName("Name", "GL_PROGRAM_ATTRIBS_ARB")]
        ProgramAttribsArb = 0x88AC,
        [NativeName("Name", "GL_MAX_PROGRAM_ATTRIBS_ARB")]
        MaxProgramAttribsArb = 0x88AD,
        [NativeName("Name", "GL_PROGRAM_NATIVE_ATTRIBS_ARB")]
        ProgramNativeAttribsArb = 0x88AE,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_ATTRIBS_ARB")]
        MaxProgramNativeAttribsArb = 0x88AF,
        [NativeName("Name", "GL_MAX_PROGRAM_LOCAL_PARAMETERS_ARB")]
        MaxProgramLocalParametersArb = 0x88B4,
        [NativeName("Name", "GL_MAX_PROGRAM_ENV_PARAMETERS_ARB")]
        MaxProgramEnvParametersArb = 0x88B5,
        [NativeName("Name", "GL_PROGRAM_UNDER_NATIVE_LIMITS_ARB")]
        ProgramUnderNativeLimitsArb = 0x88B6,
        [NativeName("Name", "GL_PROGRAM_ALU_INSTRUCTIONS_ARB")]
        ProgramAluInstructionsArb = 0x8805,
        [NativeName("Name", "GL_PROGRAM_TEX_INSTRUCTIONS_ARB")]
        ProgramTexInstructionsArb = 0x8806,
        [NativeName("Name", "GL_PROGRAM_TEX_INDIRECTIONS_ARB")]
        ProgramTexIndirectionsArb = 0x8807,
        [NativeName("Name", "GL_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
        ProgramNativeAluInstructionsArb = 0x8808,
        [NativeName("Name", "GL_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
        ProgramNativeTexInstructionsArb = 0x8809,
        [NativeName("Name", "GL_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
        ProgramNativeTexIndirectionsArb = 0x880A,
        [NativeName("Name", "GL_MAX_PROGRAM_ALU_INSTRUCTIONS_ARB")]
        MaxProgramAluInstructionsArb = 0x880B,
        [NativeName("Name", "GL_MAX_PROGRAM_TEX_INSTRUCTIONS_ARB")]
        MaxProgramTexInstructionsArb = 0x880C,
        [NativeName("Name", "GL_MAX_PROGRAM_TEX_INDIRECTIONS_ARB")]
        MaxProgramTexIndirectionsArb = 0x880D,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_ALU_INSTRUCTIONS_ARB")]
        MaxProgramNativeAluInstructionsArb = 0x880E,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_TEX_INSTRUCTIONS_ARB")]
        MaxProgramNativeTexInstructionsArb = 0x880F,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_TEX_INDIRECTIONS_ARB")]
        MaxProgramNativeTexIndirectionsArb = 0x8810,
        [NativeName("Name", "GL_PROGRAM_STRING_ARB")]
        ProgramStringArb = 0x8628,
        [NativeName("Name", "GL_PROGRAM_ERROR_POSITION_ARB")]
        ProgramErrorPositionArb = 0x864B,
        [NativeName("Name", "GL_CURRENT_MATRIX_ARB")]
        CurrentMatrixArb = 0x8641,
        [NativeName("Name", "GL_TRANSPOSE_CURRENT_MATRIX_ARB")]
        TransposeCurrentMatrixArb = 0x88B7,
        [NativeName("Name", "GL_CURRENT_MATRIX_STACK_DEPTH_ARB")]
        CurrentMatrixStackDepthArb = 0x8640,
        [NativeName("Name", "GL_MAX_PROGRAM_MATRICES_ARB")]
        MaxProgramMatricesArb = 0x862F,
        [NativeName("Name", "GL_MAX_PROGRAM_MATRIX_STACK_DEPTH_ARB")]
        MaxProgramMatrixStackDepthArb = 0x862E,
        [NativeName("Name", "GL_MAX_TEXTURE_COORDS_ARB")]
        MaxTextureCoordsArb = 0x8871,
        [NativeName("Name", "GL_MAX_TEXTURE_IMAGE_UNITS_ARB")]
        MaxTextureImageUnitsArb = 0x8872,
        [NativeName("Name", "GL_PROGRAM_ERROR_STRING_ARB")]
        ProgramErrorStringArb = 0x8874,
        [NativeName("Name", "GL_MATRIX0_ARB")]
        Matrix0Arb = 0x88C0,
        [NativeName("Name", "GL_MATRIX1_ARB")]
        Matrix1Arb = 0x88C1,
        [NativeName("Name", "GL_MATRIX2_ARB")]
        Matrix2Arb = 0x88C2,
        [NativeName("Name", "GL_MATRIX3_ARB")]
        Matrix3Arb = 0x88C3,
        [NativeName("Name", "GL_MATRIX4_ARB")]
        Matrix4Arb = 0x88C4,
        [NativeName("Name", "GL_MATRIX5_ARB")]
        Matrix5Arb = 0x88C5,
        [NativeName("Name", "GL_MATRIX6_ARB")]
        Matrix6Arb = 0x88C6,
        [NativeName("Name", "GL_MATRIX7_ARB")]
        Matrix7Arb = 0x88C7,
        [NativeName("Name", "GL_MATRIX8_ARB")]
        Matrix8Arb = 0x88C8,
        [NativeName("Name", "GL_MATRIX9_ARB")]
        Matrix9Arb = 0x88C9,
        [NativeName("Name", "GL_MATRIX10_ARB")]
        Matrix10Arb = 0x88CA,
        [NativeName("Name", "GL_MATRIX11_ARB")]
        Matrix11Arb = 0x88CB,
        [NativeName("Name", "GL_MATRIX12_ARB")]
        Matrix12Arb = 0x88CC,
        [NativeName("Name", "GL_MATRIX13_ARB")]
        Matrix13Arb = 0x88CD,
        [NativeName("Name", "GL_MATRIX14_ARB")]
        Matrix14Arb = 0x88CE,
        [NativeName("Name", "GL_MATRIX15_ARB")]
        Matrix15Arb = 0x88CF,
        [NativeName("Name", "GL_MATRIX16_ARB")]
        Matrix16Arb = 0x88D0,
        [NativeName("Name", "GL_MATRIX17_ARB")]
        Matrix17Arb = 0x88D1,
        [NativeName("Name", "GL_MATRIX18_ARB")]
        Matrix18Arb = 0x88D2,
        [NativeName("Name", "GL_MATRIX19_ARB")]
        Matrix19Arb = 0x88D3,
        [NativeName("Name", "GL_MATRIX20_ARB")]
        Matrix20Arb = 0x88D4,
        [NativeName("Name", "GL_MATRIX21_ARB")]
        Matrix21Arb = 0x88D5,
        [NativeName("Name", "GL_MATRIX22_ARB")]
        Matrix22Arb = 0x88D6,
        [NativeName("Name", "GL_MATRIX23_ARB")]
        Matrix23Arb = 0x88D7,
        [NativeName("Name", "GL_MATRIX24_ARB")]
        Matrix24Arb = 0x88D8,
        [NativeName("Name", "GL_MATRIX25_ARB")]
        Matrix25Arb = 0x88D9,
        [NativeName("Name", "GL_MATRIX26_ARB")]
        Matrix26Arb = 0x88DA,
        [NativeName("Name", "GL_MATRIX27_ARB")]
        Matrix27Arb = 0x88DB,
        [NativeName("Name", "GL_MATRIX28_ARB")]
        Matrix28Arb = 0x88DC,
        [NativeName("Name", "GL_MATRIX29_ARB")]
        Matrix29Arb = 0x88DD,
        [NativeName("Name", "GL_MATRIX30_ARB")]
        Matrix30Arb = 0x88DE,
        [NativeName("Name", "GL_MATRIX31_ARB")]
        Matrix31Arb = 0x88DF,
        [NativeName("Name", "GL_FRAGMENT_SHADER_ARB")]
        FragmentShaderArb = 0x8B30,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_COMPONENTS_ARB")]
        MaxFragmentUniformComponentsArb = 0x8B49,
        [NativeName("Name", "GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB")]
        FragmentShaderDerivativeHintArb = 0x8B8B,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_WIDTH")]
        FramebufferDefaultWidth = 0x9310,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_HEIGHT")]
        FramebufferDefaultHeight = 0x9311,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_LAYERS")]
        FramebufferDefaultLayers = 0x9312,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_SAMPLES")]
        FramebufferDefaultSamples = 0x9313,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS")]
        FramebufferDefaultFixedSampleLocations = 0x9314,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_WIDTH")]
        MaxFramebufferWidth = 0x9315,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_HEIGHT")]
        MaxFramebufferHeight = 0x9316,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_LAYERS")]
        MaxFramebufferLayers = 0x9317,
        [NativeName("Name", "GL_MAX_FRAMEBUFFER_SAMPLES")]
        MaxFramebufferSamples = 0x9318,
        [NativeName("Name", "GL_INVALID_FRAMEBUFFER_OPERATION")]
        InvalidFramebufferOperation = 0x506,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING")]
        FramebufferAttachmentColorEncoding = 0x8210,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE")]
        FramebufferAttachmentComponentType = 0x8211,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE")]
        FramebufferAttachmentRedSize = 0x8212,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE")]
        FramebufferAttachmentGreenSize = 0x8213,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE")]
        FramebufferAttachmentBlueSize = 0x8214,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE")]
        FramebufferAttachmentAlphaSize = 0x8215,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE")]
        FramebufferAttachmentDepthSize = 0x8216,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE")]
        FramebufferAttachmentStencilSize = 0x8217,
        [NativeName("Name", "GL_FRAMEBUFFER_DEFAULT")]
        FramebufferDefault = 0x8218,
        [NativeName("Name", "GL_FRAMEBUFFER_UNDEFINED")]
        FramebufferUndefined = 0x8219,
        [NativeName("Name", "GL_DEPTH_STENCIL_ATTACHMENT")]
        DepthStencilAttachment = 0x821A,
        [NativeName("Name", "GL_MAX_RENDERBUFFER_SIZE")]
        MaxRenderbufferSize = 0x84E8,
        [NativeName("Name", "GL_DEPTH_STENCIL")]
        DepthStencil = 0x84F9,
        [NativeName("Name", "GL_UNSIGNED_INT_24_8")]
        UnsignedInt248 = 0x84FA,
        [NativeName("Name", "GL_DEPTH24_STENCIL8")]
        Depth24Stencil8 = 0x88F0,
        [NativeName("Name", "GL_TEXTURE_STENCIL_SIZE")]
        TextureStencilSize = 0x88F1,
        [NativeName("Name", "GL_UNSIGNED_NORMALIZED")]
        UnsignedNormalized = 0x8C17,
        [NativeName("Name", "GL_FRAMEBUFFER_BINDING")]
        FramebufferBinding = 0x8CA6,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER_BINDING")]
        DrawFramebufferBinding = 0x8CA6,
        [NativeName("Name", "GL_RENDERBUFFER_BINDING")]
        RenderbufferBinding = 0x8CA7,
        [NativeName("Name", "GL_READ_FRAMEBUFFER")]
        ReadFramebuffer = 0x8CA8,
        [NativeName("Name", "GL_DRAW_FRAMEBUFFER")]
        DrawFramebuffer = 0x8CA9,
        [NativeName("Name", "GL_READ_FRAMEBUFFER_BINDING")]
        ReadFramebufferBinding = 0x8CAA,
        [NativeName("Name", "GL_RENDERBUFFER_SAMPLES")]
        RenderbufferSamples = 0x8CAB,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE")]
        FramebufferAttachmentObjectType = 0x8CD0,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME")]
        FramebufferAttachmentObjectName = 0x8CD1,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL")]
        FramebufferAttachmentTextureLevel = 0x8CD2,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE")]
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER")]
        FramebufferAttachmentTextureLayer = 0x8CD4,
        [NativeName("Name", "GL_FRAMEBUFFER_COMPLETE")]
        FramebufferComplete = 0x8CD5,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT")]
        FramebufferIncompleteAttachment = 0x8CD6,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT")]
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER")]
        FramebufferIncompleteDrawBuffer = 0x8CDB,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER")]
        FramebufferIncompleteReadBuffer = 0x8CDC,
        [NativeName("Name", "GL_FRAMEBUFFER_UNSUPPORTED")]
        FramebufferUnsupported = 0x8CDD,
        [NativeName("Name", "GL_MAX_COLOR_ATTACHMENTS")]
        MaxColorAttachments = 0x8CDF,
        [NativeName("Name", "GL_COLOR_ATTACHMENT0")]
        ColorAttachment0 = 0x8CE0,
        [NativeName("Name", "GL_COLOR_ATTACHMENT1")]
        ColorAttachment1 = 0x8CE1,
        [NativeName("Name", "GL_COLOR_ATTACHMENT2")]
        ColorAttachment2 = 0x8CE2,
        [NativeName("Name", "GL_COLOR_ATTACHMENT3")]
        ColorAttachment3 = 0x8CE3,
        [NativeName("Name", "GL_COLOR_ATTACHMENT4")]
        ColorAttachment4 = 0x8CE4,
        [NativeName("Name", "GL_COLOR_ATTACHMENT5")]
        ColorAttachment5 = 0x8CE5,
        [NativeName("Name", "GL_COLOR_ATTACHMENT6")]
        ColorAttachment6 = 0x8CE6,
        [NativeName("Name", "GL_COLOR_ATTACHMENT7")]
        ColorAttachment7 = 0x8CE7,
        [NativeName("Name", "GL_COLOR_ATTACHMENT8")]
        ColorAttachment8 = 0x8CE8,
        [NativeName("Name", "GL_COLOR_ATTACHMENT9")]
        ColorAttachment9 = 0x8CE9,
        [NativeName("Name", "GL_COLOR_ATTACHMENT10")]
        ColorAttachment10 = 0x8CEA,
        [NativeName("Name", "GL_COLOR_ATTACHMENT11")]
        ColorAttachment11 = 0x8CEB,
        [NativeName("Name", "GL_COLOR_ATTACHMENT12")]
        ColorAttachment12 = 0x8CEC,
        [NativeName("Name", "GL_COLOR_ATTACHMENT13")]
        ColorAttachment13 = 0x8CED,
        [NativeName("Name", "GL_COLOR_ATTACHMENT14")]
        ColorAttachment14 = 0x8CEE,
        [NativeName("Name", "GL_COLOR_ATTACHMENT15")]
        ColorAttachment15 = 0x8CEF,
        [NativeName("Name", "GL_DEPTH_ATTACHMENT")]
        DepthAttachment = 0x8D00,
        [NativeName("Name", "GL_STENCIL_ATTACHMENT")]
        StencilAttachment = 0x8D20,
        [NativeName("Name", "GL_FRAMEBUFFER")]
        Framebuffer = 0x8D40,
        [NativeName("Name", "GL_RENDERBUFFER")]
        Renderbuffer = 0x8D41,
        [NativeName("Name", "GL_RENDERBUFFER_WIDTH")]
        RenderbufferWidth = 0x8D42,
        [NativeName("Name", "GL_RENDERBUFFER_HEIGHT")]
        RenderbufferHeight = 0x8D43,
        [NativeName("Name", "GL_RENDERBUFFER_INTERNAL_FORMAT")]
        RenderbufferInternalFormat = 0x8D44,
        [NativeName("Name", "GL_STENCIL_INDEX1")]
        StencilIndex1 = 0x8D46,
        [NativeName("Name", "GL_STENCIL_INDEX4")]
        StencilIndex4 = 0x8D47,
        [NativeName("Name", "GL_STENCIL_INDEX8")]
        StencilIndex8 = 0x8D48,
        [NativeName("Name", "GL_STENCIL_INDEX16")]
        StencilIndex16 = 0x8D49,
        [NativeName("Name", "GL_RENDERBUFFER_RED_SIZE")]
        RenderbufferRedSize = 0x8D50,
        [NativeName("Name", "GL_RENDERBUFFER_GREEN_SIZE")]
        RenderbufferGreenSize = 0x8D51,
        [NativeName("Name", "GL_RENDERBUFFER_BLUE_SIZE")]
        RenderbufferBlueSize = 0x8D52,
        [NativeName("Name", "GL_RENDERBUFFER_ALPHA_SIZE")]
        RenderbufferAlphaSize = 0x8D53,
        [NativeName("Name", "GL_RENDERBUFFER_DEPTH_SIZE")]
        RenderbufferDepthSize = 0x8D54,
        [NativeName("Name", "GL_RENDERBUFFER_STENCIL_SIZE")]
        RenderbufferStencilSize = 0x8D55,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE")]
        FramebufferIncompleteMultisample = 0x8D56,
        [NativeName("Name", "GL_MAX_SAMPLES")]
        MaxSamples = 0x8D57,
        [NativeName("Name", "GL_INDEX")]
        Index = 0x8222,
        [NativeName("Name", "GL_FRAMEBUFFER_SRGB")]
        FramebufferSrgb = 0x8DB9,
        [NativeName("Name", "GL_LINES_ADJACENCY_ARB")]
        LinesAdjacencyArb = 0xA,
        [NativeName("Name", "GL_LINE_STRIP_ADJACENCY_ARB")]
        LineStripAdjacencyArb = 0xB,
        [NativeName("Name", "GL_TRIANGLES_ADJACENCY_ARB")]
        TrianglesAdjacencyArb = 0xC,
        [NativeName("Name", "GL_TRIANGLE_STRIP_ADJACENCY_ARB")]
        TriangleStripAdjacencyArb = 0xD,
        [NativeName("Name", "GL_PROGRAM_POINT_SIZE_ARB")]
        ProgramPointSizeArb = 0x8642,
        [NativeName("Name", "GL_MAX_GEOMETRY_TEXTURE_IMAGE_UNITS_ARB")]
        MaxGeometryTextureImageUnitsArb = 0x8C29,
        [NativeName("Name", "GL_FRAMEBUFFER_ATTACHMENT_LAYERED_ARB")]
        FramebufferAttachmentLayeredArb = 0x8DA7,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS_ARB")]
        FramebufferIncompleteLayerTargetsArb = 0x8DA8,
        [NativeName("Name", "GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT_ARB")]
        FramebufferIncompleteLayerCountArb = 0x8DA9,
        [NativeName("Name", "GL_GEOMETRY_SHADER_ARB")]
        GeometryShaderArb = 0x8DD9,
        [NativeName("Name", "GL_GEOMETRY_VERTICES_OUT_ARB")]
        GeometryVerticesOutArb = 0x8DDA,
        [NativeName("Name", "GL_GEOMETRY_INPUT_TYPE_ARB")]
        GeometryInputTypeArb = 0x8DDB,
        [NativeName("Name", "GL_GEOMETRY_OUTPUT_TYPE_ARB")]
        GeometryOutputTypeArb = 0x8DDC,
        [NativeName("Name", "GL_MAX_GEOMETRY_VARYING_COMPONENTS_ARB")]
        MaxGeometryVaryingComponentsArb = 0x8DDD,
        [NativeName("Name", "GL_MAX_VERTEX_VARYING_COMPONENTS_ARB")]
        MaxVertexVaryingComponentsArb = 0x8DDE,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_COMPONENTS_ARB")]
        MaxGeometryUniformComponentsArb = 0x8DDF,
        [NativeName("Name", "GL_MAX_GEOMETRY_OUTPUT_VERTICES_ARB")]
        MaxGeometryOutputVerticesArb = 0x8DE0,
        [NativeName("Name", "GL_MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS_ARB")]
        MaxGeometryTotalOutputComponentsArb = 0x8DE1,
        [NativeName("Name", "GL_MAX_VARYING_COMPONENTS")]
        MaxVaryingComponents = 0x8B4B,
        [NativeName("Name", "GL_PROGRAM_BINARY_RETRIEVABLE_HINT")]
        ProgramBinaryRetrievableHint = 0x8257,
        [NativeName("Name", "GL_PROGRAM_BINARY_LENGTH")]
        ProgramBinaryLength = 0x8741,
        [NativeName("Name", "GL_NUM_PROGRAM_BINARY_FORMATS")]
        NumProgramBinaryFormats = 0x87FE,
        [NativeName("Name", "GL_PROGRAM_BINARY_FORMATS")]
        ProgramBinaryFormats = 0x87FF,
        [NativeName("Name", "GL_SHADER_BINARY_FORMAT_SPIR_V_ARB")]
        ShaderBinaryFormatSpirVArb = 0x9551,
        [NativeName("Name", "GL_SPIR_V_BINARY_ARB")]
        SpirVBinaryArb = 0x9552,
        [NativeName("Name", "GL_GEOMETRY_SHADER_INVOCATIONS")]
        GeometryShaderInvocations = 0x887F,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_INVOCATIONS")]
        MaxGeometryShaderInvocations = 0x8E5A,
        [NativeName("Name", "GL_MIN_FRAGMENT_INTERPOLATION_OFFSET")]
        MinFragmentInterpolationOffset = 0x8E5B,
        [NativeName("Name", "GL_MAX_FRAGMENT_INTERPOLATION_OFFSET")]
        MaxFragmentInterpolationOffset = 0x8E5C,
        [NativeName("Name", "GL_FRAGMENT_INTERPOLATION_OFFSET_BITS")]
        FragmentInterpolationOffsetBits = 0x8E5D,
        [NativeName("Name", "GL_MAX_VERTEX_STREAMS")]
        MaxVertexStreams = 0x8E71,
        [NativeName("Name", "GL_DOUBLE")]
        Double = 0x140A,
        [NativeName("Name", "GL_DOUBLE_VEC2")]
        DoubleVec2 = 0x8FFC,
        [NativeName("Name", "GL_DOUBLE_VEC3")]
        DoubleVec3 = 0x8FFD,
        [NativeName("Name", "GL_DOUBLE_VEC4")]
        DoubleVec4 = 0x8FFE,
        [NativeName("Name", "GL_DOUBLE_MAT2")]
        DoubleMat2 = 0x8F46,
        [NativeName("Name", "GL_DOUBLE_MAT3")]
        DoubleMat3 = 0x8F47,
        [NativeName("Name", "GL_DOUBLE_MAT4")]
        DoubleMat4 = 0x8F48,
        [NativeName("Name", "GL_DOUBLE_MAT2x3")]
        DoubleMat2x3 = 0x8F49,
        [NativeName("Name", "GL_DOUBLE_MAT2x4")]
        DoubleMat2x4 = 0x8F4A,
        [NativeName("Name", "GL_DOUBLE_MAT3x2")]
        DoubleMat3x2 = 0x8F4B,
        [NativeName("Name", "GL_DOUBLE_MAT3x4")]
        DoubleMat3x4 = 0x8F4C,
        [NativeName("Name", "GL_DOUBLE_MAT4x2")]
        DoubleMat4x2 = 0x8F4D,
        [NativeName("Name", "GL_DOUBLE_MAT4x3")]
        DoubleMat4x3 = 0x8F4E,
        [NativeName("Name", "GL_INT64_ARB")]
        Int64Arb = 0x140E,
        [NativeName("Name", "GL_INT64_VEC2_ARB")]
        Int64Vec2Arb = 0x8FE9,
        [NativeName("Name", "GL_INT64_VEC3_ARB")]
        Int64Vec3Arb = 0x8FEA,
        [NativeName("Name", "GL_INT64_VEC4_ARB")]
        Int64Vec4Arb = 0x8FEB,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC2_ARB")]
        UnsignedInt64Vec2Arb = 0x8FF5,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC3_ARB")]
        UnsignedInt64Vec3Arb = 0x8FF6,
        [NativeName("Name", "GL_UNSIGNED_INT64_VEC4_ARB")]
        UnsignedInt64Vec4Arb = 0x8FF7,
        [NativeName("Name", "GL_HALF_FLOAT_ARB")]
        HalfFloatArb = 0x140B,
        [NativeName("Name", "GL_HALF_FLOAT")]
        HalfFloat = 0x140B,
        [NativeName("Name", "GL_BLEND_COLOR")]
        BlendColor = 0x8005,
        [NativeName("Name", "GL_BLEND_EQUATION")]
        BlendEquation = 0x8009,
        [NativeName("Name", "GL_CONSTANT_COLOR")]
        ConstantColor = 0x8001,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_COLOR")]
        OneMinusConstantColor = 0x8002,
        [NativeName("Name", "GL_CONSTANT_ALPHA")]
        ConstantAlpha = 0x8003,
        [NativeName("Name", "GL_ONE_MINUS_CONSTANT_ALPHA")]
        OneMinusConstantAlpha = 0x8004,
        [NativeName("Name", "GL_FUNC_ADD")]
        FuncAdd = 0x8006,
        [NativeName("Name", "GL_FUNC_REVERSE_SUBTRACT")]
        FuncReverseSubtract = 0x800B,
        [NativeName("Name", "GL_FUNC_SUBTRACT")]
        FuncSubtract = 0x800A,
        [NativeName("Name", "GL_MIN")]
        Min = 0x8007,
        [NativeName("Name", "GL_MAX")]
        Max = 0x8008,
        [NativeName("Name", "GL_CONVOLUTION_1D")]
        Convolution1D = 0x8010,
        [NativeName("Name", "GL_CONVOLUTION_2D")]
        Convolution2D = 0x8011,
        [NativeName("Name", "GL_SEPARABLE_2D")]
        Separable2D = 0x8012,
        [NativeName("Name", "GL_CONVOLUTION_BORDER_MODE")]
        ConvolutionBorderMode = 0x8013,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_SCALE")]
        ConvolutionFilterScale = 0x8014,
        [NativeName("Name", "GL_CONVOLUTION_FILTER_BIAS")]
        ConvolutionFilterBias = 0x8015,
        [NativeName("Name", "GL_REDUCE")]
        Reduce = 0x8016,
        [NativeName("Name", "GL_CONVOLUTION_FORMAT")]
        ConvolutionFormat = 0x8017,
        [NativeName("Name", "GL_CONVOLUTION_WIDTH")]
        ConvolutionWidth = 0x8018,
        [NativeName("Name", "GL_CONVOLUTION_HEIGHT")]
        ConvolutionHeight = 0x8019,
        [NativeName("Name", "GL_MAX_CONVOLUTION_WIDTH")]
        MaxConvolutionWidth = 0x801A,
        [NativeName("Name", "GL_MAX_CONVOLUTION_HEIGHT")]
        MaxConvolutionHeight = 0x801B,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_SCALE")]
        PostConvolutionRedScale = 0x801C,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_SCALE")]
        PostConvolutionGreenScale = 0x801D,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_SCALE")]
        PostConvolutionBlueScale = 0x801E,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_SCALE")]
        PostConvolutionAlphaScale = 0x801F,
        [NativeName("Name", "GL_POST_CONVOLUTION_RED_BIAS")]
        PostConvolutionRedBias = 0x8020,
        [NativeName("Name", "GL_POST_CONVOLUTION_GREEN_BIAS")]
        PostConvolutionGreenBias = 0x8021,
        [NativeName("Name", "GL_POST_CONVOLUTION_BLUE_BIAS")]
        PostConvolutionBlueBias = 0x8022,
        [NativeName("Name", "GL_POST_CONVOLUTION_ALPHA_BIAS")]
        PostConvolutionAlphaBias = 0x8023,
        [NativeName("Name", "GL_HISTOGRAM")]
        Histogram = 0x8024,
        [NativeName("Name", "GL_PROXY_HISTOGRAM")]
        ProxyHistogram = 0x8025,
        [NativeName("Name", "GL_HISTOGRAM_WIDTH")]
        HistogramWidth = 0x8026,
        [NativeName("Name", "GL_HISTOGRAM_FORMAT")]
        HistogramFormat = 0x8027,
        [NativeName("Name", "GL_HISTOGRAM_RED_SIZE")]
        HistogramRedSize = 0x8028,
        [NativeName("Name", "GL_HISTOGRAM_GREEN_SIZE")]
        HistogramGreenSize = 0x8029,
        [NativeName("Name", "GL_HISTOGRAM_BLUE_SIZE")]
        HistogramBlueSize = 0x802A,
        [NativeName("Name", "GL_HISTOGRAM_ALPHA_SIZE")]
        HistogramAlphaSize = 0x802B,
        [NativeName("Name", "GL_HISTOGRAM_LUMINANCE_SIZE")]
        HistogramLuminanceSize = 0x802C,
        [NativeName("Name", "GL_HISTOGRAM_SINK")]
        HistogramSink = 0x802D,
        [NativeName("Name", "GL_MINMAX")]
        Minmax = 0x802E,
        [NativeName("Name", "GL_MINMAX_FORMAT")]
        MinmaxFormat = 0x802F,
        [NativeName("Name", "GL_MINMAX_SINK")]
        MinmaxSink = 0x8030,
        [NativeName("Name", "GL_TABLE_TOO_LARGE")]
        TableTooLarge = 0x8031,
        [NativeName("Name", "GL_COLOR_MATRIX")]
        ColorMatrix = 0x80B1,
        [NativeName("Name", "GL_COLOR_MATRIX_STACK_DEPTH")]
        ColorMatrixStackDepth = 0x80B2,
        [NativeName("Name", "GL_MAX_COLOR_MATRIX_STACK_DEPTH")]
        MaxColorMatrixStackDepth = 0x80B3,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_SCALE")]
        PostColorMatrixRedScale = 0x80B4,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_SCALE")]
        PostColorMatrixGreenScale = 0x80B5,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_SCALE")]
        PostColorMatrixBlueScale = 0x80B6,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_SCALE")]
        PostColorMatrixAlphaScale = 0x80B7,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_RED_BIAS")]
        PostColorMatrixRedBias = 0x80B8,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_GREEN_BIAS")]
        PostColorMatrixGreenBias = 0x80B9,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_BLUE_BIAS")]
        PostColorMatrixBlueBias = 0x80BA,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_ALPHA_BIAS")]
        PostColorMatrixAlphaBias = 0x80BB,
        [NativeName("Name", "GL_COLOR_TABLE")]
        ColorTable = 0x80D0,
        [NativeName("Name", "GL_POST_CONVOLUTION_COLOR_TABLE")]
        PostConvolutionColorTable = 0x80D1,
        [NativeName("Name", "GL_POST_COLOR_MATRIX_COLOR_TABLE")]
        PostColorMatrixColorTable = 0x80D2,
        [NativeName("Name", "GL_PROXY_COLOR_TABLE")]
        ProxyColorTable = 0x80D3,
        [NativeName("Name", "GL_PROXY_POST_CONVOLUTION_COLOR_TABLE")]
        ProxyPostConvolutionColorTable = 0x80D4,
        [NativeName("Name", "GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE")]
        ProxyPostColorMatrixColorTable = 0x80D5,
        [NativeName("Name", "GL_COLOR_TABLE_SCALE")]
        ColorTableScale = 0x80D6,
        [NativeName("Name", "GL_COLOR_TABLE_BIAS")]
        ColorTableBias = 0x80D7,
        [NativeName("Name", "GL_COLOR_TABLE_FORMAT")]
        ColorTableFormat = 0x80D8,
        [NativeName("Name", "GL_COLOR_TABLE_WIDTH")]
        ColorTableWidth = 0x80D9,
        [NativeName("Name", "GL_COLOR_TABLE_RED_SIZE")]
        ColorTableRedSize = 0x80DA,
        [NativeName("Name", "GL_COLOR_TABLE_GREEN_SIZE")]
        ColorTableGreenSize = 0x80DB,
        [NativeName("Name", "GL_COLOR_TABLE_BLUE_SIZE")]
        ColorTableBlueSize = 0x80DC,
        [NativeName("Name", "GL_COLOR_TABLE_ALPHA_SIZE")]
        ColorTableAlphaSize = 0x80DD,
        [NativeName("Name", "GL_COLOR_TABLE_LUMINANCE_SIZE")]
        ColorTableLuminanceSize = 0x80DE,
        [NativeName("Name", "GL_COLOR_TABLE_INTENSITY_SIZE")]
        ColorTableIntensitySize = 0x80DF,
        [NativeName("Name", "GL_CONSTANT_BORDER")]
        ConstantBorder = 0x8151,
        [NativeName("Name", "GL_REPLICATE_BORDER")]
        ReplicateBorder = 0x8153,
        [NativeName("Name", "GL_CONVOLUTION_BORDER_COLOR")]
        ConvolutionBorderColor = 0x8154,
        [NativeName("Name", "GL_PARAMETER_BUFFER_ARB")]
        ParameterBufferArb = 0x80EE,
        [NativeName("Name", "GL_PARAMETER_BUFFER_BINDING_ARB")]
        ParameterBufferBindingArb = 0x80EF,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_DIVISOR_ARB")]
        VertexAttribArrayDivisorArb = 0x88FE,
        [NativeName("Name", "GL_NUM_SAMPLE_COUNTS")]
        NumSampleCounts = 0x9380,
        [NativeName("Name", "GL_IMAGE_FORMAT_COMPATIBILITY_TYPE")]
        ImageFormatCompatibilityType = 0x90C7,
        [NativeName("Name", "GL_SAMPLES")]
        Samples = 0x80A9,
        [NativeName("Name", "GL_TEXTURE_1D")]
        Texture1D = 0xDE0,
        [NativeName("Name", "GL_TEXTURE_1D_ARRAY")]
        Texture1DArray = 0x8C18,
        [NativeName("Name", "GL_TEXTURE_2D")]
        Texture2D = 0xDE1,
        [NativeName("Name", "GL_TEXTURE_2D_ARRAY")]
        Texture2DArray = 0x8C1A,
        [NativeName("Name", "GL_TEXTURE_3D")]
        Texture3D = 0x806F,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP")]
        TextureCubeMap = 0x8513,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY")]
        TextureCubeMapArray = 0x9009,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE")]
        TextureRectangle = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_BUFFER")]
        TextureBuffer = 0x8C2A,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE")]
        Texture2DMultisample = 0x9100,
        [NativeName("Name", "GL_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        Texture2DMultisampleArray = 0x9102,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED")]
        TextureCompressed = 0x86A1,
        [NativeName("Name", "GL_INTERNALFORMAT_SUPPORTED")]
        InternalformatSupported = 0x826F,
        [NativeName("Name", "GL_INTERNALFORMAT_PREFERRED")]
        InternalformatPreferred = 0x8270,
        [NativeName("Name", "GL_INTERNALFORMAT_RED_SIZE")]
        InternalformatRedSize = 0x8271,
        [NativeName("Name", "GL_INTERNALFORMAT_GREEN_SIZE")]
        InternalformatGreenSize = 0x8272,
        [NativeName("Name", "GL_INTERNALFORMAT_BLUE_SIZE")]
        InternalformatBlueSize = 0x8273,
        [NativeName("Name", "GL_INTERNALFORMAT_ALPHA_SIZE")]
        InternalformatAlphaSize = 0x8274,
        [NativeName("Name", "GL_INTERNALFORMAT_DEPTH_SIZE")]
        InternalformatDepthSize = 0x8275,
        [NativeName("Name", "GL_INTERNALFORMAT_STENCIL_SIZE")]
        InternalformatStencilSize = 0x8276,
        [NativeName("Name", "GL_INTERNALFORMAT_SHARED_SIZE")]
        InternalformatSharedSize = 0x8277,
        [NativeName("Name", "GL_INTERNALFORMAT_RED_TYPE")]
        InternalformatRedType = 0x8278,
        [NativeName("Name", "GL_INTERNALFORMAT_GREEN_TYPE")]
        InternalformatGreenType = 0x8279,
        [NativeName("Name", "GL_INTERNALFORMAT_BLUE_TYPE")]
        InternalformatBlueType = 0x827A,
        [NativeName("Name", "GL_INTERNALFORMAT_ALPHA_TYPE")]
        InternalformatAlphaType = 0x827B,
        [NativeName("Name", "GL_INTERNALFORMAT_DEPTH_TYPE")]
        InternalformatDepthType = 0x827C,
        [NativeName("Name", "GL_INTERNALFORMAT_STENCIL_TYPE")]
        InternalformatStencilType = 0x827D,
        [NativeName("Name", "GL_MAX_WIDTH")]
        MaxWidth = 0x827E,
        [NativeName("Name", "GL_MAX_HEIGHT")]
        MaxHeight = 0x827F,
        [NativeName("Name", "GL_MAX_DEPTH")]
        MaxDepth = 0x8280,
        [NativeName("Name", "GL_MAX_LAYERS")]
        MaxLayers = 0x8281,
        [NativeName("Name", "GL_MAX_COMBINED_DIMENSIONS")]
        MaxCombinedDimensions = 0x8282,
        [NativeName("Name", "GL_COLOR_COMPONENTS")]
        ColorComponents = 0x8283,
        [NativeName("Name", "GL_DEPTH_COMPONENTS")]
        DepthComponents = 0x8284,
        [NativeName("Name", "GL_STENCIL_COMPONENTS")]
        StencilComponents = 0x8285,
        [NativeName("Name", "GL_COLOR_RENDERABLE")]
        ColorRenderable = 0x8286,
        [NativeName("Name", "GL_DEPTH_RENDERABLE")]
        DepthRenderable = 0x8287,
        [NativeName("Name", "GL_STENCIL_RENDERABLE")]
        StencilRenderable = 0x8288,
        [NativeName("Name", "GL_FRAMEBUFFER_RENDERABLE")]
        FramebufferRenderable = 0x8289,
        [NativeName("Name", "GL_FRAMEBUFFER_RENDERABLE_LAYERED")]
        FramebufferRenderableLayered = 0x828A,
        [NativeName("Name", "GL_FRAMEBUFFER_BLEND")]
        FramebufferBlend = 0x828B,
        [NativeName("Name", "GL_READ_PIXELS")]
        ReadPixels = 0x828C,
        [NativeName("Name", "GL_READ_PIXELS_FORMAT")]
        ReadPixelsFormat = 0x828D,
        [NativeName("Name", "GL_READ_PIXELS_TYPE")]
        ReadPixelsType = 0x828E,
        [NativeName("Name", "GL_TEXTURE_IMAGE_FORMAT")]
        TextureImageFormat = 0x828F,
        [NativeName("Name", "GL_TEXTURE_IMAGE_TYPE")]
        TextureImageType = 0x8290,
        [NativeName("Name", "GL_GET_TEXTURE_IMAGE_FORMAT")]
        GetTextureImageFormat = 0x8291,
        [NativeName("Name", "GL_GET_TEXTURE_IMAGE_TYPE")]
        GetTextureImageType = 0x8292,
        [NativeName("Name", "GL_MIPMAP")]
        Mipmap = 0x8293,
        [NativeName("Name", "GL_MANUAL_GENERATE_MIPMAP")]
        ManualGenerateMipmap = 0x8294,
        [NativeName("Name", "GL_AUTO_GENERATE_MIPMAP")]
        AutoGenerateMipmap = 0x8295,
        [NativeName("Name", "GL_COLOR_ENCODING")]
        ColorEncoding = 0x8296,
        [NativeName("Name", "GL_SRGB_READ")]
        SrgbRead = 0x8297,
        [NativeName("Name", "GL_SRGB_WRITE")]
        SrgbWrite = 0x8298,
        [NativeName("Name", "GL_SRGB_DECODE_ARB")]
        SrgbDecodeArb = 0x8299,
        [NativeName("Name", "GL_FILTER")]
        Filter = 0x829A,
        [NativeName("Name", "GL_VERTEX_TEXTURE")]
        VertexTexture = 0x829B,
        [NativeName("Name", "GL_TESS_CONTROL_TEXTURE")]
        TessControlTexture = 0x829C,
        [NativeName("Name", "GL_TESS_EVALUATION_TEXTURE")]
        TessEvaluationTexture = 0x829D,
        [NativeName("Name", "GL_GEOMETRY_TEXTURE")]
        GeometryTexture = 0x829E,
        [NativeName("Name", "GL_FRAGMENT_TEXTURE")]
        FragmentTexture = 0x829F,
        [NativeName("Name", "GL_COMPUTE_TEXTURE")]
        ComputeTexture = 0x82A0,
        [NativeName("Name", "GL_TEXTURE_SHADOW")]
        TextureShadow = 0x82A1,
        [NativeName("Name", "GL_TEXTURE_GATHER")]
        TextureGather = 0x82A2,
        [NativeName("Name", "GL_TEXTURE_GATHER_SHADOW")]
        TextureGatherShadow = 0x82A3,
        [NativeName("Name", "GL_SHADER_IMAGE_LOAD")]
        ShaderImageLoad = 0x82A4,
        [NativeName("Name", "GL_SHADER_IMAGE_STORE")]
        ShaderImageStore = 0x82A5,
        [NativeName("Name", "GL_SHADER_IMAGE_ATOMIC")]
        ShaderImageAtomic = 0x82A6,
        [NativeName("Name", "GL_IMAGE_TEXEL_SIZE")]
        ImageTexelSize = 0x82A7,
        [NativeName("Name", "GL_IMAGE_COMPATIBILITY_CLASS")]
        ImageCompatibilityClass = 0x82A8,
        [NativeName("Name", "GL_IMAGE_PIXEL_FORMAT")]
        ImagePixelFormat = 0x82A9,
        [NativeName("Name", "GL_IMAGE_PIXEL_TYPE")]
        ImagePixelType = 0x82AA,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST")]
        SimultaneousTextureAndDepthTest = 0x82AC,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST")]
        SimultaneousTextureAndStencilTest = 0x82AD,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE")]
        SimultaneousTextureAndDepthWrite = 0x82AE,
        [NativeName("Name", "GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE")]
        SimultaneousTextureAndStencilWrite = 0x82AF,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_BLOCK_WIDTH")]
        TextureCompressedBlockWidth = 0x82B1,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT")]
        TextureCompressedBlockHeight = 0x82B2,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_BLOCK_SIZE")]
        TextureCompressedBlockSize = 0x82B3,
        [NativeName("Name", "GL_CLEAR_BUFFER")]
        ClearBuffer = 0x82B4,
        [NativeName("Name", "GL_TEXTURE_VIEW")]
        TextureView = 0x82B5,
        [NativeName("Name", "GL_VIEW_COMPATIBILITY_CLASS")]
        ViewCompatibilityClass = 0x82B6,
        [NativeName("Name", "GL_FULL_SUPPORT")]
        FullSupport = 0x82B7,
        [NativeName("Name", "GL_CAVEAT_SUPPORT")]
        CaveatSupport = 0x82B8,
        [NativeName("Name", "GL_IMAGE_CLASS_4_X_32")]
        ImageClass4X32 = 0x82B9,
        [NativeName("Name", "GL_IMAGE_CLASS_2_X_32")]
        ImageClass2X32 = 0x82BA,
        [NativeName("Name", "GL_IMAGE_CLASS_1_X_32")]
        ImageClass1X32 = 0x82BB,
        [NativeName("Name", "GL_IMAGE_CLASS_4_X_16")]
        ImageClass4X16 = 0x82BC,
        [NativeName("Name", "GL_IMAGE_CLASS_2_X_16")]
        ImageClass2X16 = 0x82BD,
        [NativeName("Name", "GL_IMAGE_CLASS_1_X_16")]
        ImageClass1X16 = 0x82BE,
        [NativeName("Name", "GL_IMAGE_CLASS_4_X_8")]
        ImageClass4X8 = 0x82BF,
        [NativeName("Name", "GL_IMAGE_CLASS_2_X_8")]
        ImageClass2X8 = 0x82C0,
        [NativeName("Name", "GL_IMAGE_CLASS_1_X_8")]
        ImageClass1X8 = 0x82C1,
        [NativeName("Name", "GL_IMAGE_CLASS_11_11_10")]
        ImageClass111110 = 0x82C2,
        [NativeName("Name", "GL_IMAGE_CLASS_10_10_10_2")]
        ImageClass1010102 = 0x82C3,
        [NativeName("Name", "GL_VIEW_CLASS_128_BITS")]
        ViewClass128Bits = 0x82C4,
        [NativeName("Name", "GL_VIEW_CLASS_96_BITS")]
        ViewClass96Bits = 0x82C5,
        [NativeName("Name", "GL_VIEW_CLASS_64_BITS")]
        ViewClass64Bits = 0x82C6,
        [NativeName("Name", "GL_VIEW_CLASS_48_BITS")]
        ViewClass48Bits = 0x82C7,
        [NativeName("Name", "GL_VIEW_CLASS_32_BITS")]
        ViewClass32Bits = 0x82C8,
        [NativeName("Name", "GL_VIEW_CLASS_24_BITS")]
        ViewClass24Bits = 0x82C9,
        [NativeName("Name", "GL_VIEW_CLASS_16_BITS")]
        ViewClass16Bits = 0x82CA,
        [NativeName("Name", "GL_VIEW_CLASS_8_BITS")]
        ViewClass8Bits = 0x82CB,
        [NativeName("Name", "GL_VIEW_CLASS_S3TC_DXT1_RGB")]
        ViewClassS3TCDxt1Rgb = 0x82CC,
        [NativeName("Name", "GL_VIEW_CLASS_S3TC_DXT1_RGBA")]
        ViewClassS3TCDxt1Rgba = 0x82CD,
        [NativeName("Name", "GL_VIEW_CLASS_S3TC_DXT3_RGBA")]
        ViewClassS3TCDxt3Rgba = 0x82CE,
        [NativeName("Name", "GL_VIEW_CLASS_S3TC_DXT5_RGBA")]
        ViewClassS3TCDxt5Rgba = 0x82CF,
        [NativeName("Name", "GL_VIEW_CLASS_RGTC1_RED")]
        ViewClassRgtc1Red = 0x82D0,
        [NativeName("Name", "GL_VIEW_CLASS_RGTC2_RG")]
        ViewClassRgtc2RG = 0x82D1,
        [NativeName("Name", "GL_VIEW_CLASS_BPTC_UNORM")]
        ViewClassBptcUnorm = 0x82D2,
        [NativeName("Name", "GL_VIEW_CLASS_BPTC_FLOAT")]
        ViewClassBptcFloat = 0x82D3,
        [NativeName("Name", "GL_VIEW_CLASS_EAC_R11")]
        ViewClassEacR11 = 0x9383,
        [NativeName("Name", "GL_VIEW_CLASS_EAC_RG11")]
        ViewClassEacRG11 = 0x9384,
        [NativeName("Name", "GL_VIEW_CLASS_ETC2_RGB")]
        ViewClassEtc2Rgb = 0x9385,
        [NativeName("Name", "GL_VIEW_CLASS_ETC2_RGBA")]
        ViewClassEtc2Rgba = 0x9386,
        [NativeName("Name", "GL_VIEW_CLASS_ETC2_EAC_RGBA")]
        ViewClassEtc2EacRgba = 0x9387,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_4x4_RGBA")]
        ViewClassAstc4x4Rgba = 0x9388,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_5x4_RGBA")]
        ViewClassAstc5x4Rgba = 0x9389,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_5x5_RGBA")]
        ViewClassAstc5x5Rgba = 0x938A,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_6x5_RGBA")]
        ViewClassAstc6x5Rgba = 0x938B,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_6x6_RGBA")]
        ViewClassAstc6x6Rgba = 0x938C,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_8x5_RGBA")]
        ViewClassAstc8x5Rgba = 0x938D,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_8x6_RGBA")]
        ViewClassAstc8x6Rgba = 0x938E,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_8x8_RGBA")]
        ViewClassAstc8x8Rgba = 0x938F,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_10x5_RGBA")]
        ViewClassAstc10x5Rgba = 0x9390,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_10x6_RGBA")]
        ViewClassAstc10x6Rgba = 0x9391,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_10x8_RGBA")]
        ViewClassAstc10x8Rgba = 0x9392,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_10x10_RGBA")]
        ViewClassAstc10x10Rgba = 0x9393,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_12x10_RGBA")]
        ViewClassAstc12x10Rgba = 0x9394,
        [NativeName("Name", "GL_VIEW_CLASS_ASTC_12x12_RGBA")]
        ViewClassAstc12x12Rgba = 0x9395,
        [NativeName("Name", "GL_MIN_MAP_BUFFER_ALIGNMENT")]
        MinMapBufferAlignment = 0x90BC,
        [NativeName("Name", "GL_MAP_INVALIDATE_RANGE_BIT")]
        MapInvalidateRangeBit = 0x4,
        [NativeName("Name", "GL_MAP_INVALIDATE_BUFFER_BIT")]
        MapInvalidateBufferBit = 0x8,
        [NativeName("Name", "GL_MAP_FLUSH_EXPLICIT_BIT")]
        MapFlushExplicitBit = 0x10,
        [NativeName("Name", "GL_MAP_UNSYNCHRONIZED_BIT")]
        MapUnsynchronizedBit = 0x20,
        [NativeName("Name", "GL_MATRIX_PALETTE_ARB")]
        MatrixPaletteArb = 0x8840,
        [NativeName("Name", "GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB")]
        MaxMatrixPaletteStackDepthArb = 0x8841,
        [NativeName("Name", "GL_MAX_PALETTE_MATRICES_ARB")]
        MaxPaletteMatricesArb = 0x8842,
        [NativeName("Name", "GL_CURRENT_PALETTE_MATRIX_ARB")]
        CurrentPaletteMatrixArb = 0x8843,
        [NativeName("Name", "GL_MATRIX_INDEX_ARRAY_ARB")]
        MatrixIndexArrayArb = 0x8844,
        [NativeName("Name", "GL_CURRENT_MATRIX_INDEX_ARB")]
        CurrentMatrixIndexArb = 0x8845,
        [NativeName("Name", "GL_MATRIX_INDEX_ARRAY_SIZE_ARB")]
        MatrixIndexArraySizeArb = 0x8846,
        [NativeName("Name", "GL_MATRIX_INDEX_ARRAY_TYPE_ARB")]
        MatrixIndexArrayTypeArb = 0x8847,
        [NativeName("Name", "GL_MATRIX_INDEX_ARRAY_STRIDE_ARB")]
        MatrixIndexArrayStrideArb = 0x8848,
        [NativeName("Name", "GL_MATRIX_INDEX_ARRAY_POINTER_ARB")]
        MatrixIndexArrayPointerArb = 0x8849,
        [NativeName("Name", "GL_MULTISAMPLE_ARB")]
        MultisampleArb = 0x809D,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_COVERAGE_ARB")]
        SampleAlphaToCoverageArb = 0x809E,
        [NativeName("Name", "GL_SAMPLE_ALPHA_TO_ONE_ARB")]
        SampleAlphaToOneArb = 0x809F,
        [NativeName("Name", "GL_SAMPLE_COVERAGE_ARB")]
        SampleCoverageArb = 0x80A0,
        [NativeName("Name", "GL_SAMPLE_BUFFERS_ARB")]
        SampleBuffersArb = 0x80A8,
        [NativeName("Name", "GL_SAMPLES_ARB")]
        SamplesArb = 0x80A9,
        [NativeName("Name", "GL_SAMPLE_COVERAGE_VALUE_ARB")]
        SampleCoverageValueArb = 0x80AA,
        [NativeName("Name", "GL_SAMPLE_COVERAGE_INVERT_ARB")]
        SampleCoverageInvertArb = 0x80AB,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_ARB")]
        MultisampleBitArb = 0x20000000,
        [NativeName("Name", "GL_TEXTURE0_ARB")]
        Texture0Arb = 0x84C0,
        [NativeName("Name", "GL_TEXTURE1_ARB")]
        Texture1Arb = 0x84C1,
        [NativeName("Name", "GL_TEXTURE2_ARB")]
        Texture2Arb = 0x84C2,
        [NativeName("Name", "GL_TEXTURE3_ARB")]
        Texture3Arb = 0x84C3,
        [NativeName("Name", "GL_TEXTURE4_ARB")]
        Texture4Arb = 0x84C4,
        [NativeName("Name", "GL_TEXTURE5_ARB")]
        Texture5Arb = 0x84C5,
        [NativeName("Name", "GL_TEXTURE6_ARB")]
        Texture6Arb = 0x84C6,
        [NativeName("Name", "GL_TEXTURE7_ARB")]
        Texture7Arb = 0x84C7,
        [NativeName("Name", "GL_TEXTURE8_ARB")]
        Texture8Arb = 0x84C8,
        [NativeName("Name", "GL_TEXTURE9_ARB")]
        Texture9Arb = 0x84C9,
        [NativeName("Name", "GL_TEXTURE10_ARB")]
        Texture10Arb = 0x84CA,
        [NativeName("Name", "GL_TEXTURE11_ARB")]
        Texture11Arb = 0x84CB,
        [NativeName("Name", "GL_TEXTURE12_ARB")]
        Texture12Arb = 0x84CC,
        [NativeName("Name", "GL_TEXTURE13_ARB")]
        Texture13Arb = 0x84CD,
        [NativeName("Name", "GL_TEXTURE14_ARB")]
        Texture14Arb = 0x84CE,
        [NativeName("Name", "GL_TEXTURE15_ARB")]
        Texture15Arb = 0x84CF,
        [NativeName("Name", "GL_TEXTURE16_ARB")]
        Texture16Arb = 0x84D0,
        [NativeName("Name", "GL_TEXTURE17_ARB")]
        Texture17Arb = 0x84D1,
        [NativeName("Name", "GL_TEXTURE18_ARB")]
        Texture18Arb = 0x84D2,
        [NativeName("Name", "GL_TEXTURE19_ARB")]
        Texture19Arb = 0x84D3,
        [NativeName("Name", "GL_TEXTURE20_ARB")]
        Texture20Arb = 0x84D4,
        [NativeName("Name", "GL_TEXTURE21_ARB")]
        Texture21Arb = 0x84D5,
        [NativeName("Name", "GL_TEXTURE22_ARB")]
        Texture22Arb = 0x84D6,
        [NativeName("Name", "GL_TEXTURE23_ARB")]
        Texture23Arb = 0x84D7,
        [NativeName("Name", "GL_TEXTURE24_ARB")]
        Texture24Arb = 0x84D8,
        [NativeName("Name", "GL_TEXTURE25_ARB")]
        Texture25Arb = 0x84D9,
        [NativeName("Name", "GL_TEXTURE26_ARB")]
        Texture26Arb = 0x84DA,
        [NativeName("Name", "GL_TEXTURE27_ARB")]
        Texture27Arb = 0x84DB,
        [NativeName("Name", "GL_TEXTURE28_ARB")]
        Texture28Arb = 0x84DC,
        [NativeName("Name", "GL_TEXTURE29_ARB")]
        Texture29Arb = 0x84DD,
        [NativeName("Name", "GL_TEXTURE30_ARB")]
        Texture30Arb = 0x84DE,
        [NativeName("Name", "GL_TEXTURE31_ARB")]
        Texture31Arb = 0x84DF,
        [NativeName("Name", "GL_ACTIVE_TEXTURE_ARB")]
        ActiveTextureArb = 0x84E0,
        [NativeName("Name", "GL_CLIENT_ACTIVE_TEXTURE_ARB")]
        ClientActiveTextureArb = 0x84E1,
        [NativeName("Name", "GL_MAX_TEXTURE_UNITS_ARB")]
        MaxTextureUnitsArb = 0x84E2,
        [NativeName("Name", "GL_QUERY_COUNTER_BITS_ARB")]
        QueryCounterBitsArb = 0x8864,
        [NativeName("Name", "GL_CURRENT_QUERY_ARB")]
        CurrentQueryArb = 0x8865,
        [NativeName("Name", "GL_QUERY_RESULT_ARB")]
        QueryResultArb = 0x8866,
        [NativeName("Name", "GL_QUERY_RESULT_AVAILABLE_ARB")]
        QueryResultAvailableArb = 0x8867,
        [NativeName("Name", "GL_SAMPLES_PASSED_ARB")]
        SamplesPassedArb = 0x8914,
        [NativeName("Name", "GL_ANY_SAMPLES_PASSED")]
        AnySamplesPassed = 0x8C2F,
        [NativeName("Name", "GL_MAX_SHADER_COMPILER_THREADS_ARB")]
        MaxShaderCompilerThreadsArb = 0x91B0,
        [NativeName("Name", "GL_COMPLETION_STATUS_ARB")]
        CompletionStatusArb = 0x91B1,
        [NativeName("Name", "GL_VERTICES_SUBMITTED_ARB")]
        VerticesSubmittedArb = 0x82EE,
        [NativeName("Name", "GL_PRIMITIVES_SUBMITTED_ARB")]
        PrimitivesSubmittedArb = 0x82EF,
        [NativeName("Name", "GL_VERTEX_SHADER_INVOCATIONS_ARB")]
        VertexShaderInvocationsArb = 0x82F0,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_PATCHES_ARB")]
        TessControlShaderPatchesArb = 0x82F1,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_INVOCATIONS_ARB")]
        TessEvaluationShaderInvocationsArb = 0x82F2,
        [NativeName("Name", "GL_GEOMETRY_SHADER_PRIMITIVES_EMITTED_ARB")]
        GeometryShaderPrimitivesEmittedArb = 0x82F3,
        [NativeName("Name", "GL_FRAGMENT_SHADER_INVOCATIONS_ARB")]
        FragmentShaderInvocationsArb = 0x82F4,
        [NativeName("Name", "GL_COMPUTE_SHADER_INVOCATIONS_ARB")]
        ComputeShaderInvocationsArb = 0x82F5,
        [NativeName("Name", "GL_CLIPPING_INPUT_PRIMITIVES_ARB")]
        ClippingInputPrimitivesArb = 0x82F6,
        [NativeName("Name", "GL_CLIPPING_OUTPUT_PRIMITIVES_ARB")]
        ClippingOutputPrimitivesArb = 0x82F7,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_ARB")]
        PixelPackBufferArb = 0x88EB,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_ARB")]
        PixelUnpackBufferArb = 0x88EC,
        [NativeName("Name", "GL_PIXEL_PACK_BUFFER_BINDING_ARB")]
        PixelPackBufferBindingArb = 0x88ED,
        [NativeName("Name", "GL_PIXEL_UNPACK_BUFFER_BINDING_ARB")]
        PixelUnpackBufferBindingArb = 0x88EF,
        [NativeName("Name", "GL_POINT_SIZE_MIN_ARB")]
        PointSizeMinArb = 0x8126,
        [NativeName("Name", "GL_POINT_SIZE_MAX_ARB")]
        PointSizeMaxArb = 0x8127,
        [NativeName("Name", "GL_POINT_FADE_THRESHOLD_SIZE_ARB")]
        PointFadeThresholdSizeArb = 0x8128,
        [NativeName("Name", "GL_POINT_DISTANCE_ATTENUATION_ARB")]
        PointDistanceAttenuationArb = 0x8129,
        [NativeName("Name", "GL_POINT_SPRITE_ARB")]
        PointSpriteArb = 0x8861,
        [NativeName("Name", "GL_COORD_REPLACE_ARB")]
        CoordReplaceArb = 0x8862,
        [NativeName("Name", "GL_POLYGON_OFFSET_CLAMP")]
        PolygonOffsetClamp = 0x8E1B,
        [NativeName("Name", "GL_UNIFORM")]
        Uniform = 0x92E1,
        [NativeName("Name", "GL_UNIFORM_BLOCK")]
        UniformBlock = 0x92E2,
        [NativeName("Name", "GL_PROGRAM_INPUT")]
        ProgramInput = 0x92E3,
        [NativeName("Name", "GL_PROGRAM_OUTPUT")]
        ProgramOutput = 0x92E4,
        [NativeName("Name", "GL_BUFFER_VARIABLE")]
        BufferVariable = 0x92E5,
        [NativeName("Name", "GL_SHADER_STORAGE_BLOCK")]
        ShaderStorageBlock = 0x92E6,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER")]
        AtomicCounterBuffer = 0x92C0,
        [NativeName("Name", "GL_VERTEX_SUBROUTINE")]
        VertexSubroutine = 0x92E8,
        [NativeName("Name", "GL_TESS_CONTROL_SUBROUTINE")]
        TessControlSubroutine = 0x92E9,
        [NativeName("Name", "GL_TESS_EVALUATION_SUBROUTINE")]
        TessEvaluationSubroutine = 0x92EA,
        [NativeName("Name", "GL_GEOMETRY_SUBROUTINE")]
        GeometrySubroutine = 0x92EB,
        [NativeName("Name", "GL_FRAGMENT_SUBROUTINE")]
        FragmentSubroutine = 0x92EC,
        [NativeName("Name", "GL_COMPUTE_SUBROUTINE")]
        ComputeSubroutine = 0x92ED,
        [NativeName("Name", "GL_VERTEX_SUBROUTINE_UNIFORM")]
        VertexSubroutineUniform = 0x92EE,
        [NativeName("Name", "GL_TESS_CONTROL_SUBROUTINE_UNIFORM")]
        TessControlSubroutineUniform = 0x92EF,
        [NativeName("Name", "GL_TESS_EVALUATION_SUBROUTINE_UNIFORM")]
        TessEvaluationSubroutineUniform = 0x92F0,
        [NativeName("Name", "GL_GEOMETRY_SUBROUTINE_UNIFORM")]
        GeometrySubroutineUniform = 0x92F1,
        [NativeName("Name", "GL_FRAGMENT_SUBROUTINE_UNIFORM")]
        FragmentSubroutineUniform = 0x92F2,
        [NativeName("Name", "GL_COMPUTE_SUBROUTINE_UNIFORM")]
        ComputeSubroutineUniform = 0x92F3,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_VARYING")]
        TransformFeedbackVarying = 0x92F4,
        [NativeName("Name", "GL_ACTIVE_RESOURCES")]
        ActiveResources = 0x92F5,
        [NativeName("Name", "GL_MAX_NAME_LENGTH")]
        MaxNameLength = 0x92F6,
        [NativeName("Name", "GL_MAX_NUM_ACTIVE_VARIABLES")]
        MaxNumActiveVariables = 0x92F7,
        [NativeName("Name", "GL_MAX_NUM_COMPATIBLE_SUBROUTINES")]
        MaxNumCompatibleSubroutines = 0x92F8,
        [NativeName("Name", "GL_NAME_LENGTH")]
        NameLength = 0x92F9,
        [NativeName("Name", "GL_TYPE")]
        Type = 0x92FA,
        [NativeName("Name", "GL_ARRAY_SIZE")]
        ArraySize = 0x92FB,
        [NativeName("Name", "GL_OFFSET")]
        Offset = 0x92FC,
        [NativeName("Name", "GL_BLOCK_INDEX")]
        BlockIndex = 0x92FD,
        [NativeName("Name", "GL_ARRAY_STRIDE")]
        ArrayStride = 0x92FE,
        [NativeName("Name", "GL_MATRIX_STRIDE")]
        MatrixStride = 0x92FF,
        [NativeName("Name", "GL_IS_ROW_MAJOR")]
        IsRowMajor = 0x9300,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_INDEX")]
        AtomicCounterBufferIndex = 0x9301,
        [NativeName("Name", "GL_BUFFER_BINDING")]
        BufferBinding = 0x9302,
        [NativeName("Name", "GL_BUFFER_DATA_SIZE")]
        BufferDataSize = 0x9303,
        [NativeName("Name", "GL_NUM_ACTIVE_VARIABLES")]
        NumActiveVariables = 0x9304,
        [NativeName("Name", "GL_ACTIVE_VARIABLES")]
        ActiveVariables = 0x9305,
        [NativeName("Name", "GL_REFERENCED_BY_VERTEX_SHADER")]
        ReferencedByVertexShader = 0x9306,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_CONTROL_SHADER")]
        ReferencedByTessControlShader = 0x9307,
        [NativeName("Name", "GL_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        ReferencedByTessEvaluationShader = 0x9308,
        [NativeName("Name", "GL_REFERENCED_BY_GEOMETRY_SHADER")]
        ReferencedByGeometryShader = 0x9309,
        [NativeName("Name", "GL_REFERENCED_BY_FRAGMENT_SHADER")]
        ReferencedByFragmentShader = 0x930A,
        [NativeName("Name", "GL_REFERENCED_BY_COMPUTE_SHADER")]
        ReferencedByComputeShader = 0x930B,
        [NativeName("Name", "GL_TOP_LEVEL_ARRAY_SIZE")]
        TopLevelArraySize = 0x930C,
        [NativeName("Name", "GL_TOP_LEVEL_ARRAY_STRIDE")]
        TopLevelArrayStride = 0x930D,
        [NativeName("Name", "GL_LOCATION")]
        Location = 0x930E,
        [NativeName("Name", "GL_LOCATION_INDEX")]
        LocationIndex = 0x930F,
        [NativeName("Name", "GL_IS_PER_PATCH")]
        IsPerPatch = 0x92E7,
        [NativeName("Name", "GL_NUM_COMPATIBLE_SUBROUTINES")]
        NumCompatibleSubroutines = 0x8E4A,
        [NativeName("Name", "GL_COMPATIBLE_SUBROUTINES")]
        CompatibleSubroutines = 0x8E4B,
        [NativeName("Name", "GL_QUADS_FOLLOW_PROVOKING_VERTEX_CONVENTION")]
        QuadsFollowProvokingVertexConvention = 0x8E4C,
        [NativeName("Name", "GL_FIRST_VERTEX_CONVENTION")]
        FirstVertexConvention = 0x8E4D,
        [NativeName("Name", "GL_LAST_VERTEX_CONVENTION")]
        LastVertexConvention = 0x8E4E,
        [NativeName("Name", "GL_PROVOKING_VERTEX")]
        ProvokingVertex = 0x8E4F,
        [NativeName("Name", "GL_QUERY_BUFFER")]
        QueryBuffer = 0x9192,
        [NativeName("Name", "GL_QUERY_BUFFER_BARRIER_BIT")]
        QueryBufferBarrierBit = 0x8000,
        [NativeName("Name", "GL_QUERY_BUFFER_BINDING")]
        QueryBufferBinding = 0x9193,
        [NativeName("Name", "GL_QUERY_RESULT_NO_WAIT")]
        QueryResultNoWait = 0x9194,
        [NativeName("Name", "GL_NO_ERROR")]
        NoError = 0x0,
        [NativeName("Name", "GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB")]
        ContextFlagRobustAccessBitArb = 0x4,
        [NativeName("Name", "GL_LOSE_CONTEXT_ON_RESET_ARB")]
        LoseContextOnResetArb = 0x8252,
        [NativeName("Name", "GL_GUILTY_CONTEXT_RESET_ARB")]
        GuiltyContextResetArb = 0x8253,
        [NativeName("Name", "GL_INNOCENT_CONTEXT_RESET_ARB")]
        InnocentContextResetArb = 0x8254,
        [NativeName("Name", "GL_UNKNOWN_CONTEXT_RESET_ARB")]
        UnknownContextResetArb = 0x8255,
        [NativeName("Name", "GL_RESET_NOTIFICATION_STRATEGY_ARB")]
        ResetNotificationStrategyArb = 0x8256,
        [NativeName("Name", "GL_NO_RESET_NOTIFICATION_ARB")]
        NoResetNotificationArb = 0x8261,
        [NativeName("Name", "GL_SAMPLE_LOCATION_SUBPIXEL_BITS_ARB")]
        SampleLocationSubpixelBitsArb = 0x933D,
        [NativeName("Name", "GL_SAMPLE_LOCATION_PIXEL_GRID_WIDTH_ARB")]
        SampleLocationPixelGridWidthArb = 0x933E,
        [NativeName("Name", "GL_SAMPLE_LOCATION_PIXEL_GRID_HEIGHT_ARB")]
        SampleLocationPixelGridHeightArb = 0x933F,
        [NativeName("Name", "GL_PROGRAMMABLE_SAMPLE_LOCATION_TABLE_SIZE_ARB")]
        ProgrammableSampleLocationTableSizeArb = 0x9340,
        [NativeName("Name", "GL_SAMPLE_LOCATION_ARB")]
        SampleLocationArb = 0x8E50,
        [NativeName("Name", "GL_PROGRAMMABLE_SAMPLE_LOCATION_ARB")]
        ProgrammableSampleLocationArb = 0x9341,
        [NativeName("Name", "GL_FRAMEBUFFER_PROGRAMMABLE_SAMPLE_LOCATIONS_ARB")]
        FramebufferProgrammableSampleLocationsArb = 0x9342,
        [NativeName("Name", "GL_FRAMEBUFFER_SAMPLE_LOCATION_PIXEL_GRID_ARB")]
        FramebufferSampleLocationPixelGridArb = 0x9343,
        [NativeName("Name", "GL_SAMPLER_BINDING")]
        SamplerBinding = 0x8919,
        [NativeName("Name", "GL_SAMPLE_SHADING_ARB")]
        SampleShadingArb = 0x8C36,
        [NativeName("Name", "GL_MIN_SAMPLE_SHADING_VALUE_ARB")]
        MinSampleShadingValueArb = 0x8C37,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_SEAMLESS")]
        TextureCubeMapSeamless = 0x884F,
        [NativeName("Name", "GL_VERTEX_SHADER_BIT")]
        VertexShaderBit = 0x1,
        [NativeName("Name", "GL_FRAGMENT_SHADER_BIT")]
        FragmentShaderBit = 0x2,
        [NativeName("Name", "GL_GEOMETRY_SHADER_BIT")]
        GeometryShaderBit = 0x4,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER_BIT")]
        TessControlShaderBit = 0x8,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER_BIT")]
        TessEvaluationShaderBit = 0x10,
        [NativeName("Name", "GL_ALL_SHADER_BITS")]
        AllShaderBits = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_PROGRAM_SEPARABLE")]
        ProgramSeparable = 0x8258,
        [NativeName("Name", "GL_ACTIVE_PROGRAM")]
        ActiveProgram = 0x8259,
        [NativeName("Name", "GL_PROGRAM_PIPELINE_BINDING")]
        ProgramPipelineBinding = 0x825A,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_BINDING")]
        AtomicCounterBufferBinding = 0x92C1,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_START")]
        AtomicCounterBufferStart = 0x92C2,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_SIZE")]
        AtomicCounterBufferSize = 0x92C3,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
        AtomicCounterBufferDataSize = 0x92C4,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
        [NativeName("Name", "GL_MAX_VERTEX_ATOMIC_COUNTER_BUFFERS")]
        MaxVertexAtomicCounterBuffers = 0x92CC,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS")]
        MaxTessControlAtomicCounterBuffers = 0x92CD,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS")]
        MaxTessEvaluationAtomicCounterBuffers = 0x92CE,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS")]
        MaxGeometryAtomicCounterBuffers = 0x92CF,
        [NativeName("Name", "GL_MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS")]
        MaxFragmentAtomicCounterBuffers = 0x92D0,
        [NativeName("Name", "GL_MAX_COMBINED_ATOMIC_COUNTER_BUFFERS")]
        MaxCombinedAtomicCounterBuffers = 0x92D1,
        [NativeName("Name", "GL_MAX_VERTEX_ATOMIC_COUNTERS")]
        MaxVertexAtomicCounters = 0x92D2,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_ATOMIC_COUNTERS")]
        MaxTessControlAtomicCounters = 0x92D3,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_ATOMIC_COUNTERS")]
        MaxTessEvaluationAtomicCounters = 0x92D4,
        [NativeName("Name", "GL_MAX_GEOMETRY_ATOMIC_COUNTERS")]
        MaxGeometryAtomicCounters = 0x92D5,
        [NativeName("Name", "GL_MAX_FRAGMENT_ATOMIC_COUNTERS")]
        MaxFragmentAtomicCounters = 0x92D6,
        [NativeName("Name", "GL_MAX_COMBINED_ATOMIC_COUNTERS")]
        MaxCombinedAtomicCounters = 0x92D7,
        [NativeName("Name", "GL_MAX_ATOMIC_COUNTER_BUFFER_SIZE")]
        MaxAtomicCounterBufferSize = 0x92D8,
        [NativeName("Name", "GL_MAX_ATOMIC_COUNTER_BUFFER_BINDINGS")]
        MaxAtomicCounterBufferBindings = 0x92DC,
        [NativeName("Name", "GL_ACTIVE_ATOMIC_COUNTER_BUFFERS")]
        ActiveAtomicCounterBuffers = 0x92D9,
        [NativeName("Name", "GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX")]
        UniformAtomicCounterBufferIndex = 0x92DA,
        [NativeName("Name", "GL_UNSIGNED_INT_ATOMIC_COUNTER")]
        UnsignedIntAtomicCounter = 0x92DB,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT")]
        VertexAttribArrayBarrierBit = 0x1,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BARRIER_BIT")]
        ElementArrayBarrierBit = 0x2,
        [NativeName("Name", "GL_UNIFORM_BARRIER_BIT")]
        UniformBarrierBit = 0x4,
        [NativeName("Name", "GL_TEXTURE_FETCH_BARRIER_BIT")]
        TextureFetchBarrierBit = 0x8,
        [NativeName("Name", "GL_SHADER_IMAGE_ACCESS_BARRIER_BIT")]
        ShaderImageAccessBarrierBit = 0x20,
        [NativeName("Name", "GL_COMMAND_BARRIER_BIT")]
        CommandBarrierBit = 0x40,
        [NativeName("Name", "GL_PIXEL_BUFFER_BARRIER_BIT")]
        PixelBufferBarrierBit = 0x80,
        [NativeName("Name", "GL_TEXTURE_UPDATE_BARRIER_BIT")]
        TextureUpdateBarrierBit = 0x100,
        [NativeName("Name", "GL_BUFFER_UPDATE_BARRIER_BIT")]
        BufferUpdateBarrierBit = 0x200,
        [NativeName("Name", "GL_FRAMEBUFFER_BARRIER_BIT")]
        FramebufferBarrierBit = 0x400,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BARRIER_BIT")]
        TransformFeedbackBarrierBit = 0x800,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BARRIER_BIT")]
        AtomicCounterBarrierBit = 0x1000,
        [NativeName("Name", "GL_ALL_BARRIER_BITS")]
        AllBarrierBits = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_MAX_IMAGE_UNITS")]
        MaxImageUnits = 0x8F38,
        [NativeName("Name", "GL_MAX_COMBINED_IMAGE_UNITS_AND_FRAGMENT_OUTPUTS")]
        MaxCombinedImageUnitsAndFragmentOutputs = 0x8F39,
        [NativeName("Name", "GL_IMAGE_BINDING_NAME")]
        ImageBindingName = 0x8F3A,
        [NativeName("Name", "GL_IMAGE_BINDING_LEVEL")]
        ImageBindingLevel = 0x8F3B,
        [NativeName("Name", "GL_IMAGE_BINDING_LAYERED")]
        ImageBindingLayered = 0x8F3C,
        [NativeName("Name", "GL_IMAGE_BINDING_LAYER")]
        ImageBindingLayer = 0x8F3D,
        [NativeName("Name", "GL_IMAGE_BINDING_ACCESS")]
        ImageBindingAccess = 0x8F3E,
        [NativeName("Name", "GL_IMAGE_1D")]
        Image1D = 0x904C,
        [NativeName("Name", "GL_IMAGE_2D")]
        Image2D = 0x904D,
        [NativeName("Name", "GL_IMAGE_3D")]
        Image3D = 0x904E,
        [NativeName("Name", "GL_IMAGE_2D_RECT")]
        Image2DRect = 0x904F,
        [NativeName("Name", "GL_IMAGE_CUBE")]
        ImageCube = 0x9050,
        [NativeName("Name", "GL_IMAGE_BUFFER")]
        ImageBuffer = 0x9051,
        [NativeName("Name", "GL_IMAGE_1D_ARRAY")]
        Image1DArray = 0x9052,
        [NativeName("Name", "GL_IMAGE_2D_ARRAY")]
        Image2DArray = 0x9053,
        [NativeName("Name", "GL_IMAGE_CUBE_MAP_ARRAY")]
        ImageCubeMapArray = 0x9054,
        [NativeName("Name", "GL_IMAGE_2D_MULTISAMPLE")]
        Image2DMultisample = 0x9055,
        [NativeName("Name", "GL_IMAGE_2D_MULTISAMPLE_ARRAY")]
        Image2DMultisampleArray = 0x9056,
        [NativeName("Name", "GL_INT_IMAGE_1D")]
        IntImage1D = 0x9057,
        [NativeName("Name", "GL_INT_IMAGE_2D")]
        IntImage2D = 0x9058,
        [NativeName("Name", "GL_INT_IMAGE_3D")]
        IntImage3D = 0x9059,
        [NativeName("Name", "GL_INT_IMAGE_2D_RECT")]
        IntImage2DRect = 0x905A,
        [NativeName("Name", "GL_INT_IMAGE_CUBE")]
        IntImageCube = 0x905B,
        [NativeName("Name", "GL_INT_IMAGE_BUFFER")]
        IntImageBuffer = 0x905C,
        [NativeName("Name", "GL_INT_IMAGE_1D_ARRAY")]
        IntImage1DArray = 0x905D,
        [NativeName("Name", "GL_INT_IMAGE_2D_ARRAY")]
        IntImage2DArray = 0x905E,
        [NativeName("Name", "GL_INT_IMAGE_CUBE_MAP_ARRAY")]
        IntImageCubeMapArray = 0x905F,
        [NativeName("Name", "GL_INT_IMAGE_2D_MULTISAMPLE")]
        IntImage2DMultisample = 0x9060,
        [NativeName("Name", "GL_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
        IntImage2DMultisampleArray = 0x9061,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_1D")]
        UnsignedIntImage1D = 0x9062,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D")]
        UnsignedIntImage2D = 0x9063,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_3D")]
        UnsignedIntImage3D = 0x9064,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_RECT")]
        UnsignedIntImage2DRect = 0x9065,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE")]
        UnsignedIntImageCube = 0x9066,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_BUFFER")]
        UnsignedIntImageBuffer = 0x9067,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_1D_ARRAY")]
        UnsignedIntImage1DArray = 0x9068,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_ARRAY")]
        UnsignedIntImage2DArray = 0x9069,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY")]
        UnsignedIntImageCubeMapArray = 0x906A,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE")]
        UnsignedIntImage2DMultisample = 0x906B,
        [NativeName("Name", "GL_UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY")]
        UnsignedIntImage2DMultisampleArray = 0x906C,
        [NativeName("Name", "GL_MAX_IMAGE_SAMPLES")]
        MaxImageSamples = 0x906D,
        [NativeName("Name", "GL_IMAGE_BINDING_FORMAT")]
        ImageBindingFormat = 0x906E,
        [NativeName("Name", "GL_IMAGE_FORMAT_COMPATIBILITY_BY_SIZE")]
        ImageFormatCompatibilityBySize = 0x90C8,
        [NativeName("Name", "GL_IMAGE_FORMAT_COMPATIBILITY_BY_CLASS")]
        ImageFormatCompatibilityByClass = 0x90C9,
        [NativeName("Name", "GL_MAX_VERTEX_IMAGE_UNIFORMS")]
        MaxVertexImageUniforms = 0x90CA,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_IMAGE_UNIFORMS")]
        MaxTessControlImageUniforms = 0x90CB,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_IMAGE_UNIFORMS")]
        MaxTessEvaluationImageUniforms = 0x90CC,
        [NativeName("Name", "GL_MAX_GEOMETRY_IMAGE_UNIFORMS")]
        MaxGeometryImageUniforms = 0x90CD,
        [NativeName("Name", "GL_MAX_FRAGMENT_IMAGE_UNIFORMS")]
        MaxFragmentImageUniforms = 0x90CE,
        [NativeName("Name", "GL_MAX_COMBINED_IMAGE_UNIFORMS")]
        MaxCombinedImageUniforms = 0x90CF,
        [NativeName("Name", "GL_PROGRAM_OBJECT_ARB")]
        ProgramObjectArb = 0x8B40,
        [NativeName("Name", "GL_SHADER_OBJECT_ARB")]
        ShaderObjectArb = 0x8B48,
        [NativeName("Name", "GL_OBJECT_TYPE_ARB")]
        ObjectTypeArb = 0x8B4E,
        [NativeName("Name", "GL_OBJECT_SUBTYPE_ARB")]
        ObjectSubtypeArb = 0x8B4F,
        [NativeName("Name", "GL_FLOAT_VEC2_ARB")]
        FloatVec2Arb = 0x8B50,
        [NativeName("Name", "GL_FLOAT_VEC3_ARB")]
        FloatVec3Arb = 0x8B51,
        [NativeName("Name", "GL_FLOAT_VEC4_ARB")]
        FloatVec4Arb = 0x8B52,
        [NativeName("Name", "GL_INT_VEC2_ARB")]
        IntVec2Arb = 0x8B53,
        [NativeName("Name", "GL_INT_VEC3_ARB")]
        IntVec3Arb = 0x8B54,
        [NativeName("Name", "GL_INT_VEC4_ARB")]
        IntVec4Arb = 0x8B55,
        [NativeName("Name", "GL_BOOL_ARB")]
        BoolArb = 0x8B56,
        [NativeName("Name", "GL_BOOL_VEC2_ARB")]
        BoolVec2Arb = 0x8B57,
        [NativeName("Name", "GL_BOOL_VEC3_ARB")]
        BoolVec3Arb = 0x8B58,
        [NativeName("Name", "GL_BOOL_VEC4_ARB")]
        BoolVec4Arb = 0x8B59,
        [NativeName("Name", "GL_FLOAT_MAT2_ARB")]
        FloatMat2Arb = 0x8B5A,
        [NativeName("Name", "GL_FLOAT_MAT3_ARB")]
        FloatMat3Arb = 0x8B5B,
        [NativeName("Name", "GL_FLOAT_MAT4_ARB")]
        FloatMat4Arb = 0x8B5C,
        [NativeName("Name", "GL_SAMPLER_1D_ARB")]
        Sampler1DArb = 0x8B5D,
        [NativeName("Name", "GL_SAMPLER_2D_ARB")]
        Sampler2DArb = 0x8B5E,
        [NativeName("Name", "GL_SAMPLER_3D_ARB")]
        Sampler3DArb = 0x8B5F,
        [NativeName("Name", "GL_SAMPLER_CUBE_ARB")]
        SamplerCubeArb = 0x8B60,
        [NativeName("Name", "GL_SAMPLER_1D_SHADOW_ARB")]
        Sampler1DShadowArb = 0x8B61,
        [NativeName("Name", "GL_SAMPLER_2D_SHADOW_ARB")]
        Sampler2DShadowArb = 0x8B62,
        [NativeName("Name", "GL_SAMPLER_2D_RECT_ARB")]
        Sampler2DRectArb = 0x8B63,
        [NativeName("Name", "GL_SAMPLER_2D_RECT_SHADOW_ARB")]
        Sampler2DRectShadowArb = 0x8B64,
        [NativeName("Name", "GL_OBJECT_DELETE_STATUS_ARB")]
        ObjectDeleteStatusArb = 0x8B80,
        [NativeName("Name", "GL_OBJECT_COMPILE_STATUS_ARB")]
        ObjectCompileStatusArb = 0x8B81,
        [NativeName("Name", "GL_OBJECT_LINK_STATUS_ARB")]
        ObjectLinkStatusArb = 0x8B82,
        [NativeName("Name", "GL_OBJECT_VALIDATE_STATUS_ARB")]
        ObjectValidateStatusArb = 0x8B83,
        [NativeName("Name", "GL_OBJECT_INFO_LOG_LENGTH_ARB")]
        ObjectInfoLogLengthArb = 0x8B84,
        [NativeName("Name", "GL_OBJECT_ATTACHED_OBJECTS_ARB")]
        ObjectAttachedObjectsArb = 0x8B85,
        [NativeName("Name", "GL_OBJECT_ACTIVE_UNIFORMS_ARB")]
        ObjectActiveUniformsArb = 0x8B86,
        [NativeName("Name", "GL_OBJECT_ACTIVE_UNIFORM_MAX_LENGTH_ARB")]
        ObjectActiveUniformMaxLengthArb = 0x8B87,
        [NativeName("Name", "GL_OBJECT_SHADER_SOURCE_LENGTH_ARB")]
        ObjectShaderSourceLengthArb = 0x8B88,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER")]
        ShaderStorageBuffer = 0x90D2,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_BINDING")]
        ShaderStorageBufferBinding = 0x90D3,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_START")]
        ShaderStorageBufferStart = 0x90D4,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_SIZE")]
        ShaderStorageBufferSize = 0x90D5,
        [NativeName("Name", "GL_MAX_VERTEX_SHADER_STORAGE_BLOCKS")]
        MaxVertexShaderStorageBlocks = 0x90D6,
        [NativeName("Name", "GL_MAX_GEOMETRY_SHADER_STORAGE_BLOCKS")]
        MaxGeometryShaderStorageBlocks = 0x90D7,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS")]
        MaxTessControlShaderStorageBlocks = 0x90D8,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS")]
        MaxTessEvaluationShaderStorageBlocks = 0x90D9,
        [NativeName("Name", "GL_MAX_FRAGMENT_SHADER_STORAGE_BLOCKS")]
        MaxFragmentShaderStorageBlocks = 0x90DA,
        [NativeName("Name", "GL_MAX_COMPUTE_SHADER_STORAGE_BLOCKS")]
        MaxComputeShaderStorageBlocks = 0x90DB,
        [NativeName("Name", "GL_MAX_COMBINED_SHADER_STORAGE_BLOCKS")]
        MaxCombinedShaderStorageBlocks = 0x90DC,
        [NativeName("Name", "GL_MAX_SHADER_STORAGE_BUFFER_BINDINGS")]
        MaxShaderStorageBufferBindings = 0x90DD,
        [NativeName("Name", "GL_MAX_SHADER_STORAGE_BLOCK_SIZE")]
        MaxShaderStorageBlockSize = 0x90DE,
        [NativeName("Name", "GL_SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT")]
        ShaderStorageBufferOffsetAlignment = 0x90DF,
        [NativeName("Name", "GL_SHADER_STORAGE_BARRIER_BIT")]
        ShaderStorageBarrierBit = 0x2000,
        [NativeName("Name", "GL_MAX_COMBINED_SHADER_OUTPUT_RESOURCES")]
        MaxCombinedShaderOutputResources = 0x8F39,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINES")]
        ActiveSubroutines = 0x8DE5,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORMS")]
        ActiveSubroutineUniforms = 0x8DE6,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
        ActiveSubroutineUniformLocations = 0x8E47,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
        ActiveSubroutineMaxLength = 0x8E48,
        [NativeName("Name", "GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
        ActiveSubroutineUniformMaxLength = 0x8E49,
        [NativeName("Name", "GL_MAX_SUBROUTINES")]
        MaxSubroutines = 0x8DE7,
        [NativeName("Name", "GL_MAX_SUBROUTINE_UNIFORM_LOCATIONS")]
        MaxSubroutineUniformLocations = 0x8DE8,
        [NativeName("Name", "GL_UNIFORM_SIZE")]
        UniformSize = 0x8A38,
        [NativeName("Name", "GL_UNIFORM_NAME_LENGTH")]
        UniformNameLength = 0x8A39,
        [NativeName("Name", "GL_SHADING_LANGUAGE_VERSION_ARB")]
        ShadingLanguageVersionArb = 0x8B8C,
        [NativeName("Name", "GL_SHADER_INCLUDE_ARB")]
        ShaderIncludeArb = 0x8DAE,
        [NativeName("Name", "GL_NAMED_STRING_LENGTH_ARB")]
        NamedStringLengthArb = 0x8DE9,
        [NativeName("Name", "GL_NAMED_STRING_TYPE_ARB")]
        NamedStringTypeArb = 0x8DEA,
        [NativeName("Name", "GL_TEXTURE_COMPARE_MODE_ARB")]
        TextureCompareModeArb = 0x884C,
        [NativeName("Name", "GL_TEXTURE_COMPARE_FUNC_ARB")]
        TextureCompareFuncArb = 0x884D,
        [NativeName("Name", "GL_COMPARE_R_TO_TEXTURE_ARB")]
        CompareRToTextureArb = 0x884E,
        [NativeName("Name", "GL_TEXTURE_COMPARE_FAIL_VALUE_ARB")]
        TextureCompareFailValueArb = 0x80BF,
        [NativeName("Name", "GL_SPARSE_STORAGE_BIT_ARB")]
        SparseStorageBitArb = 0x400,
        [NativeName("Name", "GL_SPARSE_BUFFER_PAGE_SIZE_ARB")]
        SparseBufferPageSizeArb = 0x82F8,
        [NativeName("Name", "GL_TEXTURE_SPARSE_ARB")]
        TextureSparseArb = 0x91A6,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_INDEX_ARB")]
        VirtualPageSizeIndexArb = 0x91A7,
        [NativeName("Name", "GL_NUM_SPARSE_LEVELS_ARB")]
        NumSparseLevelsArb = 0x91AA,
        [NativeName("Name", "GL_NUM_VIRTUAL_PAGE_SIZES_ARB")]
        NumVirtualPageSizesArb = 0x91A8,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_X_ARB")]
        VirtualPageSizeXArb = 0x9195,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_Y_ARB")]
        VirtualPageSizeYArb = 0x9196,
        [NativeName("Name", "GL_VIRTUAL_PAGE_SIZE_Z_ARB")]
        VirtualPageSizeZArb = 0x9197,
        [NativeName("Name", "GL_MAX_SPARSE_TEXTURE_SIZE_ARB")]
        MaxSparseTextureSizeArb = 0x9198,
        [NativeName("Name", "GL_MAX_SPARSE_3D_TEXTURE_SIZE_ARB")]
        MaxSparse3DTextureSizeArb = 0x9199,
        [NativeName("Name", "GL_MAX_SPARSE_ARRAY_TEXTURE_LAYERS_ARB")]
        MaxSparseArrayTextureLayersArb = 0x919A,
        [NativeName("Name", "GL_SPARSE_TEXTURE_FULL_ARRAY_CUBE_MIPMAPS_ARB")]
        SparseTextureFullArrayCubeMipmapsArb = 0x91A9,
        [NativeName("Name", "GL_SPIR_V_EXTENSIONS")]
        SpirVExtensions = 0x9553,
        [NativeName("Name", "GL_NUM_SPIR_V_EXTENSIONS")]
        NumSpirVExtensions = 0x9554,
        [NativeName("Name", "GL_DEPTH_STENCIL_TEXTURE_MODE")]
        DepthStencilTextureMode = 0x90EA,
        [NativeName("Name", "GL_MAX_SERVER_WAIT_TIMEOUT")]
        MaxServerWaitTimeout = 0x9111,
        [NativeName("Name", "GL_OBJECT_TYPE")]
        ObjectType = 0x9112,
        [NativeName("Name", "GL_SYNC_CONDITION")]
        SyncCondition = 0x9113,
        [NativeName("Name", "GL_SYNC_STATUS")]
        SyncStatus = 0x9114,
        [NativeName("Name", "GL_SYNC_FLAGS")]
        SyncFlags = 0x9115,
        [NativeName("Name", "GL_SYNC_FENCE")]
        SyncFence = 0x9116,
        [NativeName("Name", "GL_SYNC_GPU_COMMANDS_COMPLETE")]
        SyncGpuCommandsComplete = 0x9117,
        [NativeName("Name", "GL_UNSIGNALED")]
        Unsignaled = 0x9118,
        [NativeName("Name", "GL_SIGNALED")]
        Signaled = 0x9119,
        [NativeName("Name", "GL_ALREADY_SIGNALED")]
        AlreadySignaled = 0x911A,
        [NativeName("Name", "GL_TIMEOUT_EXPIRED")]
        TimeoutExpired = 0x911B,
        [NativeName("Name", "GL_CONDITION_SATISFIED")]
        ConditionSatisfied = 0x911C,
        [NativeName("Name", "GL_WAIT_FAILED")]
        WaitFailed = 0x911D,
        [NativeName("Name", "GL_SYNC_FLUSH_COMMANDS_BIT")]
        SyncFlushCommandsBit = 0x1,
        [NativeName("Name", "GL_TIMEOUT_IGNORED")]
        TimeoutIgnored = unchecked((int)0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "GL_PATCHES")]
        Patches = 0xE,
        [NativeName("Name", "GL_PATCH_VERTICES")]
        PatchVertices = 0x8E72,
        [NativeName("Name", "GL_PATCH_DEFAULT_INNER_LEVEL")]
        PatchDefaultInnerLevel = 0x8E73,
        [NativeName("Name", "GL_PATCH_DEFAULT_OUTER_LEVEL")]
        PatchDefaultOuterLevel = 0x8E74,
        [NativeName("Name", "GL_TESS_CONTROL_OUTPUT_VERTICES")]
        TessControlOutputVertices = 0x8E75,
        [NativeName("Name", "GL_TESS_GEN_MODE")]
        TessGenMode = 0x8E76,
        [NativeName("Name", "GL_TESS_GEN_SPACING")]
        TessGenSpacing = 0x8E77,
        [NativeName("Name", "GL_TESS_GEN_VERTEX_ORDER")]
        TessGenVertexOrder = 0x8E78,
        [NativeName("Name", "GL_TESS_GEN_POINT_MODE")]
        TessGenPointMode = 0x8E79,
        [NativeName("Name", "GL_TRIANGLES")]
        Triangles = 0x4,
        [NativeName("Name", "GL_ISOLINES")]
        Isolines = 0x8E7A,
        [NativeName("Name", "GL_QUADS")]
        Quads = 0x7,
        [NativeName("Name", "GL_EQUAL")]
        Equal = 0x202,
        [NativeName("Name", "GL_FRACTIONAL_ODD")]
        FractionalOdd = 0x8E7B,
        [NativeName("Name", "GL_FRACTIONAL_EVEN")]
        FractionalEven = 0x8E7C,
        [NativeName("Name", "GL_CCW")]
        Ccw = 0x901,
        [NativeName("Name", "GL_CW")]
        CW = 0x900,
        [NativeName("Name", "GL_MAX_PATCH_VERTICES")]
        MaxPatchVertices = 0x8E7D,
        [NativeName("Name", "GL_MAX_TESS_GEN_LEVEL")]
        MaxTessGenLevel = 0x8E7E,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_COMPONENTS")]
        MaxTessControlUniformComponents = 0x8E7F,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_COMPONENTS")]
        MaxTessEvaluationUniformComponents = 0x8E80,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS")]
        MaxTessControlTextureImageUnits = 0x8E81,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS")]
        MaxTessEvaluationTextureImageUnits = 0x8E82,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_OUTPUT_COMPONENTS")]
        MaxTessControlOutputComponents = 0x8E83,
        [NativeName("Name", "GL_MAX_TESS_PATCH_COMPONENTS")]
        MaxTessPatchComponents = 0x8E84,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS")]
        MaxTessControlTotalOutputComponents = 0x8E85,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_OUTPUT_COMPONENTS")]
        MaxTessEvaluationOutputComponents = 0x8E86,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_UNIFORM_BLOCKS")]
        MaxTessControlUniformBlocks = 0x8E89,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_UNIFORM_BLOCKS")]
        MaxTessEvaluationUniformBlocks = 0x8E8A,
        [NativeName("Name", "GL_MAX_TESS_CONTROL_INPUT_COMPONENTS")]
        MaxTessControlInputComponents = 0x886C,
        [NativeName("Name", "GL_MAX_TESS_EVALUATION_INPUT_COMPONENTS")]
        MaxTessEvaluationInputComponents = 0x886D,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS")]
        MaxCombinedTessControlUniformComponents = 0x8E1E,
        [NativeName("Name", "GL_MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS")]
        MaxCombinedTessEvaluationUniformComponents = 0x8E1F,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER")]
        UniformBlockReferencedByTessControlShader = 0x84F0,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        UniformBlockReferencedByTessEvaluationShader = 0x84F1,
        [NativeName("Name", "GL_TESS_EVALUATION_SHADER")]
        TessEvaluationShader = 0x8E87,
        [NativeName("Name", "GL_TESS_CONTROL_SHADER")]
        TessControlShader = 0x8E88,
        [NativeName("Name", "GL_CLAMP_TO_BORDER_ARB")]
        ClampToBorderArb = 0x812D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_ARB")]
        TextureBufferArb = 0x8C2A,
        [NativeName("Name", "GL_MAX_TEXTURE_BUFFER_SIZE_ARB")]
        MaxTextureBufferSizeArb = 0x8C2B,
        [NativeName("Name", "GL_TEXTURE_BINDING_BUFFER_ARB")]
        TextureBindingBufferArb = 0x8C2C,
        [NativeName("Name", "GL_TEXTURE_BUFFER_DATA_STORE_BINDING_ARB")]
        TextureBufferDataStoreBindingArb = 0x8C2D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_FORMAT_ARB")]
        TextureBufferFormatArb = 0x8C2E,
        [NativeName("Name", "GL_RGB32F")]
        Rgb32f = 0x8815,
        [NativeName("Name", "GL_RGB32UI")]
        Rgb32ui = 0x8D71,
        [NativeName("Name", "GL_RGB32I")]
        Rgb32i = 0x8D83,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET")]
        TextureBufferOffset = 0x919D,
        [NativeName("Name", "GL_TEXTURE_BUFFER_SIZE")]
        TextureBufferSize = 0x919E,
        [NativeName("Name", "GL_TEXTURE_BUFFER_OFFSET_ALIGNMENT")]
        TextureBufferOffsetAlignment = 0x919F,
        [NativeName("Name", "GL_COMPRESSED_ALPHA_ARB")]
        CompressedAlphaArb = 0x84E9,
        [NativeName("Name", "GL_COMPRESSED_LUMINANCE_ARB")]
        CompressedLuminanceArb = 0x84EA,
        [NativeName("Name", "GL_COMPRESSED_LUMINANCE_ALPHA_ARB")]
        CompressedLuminanceAlphaArb = 0x84EB,
        [NativeName("Name", "GL_COMPRESSED_INTENSITY_ARB")]
        CompressedIntensityArb = 0x84EC,
        [NativeName("Name", "GL_COMPRESSED_RGB_ARB")]
        CompressedRgbArb = 0x84ED,
        [NativeName("Name", "GL_COMPRESSED_RGBA_ARB")]
        CompressedRgbaArb = 0x84EE,
        [NativeName("Name", "GL_TEXTURE_COMPRESSION_HINT_ARB")]
        TextureCompressionHintArb = 0x84EF,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_IMAGE_SIZE_ARB")]
        TextureCompressedImageSizeArb = 0x86A0,
        [NativeName("Name", "GL_TEXTURE_COMPRESSED_ARB")]
        TextureCompressedArb = 0x86A1,
        [NativeName("Name", "GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB")]
        NumCompressedTextureFormatsArb = 0x86A2,
        [NativeName("Name", "GL_COMPRESSED_TEXTURE_FORMATS_ARB")]
        CompressedTextureFormatsArb = 0x86A3,
        [NativeName("Name", "GL_COMPRESSED_RGBA_BPTC_UNORM_ARB")]
        CompressedRgbaBptcUnormArb = 0x8E8C,
        [NativeName("Name", "GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM_ARB")]
        CompressedSrgbAlphaBptcUnormArb = 0x8E8D,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT_ARB")]
        CompressedRgbBptcSignedFloatArb = 0x8E8E,
        [NativeName("Name", "GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT_ARB")]
        CompressedRgbBptcUnsignedFloatArb = 0x8E8F,
        [NativeName("Name", "GL_COMPRESSED_RED_RGTC1")]
        CompressedRedRgtc1 = 0x8DBB,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RED_RGTC1")]
        CompressedSignedRedRgtc1 = 0x8DBC,
        [NativeName("Name", "GL_COMPRESSED_RG_RGTC2")]
        CompressedRGRgtc2 = 0x8DBD,
        [NativeName("Name", "GL_COMPRESSED_SIGNED_RG_RGTC2")]
        CompressedSignedRGRgtc2 = 0x8DBE,
        [NativeName("Name", "GL_NORMAL_MAP_ARB")]
        NormalMapArb = 0x8511,
        [NativeName("Name", "GL_REFLECTION_MAP_ARB")]
        ReflectionMapArb = 0x8512,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARB")]
        TextureCubeMapArb = 0x8513,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_ARB")]
        TextureBindingCubeMapArb = 0x8514,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB")]
        TextureCubeMapPositiveXArb = 0x8515,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB")]
        TextureCubeMapNegativeXArb = 0x8516,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB")]
        TextureCubeMapPositiveYArb = 0x8517,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB")]
        TextureCubeMapNegativeYArb = 0x8518,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB")]
        TextureCubeMapPositiveZArb = 0x8519,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB")]
        TextureCubeMapNegativeZArb = 0x851A,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP_ARB")]
        ProxyTextureCubeMapArb = 0x851B,
        [NativeName("Name", "GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB")]
        MaxCubeMapTextureSizeArb = 0x851C,
        [NativeName("Name", "GL_TEXTURE_CUBE_MAP_ARRAY_ARB")]
        TextureCubeMapArrayArb = 0x9009,
        [NativeName("Name", "GL_TEXTURE_BINDING_CUBE_MAP_ARRAY_ARB")]
        TextureBindingCubeMapArrayArb = 0x900A,
        [NativeName("Name", "GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB")]
        ProxyTextureCubeMapArrayArb = 0x900B,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_ARB")]
        SamplerCubeMapArrayArb = 0x900C,
        [NativeName("Name", "GL_SAMPLER_CUBE_MAP_ARRAY_SHADOW_ARB")]
        SamplerCubeMapArrayShadowArb = 0x900D,
        [NativeName("Name", "GL_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
        IntSamplerCubeMapArrayArb = 0x900E,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY_ARB")]
        UnsignedIntSamplerCubeMapArrayArb = 0x900F,
        [NativeName("Name", "GL_COMBINE_ARB")]
        CombineArb = 0x8570,
        [NativeName("Name", "GL_COMBINE_RGB_ARB")]
        CombineRgbArb = 0x8571,
        [NativeName("Name", "GL_COMBINE_ALPHA_ARB")]
        CombineAlphaArb = 0x8572,
        [NativeName("Name", "GL_SOURCE0_RGB_ARB")]
        Source0RgbArb = 0x8580,
        [NativeName("Name", "GL_SOURCE1_RGB_ARB")]
        Source1RgbArb = 0x8581,
        [NativeName("Name", "GL_SOURCE2_RGB_ARB")]
        Source2RgbArb = 0x8582,
        [NativeName("Name", "GL_SOURCE0_ALPHA_ARB")]
        Source0AlphaArb = 0x8588,
        [NativeName("Name", "GL_SOURCE1_ALPHA_ARB")]
        Source1AlphaArb = 0x8589,
        [NativeName("Name", "GL_SOURCE2_ALPHA_ARB")]
        Source2AlphaArb = 0x858A,
        [NativeName("Name", "GL_OPERAND0_RGB_ARB")]
        Operand0RgbArb = 0x8590,
        [NativeName("Name", "GL_OPERAND1_RGB_ARB")]
        Operand1RgbArb = 0x8591,
        [NativeName("Name", "GL_OPERAND2_RGB_ARB")]
        Operand2RgbArb = 0x8592,
        [NativeName("Name", "GL_OPERAND0_ALPHA_ARB")]
        Operand0AlphaArb = 0x8598,
        [NativeName("Name", "GL_OPERAND1_ALPHA_ARB")]
        Operand1AlphaArb = 0x8599,
        [NativeName("Name", "GL_OPERAND2_ALPHA_ARB")]
        Operand2AlphaArb = 0x859A,
        [NativeName("Name", "GL_RGB_SCALE_ARB")]
        RgbScaleArb = 0x8573,
        [NativeName("Name", "GL_ADD_SIGNED_ARB")]
        AddSignedArb = 0x8574,
        [NativeName("Name", "GL_INTERPOLATE_ARB")]
        InterpolateArb = 0x8575,
        [NativeName("Name", "GL_SUBTRACT_ARB")]
        SubtractArb = 0x84E7,
        [NativeName("Name", "GL_CONSTANT_ARB")]
        ConstantArb = 0x8576,
        [NativeName("Name", "GL_PRIMARY_COLOR_ARB")]
        PrimaryColorArb = 0x8577,
        [NativeName("Name", "GL_PREVIOUS_ARB")]
        PreviousArb = 0x8578,
        [NativeName("Name", "GL_DOT3_RGB_ARB")]
        Dot3RgbArb = 0x86AE,
        [NativeName("Name", "GL_DOT3_RGBA_ARB")]
        Dot3RgbaArb = 0x86AF,
        [NativeName("Name", "GL_TEXTURE_MAX_ANISOTROPY")]
        TextureMaxAnisotropy = 0x84FE,
        [NativeName("Name", "GL_MAX_TEXTURE_MAX_ANISOTROPY")]
        MaxTextureMaxAnisotropy = 0x84FF,
        [NativeName("Name", "GL_TEXTURE_REDUCTION_MODE_ARB")]
        TextureReductionModeArb = 0x9366,
        [NativeName("Name", "GL_WEIGHTED_AVERAGE_ARB")]
        WeightedAverageArb = 0x9367,
        [NativeName("Name", "GL_TEXTURE_RED_TYPE_ARB")]
        TextureRedTypeArb = 0x8C10,
        [NativeName("Name", "GL_TEXTURE_GREEN_TYPE_ARB")]
        TextureGreenTypeArb = 0x8C11,
        [NativeName("Name", "GL_TEXTURE_BLUE_TYPE_ARB")]
        TextureBlueTypeArb = 0x8C12,
        [NativeName("Name", "GL_TEXTURE_ALPHA_TYPE_ARB")]
        TextureAlphaTypeArb = 0x8C13,
        [NativeName("Name", "GL_TEXTURE_LUMINANCE_TYPE_ARB")]
        TextureLuminanceTypeArb = 0x8C14,
        [NativeName("Name", "GL_TEXTURE_INTENSITY_TYPE_ARB")]
        TextureIntensityTypeArb = 0x8C15,
        [NativeName("Name", "GL_TEXTURE_DEPTH_TYPE_ARB")]
        TextureDepthTypeArb = 0x8C16,
        [NativeName("Name", "GL_UNSIGNED_NORMALIZED_ARB")]
        UnsignedNormalizedArb = 0x8C17,
        [NativeName("Name", "GL_RGBA32F_ARB")]
        Rgba32fArb = 0x8814,
        [NativeName("Name", "GL_RGB32F_ARB")]
        Rgb32fArb = 0x8815,
        [NativeName("Name", "GL_ALPHA32F_ARB")]
        Alpha32fArb = 0x8816,
        [NativeName("Name", "GL_INTENSITY32F_ARB")]
        Intensity32fArb = 0x8817,
        [NativeName("Name", "GL_LUMINANCE32F_ARB")]
        Luminance32fArb = 0x8818,
        [NativeName("Name", "GL_LUMINANCE_ALPHA32F_ARB")]
        LuminanceAlpha32fArb = 0x8819,
        [NativeName("Name", "GL_RGBA16F_ARB")]
        Rgba16fArb = 0x881A,
        [NativeName("Name", "GL_RGB16F_ARB")]
        Rgb16fArb = 0x881B,
        [NativeName("Name", "GL_ALPHA16F_ARB")]
        Alpha16fArb = 0x881C,
        [NativeName("Name", "GL_INTENSITY16F_ARB")]
        Intensity16fArb = 0x881D,
        [NativeName("Name", "GL_LUMINANCE16F_ARB")]
        Luminance16fArb = 0x881E,
        [NativeName("Name", "GL_LUMINANCE_ALPHA16F_ARB")]
        LuminanceAlpha16fArb = 0x881F,
        [NativeName("Name", "GL_MIN_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
        MinProgramTextureGatherOffsetArb = 0x8E5E,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXTURE_GATHER_OFFSET_ARB")]
        MaxProgramTextureGatherOffsetArb = 0x8E5F,
        [NativeName("Name", "GL_MAX_PROGRAM_TEXTURE_GATHER_COMPONENTS_ARB")]
        MaxProgramTextureGatherComponentsArb = 0x8F9F,
        [NativeName("Name", "GL_MIRROR_CLAMP_TO_EDGE")]
        MirrorClampToEdge = 0x8743,
        [NativeName("Name", "GL_MIRRORED_REPEAT_ARB")]
        MirroredRepeatArb = 0x8370,
        [NativeName("Name", "GL_SAMPLE_POSITION")]
        SamplePosition = 0x8E50,
        [NativeName("Name", "GL_SAMPLE_MASK")]
        SampleMask = 0x8E51,
        [NativeName("Name", "GL_SAMPLE_MASK_VALUE")]
        SampleMaskValue = 0x8E52,
        [NativeName("Name", "GL_MAX_SAMPLE_MASK_WORDS")]
        MaxSampleMaskWords = 0x8E59,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_MULTISAMPLE")]
        ProxyTexture2DMultisample = 0x9101,
        [NativeName("Name", "GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY")]
        ProxyTexture2DMultisampleArray = 0x9103,
        [NativeName("Name", "GL_TEXTURE_SAMPLES")]
        TextureSamples = 0x9106,
        [NativeName("Name", "GL_TEXTURE_FIXED_SAMPLE_LOCATIONS")]
        TextureFixedSampleLocations = 0x9107,
        [NativeName("Name", "GL_SAMPLER_2D_MULTISAMPLE")]
        Sampler2DMultisample = 0x9108,
        [NativeName("Name", "GL_INT_SAMPLER_2D_MULTISAMPLE")]
        IntSampler2DMultisample = 0x9109,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE")]
        UnsignedIntSampler2DMultisample = 0x910A,
        [NativeName("Name", "GL_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        Sampler2DMultisampleArray = 0x910B,
        [NativeName("Name", "GL_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        IntSampler2DMultisampleArray = 0x910C,
        [NativeName("Name", "GL_UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY")]
        UnsignedIntSampler2DMultisampleArray = 0x910D,
        [NativeName("Name", "GL_MAX_COLOR_TEXTURE_SAMPLES")]
        MaxColorTextureSamples = 0x910E,
        [NativeName("Name", "GL_MAX_DEPTH_TEXTURE_SAMPLES")]
        MaxDepthTextureSamples = 0x910F,
        [NativeName("Name", "GL_MAX_INTEGER_SAMPLES")]
        MaxIntegerSamples = 0x9110,
        [NativeName("Name", "GL_TEXTURE_RECTANGLE_ARB")]
        TextureRectangleArb = 0x84F5,
        [NativeName("Name", "GL_TEXTURE_BINDING_RECTANGLE_ARB")]
        TextureBindingRectangleArb = 0x84F6,
        [NativeName("Name", "GL_PROXY_TEXTURE_RECTANGLE_ARB")]
        ProxyTextureRectangleArb = 0x84F7,
        [NativeName("Name", "GL_MAX_RECTANGLE_TEXTURE_SIZE_ARB")]
        MaxRectangleTextureSizeArb = 0x84F8,
        [NativeName("Name", "GL_RG")]
        RG = 0x8227,
        [NativeName("Name", "GL_RG_INTEGER")]
        RGInteger = 0x8228,
        [NativeName("Name", "GL_R8")]
        R8 = 0x8229,
        [NativeName("Name", "GL_R16")]
        R16 = 0x822A,
        [NativeName("Name", "GL_RG8")]
        RG8 = 0x822B,
        [NativeName("Name", "GL_RG16")]
        RG16 = 0x822C,
        [NativeName("Name", "GL_R16F")]
        R16f = 0x822D,
        [NativeName("Name", "GL_R32F")]
        R32f = 0x822E,
        [NativeName("Name", "GL_RG16F")]
        RG16f = 0x822F,
        [NativeName("Name", "GL_RG32F")]
        RG32f = 0x8230,
        [NativeName("Name", "GL_R8I")]
        R8i = 0x8231,
        [NativeName("Name", "GL_R8UI")]
        R8ui = 0x8232,
        [NativeName("Name", "GL_R16I")]
        R16i = 0x8233,
        [NativeName("Name", "GL_R16UI")]
        R16ui = 0x8234,
        [NativeName("Name", "GL_R32I")]
        R32i = 0x8235,
        [NativeName("Name", "GL_R32UI")]
        R32ui = 0x8236,
        [NativeName("Name", "GL_RG8I")]
        RG8i = 0x8237,
        [NativeName("Name", "GL_RG8UI")]
        RG8ui = 0x8238,
        [NativeName("Name", "GL_RG16I")]
        RG16i = 0x8239,
        [NativeName("Name", "GL_RG16UI")]
        RG16ui = 0x823A,
        [NativeName("Name", "GL_RG32I")]
        RG32i = 0x823B,
        [NativeName("Name", "GL_RG32UI")]
        RG32ui = 0x823C,
        [NativeName("Name", "GL_RGB10_A2UI")]
        Rgb10A2ui = 0x906F,
        [NativeName("Name", "GL_STENCIL_INDEX")]
        StencilIndex = 0x1901,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_FORMAT")]
        TextureImmutableFormat = 0x912F,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_R")]
        TextureSwizzleR = 0x8E42,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_G")]
        TextureSwizzleG = 0x8E43,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_B")]
        TextureSwizzleB = 0x8E44,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_A")]
        TextureSwizzleA = 0x8E45,
        [NativeName("Name", "GL_TEXTURE_SWIZZLE_RGBA")]
        TextureSwizzleRgba = 0x8E46,
        [NativeName("Name", "GL_TEXTURE_VIEW_MIN_LEVEL")]
        TextureViewMinLevel = 0x82DB,
        [NativeName("Name", "GL_TEXTURE_VIEW_NUM_LEVELS")]
        TextureViewNumLevels = 0x82DC,
        [NativeName("Name", "GL_TEXTURE_VIEW_MIN_LAYER")]
        TextureViewMinLayer = 0x82DD,
        [NativeName("Name", "GL_TEXTURE_VIEW_NUM_LAYERS")]
        TextureViewNumLayers = 0x82DE,
        [NativeName("Name", "GL_TEXTURE_IMMUTABLE_LEVELS")]
        TextureImmutableLevels = 0x82DF,
        [NativeName("Name", "GL_TIME_ELAPSED")]
        TimeElapsed = 0x88BF,
        [NativeName("Name", "GL_TIMESTAMP")]
        Timestamp = 0x8E28,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK")]
        TransformFeedback = 0x8E22,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_PAUSED")]
        TransformFeedbackBufferPaused = 0x8E23,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BUFFER_ACTIVE")]
        TransformFeedbackBufferActive = 0x8E24,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_BINDING")]
        TransformFeedbackBinding = 0x8E25,
        [NativeName("Name", "GL_MAX_TRANSFORM_FEEDBACK_BUFFERS")]
        MaxTransformFeedbackBuffers = 0x8E70,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_OVERFLOW_ARB")]
        TransformFeedbackOverflowArb = 0x82EC,
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK_STREAM_OVERFLOW_ARB")]
        TransformFeedbackStreamOverflowArb = 0x82ED,
        [NativeName("Name", "GL_TRANSPOSE_MODELVIEW_MATRIX_ARB")]
        TransposeModelviewMatrixArb = 0x84E3,
        [NativeName("Name", "GL_TRANSPOSE_PROJECTION_MATRIX_ARB")]
        TransposeProjectionMatrixArb = 0x84E4,
        [NativeName("Name", "GL_TRANSPOSE_TEXTURE_MATRIX_ARB")]
        TransposeTextureMatrixArb = 0x84E5,
        [NativeName("Name", "GL_TRANSPOSE_COLOR_MATRIX_ARB")]
        TransposeColorMatrixArb = 0x84E6,
        [NativeName("Name", "GL_UNIFORM_BUFFER")]
        UniformBuffer = 0x8A11,
        [NativeName("Name", "GL_UNIFORM_BUFFER_BINDING")]
        UniformBufferBinding = 0x8A28,
        [NativeName("Name", "GL_UNIFORM_BUFFER_START")]
        UniformBufferStart = 0x8A29,
        [NativeName("Name", "GL_UNIFORM_BUFFER_SIZE")]
        UniformBufferSize = 0x8A2A,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_BLOCKS")]
        MaxVertexUniformBlocks = 0x8A2B,
        [NativeName("Name", "GL_MAX_GEOMETRY_UNIFORM_BLOCKS")]
        MaxGeometryUniformBlocks = 0x8A2C,
        [NativeName("Name", "GL_MAX_FRAGMENT_UNIFORM_BLOCKS")]
        MaxFragmentUniformBlocks = 0x8A2D,
        [NativeName("Name", "GL_MAX_COMBINED_UNIFORM_BLOCKS")]
        MaxCombinedUniformBlocks = 0x8A2E,
        [NativeName("Name", "GL_MAX_UNIFORM_BUFFER_BINDINGS")]
        MaxUniformBufferBindings = 0x8A2F,
        [NativeName("Name", "GL_MAX_UNIFORM_BLOCK_SIZE")]
        MaxUniformBlockSize = 0x8A30,
        [NativeName("Name", "GL_MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS")]
        MaxCombinedVertexUniformComponents = 0x8A31,
        [NativeName("Name", "GL_MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS")]
        MaxCombinedGeometryUniformComponents = 0x8A32,
        [NativeName("Name", "GL_MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS")]
        MaxCombinedFragmentUniformComponents = 0x8A33,
        [NativeName("Name", "GL_UNIFORM_BUFFER_OFFSET_ALIGNMENT")]
        UniformBufferOffsetAlignment = 0x8A34,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH")]
        ActiveUniformBlockMaxNameLength = 0x8A35,
        [NativeName("Name", "GL_ACTIVE_UNIFORM_BLOCKS")]
        ActiveUniformBlocks = 0x8A36,
        [NativeName("Name", "GL_UNIFORM_TYPE")]
        UniformType = 0x8A37,
        [NativeName("Name", "GL_UNIFORM_BLOCK_INDEX")]
        UniformBlockIndex = 0x8A3A,
        [NativeName("Name", "GL_UNIFORM_OFFSET")]
        UniformOffset = 0x8A3B,
        [NativeName("Name", "GL_UNIFORM_ARRAY_STRIDE")]
        UniformArrayStride = 0x8A3C,
        [NativeName("Name", "GL_UNIFORM_MATRIX_STRIDE")]
        UniformMatrixStride = 0x8A3D,
        [NativeName("Name", "GL_UNIFORM_IS_ROW_MAJOR")]
        UniformIsRowMajor = 0x8A3E,
        [NativeName("Name", "GL_UNIFORM_BLOCK_BINDING")]
        UniformBlockBinding = 0x8A3F,
        [NativeName("Name", "GL_UNIFORM_BLOCK_DATA_SIZE")]
        UniformBlockDataSize = 0x8A40,
        [NativeName("Name", "GL_UNIFORM_BLOCK_NAME_LENGTH")]
        UniformBlockNameLength = 0x8A41,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS")]
        UniformBlockActiveUniforms = 0x8A42,
        [NativeName("Name", "GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES")]
        UniformBlockActiveUniformIndices = 0x8A43,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER")]
        UniformBlockReferencedByVertexShader = 0x8A44,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER")]
        UniformBlockReferencedByGeometryShader = 0x8A45,
        [NativeName("Name", "GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER")]
        UniformBlockReferencedByFragmentShader = 0x8A46,
        [NativeName("Name", "GL_INVALID_INDEX")]
        InvalidIndex = unchecked((int)0xFFFFFFFF),
        [NativeName("Name", "GL_BGRA")]
        Bgra = 0x80E1,
        [NativeName("Name", "GL_VERTEX_ARRAY_BINDING")]
        VertexArrayBinding = 0x85B5,
        [NativeName("Name", "GL_VERTEX_ATTRIB_BINDING")]
        VertexAttribBinding = 0x82D4,
        [NativeName("Name", "GL_VERTEX_ATTRIB_RELATIVE_OFFSET")]
        VertexAttribRelativeOffset = 0x82D5,
        [NativeName("Name", "GL_VERTEX_BINDING_DIVISOR")]
        VertexBindingDivisor = 0x82D6,
        [NativeName("Name", "GL_VERTEX_BINDING_OFFSET")]
        VertexBindingOffset = 0x82D7,
        [NativeName("Name", "GL_VERTEX_BINDING_STRIDE")]
        VertexBindingStride = 0x82D8,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIB_RELATIVE_OFFSET")]
        MaxVertexAttribRelativeOffset = 0x82D9,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIB_BINDINGS")]
        MaxVertexAttribBindings = 0x82DA,
        [NativeName("Name", "GL_MAX_VERTEX_UNITS_ARB")]
        MaxVertexUnitsArb = 0x86A4,
        [NativeName("Name", "GL_ACTIVE_VERTEX_UNITS_ARB")]
        ActiveVertexUnitsArb = 0x86A5,
        [NativeName("Name", "GL_WEIGHT_SUM_UNITY_ARB")]
        WeightSumUnityArb = 0x86A6,
        [NativeName("Name", "GL_VERTEX_BLEND_ARB")]
        VertexBlendArb = 0x86A7,
        [NativeName("Name", "GL_CURRENT_WEIGHT_ARB")]
        CurrentWeightArb = 0x86A8,
        [NativeName("Name", "GL_WEIGHT_ARRAY_TYPE_ARB")]
        WeightArrayTypeArb = 0x86A9,
        [NativeName("Name", "GL_WEIGHT_ARRAY_STRIDE_ARB")]
        WeightArrayStrideArb = 0x86AA,
        [NativeName("Name", "GL_WEIGHT_ARRAY_SIZE_ARB")]
        WeightArraySizeArb = 0x86AB,
        [NativeName("Name", "GL_WEIGHT_ARRAY_POINTER_ARB")]
        WeightArrayPointerArb = 0x86AC,
        [NativeName("Name", "GL_WEIGHT_ARRAY_ARB")]
        WeightArrayArb = 0x86AD,
        [NativeName("Name", "GL_MODELVIEW0_ARB")]
        Modelview0Arb = 0x1700,
        [NativeName("Name", "GL_MODELVIEW1_ARB")]
        Modelview1Arb = 0x850A,
        [NativeName("Name", "GL_MODELVIEW2_ARB")]
        Modelview2Arb = 0x8722,
        [NativeName("Name", "GL_MODELVIEW3_ARB")]
        Modelview3Arb = 0x8723,
        [NativeName("Name", "GL_MODELVIEW4_ARB")]
        Modelview4Arb = 0x8724,
        [NativeName("Name", "GL_MODELVIEW5_ARB")]
        Modelview5Arb = 0x8725,
        [NativeName("Name", "GL_MODELVIEW6_ARB")]
        Modelview6Arb = 0x8726,
        [NativeName("Name", "GL_MODELVIEW7_ARB")]
        Modelview7Arb = 0x8727,
        [NativeName("Name", "GL_MODELVIEW8_ARB")]
        Modelview8Arb = 0x8728,
        [NativeName("Name", "GL_MODELVIEW9_ARB")]
        Modelview9Arb = 0x8729,
        [NativeName("Name", "GL_MODELVIEW10_ARB")]
        Modelview10Arb = 0x872A,
        [NativeName("Name", "GL_MODELVIEW11_ARB")]
        Modelview11Arb = 0x872B,
        [NativeName("Name", "GL_MODELVIEW12_ARB")]
        Modelview12Arb = 0x872C,
        [NativeName("Name", "GL_MODELVIEW13_ARB")]
        Modelview13Arb = 0x872D,
        [NativeName("Name", "GL_MODELVIEW14_ARB")]
        Modelview14Arb = 0x872E,
        [NativeName("Name", "GL_MODELVIEW15_ARB")]
        Modelview15Arb = 0x872F,
        [NativeName("Name", "GL_MODELVIEW16_ARB")]
        Modelview16Arb = 0x8730,
        [NativeName("Name", "GL_MODELVIEW17_ARB")]
        Modelview17Arb = 0x8731,
        [NativeName("Name", "GL_MODELVIEW18_ARB")]
        Modelview18Arb = 0x8732,
        [NativeName("Name", "GL_MODELVIEW19_ARB")]
        Modelview19Arb = 0x8733,
        [NativeName("Name", "GL_MODELVIEW20_ARB")]
        Modelview20Arb = 0x8734,
        [NativeName("Name", "GL_MODELVIEW21_ARB")]
        Modelview21Arb = 0x8735,
        [NativeName("Name", "GL_MODELVIEW22_ARB")]
        Modelview22Arb = 0x8736,
        [NativeName("Name", "GL_MODELVIEW23_ARB")]
        Modelview23Arb = 0x8737,
        [NativeName("Name", "GL_MODELVIEW24_ARB")]
        Modelview24Arb = 0x8738,
        [NativeName("Name", "GL_MODELVIEW25_ARB")]
        Modelview25Arb = 0x8739,
        [NativeName("Name", "GL_MODELVIEW26_ARB")]
        Modelview26Arb = 0x873A,
        [NativeName("Name", "GL_MODELVIEW27_ARB")]
        Modelview27Arb = 0x873B,
        [NativeName("Name", "GL_MODELVIEW28_ARB")]
        Modelview28Arb = 0x873C,
        [NativeName("Name", "GL_MODELVIEW29_ARB")]
        Modelview29Arb = 0x873D,
        [NativeName("Name", "GL_MODELVIEW30_ARB")]
        Modelview30Arb = 0x873E,
        [NativeName("Name", "GL_MODELVIEW31_ARB")]
        Modelview31Arb = 0x873F,
        [NativeName("Name", "GL_BUFFER_SIZE_ARB")]
        BufferSizeArb = 0x8764,
        [NativeName("Name", "GL_BUFFER_USAGE_ARB")]
        BufferUsageArb = 0x8765,
        [NativeName("Name", "GL_ARRAY_BUFFER_ARB")]
        ArrayBufferArb = 0x8892,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BUFFER_ARB")]
        ElementArrayBufferArb = 0x8893,
        [NativeName("Name", "GL_ARRAY_BUFFER_BINDING_ARB")]
        ArrayBufferBindingArb = 0x8894,
        [NativeName("Name", "GL_ELEMENT_ARRAY_BUFFER_BINDING_ARB")]
        ElementArrayBufferBindingArb = 0x8895,
        [NativeName("Name", "GL_VERTEX_ARRAY_BUFFER_BINDING_ARB")]
        VertexArrayBufferBindingArb = 0x8896,
        [NativeName("Name", "GL_NORMAL_ARRAY_BUFFER_BINDING_ARB")]
        NormalArrayBufferBindingArb = 0x8897,
        [NativeName("Name", "GL_COLOR_ARRAY_BUFFER_BINDING_ARB")]
        ColorArrayBufferBindingArb = 0x8898,
        [NativeName("Name", "GL_INDEX_ARRAY_BUFFER_BINDING_ARB")]
        IndexArrayBufferBindingArb = 0x8899,
        [NativeName("Name", "GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING_ARB")]
        TextureCoordArrayBufferBindingArb = 0x889A,
        [NativeName("Name", "GL_EDGE_FLAG_ARRAY_BUFFER_BINDING_ARB")]
        EdgeFlagArrayBufferBindingArb = 0x889B,
        [NativeName("Name", "GL_SECONDARY_COLOR_ARRAY_BUFFER_BINDING_ARB")]
        SecondaryColorArrayBufferBindingArb = 0x889C,
        [NativeName("Name", "GL_FOG_COORDINATE_ARRAY_BUFFER_BINDING_ARB")]
        FogCoordinateArrayBufferBindingArb = 0x889D,
        [NativeName("Name", "GL_WEIGHT_ARRAY_BUFFER_BINDING_ARB")]
        WeightArrayBufferBindingArb = 0x889E,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING_ARB")]
        VertexAttribArrayBufferBindingArb = 0x889F,
        [NativeName("Name", "GL_READ_ONLY_ARB")]
        ReadOnlyArb = 0x88B8,
        [NativeName("Name", "GL_WRITE_ONLY_ARB")]
        WriteOnlyArb = 0x88B9,
        [NativeName("Name", "GL_READ_WRITE_ARB")]
        ReadWriteArb = 0x88BA,
        [NativeName("Name", "GL_BUFFER_ACCESS_ARB")]
        BufferAccessArb = 0x88BB,
        [NativeName("Name", "GL_BUFFER_MAPPED_ARB")]
        BufferMappedArb = 0x88BC,
        [NativeName("Name", "GL_BUFFER_MAP_POINTER_ARB")]
        BufferMapPointerArb = 0x88BD,
        [NativeName("Name", "GL_STREAM_DRAW_ARB")]
        StreamDrawArb = 0x88E0,
        [NativeName("Name", "GL_STREAM_READ_ARB")]
        StreamReadArb = 0x88E1,
        [NativeName("Name", "GL_STREAM_COPY_ARB")]
        StreamCopyArb = 0x88E2,
        [NativeName("Name", "GL_STATIC_DRAW_ARB")]
        StaticDrawArb = 0x88E4,
        [NativeName("Name", "GL_STATIC_READ_ARB")]
        StaticReadArb = 0x88E5,
        [NativeName("Name", "GL_STATIC_COPY_ARB")]
        StaticCopyArb = 0x88E6,
        [NativeName("Name", "GL_DYNAMIC_DRAW_ARB")]
        DynamicDrawArb = 0x88E8,
        [NativeName("Name", "GL_DYNAMIC_READ_ARB")]
        DynamicReadArb = 0x88E9,
        [NativeName("Name", "GL_DYNAMIC_COPY_ARB")]
        DynamicCopyArb = 0x88EA,
        [NativeName("Name", "GL_COLOR_SUM_ARB")]
        ColorSumArb = 0x8458,
        [NativeName("Name", "GL_VERTEX_PROGRAM_ARB")]
        VertexProgramArb = 0x8620,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_ENABLED_ARB")]
        VertexAttribArrayEnabledArb = 0x8622,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_SIZE_ARB")]
        VertexAttribArraySizeArb = 0x8623,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_STRIDE_ARB")]
        VertexAttribArrayStrideArb = 0x8624,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_TYPE_ARB")]
        VertexAttribArrayTypeArb = 0x8625,
        [NativeName("Name", "GL_CURRENT_VERTEX_ATTRIB_ARB")]
        CurrentVertexAttribArb = 0x8626,
        [NativeName("Name", "GL_VERTEX_PROGRAM_POINT_SIZE_ARB")]
        VertexProgramPointSizeArb = 0x8642,
        [NativeName("Name", "GL_VERTEX_PROGRAM_TWO_SIDE_ARB")]
        VertexProgramTwoSideArb = 0x8643,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_POINTER_ARB")]
        VertexAttribArrayPointerArb = 0x8645,
        [NativeName("Name", "GL_MAX_VERTEX_ATTRIBS_ARB")]
        MaxVertexAttribsArb = 0x8869,
        [NativeName("Name", "GL_VERTEX_ATTRIB_ARRAY_NORMALIZED_ARB")]
        VertexAttribArrayNormalizedArb = 0x886A,
        [NativeName("Name", "GL_PROGRAM_ADDRESS_REGISTERS_ARB")]
        ProgramAddressRegistersArb = 0x88B0,
        [NativeName("Name", "GL_MAX_PROGRAM_ADDRESS_REGISTERS_ARB")]
        MaxProgramAddressRegistersArb = 0x88B1,
        [NativeName("Name", "GL_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
        ProgramNativeAddressRegistersArb = 0x88B2,
        [NativeName("Name", "GL_MAX_PROGRAM_NATIVE_ADDRESS_REGISTERS_ARB")]
        MaxProgramNativeAddressRegistersArb = 0x88B3,
        [NativeName("Name", "GL_VERTEX_SHADER_ARB")]
        VertexShaderArb = 0x8B31,
        [NativeName("Name", "GL_MAX_VERTEX_UNIFORM_COMPONENTS_ARB")]
        MaxVertexUniformComponentsArb = 0x8B4A,
        [NativeName("Name", "GL_MAX_VARYING_FLOATS_ARB")]
        MaxVaryingFloatsArb = 0x8B4B,
        [NativeName("Name", "GL_MAX_VERTEX_TEXTURE_IMAGE_UNITS_ARB")]
        MaxVertexTextureImageUnitsArb = 0x8B4C,
        [NativeName("Name", "GL_MAX_COMBINED_TEXTURE_IMAGE_UNITS_ARB")]
        MaxCombinedTextureImageUnitsArb = 0x8B4D,
        [NativeName("Name", "GL_OBJECT_ACTIVE_ATTRIBUTES_ARB")]
        ObjectActiveAttributesArb = 0x8B89,
        [NativeName("Name", "GL_OBJECT_ACTIVE_ATTRIBUTE_MAX_LENGTH_ARB")]
        ObjectActiveAttributeMaxLengthArb = 0x8B8A,
        [NativeName("Name", "GL_FLOAT")]
        Float = 0x1406,
        [NativeName("Name", "GL_UNSIGNED_INT_10F_11F_11F_REV")]
        UnsignedInt10f11f11fRev = 0x8C3B,
        [NativeName("Name", "GL_UNSIGNED_INT_2_10_10_10_REV")]
        UnsignedInt2101010Rev = 0x8368,
        [NativeName("Name", "GL_INT_2_10_10_10_REV")]
        Int2101010Rev = 0x8D9F,
        [NativeName("Name", "GL_SCISSOR_BOX")]
        ScissorBox = 0xC10,
        [NativeName("Name", "GL_VIEWPORT")]
        Viewport = 0xBA2,
        [NativeName("Name", "GL_DEPTH_RANGE")]
        DepthRange = 0xB70,
        [NativeName("Name", "GL_SCISSOR_TEST")]
        ScissorTest = 0xC11,
        [NativeName("Name", "GL_MAX_VIEWPORTS")]
        MaxViewports = 0x825B,
        [NativeName("Name", "GL_VIEWPORT_SUBPIXEL_BITS")]
        ViewportSubpixelBits = 0x825C,
        [NativeName("Name", "GL_VIEWPORT_BOUNDS_RANGE")]
        ViewportBoundsRange = 0x825D,
        [NativeName("Name", "GL_LAYER_PROVOKING_VERTEX")]
        LayerProvokingVertex = 0x825E,
        [NativeName("Name", "GL_VIEWPORT_INDEX_PROVOKING_VERTEX")]
        ViewportIndexProvokingVertex = 0x825F,
        [NativeName("Name", "GL_UNDEFINED_VERTEX")]
        UndefinedVertex = 0x8260,
    }
}
