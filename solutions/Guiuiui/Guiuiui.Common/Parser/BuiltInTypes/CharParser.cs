
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="char"/>.
    /// </summary>
    public class CharParser : IParser<char>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<char> TryParse(string value)
        {
            if (char.TryParse(value, out var result))
            {
                return ParseResult<char>.CreateSuccessful(result);
            }

            return ParseResult<char>.CreateFailed();
        }
    }
}
