using Guiuiui.Common;
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

        /// <summary>
        /// Binds the specified combo box to the property.
        /// </summary>
        /// <typeparam name="TPropertyType">
        /// The property type
        /// </typeparam>
        /// <param name="bind">
        /// The bind term object
        /// </param>
        /// <param name="checkBox">
        /// The combo box to bind to the property
        /// </param>
        public static void ToComboBox<TPropertyType>(this IBind<TPropertyType> bind, ComboBox comboBox)
        {
            ArgumentChecks.AssertNotNull(bind, nameof(bind));
            ArgumentChecks.AssertNotNull(comboBox, nameof(comboBox));
            
            var textConverter = ToolBox.TextConverters.GetTextConverter<TPropertyType>();
            bind.ToControl(new ComboBoxAdapter<TPropertyType>(comboBox, textConverter));
        }
    }
}
