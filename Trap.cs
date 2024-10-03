// Copyright (c) 2024 Trade Winds Studios (David Thielen)
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Diagnostics;

namespace CommonUtilities.Debug
{
    /// <summary>
    /// In debug mode, this will break into the debugger if breakOn is true.
    /// </summary>
    public static class Trap
    {
        /// <summary>
        /// set to false to turn off all breaks.
        /// </summary>
        public static bool BreakOn = true;

        /// <summary>
        /// Break into the debugger (only for debug builds).
        /// </summary>
        public static void Break ()
        {
#if DEBUG
            if (BreakOn)
                Debugger.Break();
#endif
        }

        /// <summary>
        /// Break into the debugger (only for debug builds).
        /// </summary>
        /// <param name="break">Only break if this is true.</param>
        public static void Break(bool @break)
        {
#if DEBUG
            if (@break && BreakOn)
                Debugger.Break();
#endif
        }
    }
}
