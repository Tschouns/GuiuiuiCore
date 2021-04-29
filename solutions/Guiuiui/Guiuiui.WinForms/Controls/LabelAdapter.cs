using Guiuiui.Common;
using Guiuiui.Common.Controls;
using Guiuiui.Common.RuntimeChecks;
using Guiuiui.Common.TextConverter;
using System;
using System.Windows.Forms;

namespace Guiuiui.WinForms.Controls
{
    /// <summary>
    /// See <see cref="IDataControlAdapter{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue">
    /// See <see cref="IDataControlAdapter{TValue}"/>.
    /// </typeparam>
    public class LabelAdapter<TValue> : IDataControlAdapter<TValue>
    {
        private readonly ITextConverter<TValue> textConverter;
        private readonly Label label;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelAdapter{TValue}"/> class.
        /// </summary>
        public LabelAdapter(Label label)
            : this(
                  label,
                  ToolBox.TextConverters.GetTextConverter<TValue>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelAdapter{TValue}"/> class.
        /// </summary>
        public LabelAdapter(
            Label label,
            ITextConverter<TValue> textConverter)
        {
            ArgumentChecks.AssertNotNull(label, nameof(label));
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));

            this.label = label;
            this.textConverter = textConverter;
        }

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.ControlValueChanged"/>. With labels this is never raised.
        /// </summary>
        public event EventHandler ControlValueChanged;

        /// <summary>
        /// See <see cref="IDataControlAdapter{TValue}.Value"/>.
        /// </summary>
        public TValue Value
        {
            get => default;

            set => this.label.Text = this.textConverter.GetText(value);
        }
    }
}
