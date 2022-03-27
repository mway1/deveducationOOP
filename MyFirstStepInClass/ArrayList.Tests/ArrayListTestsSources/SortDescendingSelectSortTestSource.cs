using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class SortDescendingSelectSortTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), new MyArrayList(new int[] { 57,24,17,8,2 }) };

            yield return new object[] { new MyArrayList(new int[] { 9, 4, 1 }), new MyArrayList(new int[] { 9,4,1 }) };

            yield return new object[] { new MyArrayList(new int[] { 6, 56 }), new MyArrayList(new int[] { 56, 6 }) };

            yield return new object[] { new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { 1 }) };
        }

    }
}
