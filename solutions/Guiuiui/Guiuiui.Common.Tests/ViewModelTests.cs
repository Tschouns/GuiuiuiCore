
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

        [Fact]
        public void SetModel_Twice_ValueChangedEventFiredTwice()
        {
            // Arrange
            var candidate = new ViewModel<object>();
            var eventFired = 0;
            candidate.ValueChanged += (sender, e) => eventFired++;

            // Act
            candidate.Model = new object();
            candidate.Model = null;

            // Assert
            Assert.Equal(2, eventFired);
        }

        [Fact]
        public void SetModel_TwiceSameModel_ValueChangedEventFiredOnce()
        {
            // Arrange
            var candidate = new ViewModel<object>();
            var eventFired = 0;
            candidate.ValueChanged += (sender, e) => eventFired++;

            var model = new object();

            // Act
            candidate.Model = model;
            candidate.Model = model;

            // Assert
            Assert.Equal(1, eventFired);
        }
    }
}
