using System;
using ArrayList;
namespace MyFirstStepInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.AddLast(i);
            }
            list.DeleteByIndex(3);
            list.Write();
        }
   }
}
