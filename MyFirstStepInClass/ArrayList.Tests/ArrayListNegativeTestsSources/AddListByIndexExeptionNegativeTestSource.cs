using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListNegativeTestsSources
{
    internal class AddListByIndexExeptionNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new MyArrayList(new int[] { }) };
            yield return new object[] { -1, new MyArrayList(new int[] {1,2,3 }) };
        }
    }
}
