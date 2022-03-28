using System;
using ArrayList;
namespace MyFirstStepInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            MyArrayList list2 = new MyArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i);
                list2.AddLast(i);
            }

            list.Write();
            list.AddListToEnd(list2);
            list.Write();
        }
   }
}
