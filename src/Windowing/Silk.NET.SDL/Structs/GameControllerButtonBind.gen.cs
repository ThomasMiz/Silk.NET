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

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_GameControllerButtonBind")]
    public unsafe partial struct GameControllerButtonBind
    {
        public GameControllerButtonBind
        (
            GameControllerBindType? bindType = null,
            GameControllerBindValue? value = null
        ) : this()
        {
            if (bindType is not null)
            {
                BindType = bindType.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "SDL_GameControllerBindType")]
        [NativeName("Type.Name", "SDL_GameControllerBindType")]
        [NativeName("Name", "bindType")]
        public GameControllerBindType BindType;

        [NativeName("Type", "union (anonymous union at build/submodules/SDL-mirror/include\\SDL_gamecontroller.h:84:5)")]
        [NativeName("Type.Name", "union (anonymous union at build/submodules/SDL-mirror/include\\SDL_gamecontroller.h:84:5)")]
        [NativeName("Name", "value")]
        public GameControllerBindValue Value;
    }
}
