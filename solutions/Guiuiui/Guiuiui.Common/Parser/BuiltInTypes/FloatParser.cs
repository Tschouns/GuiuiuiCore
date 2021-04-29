
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="float"/>.
    /// </summary>
    public class FloatParser : IParser<float>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<float> TryParse(string value)
        {
            if (float.TryParse(value, out var result))
            {
                return ParseResult<float>.CreateSuccessful(result);
            }

            return ParseResult<float>.CreateFailed();
        }
    }
}
