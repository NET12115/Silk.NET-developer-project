// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedDLSupport;
using Silk.NET.Core.Attributes;

namespace Silk.NET.OpenAL.Extensions.Creative.EnumerateAll
{
    /// <summary>
    /// Exposes the API in the EnumerateAll extension.
    /// </summary>
    [Extension("ALC_ENUMERATE_ALL_EXT")]
    public abstract class EnumerateAll : ContextExtensionBase, IEnumerateAllContextState
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected EnumerateAll(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <inheritdoc />
        public abstract unsafe string GetString(Device* device, GetEnumerateAllContextString param);

        /// <inheritdoc />
        public abstract unsafe char* GetStringList(Device* device, GetEnumerateAllContextStringList param);

        /// <inheritdoc cref="GetStringList(Device*, GetEnumerateAllContextStringList)" />
        public IEnumerable<string> GetStringList(GetEnumerateAllContextStringList param)
        {
            unsafe {
                var result = GetStringList(null, param);
                if (result == (char*) 0) {
                    return new List<string>();
                }

                var strings = new List<string>();

                var currentPos = result;
                while (true) {
                    var currentString = Marshal.PtrToStringAnsi(new IntPtr(currentPos));
                    if (currentString is null) {
                        break;
                    }

                    strings.Add(currentString);
                    currentPos += currentString.Length + 1;
                }

                return strings;
            }
        }
    }
}