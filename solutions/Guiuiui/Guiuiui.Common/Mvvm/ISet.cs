
namespace Guiuiui.Common.Mvvm
{
    /// <summary>
    /// Represents an abstraction of a property setter.
    /// </summary>
    public interface ISet<TPropertyValue>
    {
        /// <summary>
        /// Sets the property value.
        /// </summary>
        void Set(TPropertyValue value);
    }
}
