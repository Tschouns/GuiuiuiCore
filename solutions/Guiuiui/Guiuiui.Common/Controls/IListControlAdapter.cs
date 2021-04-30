using System;
using System.Collections.Generic;

namespace Guiuiui.Common.Controls
{
    /// <summary>
    /// Represents a control which displayes a list of models.
    /// </summary>
    /// <typeparam name="TListItem">
    /// Type of the list item
    /// </typeparam>
    public interface IListControlAdapter<TListItem>
        where TListItem : class
    {
        /// <summary>
        /// Raised when the selected items have changed.
        /// </summary>
        event EventHandler SelectedItemsChanged;

        /// <summary>
        /// Gets the selected items.
        /// </summary>
        IReadOnlyList<TListItem> SelectedItems { get; }

        /// <summary>
        /// Selects the specified items, if they are in the list.
        /// </summary>
        void SelectListItems(IEnumerable<TListItem> items);

        /// <summary>
        /// Sets the items which are to be displayed in the list.
        /// </summary>
        void SetListItemsToDisplay(IReadOnlyList<TListItem> items);
    }
}
