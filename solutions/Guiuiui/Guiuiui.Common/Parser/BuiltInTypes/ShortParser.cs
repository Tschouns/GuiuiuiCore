
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="short"/>.
    /// </summary>
    public class ShortParser : IParser<short>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<short> TryParse(string value)
        {
            if (short.TryParse(value, out var result))
            {
                return ParseResult<short>.CreateSuccessful(result);
            }

            return ParseResult<short>.CreateFailed();
        }
    }
}
