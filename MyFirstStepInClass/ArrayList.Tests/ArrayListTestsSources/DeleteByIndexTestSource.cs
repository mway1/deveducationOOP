using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] {2, new MyArrayList(new int[] { 8, 17,24, 57,2 }), new MyArrayList(new int[] { 8, 17, 57, 2 }) };

            yield return new object[] {1, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 3 }) };

            yield return new object[] {1, new MyArrayList(new int[] { 2, 21 }), new MyArrayList(new int[] { 2 }) };

            yield return new object[] {0, new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { }) };
        }

    }
}
