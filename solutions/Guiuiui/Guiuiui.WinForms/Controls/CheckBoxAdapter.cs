using Guiuiui.Common.Controls;
using Guiuiui.Common.RuntimeChecks;
using System;
using System.Windows.Forms;

namespace Guiuiui.WinForms.Controls
{
    /// <summary>
    /// See <see cref="IDataControlAdapter{TValue}"/>.
    /// </summary>
    public class CheckBoxAdapter : IDataControlAdapter<bool>
    {
        private readonly CheckBox checkBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBoxAdapter"/> class.
        /// </summary>
        public CheckBoxAdapter(CheckBox checkBox)
        {
            ArgumentChecks.AssertNotNull(checkBox, nameof(checkBox));

            this.checkBox = checkBox;
            this.checkBox.CheckedChanged += this.CheckBox_CheckedChanged;
        }

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.ControlValueChanged"/>.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.Value"/>.
        /// </summary>
        public bool Value
        {
            get
            {
                return this.checkBox.Checked;
            }

            set
            {
                this.checkBox.Checked = value;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.ControlValueChanged?.Invoke(this, new EventArgs());
        }
    }
}
