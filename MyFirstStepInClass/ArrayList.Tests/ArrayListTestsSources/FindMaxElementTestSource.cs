using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class FindMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), 57 };

            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3 }), 3 };

            yield return new object[] { new MyArrayList(new int[] { 2, 21 }), 21 };

            yield return new object[] { new MyArrayList(new int[] { 1 }), 1 };
        }

    }
}