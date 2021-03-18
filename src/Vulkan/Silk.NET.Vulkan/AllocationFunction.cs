// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Vulkan
{
    public unsafe delegate void* AllocationFunction(
        void* pUserData,
        nuint size,
        nuint alignment,
        SystemAllocationScope allocationScope);
}
