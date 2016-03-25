namespace PersonLibrary.Tests.Core.Base
{
    using Moq;
    using NUnit.Framework;
    using PersonLibrary.Core.Base;
    using PersonLibrary.ExceptionHandling.Concrete;
    using PersonLibrary.Property.Core.Interface;

    [TestFixture]
    public class DynamicPersonBaseTests
    {
        private Mock<DynamicPersonBase> _dynamicPersonBaseMock;
        private Mock<IProperty> _propertyMock;

        [OneTimeSetUp]
        public void BasicSetup()
        {
            this._dynamicPersonBaseMock = new Mock<DynamicPersonBase>() {CallBase = true};
            this._propertyMock = new Mock<IProperty>();
        }

        [Test]
        public void AddProperty_ValidProperty_ShouldAddTheProperty()
        {
            // Arrange
            var mockPropertyType = this._propertyMock.Object.GetType();

            // Act
            this._dynamicPersonBaseMock.Object.AddProperty(this._propertyMock.Object);

            // Assert
            Assert.AreSame(
                this._propertyMock.Object,
                this._dynamicPersonBaseMock.Object.Properties[mockPropertyType]);
        }

        [Test]
        public void AddProperty_ValidProperty_SamePropertyExists_OverwriteIfExistsFALSE_ShouldThrowException()
        {
            // Arrange
            this._dynamicPersonBaseMock.Object.AddProperty(this._propertyMock.Object, false);

            // Act

            // Assert
            Assert.That(() =>
                this._dynamicPersonBaseMock.Object.AddProperty(this._propertyMock.Object, false),
                Throws.Exception.TypeOf<InvalidPropertyOverwriteException>());
        }
    }
}