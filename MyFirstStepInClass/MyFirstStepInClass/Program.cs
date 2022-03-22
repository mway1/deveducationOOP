using System;
using ArrayList;
namespace MyFirstStepInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            for (int i = 4; i < 10; i++)
            {
                list.AddLast(i);
            }
            list.AddLast(7);
            int a=list.FindMaxElement();
            int b = list.FindMinElement();
            list.Write();
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
   }
}
