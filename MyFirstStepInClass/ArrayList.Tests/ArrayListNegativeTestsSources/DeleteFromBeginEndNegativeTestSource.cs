using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListNegativeTestsSources
{
    internal class DeleteFromBeginEndNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {new MyArrayList(new int[] { }) };
        }

    }
}
