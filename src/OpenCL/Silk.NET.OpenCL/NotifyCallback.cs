// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.OpenCL
{
    public unsafe delegate void NotifyCallback(byte* errinfo, void* privateInfo, nuint cb, void* userData);
}
