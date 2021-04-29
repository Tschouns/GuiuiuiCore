using Guiuiui.Common;
using Guiuiui.Common.Controls;
using Guiuiui.Common.Parser;
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
    public class TextBoxAdapter<TValue> : IDataControlAdapter<TValue>
    {
        private readonly ITextConverter<TValue> _textConverter;
        private readonly IParser<TValue> _parser;
        private readonly TextBox _textBox;
        private TValue _currentValue;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxAdapter{TValue}"/> class.
        /// </summary>
        public TextBoxAdapter(TextBox textBox)
            : this(
                  textBox,
                  ToolBox.TextConverters.GetTextConverter<TValue>(),
                  ToolBox.Parsers.GetParser<TValue>())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxAdapter{TValue}"/> class.
        /// </summary>
        public TextBoxAdapter(
            TextBox textBox,
            ITextConverter<TValue> textConverter,
            IParser<TValue> parser)
        {
            ArgumentChecks.AssertNotNull(textBox, nameof(textBox));
            ArgumentChecks.AssertNotNull(textConverter, nameof(textConverter));
            ArgumentChecks.AssertNotNull(parser, nameof(parser));

            this._textBox = textBox;
            this._textConverter = textConverter;
            this._parser = parser;

            this._currentValue = this._parser.TryParse(textBox.Text).Result;

            this._textBox.TextChanged += this.TextBox_TextChanged;
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
            get => this._parser.TryParse(this._textBox.Text).Result;
            set
            {
                this._currentValue = value;

                this._textBox.Text = this._textConverter.GetText(this._currentValue);
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var result = this._parser.TryParse(this._textBox.Text);
            if (result.IsSuccessful)
            {
                this._currentValue = result.Result;
                this.ControlValueChanged?.Invoke(this, new EventArgs());
                return;
            }

            // If the conversion failed, the text is restored.
            var cursorPosition = this._textBox.SelectionStart;
            this._textBox.Text = this._textConverter.GetText(this._currentValue);
            this._textBox.Select(cursorPosition, 0);
        }
    }
}
