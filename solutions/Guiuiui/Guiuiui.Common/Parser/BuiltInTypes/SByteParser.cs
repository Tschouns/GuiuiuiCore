
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="sbyte"/>.
    /// </summary>
    public class SByteParser : IParser<sbyte>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<sbyte> TryParse(string value)
        {
            if (sbyte.TryParse(value, out var result))
            {
                return ParseResult<sbyte>.CreateSuccessful(result);
            }

            return ParseResult<sbyte>.CreateFailed();
        }
    }
}
