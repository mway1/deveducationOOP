using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, 3, new MyArrayList(new int[] { 1, 2, 3, 4 }), new MyArrayList(new int[] { 1, 3, 2, 3, 4 }) };

            yield return new object[] { 0,5, new MyArrayList(new int[] { 3, }), new MyArrayList(new int[] { 5, 3 }) };

            yield return new object[] { 0,10, new MyArrayList(new int[] { }), new MyArrayList(new int[] { 10 }) };

        }

    }
}
