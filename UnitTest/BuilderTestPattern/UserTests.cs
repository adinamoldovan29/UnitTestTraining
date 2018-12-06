using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTest.StateTestPattern;
using UnitTestTraining.BuilderTestPattern;

namespace UnitTest.BuilderTestPattern
{
    [TestClass]
    public class UserTests
    {

        [TestMethod]
        public void IsValid_NotValidEmail_False()
        {
            // Arange
            var user = new UserBuilder()
                .WithEmail("notvalid")
                .WithName("Name")
                .Build();

            // Act
            var isValid = user.IsValid();

            // Assert
            Assert.IsFalse(isValid); 
        }

        [TestMethod]
        public void IsValid_NotValidMobileNumber_False()
        {
            // Arange
            var user = new UserBuilder()
                .WithEmail("s@e.com")
                .WithMobileNumber("123")
                .Build();

            // Act
            var isValid = user.IsValid();

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValid_WithoutMobileNumber_False()
        {
            // Arange
            var user = new UserBuilder()
                .WithEmail("s@e.com")
                .Build();

            // Act
            var isValid = user.IsValid();

            // Assert
            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void IsValid_ValidData_True()
        {
            // Arange
            var user = new UserBuilder()
                .WithEmail("s@e.com")
                .WithMobileNumber("1239988989")
                .Build();

            // Act
            var isValid = user.IsValid();

            // Assert
            Assert.IsTrue(isValid);
        }
    }
}