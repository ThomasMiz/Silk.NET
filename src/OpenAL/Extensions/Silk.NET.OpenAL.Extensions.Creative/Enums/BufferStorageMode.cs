// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// This enum is used to abstract the need of using AL.GetEnumValue() with the extension. The values do not
    /// correspond to the actual tokens.
    /// </summary>
    public enum BufferStorageMode
    {
        /// <summary>
        /// Put an Open AL Buffer into X-RAM if memory is available, otherwise use host RAM.  This is the default mode.
        /// </summary>
        Automatic,

        /// <summary>
        /// Force an Open AL Buffer into X-RAM, good for non-streaming buffers.
        /// </summary>
        Hardware,

        /// <summary>
        /// Force an Open AL Buffer into 'accessible' (currently host) RAM, good for streaming buffers.
        /// </summary>
        Accessible
    }
}
