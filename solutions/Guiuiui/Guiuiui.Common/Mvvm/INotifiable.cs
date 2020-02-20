
namespace Guiuiui.Common.Mvvm
{
    /// <summary>
    /// Can be notified when a value has changed.
    /// </summary>
    public interface INotifiable
    {
        /// <summary>
        /// Notifies this that one of its values has changed.
        /// </summary>
        void NotifyValueHasChanged();
    }
}
