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

namespace Silk.NET.EGL.Extensions.NV
{
    public static class NVStreamConsumerGltextureYuvOverloads
    {
        public static unsafe int StreamConsumerGltextureExternalAttrib(this NVStreamConsumerGltextureYuv thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.StreamConsumerGltextureExternalAttrib(dpy, stream, in attrib_list.GetPinnableReference());
        }

    }
}

