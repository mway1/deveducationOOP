using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class SortAscendingBubbleSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), new MyArrayList(new int[] { 2, 8, 17, 24, 57 }) };

            yield return new object[] { new MyArrayList(new int[] { 9, 4, 1 }), new MyArrayList(new int[] { 1, 4, 9 }) };

            yield return new object[] { new MyArrayList(new int[] { 23, 7 }), new MyArrayList(new int[] { 7, 23 }) };

            yield return new object[] { new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { 1 }) };
        }

    }
}
