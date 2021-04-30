using System;

namespace Guiuiui.Common.Parser.SystemTypes
{
    public class GuidParser : IParser<Guid>
    {
        public ParseResult<Guid> TryParse(string value)
        {
            if (Guid.TryParse(value, out var result))
            {
                return ParseResult<Guid>.CreateSuccessful(result);
            }

            return ParseResult<Guid>.CreateFailed();
        }
    }
}
