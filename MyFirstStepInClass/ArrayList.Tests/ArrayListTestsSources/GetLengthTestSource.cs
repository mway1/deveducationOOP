using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class GetLengthTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] {new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), 5 };
            
            yield return new object[] {new MyArrayList(new int[] { 1,2 }), 2 };
            
            yield return new object[] {new MyArrayList(new int[] { 1 }), 1 };
            
            yield return new object[] {new MyArrayList(new int[] {  }), 0 };

        }

    }
}