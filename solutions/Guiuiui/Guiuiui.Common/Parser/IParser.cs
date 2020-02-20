
namespace Guiuiui.Common.Parser
{
    /// <summary>
    /// Provides a method to parse a string and convert it to <typeparamref name="TResult"/>.
    /// </summary>
    /// <typeparam name="TResult">
    /// Output type of the parsing operation
    /// </typeparam>
    public interface IParser<TResult>
    {
        /// <summary>
        /// Tries to parse the specified string and convert it to <typeparamref name="TResult"/>.
        /// </summary>
        ParseResult<TResult> TryParse(string value);
    }
}
