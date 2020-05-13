
using Xunit;

namespace Guiuiui.Common.Tests
{
    public class ViewModelTests
    {
        [Fact]
        public void SetModel_AnyObject_ValueChangedEventFiredOnce()
        {
            // Arrange
            var candidate = new ViewModel<object>();
            var eventFired = 0;
            candidate.ValueChanged += (sender, e) => eventFired++;

            // Act
            candidate.Model = new object();

            // Assert
            Assert.Equal(1, eventFired);
        }
    }
}
