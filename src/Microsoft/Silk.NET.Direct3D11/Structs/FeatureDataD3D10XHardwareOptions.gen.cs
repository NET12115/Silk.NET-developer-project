// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_D3D10_X_HARDWARE_OPTIONS")]
    public unsafe partial struct FeatureDataD3D10XHardwareOptions
    {
        public FeatureDataD3D10XHardwareOptions
        (
            int? computeShadersPlusRawAndStructuredBuffersViaShader4X = null
        ) : this()
        {
            if (computeShadersPlusRawAndStructuredBuffersViaShader4X is not null)
            {
                ComputeShadersPlusRawAndStructuredBuffersViaShader4X = computeShadersPlusRawAndStructuredBuffersViaShader4X.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ComputeShaders_Plus_RawAndStructuredBuffers_Via_Shader_4_x")]
        public int ComputeShadersPlusRawAndStructuredBuffersViaShader4X;
    }
}
