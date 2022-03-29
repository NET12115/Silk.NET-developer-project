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

namespace Silk.NET.Assimp
{
    public unsafe partial class Assimp : NativeAPI
    {
        [NativeName("Type", "const size_t")]
        [NativeName("Name", "MAXLEN")]
        public const nuint Maxlen = unchecked((nuint) 0x400);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_FALSE")]
        public const int False = unchecked((int) 0x0);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_TRUE")]
        public const int True = unchecked((int) 0x1);
        [NativeName("Type", "")]
        [NativeName("Name", "AI_DEFAULT_MATERIAL_NAME")]
        public const string DefaultMaterialName = unchecked((string) "DefaultMaterial");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_NAME")]
        public const string MatkeyName = unchecked((string) "?mat.name");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_TWOSIDED")]
        public const string MatkeyTwosided = unchecked((string) "$mat.twosided");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADING_MODEL")]
        public const string MatkeyShadingModel = unchecked((string) "$mat.shadingm");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_ENABLE_WIREFRAME")]
        public const string MatkeyEnableWireframe = unchecked((string) "$mat.wireframe");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_BLEND_FUNC")]
        public const string MatkeyBlendFunc = unchecked((string) "$mat.blend");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_OPACITY")]
        public const string MatkeyOpacity = unchecked((string) "$mat.opacity");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_TRANSPARENCYFACTOR")]
        public const string MatkeyTransparencyfactor = unchecked((string) "$mat.transparencyfactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_BUMPSCALING")]
        public const string MatkeyBumpscaling = unchecked((string) "$mat.bumpscaling");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHININESS")]
        public const string MatkeyShininess = unchecked((string) "$mat.shininess");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_REFLECTIVITY")]
        public const string MatkeyReflectivity = unchecked((string) "$mat.reflectivity");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHININESS_STRENGTH")]
        public const string MatkeyShininessStrength = unchecked((string) "$mat.shinpercent");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_REFRACTI")]
        public const string MatkeyRefracti = unchecked((string) "$mat.refracti");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_DIFFUSE")]
        public const string MatkeyColorDiffuse = unchecked((string) "$clr.diffuse");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_AMBIENT")]
        public const string MatkeyColorAmbient = unchecked((string) "$clr.ambient");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_SPECULAR")]
        public const string MatkeyColorSpecular = unchecked((string) "$clr.specular");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_EMISSIVE")]
        public const string MatkeyColorEmissive = unchecked((string) "$clr.emissive");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_TRANSPARENT")]
        public const string MatkeyColorTransparent = unchecked((string) "$clr.transparent");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_COLOR_REFLECTIVE")]
        public const string MatkeyColorReflective = unchecked((string) "$clr.reflective");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_GLOBAL_BACKGROUND_IMAGE")]
        public const string MatkeyGlobalBackgroundImage = unchecked((string) "?bg.global");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_GLOBAL_SHADERLANG")]
        public const string MatkeyGlobalShaderlang = unchecked((string) "?sh.lang");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_VERTEX")]
        public const string MatkeyShaderVertex = unchecked((string) "?sh.vs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_FRAGMENT")]
        public const string MatkeyShaderFragment = unchecked((string) "?sh.fs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_GEO")]
        public const string MatkeyShaderGeo = unchecked((string) "?sh.gs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_TESSELATION")]
        public const string MatkeyShaderTesselation = unchecked((string) "?sh.ts");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_PRIMITIVE")]
        public const string MatkeyShaderPrimitive = unchecked((string) "?sh.ps");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHADER_COMPUTE")]
        public const string MatkeyShaderCompute = unchecked((string) "?sh.cs");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_COLOR_MAP")]
        public const string MatkeyUseColorMap = unchecked((string) "$mat.useColorMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_BASE_COLOR")]
        public const string MatkeyBaseColor = unchecked((string) "$clr.base");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_METALLIC_MAP")]
        public const string MatkeyUseMetallicMap = unchecked((string) "$mat.useMetallicMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_METALLIC_FACTOR")]
        public const string MatkeyMetallicFactor = unchecked((string) "$mat.metallicFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_ROUGHNESS_MAP")]
        public const string MatkeyUseRoughnessMap = unchecked((string) "$mat.useRoughnessMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_ROUGHNESS_FACTOR")]
        public const string MatkeyRoughnessFactor = unchecked((string) "$mat.roughnessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_ANISOTROPY_FACTOR")]
        public const string MatkeyAnisotropyFactor = unchecked((string) "$mat.anisotropyFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SPECULAR_FACTOR")]
        public const string MatkeySpecularFactor = unchecked((string) "$mat.specularFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_GLOSSINESS_FACTOR")]
        public const string MatkeyGlossinessFactor = unchecked((string) "$mat.glossinessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHEEN_COLOR_FACTOR")]
        public const string MatkeySheenColorFactor = unchecked((string) "$clr.sheen.factor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_SHEEN_ROUGHNESS_FACTOR")]
        public const string MatkeySheenRoughnessFactor = unchecked((string) "$mat.sheen.roughnessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_CLEARCOAT_FACTOR")]
        public const string MatkeyClearcoatFactor = unchecked((string) "$mat.clearcoat.factor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_CLEARCOAT_ROUGHNESS_FACTOR")]
        public const string MatkeyClearcoatRoughnessFactor = unchecked((string) "$mat.clearcoat.roughnessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_TRANSMISSION_FACTOR")]
        public const string MatkeyTransmissionFactor = unchecked((string) "$mat.transmission.factor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_VOLUME_THICKNESS_FACTOR")]
        public const string MatkeyVolumeThicknessFactor = unchecked((string) "$mat.volume.thicknessFactor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_VOLUME_ATTENUATION_DISTANCE")]
        public const string MatkeyVolumeAttenuationDistance = unchecked((string) "$mat.volume.attenuationDistance");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_VOLUME_ATTENUATION_COLOR")]
        public const string MatkeyVolumeAttenuationColor = unchecked((string) "$mat.volume.attenuationColor");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_EMISSIVE_MAP")]
        public const string MatkeyUseEmissiveMap = unchecked((string) "$mat.useEmissiveMap");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_EMISSIVE_INTENSITY")]
        public const string MatkeyEmissiveIntensity = unchecked((string) "$mat.emissiveIntensity");
        [NativeName("Type", "")]
        [NativeName("Name", "AI_MATKEY_USE_AO_MAP")]
        public const string MatkeyUseAOMap = unchecked((string) "$mat.useAOMap");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXTURE_BASE")]
        public const string MatkeyTextureBase = unchecked((string) "$tex.file");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_UVWSRC_BASE")]
        public const string MatkeyUvwsrcBase = unchecked((string) "$tex.uvwsrc");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXOP_BASE")]
        public const string MatkeyTexopBase = unchecked((string) "$tex.op");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_MAPPING_BASE")]
        public const string MatkeyMappingBase = unchecked((string) "$tex.mapping");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXBLEND_BASE")]
        public const string MatkeyTexblendBase = unchecked((string) "$tex.blend");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_MAPPINGMODE_U_BASE")]
        public const string MatkeyMappingmodeUBase = unchecked((string) "$tex.mapmodeu");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_MAPPINGMODE_V_BASE")]
        public const string MatkeyMappingmodeVBase = unchecked((string) "$tex.mapmodev");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXMAP_AXIS_BASE")]
        public const string MatkeyTexmapAxisBase = unchecked((string) "$tex.mapaxis");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_UVTRANSFORM_BASE")]
        public const string MatkeyUvtransformBase = unchecked((string) "$tex.uvtrafo");
        [NativeName("Type", "")]
        [NativeName("Name", "_AI_MATKEY_TEXFLAGS_BASE")]
        public const string MatkeyTexflagsBase = unchecked((string) "$tex.flags");
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_SHARED")]
        public const int AssimpCflagsShared = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_STLPORT")]
        public const int AssimpCflagsStlport = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_DEBUG")]
        public const int AssimpCflagsDebug = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_NOBOOST")]
        public const int AssimpCflagsNoboost = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_SINGLETHREADED")]
        public const int AssimpCflagsSinglethreaded = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "ASSIMP_CFLAGS_DOUBLE_SUPPORT")]
        public const int AssimpCflagsDoubleSupport = unchecked((int) 0x20);
        [NativeName("Type", "")]
        [NativeName("Name", "AI_EMBEDDED_TEXNAME_PREFIX")]
        public const string EmbeddedTexnamePrefix = unchecked((string) "*");
        [NativeName("Type", "int")]
        [NativeName("Name", "HINTMAXTEXTURELEN")]
        public const int Hintmaxtexturelen = unchecked((int) 0x9);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_FACE_INDICES")]
        public const int MaxFaceIndices = unchecked((int) 0x7FFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_BONE_WEIGHTS")]
        public const int MaxBoneWeights = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_VERTICES")]
        public const int MaxVertices = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_FACES")]
        public const int MaxFaces = unchecked((int) 0x7FFFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_NUMBER_OF_COLOR_SETS")]
        public const int MaxNumberOfColorSets = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_MAX_NUMBER_OF_TEXTURECOORDS")]
        public const int MaxNumberOfTexturecoords = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_INCOMPLETE")]
        public const int SceneFlagsIncomplete = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_VALIDATED")]
        public const int SceneFlagsValidated = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_VALIDATION_WARNING")]
        public const int SceneFlagsValidationWarning = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_NON_VERBOSE_FORMAT")]
        public const int SceneFlagsNonVerboseFormat = unchecked((int) 0x8);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_TERRAIN")]
        public const int SceneFlagsTerrain = unchecked((int) 0x10);
        [NativeName("Type", "int")]
        [NativeName("Name", "AI_SCENE_FLAGS_ALLOW_SHARED")]
        public const int SceneFlagsAllowShared = unchecked((int) 0x20);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 19 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiGetExportFormatCount")]
        public partial nuint GetExportFormatCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 100, Column 47 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiGetExportFormatDescription", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportFormatDesc* GetExportFormatDescription(nuint pIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleaseExportFormatDescription([Flow(FlowDirection.In)] ExportFormatDesc* desc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 107, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription", Convention = CallingConvention.Winapi)]
        public partial void ReleaseExportFormatDescription([Flow(FlowDirection.In)] in ExportFormatDesc desc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] Scene* pIn, Scene** pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] Scene* pIn, ref Scene* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] in Scene pIn, Scene** pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] in Scene pIn, ref Scene* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiFreeScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void FreeScene([Flow(FlowDirection.In)] Scene* pIn);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiFreeScene", Convention = CallingConvention.Winapi)]
        public partial void FreeScene([Flow(FlowDirection.In)] in Scene pIn);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleaseExportBlob([Flow(FlowDirection.In)] ExportDataBlob* pData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 17 in build/submodules/Assimp/include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportBlob", Convention = CallingConvention.Winapi)]
        public partial void ReleaseExportBlob([Flow(FlowDirection.In)] in ExportDataBlob pData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 43 in build/submodules/Assimp/include\\assimp/importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImporterDesc(byte* extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 43 in build/submodules/Assimp/include\\assimp/importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImporterDesc(ref byte extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 43 in build/submodules/Assimp/include\\assimp/importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImporterDesc([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFile(byte* pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFile(ref byte pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 117, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(byte* pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(byte* pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(ref byte pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(ref byte pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 142, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 163, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, ref byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(ref byte pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(ref byte pBuffer, uint pLength, uint pFlags, ref byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(ref byte pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, ref byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 200, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 234, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiApplyPostProcessing", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ApplyPostProcessing([Flow(FlowDirection.In)] Scene* pScene, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 256, Column 36 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiApplyPostProcessing", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ApplyPostProcessing([Flow(FlowDirection.In)] in Scene pScene, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 33 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream", Convention = CallingConvention.Winapi)]
        public unsafe partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, byte* file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 33 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream", Convention = CallingConvention.Winapi)]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, ref byte file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 280, Column 33 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream", Convention = CallingConvention.Winapi)]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiAttachLogStream", Convention = CallingConvention.Winapi)]
        public unsafe partial void AttachLogStream([Flow(FlowDirection.In)] LogStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 294, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiAttachLogStream", Convention = CallingConvention.Winapi)]
        public partial void AttachLogStream([Flow(FlowDirection.In)] in LogStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 304, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiEnableVerboseLogging", Convention = CallingConvention.Winapi)]
        public partial void EnableVerboseLogging(int d);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 28 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDetachLogStream", Convention = CallingConvention.Winapi)]
        public unsafe partial Return DetachLogStream([Flow(FlowDirection.In)] LogStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 28 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDetachLogStream", Convention = CallingConvention.Winapi)]
        public partial Return DetachLogStream([Flow(FlowDirection.In)] in LogStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 326, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDetachAllLogStreams")]
        public partial void DetachAllLogStreams();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleaseImport", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleaseImport([Flow(FlowDirection.In)] Scene* pScene);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 334, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleaseImport", Convention = CallingConvention.Winapi)]
        public partial void ReleaseImport([Flow(FlowDirection.In)] in Scene pScene);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 344, Column 24 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public unsafe partial byte* GetErrorString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 344, Column 24 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetErrorString", Convention = CallingConvention.Winapi)]
        public partial string GetErrorStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 19 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported", Convention = CallingConvention.Winapi)]
        public unsafe partial int IsExtensionSupported(byte* szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 19 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported", Convention = CallingConvention.Winapi)]
        public partial int IsExtensionSupported(ref byte szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 353, Column 19 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported", Convention = CallingConvention.Winapi)]
        public partial int IsExtensionSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetExtensionList", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetExtensionList(AssimpString* szOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 364, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetExtensionList", Convention = CallingConvention.Winapi)]
        public partial void GetExtensionList(ref AssimpString szOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryRequirements([Flow(FlowDirection.In)] Scene* pIn, MemoryInfo* @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryRequirements([Flow(FlowDirection.In)] Scene* pIn, ref MemoryInfo @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryRequirements([Flow(FlowDirection.In)] in Scene pIn, MemoryInfo* @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 372, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryRequirements([Flow(FlowDirection.In)] in Scene pIn, ref MemoryInfo @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 382, Column 38 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreatePropertyStore")]
        public unsafe partial PropertyStore* CreatePropertyStore();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 388, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleasePropertyStore", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleasePropertyStore(PropertyStore* p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 388, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleasePropertyStore", Convention = CallingConvention.Winapi)]
        public partial void ReleasePropertyStore(ref PropertyStore p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, byte* szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, ref byte szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(ref PropertyStore store, byte* szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyInteger(ref PropertyStore store, ref byte szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 402, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyInteger(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, byte* szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, ref byte szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(ref PropertyStore store, byte* szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyFloat(ref PropertyStore store, ref byte szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 419, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyFloat(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, byte* szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, byte* szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, ref byte szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, ref byte szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, byte* szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, byte* szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, ref byte szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyString(ref PropertyStore store, ref byte szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 436, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyString(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, byte* szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, byte* szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, ref byte szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, ref byte szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, byte* szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, byte* szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, ref byte szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyMatrix(ref PropertyStore store, ref byte szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 453, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyMatrix(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQuaternionFromMatrix(AssimpQuaternion* quat, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQuaternionFromMatrix(AssimpQuaternion* quat, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQuaternionFromMatrix(ref AssimpQuaternion quat, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 464, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public partial void CreateQuaternionFromMatrix(ref AssimpQuaternion quat, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 478, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransposeMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 488, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix4", Convention = CallingConvention.Winapi)]
        public partial void TransposeMatrix4(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransposeMatrix3(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 495, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix3", Convention = CallingConvention.Winapi)]
        public partial void TransposeMatrix3(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix3(System.Numerics.Vector3* vec, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix3(System.Numerics.Vector3* vec, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix3(ref System.Numerics.Vector3 vec, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 503, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public partial void TransformVecByMatrix3(ref System.Numerics.Vector3 vec, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix4(System.Numerics.Vector3* vec, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix4(System.Numerics.Vector3* vec, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix4(ref System.Numerics.Vector3 vec, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public partial void TransformVecByMatrix4(ref System.Numerics.Vector3 vec, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, ref System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix4(ref System.Numerics.Matrix4x4 dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public partial void MultiplyMatrix4(ref System.Numerics.Matrix4x4 dst, ref System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix3(Silk.NET.Maths.Matrix3X3<float>* dst, Silk.NET.Maths.Matrix3X3<float>* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix3(Silk.NET.Maths.Matrix3X3<float>* dst, ref Silk.NET.Maths.Matrix3X3<float> src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix3(ref Silk.NET.Maths.Matrix3X3<float> dst, Silk.NET.Maths.Matrix3X3<float>* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public partial void MultiplyMatrix3(ref Silk.NET.Maths.Matrix3X3<float> dst, ref Silk.NET.Maths.Matrix3X3<float> src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void IdentityMatrix3(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 538, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix3", Convention = CallingConvention.Winapi)]
        public partial void IdentityMatrix3(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 545, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void IdentityMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 545, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix4", Convention = CallingConvention.Winapi)]
        public partial void IdentityMatrix4(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 552, Column 19 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetImportFormatCount")]
        public partial nuint GetImportFormatCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 561, Column 43 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetImportFormatDescription", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImportFormatDescription(nuint pIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector2AreEqual(System.Numerics.Vector2* a, System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector2AreEqual(System.Numerics.Vector2* a, ref System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector2AreEqual(ref System.Numerics.Vector2 a, System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 570, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqual", Convention = CallingConvention.Winapi)]
        public partial int Vector2AreEqual(ref System.Numerics.Vector2 a, ref System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector2AreEqualEpsilon(System.Numerics.Vector2* a, System.Numerics.Vector2* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector2AreEqualEpsilon(System.Numerics.Vector2* a, ref System.Numerics.Vector2 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector2AreEqualEpsilon(ref System.Numerics.Vector2 a, System.Numerics.Vector2* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 582, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public partial int Vector2AreEqualEpsilon(ref System.Numerics.Vector2 a, ref System.Numerics.Vector2 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Add(System.Numerics.Vector2* dst, System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Add(System.Numerics.Vector2* dst, ref System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Add(ref System.Numerics.Vector2 dst, System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 592, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Add", Convention = CallingConvention.Winapi)]
        public partial void Vector2Add(ref System.Numerics.Vector2 dst, ref System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Subtract(System.Numerics.Vector2* dst, System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Subtract(System.Numerics.Vector2* dst, ref System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Subtract(ref System.Numerics.Vector2 dst, System.Numerics.Vector2* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Subtract", Convention = CallingConvention.Winapi)]
        public partial void Vector2Subtract(ref System.Numerics.Vector2 dst, ref System.Numerics.Vector2 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Scale", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Scale(System.Numerics.Vector2* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Scale", Convention = CallingConvention.Winapi)]
        public partial void Vector2Scale(ref System.Numerics.Vector2 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2SymMul(System.Numerics.Vector2* dst, System.Numerics.Vector2* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2SymMul(System.Numerics.Vector2* dst, ref System.Numerics.Vector2 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2SymMul(ref System.Numerics.Vector2 dst, System.Numerics.Vector2* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 620, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SymMul", Convention = CallingConvention.Winapi)]
        public partial void Vector2SymMul(ref System.Numerics.Vector2 dst, ref System.Numerics.Vector2 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 629, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByScalar", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2DivideByScalar(System.Numerics.Vector2* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 629, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByScalar", Convention = CallingConvention.Winapi)]
        public partial void Vector2DivideByScalar(ref System.Numerics.Vector2 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2DivideByVector(System.Numerics.Vector2* dst, System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2DivideByVector(System.Numerics.Vector2* dst, ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2DivideByVector(ref System.Numerics.Vector2 dst, System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 639, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DivideByVector", Convention = CallingConvention.Winapi)]
        public partial void Vector2DivideByVector(ref System.Numerics.Vector2 dst, ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Length", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector2Length(System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 647, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Length", Convention = CallingConvention.Winapi)]
        public partial float Vector2Length(ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SquareLength", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector2SquareLength(System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 654, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2SquareLength", Convention = CallingConvention.Winapi)]
        public partial float Vector2SquareLength(ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 661, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Negate", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Negate(System.Numerics.Vector2* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 661, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Negate", Convention = CallingConvention.Winapi)]
        public partial void Vector2Negate(ref System.Numerics.Vector2 dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector2DotProduct(System.Numerics.Vector2* a, System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector2DotProduct(System.Numerics.Vector2* a, ref System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector2DotProduct(ref System.Numerics.Vector2 a, System.Numerics.Vector2* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2DotProduct", Convention = CallingConvention.Winapi)]
        public partial float Vector2DotProduct(ref System.Numerics.Vector2 a, ref System.Numerics.Vector2 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 678, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Normalize", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector2Normalize(System.Numerics.Vector2* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 678, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector2Normalize", Convention = CallingConvention.Winapi)]
        public partial void Vector2Normalize(ref System.Numerics.Vector2 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3AreEqual(System.Numerics.Vector3* a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3AreEqual(System.Numerics.Vector3* a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3AreEqual(ref System.Numerics.Vector3 a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 688, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqual", Convention = CallingConvention.Winapi)]
        public partial int Vector3AreEqual(ref System.Numerics.Vector3 a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3AreEqualEpsilon(System.Numerics.Vector3* a, System.Numerics.Vector3* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3AreEqualEpsilon(System.Numerics.Vector3* a, ref System.Numerics.Vector3 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3AreEqualEpsilon(ref System.Numerics.Vector3 a, System.Numerics.Vector3* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 700, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public partial int Vector3AreEqualEpsilon(ref System.Numerics.Vector3 a, ref System.Numerics.Vector3 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3LessThan(System.Numerics.Vector3* a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3LessThan(System.Numerics.Vector3* a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan", Convention = CallingConvention.Winapi)]
        public unsafe partial int Vector3LessThan(ref System.Numerics.Vector3 a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 713, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3LessThan", Convention = CallingConvention.Winapi)]
        public partial int Vector3LessThan(ref System.Numerics.Vector3 a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Add(System.Numerics.Vector3* dst, System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Add(System.Numerics.Vector3* dst, ref System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Add(ref System.Numerics.Vector3 dst, System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Add", Convention = CallingConvention.Winapi)]
        public partial void Vector3Add(ref System.Numerics.Vector3 dst, ref System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Subtract(System.Numerics.Vector3* dst, System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Subtract(System.Numerics.Vector3* dst, ref System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Subtract(ref System.Numerics.Vector3 dst, System.Numerics.Vector3* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Subtract", Convention = CallingConvention.Winapi)]
        public partial void Vector3Subtract(ref System.Numerics.Vector3 dst, ref System.Numerics.Vector3 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Scale", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Scale(System.Numerics.Vector3* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Scale", Convention = CallingConvention.Winapi)]
        public partial void Vector3Scale(ref System.Numerics.Vector3 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3SymMul(System.Numerics.Vector3* dst, System.Numerics.Vector3* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3SymMul(System.Numerics.Vector3* dst, ref System.Numerics.Vector3 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3SymMul(ref System.Numerics.Vector3 dst, System.Numerics.Vector3* other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 750, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SymMul", Convention = CallingConvention.Winapi)]
        public partial void Vector3SymMul(ref System.Numerics.Vector3 dst, ref System.Numerics.Vector3 other);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByScalar", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3DivideByScalar(System.Numerics.Vector3* dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByScalar", Convention = CallingConvention.Winapi)]
        public partial void Vector3DivideByScalar(ref System.Numerics.Vector3 dst, float s);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3DivideByVector(System.Numerics.Vector3* dst, System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3DivideByVector(System.Numerics.Vector3* dst, ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3DivideByVector(ref System.Numerics.Vector3 dst, System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 769, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DivideByVector", Convention = CallingConvention.Winapi)]
        public partial void Vector3DivideByVector(ref System.Numerics.Vector3 dst, ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Length", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector3Length(System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 777, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Length", Convention = CallingConvention.Winapi)]
        public partial float Vector3Length(ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SquareLength", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector3SquareLength(System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 784, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3SquareLength", Convention = CallingConvention.Winapi)]
        public partial float Vector3SquareLength(ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Negate", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Negate(System.Numerics.Vector3* dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 791, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Negate", Convention = CallingConvention.Winapi)]
        public partial void Vector3Negate(ref System.Numerics.Vector3 dst);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector3DotProduct(System.Numerics.Vector3* a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector3DotProduct(System.Numerics.Vector3* a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial float Vector3DotProduct(ref System.Numerics.Vector3 a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3DotProduct", Convention = CallingConvention.Winapi)]
        public partial float Vector3DotProduct(ref System.Numerics.Vector3 a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, System.Numerics.Vector3* a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, System.Numerics.Vector3* a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, ref System.Numerics.Vector3 a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3CrossProduct(System.Numerics.Vector3* dst, ref System.Numerics.Vector3 a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, System.Numerics.Vector3* a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, System.Numerics.Vector3* a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, ref System.Numerics.Vector3 a, System.Numerics.Vector3* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 811, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3CrossProduct", Convention = CallingConvention.Winapi)]
        public partial void Vector3CrossProduct(ref System.Numerics.Vector3 dst, ref System.Numerics.Vector3 a, ref System.Numerics.Vector3 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Normalize", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3Normalize(System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3Normalize", Convention = CallingConvention.Winapi)]
        public partial void Vector3Normalize(ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3NormalizeSafe", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3NormalizeSafe(System.Numerics.Vector3* v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 827, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3NormalizeSafe", Convention = CallingConvention.Winapi)]
        public partial void Vector3NormalizeSafe(ref System.Numerics.Vector3 v);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3RotateByQuaternion(System.Numerics.Vector3* v, AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3RotateByQuaternion(System.Numerics.Vector3* v, ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void Vector3RotateByQuaternion(ref System.Numerics.Vector3 v, AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 835, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiVector3RotateByQuaternion", Convention = CallingConvention.Winapi)]
        public partial void Vector3RotateByQuaternion(ref System.Numerics.Vector3 v, ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromMatrix4(Silk.NET.Maths.Matrix3X3<float>* dst, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromMatrix4(Silk.NET.Maths.Matrix3X3<float>* dst, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromMatrix4(ref Silk.NET.Maths.Matrix3X3<float> dst, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromMatrix4", Convention = CallingConvention.Winapi)]
        public partial void Matrix3FromMatrix4(ref Silk.NET.Maths.Matrix3X3<float> dst, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromQuaternion(Silk.NET.Maths.Matrix3X3<float>* mat, AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromQuaternion(Silk.NET.Maths.Matrix3X3<float>* mat, ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromQuaternion(ref Silk.NET.Maths.Matrix3X3<float> mat, AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromQuaternion", Convention = CallingConvention.Winapi)]
        public partial void Matrix3FromQuaternion(ref Silk.NET.Maths.Matrix3X3<float> mat, ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix3AreEqual(Silk.NET.Maths.Matrix3X3<float>* a, Silk.NET.Maths.Matrix3X3<float>* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix3AreEqual(Silk.NET.Maths.Matrix3X3<float>* a, ref Silk.NET.Maths.Matrix3X3<float> b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix3AreEqual(ref Silk.NET.Maths.Matrix3X3<float> a, Silk.NET.Maths.Matrix3X3<float>* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 864, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqual", Convention = CallingConvention.Winapi)]
        public partial int Matrix3AreEqual(ref Silk.NET.Maths.Matrix3X3<float> a, ref Silk.NET.Maths.Matrix3X3<float> b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix3AreEqualEpsilon(Silk.NET.Maths.Matrix3X3<float>* a, Silk.NET.Maths.Matrix3X3<float>* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix3AreEqualEpsilon(Silk.NET.Maths.Matrix3X3<float>* a, ref Silk.NET.Maths.Matrix3X3<float> b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix3AreEqualEpsilon(ref Silk.NET.Maths.Matrix3X3<float> a, Silk.NET.Maths.Matrix3X3<float>* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 876, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public partial int Matrix3AreEqualEpsilon(ref Silk.NET.Maths.Matrix3X3<float> a, ref Silk.NET.Maths.Matrix3X3<float> b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Inverse", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3Inverse(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Inverse", Convention = CallingConvention.Winapi)]
        public partial void Matrix3Inverse(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 892, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Determinant", Convention = CallingConvention.Winapi)]
        public unsafe partial float Matrix3Determinant(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 892, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Determinant", Convention = CallingConvention.Winapi)]
        public partial float Matrix3Determinant(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 900, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3RotationZ", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3RotationZ(Silk.NET.Maths.Matrix3X3<float>* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 900, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3RotationZ", Convention = CallingConvention.Winapi)]
        public partial void Matrix3RotationZ(ref Silk.NET.Maths.Matrix3X3<float> mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromRotationAroundAxis(Silk.NET.Maths.Matrix3X3<float>* mat, System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromRotationAroundAxis(Silk.NET.Maths.Matrix3X3<float>* mat, ref System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromRotationAroundAxis(ref Silk.NET.Maths.Matrix3X3<float> mat, System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 910, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public partial void Matrix3FromRotationAroundAxis(ref Silk.NET.Maths.Matrix3X3<float> mat, ref System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3Translation(Silk.NET.Maths.Matrix3X3<float>* mat, System.Numerics.Vector2* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3Translation(Silk.NET.Maths.Matrix3X3<float>* mat, ref System.Numerics.Vector2 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3Translation(ref Silk.NET.Maths.Matrix3X3<float> mat, System.Numerics.Vector2* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 920, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3Translation", Convention = CallingConvention.Winapi)]
        public partial void Matrix3Translation(ref Silk.NET.Maths.Matrix3X3<float> mat, ref System.Numerics.Vector2 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, System.Numerics.Vector3* from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, System.Numerics.Vector3* from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, ref System.Numerics.Vector3 from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromTo(Silk.NET.Maths.Matrix3X3<float>* mat, ref System.Numerics.Vector3 from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, System.Numerics.Vector3* from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, System.Numerics.Vector3* from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, ref System.Numerics.Vector3 from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 930, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix3FromTo", Convention = CallingConvention.Winapi)]
        public partial void Matrix3FromTo(ref Silk.NET.Maths.Matrix3X3<float> mat, ref System.Numerics.Vector3 from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromMatrix3(System.Numerics.Matrix4x4* dst, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromMatrix3(System.Numerics.Matrix4x4* dst, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromMatrix3(ref System.Numerics.Matrix4x4 dst, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 940, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromMatrix3", Convention = CallingConvention.Winapi)]
        public partial void Matrix4FromMatrix3(ref System.Numerics.Matrix4x4 dst, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 951, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromScalingQuaternionPosition", Convention = CallingConvention.Winapi)]
        public partial void Matrix4FromScalingQuaternionPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Add(System.Numerics.Matrix4x4* dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Add(System.Numerics.Matrix4x4* dst, ref System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Add(ref System.Numerics.Matrix4x4 dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 962, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Add", Convention = CallingConvention.Winapi)]
        public partial void Matrix4Add(ref System.Numerics.Matrix4x4 dst, ref System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix4AreEqual(System.Numerics.Matrix4x4* a, System.Numerics.Matrix4x4* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix4AreEqual(System.Numerics.Matrix4x4* a, ref System.Numerics.Matrix4x4 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix4AreEqual(ref System.Numerics.Matrix4x4 a, System.Numerics.Matrix4x4* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 973, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqual", Convention = CallingConvention.Winapi)]
        public partial int Matrix4AreEqual(ref System.Numerics.Matrix4x4 a, ref System.Numerics.Matrix4x4 b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix4AreEqualEpsilon(System.Numerics.Matrix4x4* a, System.Numerics.Matrix4x4* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix4AreEqualEpsilon(System.Numerics.Matrix4x4* a, ref System.Numerics.Matrix4x4 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix4AreEqualEpsilon(ref System.Numerics.Matrix4x4 a, System.Numerics.Matrix4x4* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 985, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4AreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public partial int Matrix4AreEqualEpsilon(ref System.Numerics.Matrix4x4 a, ref System.Numerics.Matrix4x4 b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Inverse", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Inverse(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Inverse", Convention = CallingConvention.Winapi)]
        public partial void Matrix4Inverse(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1002, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Determinant", Convention = CallingConvention.Winapi)]
        public unsafe partial float Matrix4Determinant(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1002, Column 18 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Determinant", Convention = CallingConvention.Winapi)]
        public partial float Matrix4Determinant(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4IsIdentity", Convention = CallingConvention.Winapi)]
        public unsafe partial int Matrix4IsIdentity(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4IsIdentity", Convention = CallingConvention.Winapi)]
        public partial int Matrix4IsIdentity(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1023, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingEulerAnglesPosition", Convention = CallingConvention.Winapi)]
        public partial void Matrix4DecomposeIntoScalingEulerAnglesPosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Vector3* axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, float* angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1040, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeIntoScalingAxisAnglePosition", Convention = CallingConvention.Winapi)]
        public partial void Matrix4DecomposeIntoScalingAxisAnglePosition(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Vector3 axis, ref float angle, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeNoScaling(System.Numerics.Matrix4x4* mat, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeNoScaling(System.Numerics.Matrix4x4* mat, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeNoScaling(System.Numerics.Matrix4x4* mat, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeNoScaling(System.Numerics.Matrix4x4* mat, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeNoScaling(ref System.Numerics.Matrix4x4 mat, AssimpQuaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeNoScaling(ref System.Numerics.Matrix4x4 mat, AssimpQuaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4DecomposeNoScaling(ref System.Numerics.Matrix4x4 mat, ref AssimpQuaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1055, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4DecomposeNoScaling", Convention = CallingConvention.Winapi)]
        public partial void Matrix4DecomposeNoScaling(ref System.Numerics.Matrix4x4 mat, ref AssimpQuaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1067, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromEulerAngles", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromEulerAngles(System.Numerics.Matrix4x4* mat, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1067, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromEulerAngles", Convention = CallingConvention.Winapi)]
        public partial void Matrix4FromEulerAngles(ref System.Numerics.Matrix4x4 mat, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationX", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4RotationX(System.Numerics.Matrix4x4* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationX", Convention = CallingConvention.Winapi)]
        public partial void Matrix4RotationX(ref System.Numerics.Matrix4x4 mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationY", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4RotationY(System.Numerics.Matrix4x4* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationY", Convention = CallingConvention.Winapi)]
        public partial void Matrix4RotationY(ref System.Numerics.Matrix4x4 mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1094, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationZ", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4RotationZ(System.Numerics.Matrix4x4* mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1094, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4RotationZ", Convention = CallingConvention.Winapi)]
        public partial void Matrix4RotationZ(ref System.Numerics.Matrix4x4 mat, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromRotationAroundAxis(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromRotationAroundAxis(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromRotationAroundAxis(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1104, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromRotationAroundAxis", Convention = CallingConvention.Winapi)]
        public partial void Matrix4FromRotationAroundAxis(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Translation(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Translation(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Translation(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1114, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Translation", Convention = CallingConvention.Winapi)]
        public partial void Matrix4Translation(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 translation);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Scaling(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Scaling(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4Scaling(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4Scaling", Convention = CallingConvention.Winapi)]
        public partial void Matrix4Scaling(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromTo(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public unsafe partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 from, System.Numerics.Vector3* to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1133, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMatrix4FromTo", Convention = CallingConvention.Winapi)]
        public partial void Matrix4FromTo(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 from, ref System.Numerics.Vector3 to);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromEulerAngles", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionFromEulerAngles(AssimpQuaternion* q, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1145, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromEulerAngles", Convention = CallingConvention.Winapi)]
        public partial void QuaternionFromEulerAngles(ref AssimpQuaternion q, float x, float y, float z);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionFromAxisAngle(AssimpQuaternion* q, System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionFromAxisAngle(AssimpQuaternion* q, ref System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionFromAxisAngle(ref AssimpQuaternion q, System.Numerics.Vector3* axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1155, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromAxisAngle", Convention = CallingConvention.Winapi)]
        public partial void QuaternionFromAxisAngle(ref AssimpQuaternion q, ref System.Numerics.Vector3 axis, float angle);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionFromNormalizedQuaternion(AssimpQuaternion* q, System.Numerics.Vector3* normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionFromNormalizedQuaternion(AssimpQuaternion* q, ref System.Numerics.Vector3 normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionFromNormalizedQuaternion(ref AssimpQuaternion q, System.Numerics.Vector3* normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1166, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionFromNormalizedQuaternion", Convention = CallingConvention.Winapi)]
        public partial void QuaternionFromNormalizedQuaternion(ref AssimpQuaternion q, ref System.Numerics.Vector3 normalized);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int QuaternionAreEqual(AssimpQuaternion* a, AssimpQuaternion* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int QuaternionAreEqual(AssimpQuaternion* a, ref AssimpQuaternion b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual", Convention = CallingConvention.Winapi)]
        public unsafe partial int QuaternionAreEqual(ref AssimpQuaternion a, AssimpQuaternion* b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1177, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqual", Convention = CallingConvention.Winapi)]
        public partial int QuaternionAreEqual(ref AssimpQuaternion a, ref AssimpQuaternion b);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int QuaternionAreEqualEpsilon(AssimpQuaternion* a, AssimpQuaternion* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int QuaternionAreEqualEpsilon(AssimpQuaternion* a, ref AssimpQuaternion b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public unsafe partial int QuaternionAreEqualEpsilon(ref AssimpQuaternion a, AssimpQuaternion* b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1189, Column 16 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionAreEqualEpsilon", Convention = CallingConvention.Winapi)]
        public partial int QuaternionAreEqualEpsilon(ref AssimpQuaternion a, ref AssimpQuaternion b, float epsilon);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionNormalize", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionNormalize(AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionNormalize", Convention = CallingConvention.Winapi)]
        public partial void QuaternionNormalize(ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1206, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionConjugate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionConjugate(AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1206, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionConjugate", Convention = CallingConvention.Winapi)]
        public partial void QuaternionConjugate(ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionMultiply(AssimpQuaternion* dst, AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionMultiply(AssimpQuaternion* dst, ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionMultiply(ref AssimpQuaternion dst, AssimpQuaternion* q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1214, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionMultiply", Convention = CallingConvention.Winapi)]
        public partial void QuaternionMultiply(ref AssimpQuaternion dst, ref AssimpQuaternion q);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, AssimpQuaternion* start, AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, AssimpQuaternion* start, ref AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, ref AssimpQuaternion start, AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionInterpolate(AssimpQuaternion* dst, ref AssimpQuaternion start, ref AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionInterpolate(ref AssimpQuaternion dst, AssimpQuaternion* start, AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionInterpolate(ref AssimpQuaternion dst, AssimpQuaternion* start, ref AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public unsafe partial void QuaternionInterpolate(ref AssimpQuaternion dst, ref AssimpQuaternion start, AssimpQuaternion* end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1225, Column 17 in build/submodules/Assimp/include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiQuaternionInterpolate", Convention = CallingConvention.Winapi)]
        public partial void QuaternionInterpolate(ref AssimpQuaternion dst, ref AssimpQuaternion start, ref AssimpQuaternion end, float factor);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 24 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "TextureTypeToString", Convention = CallingConvention.Winapi)]
        public unsafe partial byte* TextureTypeToString(TextureType @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 338, Column 24 in build/submodules/Assimp/include\\assimp/material.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "TextureTypeToString", Convention = CallingConvention.Winapi)]
        public partial string TextureTypeToStringS(TextureType @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1477, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1510, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1550, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1575, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1586, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1597, Column 28 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1610, Column 25 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetMaterialTextureCount([Flow(FlowDirection.In)] Material* pMat, TextureType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1610, Column 25 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount", Convention = CallingConvention.Winapi)]
        public partial uint GetMaterialTextureCount([Flow(FlowDirection.In)] in Material pMat, TextureType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1651, Column 21 in build/submodules/Assimp/include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 25 in build/submodules/Assimp/include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public unsafe partial byte* GetLegalString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 61, Column 25 in build/submodules/Assimp/include\\assimp/version.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetLegalString", Convention = CallingConvention.Winapi)]
        public partial string GetLegalStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 68, Column 25 in build/submodules/Assimp/include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetVersionPatch")]
        public partial uint GetVersionPatch();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 75, Column 25 in build/submodules/Assimp/include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetVersionMinor")]
        public partial uint GetVersionMinor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 82, Column 25 in build/submodules/Assimp/include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetVersionMajor")]
        public partial uint GetVersionMajor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 89, Column 25 in build/submodules/Assimp/include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetVersionRevision")]
        public partial uint GetVersionRevision();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 24 in build/submodules/Assimp/include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public unsafe partial byte* GetBranchName();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 95, Column 24 in build/submodules/Assimp/include\\assimp/version.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetBranchName", Convention = CallingConvention.Winapi)]
        public partial string GetBranchNameS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 115, Column 25 in build/submodules/Assimp/include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetCompileFlags")]
        public partial uint GetCompileFlags();


        public Assimp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

