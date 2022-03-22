using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArrayList.Tests.MyArrayListTestsSources
{
    internal class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 5;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 5 });
            yield return new object[] { value, list, expectedList };

        }

    }
}
