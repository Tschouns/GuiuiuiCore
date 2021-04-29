using Guiuiui.Common.Reflection;
using Guiuiui.Common.TestTypes.Reflection;
using System;
using System.Collections.Generic;
using Xunit;

namespace Guiuiui.Common.Tests.Reflection
{
    public class TypeHelperTests
    {
        [Fact]
        public void GetInheritedTypes_Bird_ReturnsAllInheritedTypesInExpectedOrder()
        {
            // Arrange
            var candidate = new TypeHelper();
            var type = typeof(Bird);
            var expectedInheritedTypes = new List<Type>
            {
                typeof(Bird),
                typeof(IWalk),
                typeof(IFly),
                typeof(object),
            };

            // Act
            var inheritedTypes = candidate.GetInheritedTypes(type);

            // Assert
            Assert.Equal(expectedInheritedTypes.Count, inheritedTypes.Count);
            for (var i = 0; i < expectedInheritedTypes.Count; i++)
            {
                Assert.Equal(expectedInheritedTypes[i], inheritedTypes[i]);
            }
        }

        [Fact]
        public void GetInheritedTypes_Nightingale_ReturnsAllInheritedTypesInExpectedOrder()
        {
            // Arrange
            var candidate = new TypeHelper();
            var type = typeof(Nightingale);
            var expectedInheritedTypes = new List<Type>
            {
                typeof(Nightingale),
                typeof(SingBird),
                typeof(Bird),
                typeof(IWalk),
                typeof(IFly),
                typeof(ISing),
                typeof(object),
            };

            // Act
            var inheritedTypes = candidate.GetInheritedTypes(type);

            // Assert
            Assert.Equal(expectedInheritedTypes.Count, inheritedTypes.Count);
            for (var i = 0; i < expectedInheritedTypes.Count; i++)
            {
                Assert.Equal(expectedInheritedTypes[i], inheritedTypes[i]);
            }
        }
    }
}
