
using System;

namespace Guiuiui.Common.Mvvm
{
    /// <summary>
    /// Can be observed -- and notifies observers when a value has changed.
    /// </summary>
    public interface IObservable
    {
        /// <summary>
        /// Raised when a value has changed.
        /// </summary>
        event EventHandler ValueChanged;
    }
}
