
namespace Guiuiui.Common.ViewModelInternals
{
    /// <summary>
    /// Represents a single binding between a property and a control.
    /// </summary>
    internal interface IPropertyBinding
    {
        /// <summary>
        /// "Unbinds" the property and control, i.e. makes this data binding ineffective. Unregisters
        /// any event handlers.
        /// </summary>
        void Unbind();
    }
}
