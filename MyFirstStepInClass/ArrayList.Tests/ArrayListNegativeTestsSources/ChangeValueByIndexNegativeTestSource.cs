using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListNegativeTestsSources
{
    internal class ChangeValueByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1,7, new MyArrayList(new int[] { }) };
            yield return new object[] { 5,24, new MyArrayList(new int[] { 9,1,3,7}) };
        }

    }
}
