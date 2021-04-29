
using Guiuiui.Common.TestTypes.Controls;
using Guiuiui.Common.TestTypes.Models;
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

        [Fact]
        public void BindPropertyReadOnly_WithoutModel_ControlIsInitialized()
        {
            // Arrange
            var candidate = new ViewModel<Person>();
            var displayedValue = "rubbish";
            var mockControl = new MockDataControlAdapter<string>(value => displayedValue = value);

            // Act
            candidate.BindPropertyReadOnly(p => p.FirstName).ToControl(mockControl);

            // Assert
            Assert.Equal(default, displayedValue);
            Assert.Equal(default, mockControl.Value);
        }

        [Fact]
        public void BindPropertyReadOnly_WithModel_ModelPropertyIsDisplayedRightAway()
        {
            // Arrange
            var candidate = new ViewModel<Person>();
            var displayedValue = "rubbish";
            var mockControl = new MockDataControlAdapter<string>(value => displayedValue = value);

            var model = new Person
            {
                FirstName = "Foo"
            };
            candidate.Model = model;

            // Act
            candidate.BindPropertyReadOnly(p => p.FirstName).ToControl(mockControl);

            // Assert
            Assert.Equal(model.FirstName, displayedValue);
            Assert.Equal(model.FirstName, mockControl.Value);
        }

        [Fact]
        public void BindPropertyReadOnly_SetModelAfterwards_ModelPropertyIsDisplayed()
        {
            // Arrange
            var candidate = new ViewModel<Person>();
            var displayedValue = string.Empty;
            var mockControl = new MockDataControlAdapter<string>(value => displayedValue = value);
            var model = new Person
            {
                FirstName = "Foo"
            };

            // Act
            candidate.BindPropertyReadOnly(p => p.FirstName).ToControl(mockControl);
            candidate.Model = model;

            // Assert
            Assert.Equal(model.FirstName, displayedValue);
            Assert.Equal(model.FirstName, mockControl.Value);
        }

        [Fact]
        public void NotifyValueHasChanged_AfterPropertyValueChanged_ModelPropertyIsDisplayed()
        {
            // Arrange
            var candidate = new ViewModel<Person>();
            var displayedValue = string.Empty;
            var mockControl = new MockDataControlAdapter<string>(value => displayedValue = value);

            candidate.BindPropertyReadOnly(p => p.FirstName).ToControl(mockControl);
            
            var model = new Person
            {
                FirstName = "Foo"
            };
            candidate.Model = model;

            // Act
            model.FirstName = "Bar";
            candidate.NotifyValueHasChanged();

            // Assert
            Assert.Equal(model.FirstName, displayedValue);
            Assert.Equal(model.FirstName, mockControl.Value);
        }
    }
}
