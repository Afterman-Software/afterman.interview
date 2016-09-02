using Afterman.Interview.Problem2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Afterman.Interview.Tests.Problem2
{
    [TestClass]
    public class DuplicateDetectorTests
    {
        [TestMethod]
        public void HasDupesTest()
        {
            // arrange
            int[] values = new int[] { 12, 55, 99, 42, 6, 7, 99 };

            // act
            bool actual = DuplicateDetector.HasDuplicates(values);

            // assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void NoDupesTest()
        {
            // arrange
            int[] values = new int[] { 12, 55, 99, 42, 6, 7, 5000 };

            // act
            bool actual = DuplicateDetector.HasDuplicates(values);

            // assert
            Assert.AreEqual(false, actual);
        }
    }
}
