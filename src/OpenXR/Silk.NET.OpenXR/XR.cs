using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using ExtensionAttribute = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public partial class XR
    {
        public Instance? CurrentInstance { get; set; }
        public static XR GetApi()
        {
            return new XR(CreateDefaultContext(new OpenXRLibraryNameContainer().GetLibraryName()));
        }

        [Obsolete("Use IsInstanceExtensionPresent instead.", true)]
        public override bool IsExtensionPresent(string extension) => IsInstanceExtensionPresent(null, extension);
        private readonly HashSet<string> _cachedInstanceExtensions = new HashSet<string>();
        private readonly ReaderWriterLockSlim _cachedInstanceExtensionsLock = new ReaderWriterLockSlim();

        /// <summary>
        /// Attempts to load the given instance extension.
        /// </summary>
        /// <param name="layer">The layer name.</param>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="ext">The loaded instance extension, or null if load failed.</param>
        /// <typeparam name="T">The instance extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
        public bool TryGetInstanceExtension<T>(string layer, Instance instance, out T ext) where T : NativeExtension<XR> =>
            !((ext = IsInstanceExtensionPresent(layer, ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? (T) Activator.CreateInstance
                    (typeof(T), new LamdaNativeContext(
                    x =>
                    {
                        PfnVoidFunction ptr = default;
                        var result = GetInstanceProcAddr(instance, x, ref ptr);
                        if (result != Result.Success)
                        {
                            throw new InvalidOperationException($"Symbol loading failed with XrResult {result}");
                        }

                        return ptr;
                    }))
                : null) is null);

        /// <summary>
        /// Checks whether the given instance extension is available.
        /// </summary>
        /// <param name="layer">The layer name.</param>
        /// <param name="extension">The instance extension name.</param>
        /// <returns>Whether the instance extension is available.</returns>
        public unsafe bool IsInstanceExtensionPresent(string layer, string extension)
        {
            // For a detailed explanation of the logic see Silk.Net.Vulkan.Vk.IsDeviceExtensionPresent
            layer ??= string.Empty;
            var layer_sep = layer + '\0';
            var fullKey = layer_sep + extension;
            var result = false;

            _cachedInstanceExtensionsLock.EnterUpgradeableReadLock();
            if (_cachedInstanceExtensions.Contains(fullKey))
            {
                // We found the extension
                result = true;
            }
            else if (!_cachedInstanceExtensions.Contains(layer))
            {
                // The lack of the device handle indicates we've not been previously initialised.  We now need a write lock.
                _cachedInstanceExtensionsLock.EnterWriteLock();
                GlobalMemory mem = null;
                var layerName = SilkMarshal.StringToPtr(layer);
                try
                {
                    var extensionCount = 0u;
                    EnumerateInstanceExtensionProperties((byte*) layerName, extensionCount, &extensionCount, null);

                    mem = GlobalMemory.Allocate((int) extensionCount * sizeof(ExtensionProperties));
                    var exts = (ExtensionProperties*) Unsafe.AsPointer(ref mem.GetPinnableReference());

                    // TODO Is this necessary?
                    for (int i = 0; i < extensionCount; i++)
                    {
                        exts[i] = new ExtensionProperties(StructureType.TypeExtensionProperties);
                    }

                    EnumerateInstanceExtensionProperties((byte*) layerName, extensionCount, &extensionCount, exts);
                    for (var i = 0; i < extensionCount; i++)
                    {
                        var newKey = layer_sep + Marshal.PtrToStringAnsi((IntPtr) exts[i].ExtensionName);
                        _cachedInstanceExtensions.Add(newKey);
                        if (!result && string.Equals(newKey, fullKey))
                        {
                            result = true;
                        }
                    }
                }
                finally
                {
                    _cachedInstanceExtensionsLock.ExitWriteLock();
                    SilkMarshal.Free(layerName);
                    mem?.Dispose();
                }
            }

            _cachedInstanceExtensionsLock.ExitUpgradeableReadLock();
            return result;
        }
    }
}

