using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            MyArrayList list = new MyArrayList(new int[] { 1, 2, 3 });
            MyArrayList expectedList = new MyArrayList(new int[] { 1, 2, 3, 3 });
            yield return new object[] { value, list, expectedList };

            yield return new object[] {2, new MyArrayList(new int[] { 3, }), new MyArrayList(new int[] { 3, 2}) };
            
            yield return new object[] {10, new MyArrayList(new int[] { }), new MyArrayList(new int[] {10 }) };

        }



    }
}
