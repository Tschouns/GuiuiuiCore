
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="ushort"/>.
    /// </summary>
    public class UShortParser : IParser<ushort>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<ushort> TryParse(string value)
        {
            ushort result;
            if (ushort.TryParse(value, out result))
            {
                return ParseResult<ushort>.CreateSuccessful(result);
            }

            return ParseResult<ushort>.CreateFailed();
        }
    }
}
