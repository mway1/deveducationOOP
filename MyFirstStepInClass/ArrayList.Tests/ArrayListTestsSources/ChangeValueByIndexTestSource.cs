using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class ChangeValueByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { 2, 6, new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), new MyArrayList(new int[] { 8, 17, 6, 57, 2 }) };

            yield return new object[] { 1, 10, new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 1, 10, 3 }) };

            yield return new object[] { 0, 45, new MyArrayList(new int[] { 2, 21 }), new MyArrayList(new int[] { 45, 21 }) };

            yield return new object[] { 0, 8, new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { 8 }) };
        }

    }
}
