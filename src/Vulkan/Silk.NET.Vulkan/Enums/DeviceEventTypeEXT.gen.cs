// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceEventTypeEXT")]
    public enum DeviceEventTypeEXT : int
    {
        [NativeName("Name", "VK_DEVICE_EVENT_TYPE_DISPLAY_HOTPLUG_EXT")]
        DeviceEventTypeDisplayHotplugExt = 0,
    }
}
