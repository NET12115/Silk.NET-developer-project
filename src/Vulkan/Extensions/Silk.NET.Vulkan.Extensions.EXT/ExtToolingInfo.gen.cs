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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_tooling_info")]
    public unsafe partial class ExtToolingInfo : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_tooling_info";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Parameter = "pToolCount"), Flow(FlowDirection.Out)] PhysicalDeviceToolPropertiesEXT* pToolProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolPropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Parameter = "pToolCount"), Flow(FlowDirection.Out)] out PhysicalDeviceToolPropertiesEXT pToolProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pToolCount, [Count(Parameter = "pToolCount"), Flow(FlowDirection.Out)] PhysicalDeviceToolPropertiesEXT* pToolProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolPropertiesExt);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pToolCount, [Count(Parameter = "pToolCount"), Flow(FlowDirection.Out)] out PhysicalDeviceToolPropertiesEXT pToolProperties);

        public ExtToolingInfo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

