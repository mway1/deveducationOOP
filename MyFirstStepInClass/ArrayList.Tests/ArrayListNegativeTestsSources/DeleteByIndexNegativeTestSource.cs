using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListNegativeTestsSources
{
    internal class DeleteByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { }) };
            yield return new object[] {3, new MyArrayList(new int[] {1,2,3}) };
        }

    }
}
