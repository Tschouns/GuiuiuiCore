
using Guiuiui.Common.Controls;
using Guiuiui.Common.RuntimeChecks;
using System;

namespace Guiuiui.Common.TestTypes.Controls
{
    /// <summary>
    /// A mock type which immitates the behavior of a generic control adapter.
    /// The <see cref="IDataControlAdapter{TValue}.ControlValueChanged"/> event fires
    /// whenever <see cref="IDataControlAdapter{TValue}.Value"/> is set.
    /// This class provides a constructor which takes a callback action which is called
    /// whenever <see cref="IDataControlAdapter{TValue}.Value"/> is set.
    /// </summary>
    /// <typeparam name="TValue">
    /// The type of the value represented by the control
    /// </typeparam>
    public class MockDataControlAdapter<TValue> : IDataControlAdapter<TValue>
    {
        private readonly Action<TValue> valueSetCallback;
        private TValue internalValue = default;

        public MockDataControlAdapter(Action<TValue> valueSetCallback)
        {
            ArgumentChecks.AssertNotNull(valueSetCallback, nameof(valueSetCallback));

            this.valueSetCallback = valueSetCallback;
        }

        public TValue Value
        {
            get => this.internalValue;
            set
            {
                this.internalValue = value;
                this.valueSetCallback(value);
                this.ControlValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ControlValueChanged;

        public void Dispose()
        {
            // Nothing to do.
        }
    }
}
