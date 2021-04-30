using Guiuiui.Common;
using Guiuiui.Common.Controls;
using Guiuiui.Common.RuntimeChecks;
using Guiuiui.Common.TextConverter;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Guiuiui.WinForms.Controls
{
    /// <summary>
    /// See <see cref="IDataControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IDataControlAdapter{TValue}"/>.
    /// </typeparam>
    public class ComboBoxAdapter<TValue> : IDataControlAdapter<TValue>
    {
        private readonly ITextConverter<TValue> textConverter;
        private readonly ComboBox comboBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBoxAdapter{TValue}"/> class.
        /// </summary>
        public ComboBoxAdapter(
            ComboBox comboBox,
            ITextConverter<TValue> textConverter)
        {
            ArgumentChecks.AssertNotNull(comboBox, nameof(comboBox));
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));

            this.comboBox = comboBox;
            this.textConverter = textConverter;

            this.comboBox.Format += this.ComboBox_Format;
            this.comboBox.SelectedValueChanged += this.ComboBox_SelectedValueChanged;
            this.comboBox.TextChanged += this.ComboBox_TextChanged;
        }

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.ControlValueChanged"/>.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.Value"/>.
        /// </summary>
        public TValue Value
        {
            get => this.GetSelectedValue();

            set => this.TrySetSelectedItem(value);
        }

        private TValue GetSelectedValue()
        {
            if (this.comboBox.SelectedItem is TValue)
            {
                return (TValue)this.comboBox.SelectedItem;
            }

            return default;
        }

        private void TrySetSelectedItem(TValue value)
        {
            if (this.comboBox.Items.OfType<TValue>().Contains(value))
            {
                this.comboBox.SelectedItem = value;
            }
            else
            {
                this.comboBox.SelectedItem = default;
            }
        }

        private void ComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.Value == null || e.Value is TValue)
            {
                e.Value = this.textConverter.GetText((TValue)e.Value);
            }
        }

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ControlValueChanged?.Invoke(this, new EventArgs());
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // TODO: rethink/refactor
            var itemsMatchingText = this.comboBox.Items
                .OfType<TValue>()
                .Where(v => this.textConverter.GetText(v).ToLower() == this.comboBox.Text.ToLower())
                .ToList();

            if (itemsMatchingText.Count == 1)
            {
                this.TrySetSelectedItem(itemsMatchingText.Single());

                return;
            }

            var itemsContainingText = this.comboBox.Items
                .OfType<TValue>()
                .Where(v => this.textConverter.GetText(v).ToLower().Contains(this.comboBox.Text.ToLower()))
                .ToList();

            if (itemsContainingText.Count == 1)
            {
                this.TrySetSelectedItem(itemsContainingText.Single());
            }
        }
    }
}
