// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SHADER_TRACE_DESC")]
    public unsafe partial struct ShaderTraceDesc
    {
        public ShaderTraceDesc
        (
            ShaderType? type = null,
            uint? flags = null,
            ShaderTraceDescUnion? anonymous = null,
            VertexShaderTraceDesc? vertexShaderTraceDesc = null,
            HullShaderTraceDesc? hullShaderTraceDesc = null,
            DomainShaderTraceDesc? domainShaderTraceDesc = null,
            GeometryShaderTraceDesc? geometryShaderTraceDesc = null,
            PixelShaderTraceDesc? pixelShaderTraceDesc = null,
            ComputeShaderTraceDesc? computeShaderTraceDesc = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (vertexShaderTraceDesc is not null)
            {
                VertexShaderTraceDesc = vertexShaderTraceDesc.Value;
            }

            if (hullShaderTraceDesc is not null)
            {
                HullShaderTraceDesc = hullShaderTraceDesc.Value;
            }

            if (domainShaderTraceDesc is not null)
            {
                DomainShaderTraceDesc = domainShaderTraceDesc.Value;
            }

            if (geometryShaderTraceDesc is not null)
            {
                GeometryShaderTraceDesc = geometryShaderTraceDesc.Value;
            }

            if (pixelShaderTraceDesc is not null)
            {
                PixelShaderTraceDesc = pixelShaderTraceDesc.Value;
            }

            if (computeShaderTraceDesc is not null)
            {
                ComputeShaderTraceDesc = computeShaderTraceDesc.Value;
            }
        }


        [NativeName("Type", "D3D11_SHADER_TYPE")]
        [NativeName("Type.Name", "D3D11_SHADER_TYPE")]
        [NativeName("Name", "Type")]
        public ShaderType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d11shadertracing_L126_C5")]
        [NativeName("Name", "anonymous1")]
        public ShaderTraceDescUnion Anonymous;
#if NETSTANDARD2_1
        public ref VertexShaderTraceDesc VertexShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.VertexShaderTraceDesc;
        }
#else
        public VertexShaderTraceDesc VertexShaderTraceDesc
        {
            get => Anonymous.VertexShaderTraceDesc;
            set => Anonymous.VertexShaderTraceDesc = value;
        }
#endif

#if NETSTANDARD2_1
        public ref HullShaderTraceDesc HullShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.HullShaderTraceDesc;
        }
#else
        public HullShaderTraceDesc HullShaderTraceDesc
        {
            get => Anonymous.HullShaderTraceDesc;
            set => Anonymous.HullShaderTraceDesc = value;
        }
#endif

#if NETSTANDARD2_1
        public ref DomainShaderTraceDesc DomainShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.DomainShaderTraceDesc;
        }
#else
        public DomainShaderTraceDesc DomainShaderTraceDesc
        {
            get => Anonymous.DomainShaderTraceDesc;
            set => Anonymous.DomainShaderTraceDesc = value;
        }
#endif

#if NETSTANDARD2_1
        public ref GeometryShaderTraceDesc GeometryShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.GeometryShaderTraceDesc;
        }
#else
        public GeometryShaderTraceDesc GeometryShaderTraceDesc
        {
            get => Anonymous.GeometryShaderTraceDesc;
            set => Anonymous.GeometryShaderTraceDesc = value;
        }
#endif

#if NETSTANDARD2_1
        public ref PixelShaderTraceDesc PixelShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.PixelShaderTraceDesc;
        }
#else
        public PixelShaderTraceDesc PixelShaderTraceDesc
        {
            get => Anonymous.PixelShaderTraceDesc;
            set => Anonymous.PixelShaderTraceDesc = value;
        }
#endif

#if NETSTANDARD2_1
        public ref ComputeShaderTraceDesc ComputeShaderTraceDesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref Anonymous.ComputeShaderTraceDesc;
        }
#else
        public ComputeShaderTraceDesc ComputeShaderTraceDesc
        {
            get => Anonymous.ComputeShaderTraceDesc;
            set => Anonymous.ComputeShaderTraceDesc = value;
        }
#endif

    }
}
