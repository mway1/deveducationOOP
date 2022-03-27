using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class ReverseArrayTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] {new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), new MyArrayList(new int[] { 2, 57, 24, 17, 8 }) };

            yield return new object[] {new MyArrayList(new int[] { 1, 2, 3 }), new MyArrayList(new int[] { 3, 2, 1 }) };

            yield return new object[] {new MyArrayList(new int[] { 2, 21 }), new MyArrayList(new int[] { 21, 2 }) };

            yield return new object[] {new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { 1 }) };
        }

    }
}