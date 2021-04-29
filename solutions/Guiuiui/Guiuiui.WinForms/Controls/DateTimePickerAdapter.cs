using Guiuiui.Common.Controls;
using Guiuiui.Common.RuntimeChecks;
using System;
using System.Windows.Forms;

namespace Guiuiui.WinForms.Controls
{
    /// <summary>
    /// See <see cref="IDataControlAdapter{TValue}"/>.
    /// </summary>
    public class DateTimePickerAdapter : IDataControlAdapter<DateTime>
    {
        private readonly DateTimePicker dateTimePicker;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimePickerAdapter"/> class.
        /// </summary>
        public DateTimePickerAdapter(DateTimePicker dateTimePicker)
        {
            ArgumentChecks.AssertNotNull(dateTimePicker, nameof(dateTimePicker));

            this.dateTimePicker = dateTimePicker;
            this.dateTimePicker.ValueChanged += this.DateTimePicker_ValueChanged;
        }

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.ControlValueChanged"/>.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.Value"/>.
        /// </summary>
        public DateTime Value
        {
            get => this.dateTimePicker.Value;

            set
            {
                if (value > this.dateTimePicker.MaxDate)
                {
                    this.dateTimePicker.Value = this.dateTimePicker.MaxDate;
                    return;
                }

                if (value < this.dateTimePicker.MinDate)
                {
                    this.dateTimePicker.Value = this.dateTimePicker.MinDate;
                    return;
                }

                this.dateTimePicker.Value = value;
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            this.ControlValueChanged?.Invoke(this, new EventArgs());
        }
    }
}
