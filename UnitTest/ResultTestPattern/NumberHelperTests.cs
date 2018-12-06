using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UnitTestTraining.ResultTestPattern;

namespace UnitTests.ResultTestPattern
{
    [TestClass]
    public class NumberHelperTests
    {
        [TestMethod]
        public void IsEven_OddNumber_False()
        {
            // Act
            var result = NumberHelper.IsEven(5);

            // Assert
            Assert.IsFalse(result);
        }

    }
}
