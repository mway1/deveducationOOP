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
        
        [TestCaseSource(typeof(DeleteByIndexElementsTestSource))]
        public void DeleteByIndexElementsTest(int index, int count, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteByIndexElements(index,count);

            Assert.AreEqual(expectedList, actualList);
        }
        [TestCaseSource(typeof(GetLengthTestSource))]
        public void GetLengthTest( MyArrayList list, int expected)
        {
            int actual = list.GetLength();
            Assert.AreEqual(expected, actual);
        }
        
        [TestCaseSource(typeof(GetValueByIndexTestSource))]
        public void GetValueByIndexTest( MyArrayList list,int index, int expected)
        {
            int actual = list.GetValueByIndex(index);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValueTest( MyArrayList list,int value, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }
        
        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.ChangeValueByIndex(index,value);
            Assert.AreEqual(expectedList, actualList);
        }
        
        [TestCaseSource(typeof(ReverseArrayTestSource))]
        public void ReverseArrayTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.ReverseArray();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(FindMaxElementTestSource))]
        public void FindMaxElementTest(MyArrayList list, int expected)
        {
            int actual = list.FindMaxElement();
            Assert.AreEqual(expected, actual);
        }



    }
}