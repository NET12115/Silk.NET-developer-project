// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousEnum_SDL_pixels_L68_C9")]
    [NativeName("Name", "SDL_BitmapOrder")]
    public enum BitmapOrder : int
    {
        [NativeName("Name", "SDL_BITMAPORDER_NONE")]
        BitmaporderNone = 0x0,
        [NativeName("Name", "SDL_BITMAPORDER_4321")]
        Bitmaporder4321 = 0x1,
        [NativeName("Name", "SDL_BITMAPORDER_1234")]
        Bitmaporder1234 = 0x2,
    }
}
