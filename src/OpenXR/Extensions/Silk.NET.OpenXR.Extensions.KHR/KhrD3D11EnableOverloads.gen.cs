// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    public static class KhrD3D11EnableOverloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetD3D11GraphicsRequirements(this KhrD3D11Enable thisApi, [Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Span<GraphicsRequirementsD3D11KHR> graphicsRequirements)
        {
            // SpanOverloader
            return thisApi.GetD3D11GraphicsRequirements(instance, systemId, ref graphicsRequirements.GetPinnableReference());
        }

    }
}
