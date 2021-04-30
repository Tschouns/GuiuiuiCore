using System;
using System.Collections.Generic;

namespace Guiuiui.Common.DataBinding
{
    /// <summary>
    /// Provides an interface to bind properties of <typeparamref name="TModel"/> to controls.
    /// </summary>
    /// <typeparam name="TModel">
    /// Type of the underlying data model
    /// </typeparam>
    public interface IBindable<TModel>
        where TModel : class
    {
        /// <summary>
        /// Binds the specified property read-only.
        /// </summary>
        /// <typeparam name="TPropertyValue">
        /// Type of the property value
        /// </typeparam>
        IBindProperty<TPropertyValue> BindPropertyReadOnly<TPropertyValue>(Func<TModel, TPropertyValue> getFunc);

        /// <summary>
        /// Binds the specified property two-way.
        /// </summary>
        /// <typeparam name="TPropertyValue">
        /// Type of the property value
        /// </typeparam>
        IBindProperty<TPropertyValue> BindProperty<TPropertyValue>(Func<TModel, TPropertyValue> getFunc, Action<TModel, TPropertyValue> setAction);

        /// <summary>
        /// Binds the specified list property.
        /// </summary>
        /// <typeparam name="TListItem">
        /// Type of the list item
        /// </typeparam>
        IBindListPredicate<TListItem> BindListProperty<TListItem>(Func<TModel, IEnumerable<TListItem>> getFunc)
            where TListItem : class;

        /// <summary>
        /// "Unbinds" all properties and controls.
        /// </summary>
        void UnbindAll();
    }
}
