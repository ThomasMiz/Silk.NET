// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.FJ
{
    [NativeName("Name", "GLenum")]
    public enum FJ : int
    {
        [NativeName("Name", "GL_GCCSO_SHADER_BINARY_FJ")]
        GccsoShaderBinaryFJ = 0x9260,
    }
}
