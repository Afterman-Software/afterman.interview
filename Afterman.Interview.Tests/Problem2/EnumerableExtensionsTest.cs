using System;
using System.Collections.Generic;
using Afterman.Interview.Problem2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Afterman.Interview.Tests.Problem2
{
    [TestClass]
    public class EnumerableExtensionsTest
    {
        [TestMethod]
        public void TestIsUniqueTrue()
        {
            int i = 0;
            List<int> integerList = new List<int>();
            while ( i < 10000 )
            {
                integerList.Add( i++ );
            }

            Assert.IsTrue( integerList.GetIsUnique() );
        }

        [TestMethod]
        public void TestIsUniqueFalse()
        {
            int i = 0;
            List<int> integerList = new List<int>();
            while ( i < 10000 )
            {
                integerList.Add( i++ );
            }

            integerList.Add( 42 );

            Assert.IsFalse( integerList.GetIsUnique() );
        }
    }
}
