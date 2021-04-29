
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="bool"/>.
    /// </summary>
    public class BoolParser : IParser<bool>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<bool> TryParse(string value)
        {
            if (bool.TryParse(value, out var result))
            {
                return ParseResult<bool>.CreateSuccessful(result);
            }

            return ParseResult<bool>.CreateFailed();
        }
    }
}
