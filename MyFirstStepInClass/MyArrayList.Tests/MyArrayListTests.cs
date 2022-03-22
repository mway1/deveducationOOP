using NUnit.Framework;
using System.Collections;
using MyArrayList.Tests.MyArrayListTestsSources;

namespace MyArrayList.Tests
{
    public class MyArrayListTests
    {
        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddLast(value);

            Assert.AreEqual(expectedList, actualList);
        }
    }
}
