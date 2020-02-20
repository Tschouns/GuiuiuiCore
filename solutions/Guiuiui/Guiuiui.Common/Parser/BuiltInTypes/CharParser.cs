﻿
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. Converts to <see cref="char"/>.
    /// </summary>
    public class CharParser : IParser<char>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>.
        /// </summary>
        public ParseResult<char> TryParse(string value)
        {
            char result;
            if (char.TryParse(value, out result))
            {
                return ParseResult<char>.CreateSuccessful(result);
            }

            return ParseResult<char>.CreateFailed();
        }
    }
}
