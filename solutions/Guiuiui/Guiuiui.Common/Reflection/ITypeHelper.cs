using System;
using System.Collections.Generic;

namespace Guiuiui.Common.Reflection
{
    /// <summary>
    /// Provides helper methods concerning <see cref="Type"/>.
    /// </summary>
    public interface ITypeHelper
    {
        /// <summary>
        /// Gets a list of all types inherited by <typeparamref name="TType"/>, including
        /// <typeparamref name="TType"/> itself, ordered by their position in the type hierarchy.
        /// The types are ordered "top-down", i.e. <typeparamref name="TType"/> is the first
        /// element in the list.
        /// </summary>
        /// <typeparam name="TType">
        /// Type for which to retrieve all inherited types
        /// </typeparam>
        IReadOnlyList<Type> GetInheritedTypes<TType>();

        /// <summary>
        /// Gets a list of all types inherited by the specified <paramref name="type"/>, including
        /// said <paramref name="type"/> itself, ordered by their position in the type hierarchy.
        /// The types are ordered "top-down", i.e. the specified <paramref name="type"/> is the first
        /// element in the list.
        /// </summary>
        IReadOnlyList<Type> GetInheritedTypes(Type type);
    }
}
