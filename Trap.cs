// copyright (C) 2023 by David Thielen. ALL RIGHTS RESERVED
// This code is confidential and is only to be viewed and/or used by authorized individuals & entities.

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
