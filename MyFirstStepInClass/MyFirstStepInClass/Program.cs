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
            list.Write();
            int a = list.DeleteFirstByValue(4);
            list.DeleteFirstByValue(4);
            list.Write();
            Console.WriteLine(a);
        }
   }
}
