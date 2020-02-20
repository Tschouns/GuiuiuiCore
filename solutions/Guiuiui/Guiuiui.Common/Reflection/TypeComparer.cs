﻿using Guiuiui.Common.RuntimeChecks;
using System;
using System.Collections.Generic;

namespace Guiuiui.Common.Reflection
{
    /// <summary>
    /// See <see cref="IComparer{T}"/>.
    /// </summary>
    public class TypeComparer : IComparer<Type>
    {
        /// <summary>
        /// See <see cref="IComparer{Type}.Compare"/>.
        /// </summary>
        public int Compare(Type x, Type y)
        {
            ArgumentChecks.AssertNotNull(x, nameof(x));
            ArgumentChecks.AssertNotNull(y, nameof(y));

            // Special case: x and y are the same type.
            if (x == y)
            {
                return 0;
            }

            if (x.IsAssignableFrom(y))
            {
                // Means x is less.
                return -1;
            }

            if (y.IsAssignableFrom(x))
            {
                // Means x is greater.
                return 1;
            }

            // If they are completely unrelated, none is greater.
            return 0;
        }
    }
}
