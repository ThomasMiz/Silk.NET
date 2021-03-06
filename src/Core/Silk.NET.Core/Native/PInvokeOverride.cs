// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Native
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PInvokeOverride : Attribute
    {
        public PInvokeOverride(int id, string target)
        {
        }
    }
}
