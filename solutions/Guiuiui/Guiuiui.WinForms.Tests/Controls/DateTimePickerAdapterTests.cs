using Guiuiui.WinForms.Controls;
using System.Windows.Forms;
using Xunit;

namespace Guiuiui.WinForms.Tests.Controls
{
    /// <summary>
    /// Performs tests for the <see cref="DateTimePickerAdapter"/> class.
    /// </summary>
    public class DateTimePickerAdapterTests
    {
        [Fact]
        public void Dispose_CalledTwice_DoesNotThrow()
        {
            // Arrange
            var candidate = new DateTimePickerAdapter(new DateTimePicker());

            // Act / Assert
            candidate.Dispose();
            candidate.Dispose();
        }
    }
}
