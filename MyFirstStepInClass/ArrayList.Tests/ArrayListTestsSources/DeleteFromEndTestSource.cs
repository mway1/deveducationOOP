using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class DeleteFromEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] {new MyArrayList(new int[] { 7, 7, 8, 8 }), new MyArrayList(new int[] { 7, 7, 8}) };

        }

    }
}