// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrPerfSettingsSubDomainEXT")]
    public enum PerfSettingsSubDomainEXT : int
    {
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_COMPOSITING_EXT")]
        PerfSettingsSubDomainCompositingExt = 1,
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_RENDERING_EXT")]
        PerfSettingsSubDomainRenderingExt = 2,
        [NativeName("Name", "XR_PERF_SETTINGS_SUB_DOMAIN_THERMAL_EXT")]
        PerfSettingsSubDomainThermalExt = 3,
    }
}
