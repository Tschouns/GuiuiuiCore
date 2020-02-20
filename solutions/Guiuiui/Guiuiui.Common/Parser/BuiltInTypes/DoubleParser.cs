
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="double"/>.
    /// </summary>
    public class DoubleParser : IParser<double>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<double> TryParse(string value)
        {
            double result;
            if (double.TryParse(value, out result))
            {
                return ParseResult<double>.CreateSuccessful(result);
            }

            return ParseResult<double>.CreateFailed();
        }
    }
}
