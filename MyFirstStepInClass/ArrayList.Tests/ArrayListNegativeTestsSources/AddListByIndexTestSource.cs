using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListNegativeTestsSources
{
    internal class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new MyArrayList(new int[] { 8, 7, 9, 2 }),1, new MyArrayList(new int[] { 3, 7, 9 }), new MyArrayList(new int[] { 8, 3, 7, 9, 7, 9, 2 }) };
            yield return new object[] { new MyArrayList(new int[] { 1, 2 }),0, new MyArrayList(new int[] { 13 }), new MyArrayList(new int[] { 13, 1, 2 }) };
            yield return new object[] { new MyArrayList(new int[] { 1 }),1, new MyArrayList(new int[] { 2, 8, 0 }), new MyArrayList(new int[] { 1, 2, 8, 0 }) };
        }
    }
}
