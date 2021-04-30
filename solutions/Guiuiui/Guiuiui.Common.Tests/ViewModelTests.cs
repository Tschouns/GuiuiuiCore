
using Guiuiui.Common.TestTypes.Controls;
using Guiuiui.Common.TestTypes.Models;
using Xunit;

namespace Guiuiui.Common.Tests
{
    /// <summary>
    /// Performs tests for the <see cref="ViewModel{TModel}"/> class.
    /// </summary>
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
            candidate.BindPropertyReadOnly(p => p.Name).ToControl(mockControl);

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
                Name = "Foo"
            };
            candidate.Model = model;

            // Act
            candidate.BindPropertyReadOnly(p => p.Name).ToControl(mockControl);

            // Assert
            Assert.Equal(model.Name, displayedValue);
            Assert.Equal(model.Name, mockControl.Value);
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
                Name = "Foo"
            };

            // Act
            candidate.BindPropertyReadOnly(p => p.Name).ToControl(mockControl);
            candidate.Model = model;

            // Assert
            Assert.Equal(model.Name, displayedValue);
            Assert.Equal(model.Name, mockControl.Value);
        }

        [Fact]
        public void NotifyValueHasChanged_AfterPropertyValueChanged_ModelPropertyIsDisplayed()
        {
            // Arrange
            var candidate = new ViewModel<Person>();
            var displayedValue = string.Empty;
            var mockControl = new MockDataControlAdapter<string>(value => displayedValue = value);

            candidate.BindPropertyReadOnly(p => p.Name).ToControl(mockControl);
            
            var model = new Person
            {
                Name = "Foo"
            };
            candidate.Model = model;

            // Act
            model.Name = "Bar";
            candidate.NotifyValueHasChanged();

            // Assert
            Assert.Equal(model.Name, displayedValue);
            Assert.Equal(model.Name, mockControl.Value);
        }

        [Fact]
        public void UnbindAll_AfterPropertyBound_ChangesAreNoLongerAppliedToControl()
        {
            // Arrange
            var candidate = new ViewModel<Person>();
            var displayedValue = string.Empty;
            var mockControl = new MockDataControlAdapter<string>(value => displayedValue = value);

            candidate.BindPropertyReadOnly(p => p.Name).ToControl(mockControl);

            var model = new Person
            {
                Name = "Foo"
            };
            candidate.Model = model;

            // Act
            candidate.UnbindAll();

            // Assert
            model.Name = "Bar";
            candidate.NotifyValueHasChanged();

            Assert.NotEqual(model.Name, displayedValue);
            Assert.NotEqual(model.Name, mockControl.Value);
        }


        [Fact]
        public void UnbindAll_TwiceAfterPropertyBound_DoesNotThrow()
        {
            // Arrange
            var candidate = new ViewModel<Person>();
            var mockControl = new MockDataControlAdapter<string>(value => { });

            candidate.BindPropertyReadOnly(p => p.Name).ToControl(mockControl);

            candidate.Model = new Person
            {
                Name = "Foo"
            };

            // Act / Assert
            candidate.UnbindAll();
            candidate.UnbindAll();
        }
    }
}
