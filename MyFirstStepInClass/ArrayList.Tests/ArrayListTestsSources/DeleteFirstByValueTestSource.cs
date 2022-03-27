using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class DeleteFirstByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] {24, new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), new MyArrayList(new int[] { 8, 17, 57, 2 }),2 };

            yield return new object[] {1, new MyArrayList(new int[] { 9, 4, 1 }), new MyArrayList(new int[] { 9, 4 }),2 };

            yield return new object[] {6, new MyArrayList(new int[] { 6, 56 }), new MyArrayList(new int[] { 56 }),0 };

            yield return new object[] {4, new MyArrayList(new int[] { 1 }), new MyArrayList(new int[] { 1 }),-1 };
        }

    }
}
