using System;

namespace Guiuiui.Common.Controls
{
    /// <summary>
    /// Provides an abstract interface to interact with any control.
    /// </summary>
    /// <typeparam name="TValue">
    /// Type of the value represented by the control
    /// </typeparam>
    public interface IDataControlAdapter<TValue>
    {
        /// <summary>
        /// Raised whenever the value of the underlying control has changed.
        /// </summary>
        event EventHandler ControlValueChanged;

        /// <summary>
        /// Gets or sets the current value of the control.
        /// </summary>
        TValue Value { get; set; }
    }
}
