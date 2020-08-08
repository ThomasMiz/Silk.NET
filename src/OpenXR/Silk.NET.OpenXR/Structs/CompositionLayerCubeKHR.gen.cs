// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrCompositionLayerCubeKHR")]
    public unsafe partial struct CompositionLayerCubeKHR
    {
        public CompositionLayerCubeKHR
        (
            StructureType type = StructureType.TypeCompositionLayerCubeKhr,
            void* next = default,
            CompositionLayerFlags layerFlags = default,
            Space space = default,
            EyeVisibility eyeVisibility = default,
            Swapchain swapchain = default,
            uint imageArrayIndex = default,
            Quaternionf orientation = default
        )
        {
            Type = type;
            Next = next;
            LayerFlags = layerFlags;
            Space = space;
            EyeVisibility = eyeVisibility;
            Swapchain = swapchain;
            ImageArrayIndex = imageArrayIndex;
            Orientation = orientation;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrCompositionLayerFlags")]
        [NativeName("Type.Name", "XrCompositionLayerFlags")]
        [NativeName("Name", "layerFlags")]
        public CompositionLayerFlags LayerFlags;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrEyeVisibility")]
        [NativeName("Type.Name", "XrEyeVisibility")]
        [NativeName("Name", "eyeVisibility")]
        public EyeVisibility EyeVisibility;
/// <summary></summary>
        [NativeName("Type", "XrSwapchain")]
        [NativeName("Type.Name", "XrSwapchain")]
        [NativeName("Name", "swapchain")]
        public Swapchain Swapchain;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageArrayIndex")]
        public uint ImageArrayIndex;
/// <summary></summary>
        [NativeName("Type", "XrQuaternionf")]
        [NativeName("Type.Name", "XrQuaternionf")]
        [NativeName("Name", "orientation")]
        public Quaternionf Orientation;
    }
}