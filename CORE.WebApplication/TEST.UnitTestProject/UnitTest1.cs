using System;
using NUnit.Framework;

namespace TEST.UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [OneTimeSetUp]
        public void Setup()
        {

        }

        [OneTimeTearDown]
        public void TearDown()
        {

        }

        [Test]
        public void TestMethod1()
        {
            //Arrange
            //Act
            var customer = new Customer("Richard", "Wysocki");
            //Assert
            Assert.That(customer.Name() == "","Customer Name should equal the Combined Name of the Customer.");
        }
    }
}
