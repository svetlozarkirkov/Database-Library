namespace Person.Tests.Core.Base
{
    using System;
    using System.Collections.Generic;
    using Moq;
    using NUnit.Framework;
    using Person.Core.Base;
    using Person.ExceptionHandling.Concrete;
    using Person.Property.Core.Interface;

    [TestFixture]
    public class DynamicPersonBaseTests
    {
        private Mock<DynamicPersonBase> _dynamicPersonBaseMock;
        private Mock<IProperty> _propertyMock;

        [Test]
        public void InitializedWithDefaultConstructor_PropertiesShouldNotBeNull()
        {
            // Act
            this._dynamicPersonBaseMock = new Mock<DynamicPersonBase>() {CallBase = true};

            // Assert
            Assert.NotNull(this._dynamicPersonBaseMock.Object.Properties);
        }

        /// <exception cref="ArgumentNullException"><paramref name="key" /> is null.</exception>
        /// <exception cref="KeyNotFoundException">The property is retrieved and <paramref name="key" /> is not found.</exception>
        /// <exception cref="NotSupportedException">The property is set and the <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        /// <exception cref="PropertyIsNullException">Property is null.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</exception>
        /// <exception cref="InvalidPropertyOverwriteException">Cannot overwrite existing property.</exception>
        [Test]
        public void AddProperty_ValidProperty_ShouldAddTheProperty()
        {
            // Arrange
            this._dynamicPersonBaseMock = new Mock<DynamicPersonBase>() {CallBase = true};
            this._propertyMock = new Mock<IProperty>();
            var mockPropertyType = this._propertyMock.Object.GetType();

            // Act
            this._dynamicPersonBaseMock.Object.AddProperty(this._propertyMock.Object);

            // Assert
            Assert.AreSame(
                this._propertyMock.Object,
                this._dynamicPersonBaseMock.Object.Properties[mockPropertyType]);
        }

        /// <exception cref="PropertyIsNullException">Property is null.</exception>
        /// <exception cref="ArgumentException">An element with the same key already exists in the <see cref="T:System.Collections.Generic.IDictionary`2" />.</exception>
        /// <exception cref="NotSupportedException">The <see cref="T:System.Collections.Generic.IDictionary`2" /> is read-only.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="property" /> is null.</exception>
        /// <exception cref="InvalidPropertyOverwriteException">Cannot overwrite existing property.</exception>
        [Test]
        public void AddProperty_ValidProperty_SamePropertyExists_OverwriteIfExistsFALSE_ShouldThrowException()
        {
            // Arrange
            this._dynamicPersonBaseMock = new Mock<DynamicPersonBase>() {CallBase = true};
            this._propertyMock = new Mock<IProperty>();
            this._dynamicPersonBaseMock.Object.AddProperty(this._propertyMock.Object, false);

            // Act

            // Assert
            Assert.That(() =>
                this._dynamicPersonBaseMock.Object.AddProperty(this._propertyMock.Object, false),
                Throws.Exception.TypeOf<InvalidPropertyOverwriteException>());
        }
    }
}