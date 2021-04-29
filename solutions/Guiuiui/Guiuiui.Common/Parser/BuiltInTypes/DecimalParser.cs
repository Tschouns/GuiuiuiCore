﻿
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="decimal"/>.
    /// </summary>
    public class DecimalParser : IParser<decimal>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<decimal> TryParse(string value)
        {
            if (decimal.TryParse(value, out var result))
            {
                return ParseResult<decimal>.CreateSuccessful(result);
            }

            return ParseResult<decimal>.CreateFailed();
        }
    }
}
