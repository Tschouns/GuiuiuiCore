using Guiuiui.Common;
using Guiuiui.Common.DataBinding;
using Guiuiui.Common.RuntimeChecks;
using Guiuiui.WinForms.Controls;
using System;
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

        /// <summary>
        /// Binds the specified date time picker to the property.
        /// </summary>
        /// <param name="bind">
        /// The bind term object
        /// </param>
        /// <param name="dateTimePicker">
        /// The date time picker to bind to the property
        /// </param>
        public static void ToDateTimePicker(this IBind<DateTime> bind, DateTimePicker dateTimePicker)
        {
            ArgumentChecks.AssertNotNull(bind, nameof(bind));
            ArgumentChecks.AssertNotNull(dateTimePicker, nameof(dateTimePicker));

            bind.ToControl(new DateTimePickerAdapter(dateTimePicker));
        }

        /// <summary>
        /// Binds the specified label to the property.
        /// </summary>
        /// <typeparam name="TPropertyType">
        /// The property type
        /// </typeparam>
        /// <param name="bind">
        /// The bind term object
        /// </param>
        /// <param name="checkBox">
        /// The label to bind to the property
        /// </param>
        public static void ToLabel<TPropertyType>(this IBind<TPropertyType> bind, Label label)
        {
            ArgumentChecks.AssertNotNull(bind, nameof(bind));
            ArgumentChecks.AssertNotNull(label, nameof(label));

            var textConverter = ToolBox.TextConverters.GetTextConverter<TPropertyType>();
            bind.ToControl(new LabelAdapter<TPropertyType>(label, textConverter));
        }
    }
}
