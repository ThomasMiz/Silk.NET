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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_host_query_reset")]
    public unsafe partial class ExtHostQueryReset : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_host_query_reset";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkResetQueryPoolEXT")]
        public partial void ResetQueryPool([Count(Count = 0)] Device device, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint firstQuery, [Count(Count = 0)] uint queryCount);

        public ExtHostQueryReset(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

