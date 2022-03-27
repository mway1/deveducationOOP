using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class FindFirstIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new MyArrayList(new int[] { 8, 17, 24, 57, 24, 24 }), 24, 2 };

            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3, 4, 1 }), 1, 0 };

            yield return new object[] { new MyArrayList(new int[] { 1 }), 1, 0 };
        }

    }
}
