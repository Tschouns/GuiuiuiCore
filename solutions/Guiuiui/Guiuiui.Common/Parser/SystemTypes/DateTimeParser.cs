using System;

namespace Guiuiui.Common.Parser.SystemTypes
{
    public class DateTimeParser : IParser<DateTime>
    {
        public ParseResult<DateTime> TryParse(string value)
        {
            if (DateTime.TryParse(value, out var result))
            {
                return ParseResult<DateTime>.CreateSuccessful(result);
            }

            return ParseResult<DateTime>.CreateFailed();
        }
    }
}
