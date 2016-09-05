using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Afterman.Interview.Problem2;

namespace Afterman.Interview.Tests.Problem2
{
    [TestClass]
    public class DuplicateFinderTests
    {
        [TestMethod]
        public void PositiveValuesCheck()
        {
            DuplicateFinder dfind = new DuplicateFinder();
            for (int i = 2147483647; i > 2147483600; i--)
            {
                Assert.IsFalse(dfind.CheckElement(i));
            }
            Assert.IsFalse(dfind.HasDuplicates);

            Assert.IsTrue(dfind.CheckElement(2147483647));
            Assert.IsTrue(dfind.HasDuplicates);

        }

        [TestMethod]
        public void NegativeValuesCheck()
        {
            DuplicateFinder dfind = new DuplicateFinder();

            // add unique negative values in sequence
            for (int i = -2147483620; i < -2147483600; i++)
            {
                Assert.IsFalse(dfind.CheckElement(i));
            }
            Assert.IsFalse(dfind.HasDuplicates);

            // check that using the same positive values does not trigger duplicate
            for (int i = 2147483600; i < 2147483620; i++)
            {
                Assert.IsFalse(dfind.CheckElement(i));
            }
            Assert.IsFalse(dfind.HasDuplicates);

            // verify that adding a duplicate negative value triggers duplicate
            Assert.IsTrue(dfind.CheckElement(-2147483620));
            Assert.IsTrue(dfind.HasDuplicates);

        }

        [TestMethod]
        public void LocZeroValuesCheck()
        {
            DuplicateFinder dfind = new DuplicateFinder();

            // add unique negative values in sequence
            for (int i = -3; i <= 3; i++)
            {
                Assert.IsFalse(dfind.CheckElement(i));
            }
            Assert.IsFalse(dfind.HasDuplicates);

            // verify that adding a duplicate negative value triggers duplicate
            Assert.IsTrue(dfind.CheckElement(-1));
            Assert.IsTrue(dfind.HasDuplicates);

            // verify that the element zero also exists
            Assert.IsTrue(dfind.CheckElement(0));

            // and verify that the element positive one exists
            Assert.IsTrue(dfind.CheckElement(1));

        }
    }
}
