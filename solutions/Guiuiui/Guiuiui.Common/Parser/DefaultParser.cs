
namespace Guiuiui.Common.Parser
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Default parser which can be used as a
    /// fall-back for anything, but the parsing always fails.
    /// </summary>
    /// <typeparam name="TResult">
    /// See <see cref="IParser{TResult}"/>.
    /// </typeparam>
    public class DefaultParser<TResult> : IParser<TResult>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<TResult> TryParse(string value)
        {
            return ParseResult<TResult>.CreateFailed();
        }
    }
}
