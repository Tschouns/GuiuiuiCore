
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="long"/>.
    /// </summary>
    public class LongParser : IParser<long>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<long> TryParse(string value)
        {
            long result;
            if (long.TryParse(value, out result))
            {
                return ParseResult<long>.CreateSuccessful(result);
            }

            return ParseResult<long>.CreateFailed();
        }
    }
}
