
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="uint"/>.
    /// </summary>
    public class UIntParser : IParser<uint>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<uint> TryParse(string value)
        {
            if (uint.TryParse(value, out var result))
            {
                return ParseResult<uint>.CreateSuccessful(result);
            }

            return ParseResult<uint>.CreateFailed();
        }
    }
}
