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
        [TestCaseSource(typeof(DeleteFromEndTestSource))]
        public void DeleteFromEndTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromEnd();

            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteFromBeginningTestSource))]
        public void DeleteFromBeginningTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromBeginning();

            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteByIndex(index);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromEndElementsTestSource))]
        public void DeleteFromEndElementsTest(int count, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromEndElements(count);

            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(DeleteFromBeginingElementsTestSource))]
        public void DeleteFromBeginingElementsTest(int count, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromBeginingElements(count);

            Assert.AreEqual(expectedList, actualList);
        }



    }
}