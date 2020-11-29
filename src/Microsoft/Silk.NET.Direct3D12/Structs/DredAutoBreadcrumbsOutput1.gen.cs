// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1")]
    public unsafe partial struct DredAutoBreadcrumbsOutput1
    {
        public DredAutoBreadcrumbsOutput1
        (
            AutoBreadcrumbNode1* pHeadAutoBreadcrumbNode = null
        ) : this()
        {
            if (pHeadAutoBreadcrumbNode is not null)
            {
                PHeadAutoBreadcrumbNode = pHeadAutoBreadcrumbNode;
            }
        }


        [NativeName("Type", "const D3D12_AUTO_BREADCRUMB_NODE1 *")]
        [NativeName("Type.Name", "const D3D12_AUTO_BREADCRUMB_NODE1 *")]
        [NativeName("Name", "pHeadAutoBreadcrumbNode")]
        public AutoBreadcrumbNode1* PHeadAutoBreadcrumbNode;
    }
}