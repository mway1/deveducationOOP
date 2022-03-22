using System;
using ArrayList;
namespace MyFirstStepInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            for (int i = 0; i < 2; i++)
            {
                list.AddLast(i);
            }
            list.Write();
            list.DeleteByIndex(2);
            list.Write();
        }
   }
}
