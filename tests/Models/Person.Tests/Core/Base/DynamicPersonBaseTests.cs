namespace Person.Tests.Core.Base
{
    using System;
    using System.Collections.Generic;
    using Moq;
    using NUnit.Framework;
    using Person.Core.Base;
    using Person.ExceptionHandling.Concrete;
    using Person.Property.Core.Contracts;

    [TestFixture]
    public class DynamicPersonBaseTests
    {
        [Test]
        public void InitializedWithDefaultConstructor_PropertiesShouldNotBeNull()
        {
            // Arrange
            var classMock = new Mock<DynamicPersonBase>();

            // Act Assert
            Assert.NotNull(classMock.Object.Properties);
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
            var classMock = new Mock<DynamicPersonBase>();
            var propertyMock = new Mock<IProperty>();
            var mockPropertyType = propertyMock.Object.GetType();

            // Act
            classMock.Object.AddProperty(propertyMock.Object, false);

            // Assert
            Assert.AreSame(
                propertyMock.Object,
                classMock.Object.Properties[mockPropertyType]);
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
            var classMock = new Mock<DynamicPersonBase>();
            var propertyMock = new Mock<IProperty>();
            classMock.Object.AddProperty(propertyMock.Object, false);

            // Act Assert
            Assert.That(() =>
                classMock.Object.AddProperty(propertyMock.Object, false),
                Throws.Exception.TypeOf<InvalidPropertyOverwriteException>());
        }
    }
}