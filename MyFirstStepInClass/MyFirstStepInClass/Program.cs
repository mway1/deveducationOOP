﻿using System;
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
            list.AddFirst(2);
            list.AddLast(2);
            list.AddLast(0);
            list.Write();
            int a=list.DeleteAllByValue(2);
            list.Write();
            Console.WriteLine(a);
        }
   }
}
