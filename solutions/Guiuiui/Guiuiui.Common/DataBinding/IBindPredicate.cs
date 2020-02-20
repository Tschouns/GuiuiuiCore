
using Guiuiui.Common.Controls;

namespace Guiuiui.Common.DataBinding
{
    /// <summary>
    /// Provides an interface to bind a data control to the (previously specified) property.
    /// </summary>
    public interface IBindPredicate<TPropertyValue>
    {
        /// <summary>
        /// Binds the specified data control to the property.
        /// </summary>
        void ToControl(IDataControlAdapter<TPropertyValue> controlAdapter);
    }
}
