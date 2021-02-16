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

namespace Silk.NET.XAudio
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [NativeName("Name", "XAUDIO2_EFFECT_DESCRIPTOR")]
    public unsafe partial struct EffectDescriptor
    {
        public EffectDescriptor
        (
            Silk.NET.Core.Native.IUnknown* pEffect = null,
            int? initialState = null,
            uint? outputChannels = null
        ) : this()
        {
            if (pEffect is not null)
            {
                PEffect = pEffect;
            }

            if (initialState is not null)
            {
                InitialState = initialState.Value;
            }

            if (outputChannels is not null)
            {
                OutputChannels = outputChannels.Value;
            }
        }


        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "pEffect")]
        public Silk.NET.Core.Native.IUnknown* PEffect;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InitialState")]
        public int InitialState;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "OutputChannels")]
        public uint OutputChannels;
    }
}
