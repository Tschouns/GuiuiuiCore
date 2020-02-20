
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="byte"/>.
    /// </summary>
    public class ByteParser : IParser<byte>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<byte> TryParse(string value)
        {
            byte result;
            if (byte.TryParse(value, out result))
            {
                return ParseResult<byte>.CreateSuccessful(result);
            }

            return ParseResult<byte>.CreateFailed();
        }
    }
}
