using System;
using NUnit.Framework;
using UnitTestTraining.TestCases;

namespace UnitTest.TestCases
{
    [TestFixture]
    public class StringCleanerTests
    {
        [TestCase("", "")]
        [TestCase("test with space", "testwithspace")]
        [TestCase("testwithoutspace", "testwithoutspace")]
        public void Clean_TextWithSpaces_SpacesRemoved(string text, string expectedResult)
        {
            // Act
            var actualResult = StringCleaner.Clean(text);

            // Assert
            Assert.AreEqual(expectedResult, actualResult); 
        }

       [Test]
        public void Clean_NullText_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => StringCleaner.Clean(null));
            // This was added
            // This was added2
            // This was added3
        }
    }
}