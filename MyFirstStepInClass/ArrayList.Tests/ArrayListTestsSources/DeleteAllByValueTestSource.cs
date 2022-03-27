using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { 8, new MyArrayList(new int[] { 8, 17, 24, 8, 2 }), new MyArrayList(new int[] { 17, 24, 2 }), 2 };

            yield return new object[] { 9, new MyArrayList(new int[] { 9, 4, 1, 9, 9 }), new MyArrayList(new int[] { 4, 1 }), 3 };

            yield return new object[] { 6, new MyArrayList(new int[] { 6, 56 }), new MyArrayList(new int[] { 56 }), 1 };

            yield return new object[] { 1, new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] {  }), 1 };
        }

    }
}
