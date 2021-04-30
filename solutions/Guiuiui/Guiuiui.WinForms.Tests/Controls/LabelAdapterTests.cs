using Guiuiui.Common.TextConverter;
using Guiuiui.WinForms.Controls;
using System.Windows.Forms;
using Xunit;

namespace Guiuiui.WinForms.Tests.Controls
{
    /// <summary>
    /// Performs tests for the <see cref="LabelAdapter{TValue}"/> class.
    /// </summary>
    public class LabelAdapterTests
    {
        [Fact]
        public void Dispose_CalledTwice_DoesNotThrow()
        {
            // Arrange
            var candidate = new LabelAdapter<object>(new Label(), new DefaultTextConverter<object>());

            // Act / Assert
            candidate.Dispose();
            candidate.Dispose();
        }
    }
}
