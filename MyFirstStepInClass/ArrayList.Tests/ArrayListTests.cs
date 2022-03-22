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

        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddFirst(value);

            Assert.AreEqual(expectedList, actualList);
        } 
        
        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int index, int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddByIndex(index,value);

            Assert.AreEqual(expectedList, actualList);
        }



    }
}