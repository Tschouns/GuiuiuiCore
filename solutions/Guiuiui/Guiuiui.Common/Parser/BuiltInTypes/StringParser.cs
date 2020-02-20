
namespace Guiuiui.Common.Parser.BuiltInTypes
{
    /// <summary>
    /// See <see cref="IParser{TResult}"/>. "Converts" to a string... or really doesn't do anything.
    /// </summary>
    public class StringDummyParser : IParser<string>
    {
        /// <summary>
        /// See <see cref="IParser{TResult}.TryParse(string)"/>
        /// </summary>
        public ParseResult<string> TryParse(string value)
        {
            return ParseResult<string>.CreateSuccessful(value);
        }
    }
}
