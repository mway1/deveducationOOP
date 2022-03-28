using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListNegativeTestsSources
{
    internal class GetValueByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -2, new MyArrayList(new int[] {1}) };
            yield return new object[] { 4, new MyArrayList(new int[] { 1, 2, 3 }) };
        }

    }
}
