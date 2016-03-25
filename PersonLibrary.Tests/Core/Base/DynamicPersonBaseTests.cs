namespace PersonLibrary.Tests.Core.Base
{
    using Moq;
    using NUnit.Framework;
    using PersonLibrary.Core.Base;
    using PersonLibrary.Property.Core.Interface;

    [TestFixture]
    public class DynamicPersonBaseTests
    {
        [Test]
        public void AddProperty_ValidProperty_ShouldAddTheProperty()
        {
            // Arrange
            var mockDynamicPersonObject = new Mock<DynamicPersonBase>{CallBase = true}.Object;
            var mockPropertyObject = new Mock<IProperty>().Object;
            var mockPropertyType = mockPropertyObject.GetType();

            // Act
            mockDynamicPersonObject.AddProperty(mockPropertyObject);

            // Assert
            Assert.AreSame(
                mockPropertyObject,
                mockDynamicPersonObject.Properties[mockPropertyType]);
        }
    }
}