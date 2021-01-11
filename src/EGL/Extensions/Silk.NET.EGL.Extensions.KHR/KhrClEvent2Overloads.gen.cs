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

namespace Silk.NET.EGL.Extensions.KHR
{
    public static class KhrClEvent2Overloads
    {
        public static unsafe nint CreateSync64(this KhrClEvent2 thisApi, [Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.CreateSync64(dpy, type, in attrib_list.GetPinnableReference());
        }

    }
}
