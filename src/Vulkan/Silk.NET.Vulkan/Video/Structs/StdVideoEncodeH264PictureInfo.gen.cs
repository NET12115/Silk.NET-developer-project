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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoEncodeH264PictureInfo")]
    public unsafe partial struct StdVideoEncodeH264PictureInfo
    {
        public StdVideoEncodeH264PictureInfo
        (
            StdVideoEncodeH264PictureInfoFlags? flags = null,
            StdVideoH264PictureType? pictureType = null,
            uint? frameNum = null,
            uint? pictureOrderCount = null,
            ushort? longTermPicNum = null,
            ushort? longTermFrameIdx = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pictureType is not null)
            {
                PictureType = pictureType.Value;
            }

            if (frameNum is not null)
            {
                FrameNum = frameNum.Value;
            }

            if (pictureOrderCount is not null)
            {
                PictureOrderCount = pictureOrderCount.Value;
            }

            if (longTermPicNum is not null)
            {
                LongTermPicNum = longTermPicNum.Value;
            }

            if (longTermFrameIdx is not null)
            {
                LongTermFrameIdx = longTermFrameIdx.Value;
            }
        }


        [NativeName("Type", "StdVideoEncodeH264PictureInfoFlags")]
        [NativeName("Type.Name", "StdVideoEncodeH264PictureInfoFlags")]
        [NativeName("Name", "flags")]
        public StdVideoEncodeH264PictureInfoFlags Flags;

        [NativeName("Type", "StdVideoH264PictureType")]
        [NativeName("Type.Name", "StdVideoH264PictureType")]
        [NativeName("Name", "pictureType")]
        public StdVideoH264PictureType PictureType;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frameNum")]
        public uint FrameNum;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pictureOrderCount")]
        public uint PictureOrderCount;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "long_term_pic_num")]
        public ushort LongTermPicNum;

        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "long_term_frame_idx")]
        public ushort LongTermFrameIdx;
    }
}
