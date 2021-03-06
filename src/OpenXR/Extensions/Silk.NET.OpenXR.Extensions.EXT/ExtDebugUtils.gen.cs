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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_debug_utils")]
    public unsafe partial class ExtDebugUtils : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_debug_utils";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* createInfo, [Count(Count = 0)] DebugUtilsMessengerEXT* messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* createInfo, [Count(Count = 0)] ref DebugUtilsMessengerEXT messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT")]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCreateInfoEXT createInfo, [Count(Count = 0)] DebugUtilsMessengerEXT* messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT")]
        public partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCreateInfoEXT createInfo, [Count(Count = 0)] ref DebugUtilsMessengerEXT messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyDebugUtilsMessengerEXT")]
        public partial Result DestroyDebugUtilsMessenger([Count(Count = 0)] DebugUtilsMessengerEXT messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionBeginDebugUtilsLabelRegionEXT")]
        public unsafe partial Result SessionBeginDebugUtilsLabelRegion([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionBeginDebugUtilsLabelRegionEXT")]
        public partial Result SessionBeginDebugUtilsLabelRegion([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsLabelEXT labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionEndDebugUtilsLabelRegionEXT")]
        public partial Result SessionEndDebugUtilsLabelRegion([Count(Count = 0)] Session session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionInsertDebugUtilsLabelEXT")]
        public unsafe partial Result SessionInsertDebugUtilsLabel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionInsertDebugUtilsLabelEXT")]
        public partial Result SessionInsertDebugUtilsLabel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsLabelEXT labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetDebugUtilsObjectNameEXT")]
        public unsafe partial Result SetDebugUtilsObjectName([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectNameInfoEXT* nameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetDebugUtilsObjectNameEXT")]
        public partial Result SetDebugUtilsObjectName([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsObjectNameInfoEXT nameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSubmitDebugUtilsMessageEXT")]
        public unsafe partial Result SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCallbackDataEXT* callbackData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSubmitDebugUtilsMessageEXT")]
        public partial Result SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] in DebugUtilsMessengerCallbackDataEXT callbackData);

        public ExtDebugUtils(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

