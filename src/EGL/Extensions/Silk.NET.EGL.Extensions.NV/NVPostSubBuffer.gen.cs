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

namespace Silk.NET.EGL.Extensions.NV
{
    [Extension("NV_post_sub_buffer")]
    public unsafe partial class NVPostSubBuffer : NativeExtension<EGL>
    {
        public const string ExtensionName = "NV_post_sub_buffer";
        [NativeApi(EntryPoint = "eglPostSubBufferNV")]
        public partial int PostSubBuffer([Flow(FlowDirection.In)] nint dpy, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int width, [Flow(FlowDirection.In)] int height);

        public NVPostSubBuffer(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}
