﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList.Tests.ArrayListTestsSources
{
    internal class FindIndexOfMaxElementTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            yield return new object[] { new MyArrayList(new int[] { 8, 17, 24, 57, 2 }), 3 };

            yield return new object[] { new MyArrayList(new int[] { 1, 2, 3 }), 2 };

            yield return new object[] { new MyArrayList(new int[] { 2, 21 }), 1 };

            yield return new object[] { new MyArrayList(new int[] { 1 }), 0 };
        }

    }
}
