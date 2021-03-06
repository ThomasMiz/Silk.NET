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
    [NativeName("Name", "VkPhysicalDeviceBufferDeviceAddressFeatures")]
    public unsafe partial struct PhysicalDeviceBufferDeviceAddressFeatures
    {
        public PhysicalDeviceBufferDeviceAddressFeatures
        (
            StructureType? sType = StructureType.PhysicalDeviceBufferDeviceAddressFeatures,
            void* pNext = null,
            Bool32? bufferDeviceAddress = null,
            Bool32? bufferDeviceAddressCaptureReplay = null,
            Bool32? bufferDeviceAddressMultiDevice = null
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

            if (bufferDeviceAddress is not null)
            {
                BufferDeviceAddress = bufferDeviceAddress.Value;
            }

            if (bufferDeviceAddressCaptureReplay is not null)
            {
                BufferDeviceAddressCaptureReplay = bufferDeviceAddressCaptureReplay.Value;
            }

            if (bufferDeviceAddressMultiDevice is not null)
            {
                BufferDeviceAddressMultiDevice = bufferDeviceAddressMultiDevice.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddress")]
        public Bool32 BufferDeviceAddress;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddressCaptureReplay")]
        public Bool32 BufferDeviceAddressCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddressMultiDevice")]
        public Bool32 BufferDeviceAddressMultiDevice;
    }
}
