// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Contexts;

namespace Silk.NET.OpenGL.Legacy
{
    public static class ContextSourceExtensions
    {
        public static GL CreateLegacyOpenGL(this IGLContextSource src) => GL.GetApi(src);
    }
}
