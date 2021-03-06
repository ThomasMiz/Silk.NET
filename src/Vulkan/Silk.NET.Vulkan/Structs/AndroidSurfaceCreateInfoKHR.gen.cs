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
    [NativeName("Name", "VkAndroidSurfaceCreateInfoKHR")]
    public unsafe partial struct AndroidSurfaceCreateInfoKHR
    {
        public AndroidSurfaceCreateInfoKHR
        (
            StructureType? sType = StructureType.AndroidSurfaceCreateInfoKhr,
            void* pNext = null,
            uint? flags = null,
            nint* window = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (window is not null)
            {
                Window = window;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkAndroidSurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkAndroidSurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "ANativeWindow*")]
        [NativeName("Type.Name", "ANativeWindow")]
        [NativeName("Name", "window")]
        public nint* Window;
    }
}
