
using Guiuiui.Common.Controls;

namespace Guiuiui.Common.DataBinding
{
    /// <summary>
    /// Provides an interface to bind a list control to the (previously specified) list property.
    /// </summary>
    public interface IBindListPredicate<TListItem>
        where TListItem : class
    {
        /// <summary>
        /// Binds the specified list control to the list property.
        /// </summary>
        void ToListControl(IListControlAdapter<TListItem> controlAdapter);
    }
}
