﻿
namespace Guiuiui.Common.TextConverter
{
    /// <summary>
    /// Provides a method to convert a <typeparamref name="TValue"/> to a user-readable text.
    /// </summary>
    /// <typeparam name="TValue">
    /// Type of the value which is converted
    /// </typeparam>
    public interface ITextConverter<in TValue>
    {
        /// <summary>
        /// Convert a <typeparamref name="TValue"/> to a user-readable text.
        /// </summary>
        /// <param name="value">
        /// Can be <c>null</c>.
        /// </param>
        string GetText(TValue value);
    }
}
