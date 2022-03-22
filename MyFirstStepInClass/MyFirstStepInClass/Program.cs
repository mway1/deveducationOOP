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
            list.AddLast(22);
            int a=list.FindIndexOfMaxElement();
            int b = list.FindIndexOfMinElement();
            list.Write();
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
   }
}
