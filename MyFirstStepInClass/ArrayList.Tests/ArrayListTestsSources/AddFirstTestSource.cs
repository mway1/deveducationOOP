using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new MyArrayList(new int[] { 1,2,3,4 }), new MyArrayList(new int[] { 1, 1, 2, 3, 4 }) };

            yield return new object[] { 2, new MyArrayList(new int[] { 3, }), new MyArrayList(new int[] { 2, 3 }) };

            yield return new object[] { 10, new MyArrayList(new int[] { }), new MyArrayList(new int[] { 10 }) };

        }

    }
}