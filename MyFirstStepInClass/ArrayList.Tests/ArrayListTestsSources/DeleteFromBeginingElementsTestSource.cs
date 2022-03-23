using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class DeleteFromBeginingElementsTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { 4, new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), new MyArrayList(new int[] { 2 }) };

            yield return new object[] { 1, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 2, 3 }) };

            yield return new object[] { 1, new MyArrayList(new int[] { 2, 21 }), new MyArrayList(new int[] { 21 }) };

            yield return new object[] { 1, new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { }) };
        }

    }
}
