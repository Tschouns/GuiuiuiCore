using Guiuiui.Common.Parser;
using Xunit;

namespace Guiuiui.Common.Tests
{
    public class ToolBoxTests
    {
        [Fact]
        public void TextConvertersProperty_GetInstance_InstanceIsReturned()
        {
            // Act
            var provider = ToolBox.TextConverters;

            // Assert
            Assert.NotNull(provider);
        }

        [Fact]
        public void TextConvertersGetTextConverter_UnsupportedType_DefaultInstanceIsReturnedWhichCallsToString()
        {
            // Arrange
            var provider = ToolBox.TextConverters;
            var dummyObject = new object();
            var expectedText = dummyObject.ToString();

            // Act
            var textConverter = provider.GetTextConverter<object>();
            var text = textConverter.GetText(dummyObject);

            // Assert
            Assert.NotNull(text);
            Assert.Equal(expectedText, text);
        }

        [Fact]
        public void ParsersProperty_GetInstance_InstanceIsReturned()
        {
            // Act
            var provider = ToolBox.Parsers;

            // Assert
            Assert.NotNull(provider);
        }

        [Fact]
        public void ParsersGetParser_AllKnownBuiltInTypes_WorkingInstanceIsReturned()
        {
            // Arrange
            var provider = ToolBox.Parsers;

            // Act / Assert
            this.TestParserForType<bool>(provider);
            this.TestParserForType<byte>(provider);
            this.TestParserForType<char>(provider);
            this.TestParserForType<decimal>(provider);
            this.TestParserForType<double>(provider);
            this.TestParserForType<float>(provider);
            this.TestParserForType<int>(provider);
            this.TestParserForType<long>(provider);
            this.TestParserForType<sbyte>(provider);
            this.TestParserForType<short>(provider);
            this.TestParserForType<string>(provider);
            this.TestParserForType<uint>(provider);
            this.TestParserForType<ulong>(provider);
            this.TestParserForType<ushort>(provider);
        }

        [Fact]
        public void ParsersGetParser_UnsupportedType_InstanceIsReturnedWhichAlwaysFails()
        {
            // Arrange
            var provider = ToolBox.Parsers;
            var objectString = new object().ToString();

            // Act
            var parser = provider.GetParser<object>();
            var parseResult = parser.TryParse(objectString);

            // Assert
            Assert.NotNull(parseResult);
            Assert.False(parseResult.IsSuccessful);
            Assert.Null(parseResult.Result);
        }

        private void TestParserForType<T>(IParserProvider provider)
        {
            // Arrange
            var testString = default(T)?.ToString() ?? string.Empty;

            // Act
            var parser = provider.GetParser<T>();
            var parseResult = parser.TryParse(testString);

            // Assert
            Assert.NotNull(parseResult);
            Assert.True(parseResult.IsSuccessful);
            Assert.NotNull(parseResult.Result);
        }
    }
}
