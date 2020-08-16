﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Silk.NET.Input.Internals
{
    internal readonly struct CastReadOnlyList<TFrom, TTo> : IReadOnlyList<TTo>
    {
        private readonly IReadOnlyList<TFrom> _original;

        public CastReadOnlyList(IReadOnlyList<TFrom> original)
        {
            _original = original;
        }

        public IEnumerator<TTo> GetEnumerator() => _original.Cast<TTo>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _original.Count;

        public TTo this[int index]
        {
            get
            {
                var ret = (object?) _original[index];
                if (ret is null)
                {
                    return default!;
                }

                return (TTo) ret;
            }
        }
    }
}
