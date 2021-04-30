using Guiuiui.Common.TextConverter;

namespace Guiuiui.Common.TestTypes.TextConverter
{
    /// <summary>
    /// A mock text converter.
    /// </summary>
    /// <typeparam name="T">
    /// See <see cref="ITextConverter{TValue}"/>
    /// </typeparam>
    public class MockTextConverter<T> : ITextConverter<T>
    {
        public string GetText(T value)
        {
            return "mock";
        }
    }
}
