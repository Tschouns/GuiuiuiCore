
using Guiuiui.Common.Parser;
using Guiuiui.Common.TextConverter;
using Guiuiui.WinForms.Controls;
using System.Windows.Forms;
using Xunit;

namespace Guiuiui.WinForms.Tests.Controls
{
    /// <summary>
    /// Performs tests for the <see cref="TextBoxAdapter{TValue}"/> class.
    /// </summary>
    public class TextBoxAdapterTests
    {
        [Fact]
        public void Dispose_CalledTwice_DoesNotThrow()
        {
            // Arrange
            var candidate = new TextBoxAdapter<object>(new TextBox(), new DefaultTextConverter<object>(), new DefaultParser<object>());

            // Act / Assert
            candidate.Dispose();
            candidate.Dispose();
        }
    }
}
