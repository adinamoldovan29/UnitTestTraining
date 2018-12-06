using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestTraining.StateTestPattern;

namespace UnitTest.StateTestPattern
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Shrink_10Radius_SmallerRadius()
        {
            // Arange
            var circle = new Circle(10);

            // Act
            circle.Shrink();

            // Assert
            Assert.AreEqual(5, circle.Radius); 
        }
    }
}