
using Guiuiui.Common.TestTypes.TextConverter;
using Guiuiui.WinForms.Controls;
using System.Windows.Forms;
using Xunit;

namespace Guiuiui.WinForms.Tests.Controls
{
    /// <summary>
    /// Performs tests for the <see cref="ComboBoxAdapter{TValue}"/> class.
    /// </summary>
    public class ComboBoxAdapterTests
    {
        [Fact]
        public void Dispose_CalledTwice_DoesNotThrow()
        {
            // Arrange
            var candidate = new ComboBoxAdapter<object>(new ComboBox(), new MockTextConverter<object>());

            // Act / Assert
            candidate.Dispose();
            candidate.Dispose();
        }
    }
}
