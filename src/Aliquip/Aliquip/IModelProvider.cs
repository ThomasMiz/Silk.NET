﻿// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Aliquip
{
    public interface IModelProvider
    {
        Vertex[] Vertices { get; }
        uint[] Indices { get; }
    }
}