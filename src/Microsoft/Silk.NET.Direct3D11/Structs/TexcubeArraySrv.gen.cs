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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_TEXCUBE_ARRAY_SRV")]
    public unsafe partial struct TexcubeArraySrv
    {
        public TexcubeArraySrv
        (
            uint? mostDetailedMip = null,
            uint? mipLevels = null,
            uint? first2DArrayFace = null,
            uint? numCubes = null
        ) : this()
        {
            if (mostDetailedMip is not null)
            {
                MostDetailedMip = mostDetailedMip.Value;
            }

            if (mipLevels is not null)
            {
                MipLevels = mipLevels.Value;
            }

            if (first2DArrayFace is not null)
            {
                First2DArrayFace = first2DArrayFace.Value;
            }

            if (numCubes is not null)
            {
                NumCubes = numCubes.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MostDetailedMip")]
        public uint MostDetailedMip;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipLevels")]
        public uint MipLevels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "First2DArrayFace")]
        public uint First2DArrayFace;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumCubes")]
        public uint NumCubes;
    }
}
