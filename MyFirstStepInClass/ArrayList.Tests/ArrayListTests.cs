using NUnit.Framework;
using System.Collections;
using ArrayList.Tests.ArrayListTestsSources;

namespace ArrayList.Tests
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