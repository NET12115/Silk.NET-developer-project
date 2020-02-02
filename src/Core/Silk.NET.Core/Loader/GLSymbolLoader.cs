// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.Core.Loader
{
    public abstract class GLSymbolLoader : Ultz.SuperInvoke.Loader.LibraryLoader
    {
        // pass-through class for dependency injection
        protected Ultz.SuperInvoke.Loader.LibraryLoader UnderlyingLoader { get; } = GetPlatformDefaultLoader();
        protected override IntPtr CoreLoadNativeLibrary(string name) => UnderlyingLoader.LoadNativeLibrary(name);
        protected override void CoreFreeNativeLibrary(IntPtr handle) => UnderlyingLoader.FreeNativeLibrary(handle);
    }
}
