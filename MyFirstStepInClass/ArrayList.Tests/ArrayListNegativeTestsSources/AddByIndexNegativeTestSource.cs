using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListNegativeTestsSources
{
    internal class AddByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { -1,4, new MyArrayList(new int[] { 8, 17, 24, 8, 2 })};

            yield return new object[] { 4,7, new MyArrayList(new int[] { 9, 4, 1 })};

            yield return new object[] { 1,3, new MyArrayList(new int[] { })};
        }

    }
}
