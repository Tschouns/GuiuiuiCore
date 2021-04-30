using Guiuiui.Common.DataBinding;
using Guiuiui.Common.RuntimeChecks;
using Guiuiui.WinForms.Controls;
using System.Windows.Forms;

namespace Guiuiui.WinForms.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="IBind"/> interface.
    /// </summary>
    public static class BindExtensions
    {
        /// <summary>
        /// Binds the specified check box to the property.
        /// </summary>
        /// <param name="bind">
        /// The bind term object
        /// </param>
        /// <param name="checkBox">
        /// The check box to bind to the property
        /// </param>
        public static void ToCheckBox(this IBind<bool> bind, CheckBox checkBox)
        {
            ArgumentChecks.AssertNotNull(bind, nameof(bind));
            ArgumentChecks.AssertNotNull(checkBox, nameof(checkBox));

            bind.ToControl(new CheckBoxAdapter(checkBox));
        }
    }
}
