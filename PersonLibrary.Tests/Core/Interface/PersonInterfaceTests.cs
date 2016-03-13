namespace PersonLibrary.Tests.Core.Interface
{
    using Moq;
    using NUnit.Framework;
    using PersonLibrary.Core.Interface;

    [TestFixture]
    public class PersonInterfaceTests
    {
        [Test]
        public void BasicTest()
        {
            // Arrange
            var person = new Mock<IPerson>().Object;

            // Act

            // Assert
        }
    }
}