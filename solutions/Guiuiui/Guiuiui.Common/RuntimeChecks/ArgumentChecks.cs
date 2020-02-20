﻿
using System;

namespace Guiuiui.Common.RuntimeChecks
{
    /// <summary>
    /// Provides runtime checks for arguments, throws exceptions.
    /// </summary>
    public static class ArgumentChecks
    {
        /// <summary>
        /// Asserts that a specified argument is not <c>null</c>.
        /// </summary>
        public static void AssertNotNull(object argument, string argumentName)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(argumentName);
            }
        }
    }
}
