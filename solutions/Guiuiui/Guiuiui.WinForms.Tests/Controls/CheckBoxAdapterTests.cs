using Guiuiui.WinForms.Controls;
using System.Windows.Forms;
using Xunit;

namespace Guiuiui.WinForms.Tests.Controls
{
    /// <summary>
    /// Performs tests for the <see cref="CheckBoxAdapter"/> class.
    /// </summary>
    public class CheckBoxAdapterTests
    {
        [Fact]
        public void Dispose_CalledTwice_DoesNotThrow()
        {
            // Arrange
            var candidate = new CheckBoxAdapter(new CheckBox());

            // Act / Assert
            candidate.Dispose();
            candidate.Dispose();
        }
    }
}
