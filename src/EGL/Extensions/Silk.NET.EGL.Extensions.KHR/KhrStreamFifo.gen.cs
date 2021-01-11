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
using Silk.NET.EGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_stream_fifo")]
    public unsafe partial class KhrStreamFifo : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_stream_fifo";
        [NativeApi(EntryPoint = "eglQueryStreamTimeKHR")]
        public unsafe partial int QueryStreamTime([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] ulong* value);

        [NativeApi(EntryPoint = "eglQueryStreamTimeKHR")]
        public partial int QueryStreamTime([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint stream, [Flow(FlowDirection.In)] KHR attribute, [Flow(FlowDirection.Out)] out ulong value);

        public KhrStreamFifo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

