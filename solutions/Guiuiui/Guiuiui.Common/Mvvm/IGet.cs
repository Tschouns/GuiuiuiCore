
namespace Guiuiui.Common.Mvvm
{
    /// <summary>
    /// Represents an abstraction of a property getter.
    /// </summary>
    public interface IGet<TPropertyValue>
    {
        /// <summary>
        /// Gets the property value.
        /// </summary>
        TPropertyValue Get();
    }
}
