using System;
using NUnit.Framework;
using System.Collections;
using ArrayList.Tests.ArrayListTestsSources;
using ArrayList.Tests.ArrayListNegativeTestsSources;

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

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndex_WhenIndexIsWrong_ShouldThrowNewException(int index, int value, MyArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.AddByIndex(index, value));
        }

        [TestCaseSource(typeof(DeleteFromEndTestSource))]
        public void DeleteFromEndTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromEnd();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromEndNegativeTestSource))]
        public void DeleteFromEnd_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromEnd());
        }

        [TestCaseSource(typeof(DeleteFromBeginningTestSource))]
        public void DeleteFromBeginningTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromBeginning();

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromBeginningNegativeTestSource))]
        public void DeleteFromBeginning_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromBeginning());
        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteByIndex(index);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteByIndexNegativeTestSource))]
        public void DeleteByIndex_WhenLengthLessOne_ShouldThrowNewException(int index, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteFromEndElementsTestSource))]
        public void DeleteFromEndElementsTest(int count, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromEndElements(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromEndElementsNegativeTestSource))]
        public void DeleteFromEndElements_WhenCountLessLength_ShouldThrowNewException(int count, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromEndElements(count));
        }

        [TestCaseSource(typeof(DeleteFromBeginingElementsTestSource))]
        public void DeleteFromBeginingElementsTest(int count, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.DeleteFromBeginingElements(count);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(DeleteFromBeginingElementsNegativeTestSource))]
        public void DeleteFromBeginingElements_WhenCountLessLength_ShouldThrowNewException(int count, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFromBeginingElements(count));
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
        
        [TestCaseSource(typeof(GetValueByIndexNegativeTestSource))]
        public void GetValueByIndex_WhenIndexLessNullAndIndexMoreLength_ShouldThrowNewException(int index, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.GetValueByIndex(index));
        }
        
        [TestCaseSource(typeof(FindFirstIndexByValueTestSource))]
        public void FindFirstIndexByValueTest( MyArrayList list,int value, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindFirstIndexByValueNegativeTestSource))]
        public void FindFirstIndexByValue_WhenLengthEqualZero_ShouldThrowNewException(int value, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindFirstIndexByValue(value));
        }

        [TestCaseSource(typeof(ChangeValueByIndexTestSource))]
        public void ChangeValueByIndexTest(int index, int value, MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.ChangeValueByIndex(index,value);
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ChangeValueByIndexNegativeTestSource))]
        public void ChangeValueByIndex_WhenLengthEqualZeroOrIndexMoreLength_ShouldThrowNewException(int index,int value, MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.ChangeValueByIndex(index,value));
        }

        [TestCaseSource(typeof(ReverseArrayTestSource))]
        public void ReverseArrayTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.ReverseArray();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(ReverseArrayNegativeTestSource))]
        public void ReverseArray_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.ReverseArray());
        }


        [TestCaseSource(typeof(FindMaxElementTestSource))]
        public void FindMaxElementTest(MyArrayList list, int expected)
        {
            int actual = list.FindMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMaxElementNegativeTestSource))]
        public void FindMaxElement_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMaxElement());
        }

        [TestCaseSource(typeof(FindMinElementTestSource))]
        public void FindMinElementTest(MyArrayList list, int expected)
        {
            int actual = list.FindMinElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindMinElementNegativeTestSource))]
        public void FindMinElement_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMinElement());
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementTestSource))]
        public void FindIndexOfMaxElementTest(MyArrayList list, int expected)
        {
            int actual = list.FindIndexOfMaxElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMaxElementNegativeTestSource))]
        public void FindIndexOfMaxElement_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMaxElement());
        }

        [TestCaseSource(typeof(FindIndexOfMinElementTestSource))]
        public void FindIndexOfMinElementTest(MyArrayList list, int expected)
        {
            int actual = list.FindIndexOfMinElement();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(FindIndexOfMinElementNegativeTestSource))]
        public void FindIndexOfMinElement_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexOfMinElement());
        }

        [TestCaseSource(typeof(SortAscendingBubbleSortTestSource))]
        public void SortAscendingBubbleSortTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.SortAscendingBubbleSort();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortAscendingBubbleSortNegativeTestSource))]
        public void SortAscendingBubbleSort_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.SortAscendingBubbleSort());
        }

        [TestCaseSource(typeof(SortDescendingSelectSortTestSource))]
        public void SortDescendingSelectSortTest(MyArrayList list, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.SortDescendingSelectSort();
            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(SortDescendingSelectSortNegativeTestSource))]
        public void SortDescendingSelectSort_WhenLengthLessOne_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.SortDescendingSelectSort());
        }

        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, MyArrayList list, MyArrayList expectedList,int expected)
        {
            int actual = list.DeleteFirstByValue(value);
            MyArrayList actualList = list;
            actualList.DeleteFirstByValue(value);


            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(DeleteFirstByValueNegativeTestSource))]
        public void DeleteFirstByValuet_WhenLengthEqualZero_ShouldThrowNewException(int value,MyArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirstByValue(value));
        }

        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, MyArrayList list, MyArrayList expectedList,int expected)
        {
            int actual = list.DeleteAllByValue(value);
            MyArrayList actualList = list;
            actualList.DeleteAllByValue(value);


            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(AddListToEndTestSource))]
        public void AddListToEndTest(MyArrayList list, MyArrayList list2 ,MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddListToEnd(list2);

            Assert.AreEqual(expectedList, actualList);
        }

        [TestCaseSource(typeof(AddListToEndNegativeTestSource))]
        public void AddListToEnd_WhenLengthEqualZero_ShouldThrowNewException(MyArrayList list)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToEnd(list));
        }

        [TestCaseSource(typeof(AddListToBeginingTestSource))]
        public void AddListToBeginingTest(MyArrayList list, MyArrayList list2, MyArrayList expectedList)
        {
            MyArrayList actualList = list;
            actualList.AddListToBegining(list2);

            Assert.AreEqual(expectedList, actualList);
        }

    }
}