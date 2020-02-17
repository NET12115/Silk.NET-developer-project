// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Ultz.SuperInvoke.Loader;

namespace Silk.NET.Vulkan
{
    public class VkLoader : LibraryLoader
    {
        public Vk Vulkan { get; internal set; }
        public LibraryLoader BaseLoader { get; }
        public VkLoader(LibraryLoader defaultLoader)
        {
            BaseLoader = defaultLoader;
            Vulkan = null;
        }

        protected override IntPtr CoreLoadNativeLibrary(string name) => BaseLoader.LoadNativeLibrary(name);
        protected override void CoreFreeNativeLibrary(IntPtr handle) => BaseLoader.FreeNativeLibrary(handle);
        protected override IntPtr CoreLoadFunctionPointer(IntPtr library, string symbolName)
        {
            IntPtr sym;
            try
            {
                sym = BaseLoader.LoadFunctionPointer(library, symbolName);
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }
            catch
            {
                // do nothing, just move on.
            }

            sym = Vulkan.GetInstanceProcAddr(default, symbolName).Value;
            if (sym != IntPtr.Zero)
            {
                return sym;
            }

            if (Vulkan.CurrentInstance.HasValue)
            {
                sym = Vulkan.GetInstanceProcAddr(Vulkan.CurrentInstance.Value, symbolName).Value;
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }

            if (Vulkan.CurrentDevice.HasValue)
            {
                sym = Vulkan.GetDeviceProcAddr(Vulkan.CurrentDevice.Value, symbolName).Value;
                if (sym != IntPtr.Zero)
                {
                    return sym;
                }
            }
            
            throw new EntryPointNotFoundException();
        }
    }
}
