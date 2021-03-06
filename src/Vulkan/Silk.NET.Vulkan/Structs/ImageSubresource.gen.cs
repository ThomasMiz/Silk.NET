// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageSubresource")]
    public unsafe partial struct ImageSubresource
    {
        public ImageSubresource
        (
            ImageAspectFlags? aspectMask = null,
            uint? mipLevel = null,
            uint? arrayLayer = null
        ) : this()
        {
            if (aspectMask is not null)
            {
                AspectMask = aspectMask.Value;
            }

            if (mipLevel is not null)
            {
                MipLevel = mipLevel.Value;
            }

            if (arrayLayer is not null)
            {
                ArrayLayer = arrayLayer.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkImageAspectFlags")]
        [NativeName("Type.Name", "VkImageAspectFlags")]
        [NativeName("Name", "aspectMask")]
        public ImageAspectFlags AspectMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mipLevel")]
        public uint MipLevel;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "arrayLayer")]
        public uint ArrayLayer;
    }
}
