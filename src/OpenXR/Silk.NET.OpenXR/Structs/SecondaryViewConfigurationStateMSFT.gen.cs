// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct SecondaryViewConfigurationStateMSFT
    {
        public SecondaryViewConfigurationStateMSFT
        (
            StructureType type = StructureType.TypeSecondaryViewConfigurationStateMsft,
            void* next = default,
            ViewConfigurationType viewConfigurationType = default,
            uint active = default
        )
        {
           Type = type;
           Next = next;
           ViewConfigurationType = viewConfigurationType;
           Active = active;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ViewConfigurationType ViewConfigurationType;
/// <summary></summary>
        public uint Active;
    }
}
