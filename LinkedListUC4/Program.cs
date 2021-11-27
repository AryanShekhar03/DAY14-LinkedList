using System;
using System.Collections.Generic;

namespace LinkedListUC4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(56);
            l1.Add(70);
            foreach (var ele in l1)
            {
                Console.WriteLine(ele);
            }
            l1.Insert(1, 30);
            Console.WriteLine("After inserting 30 between 56 and 70-------------------------");
            foreach (var ele in l1)
            {
                Console.WriteLine(ele);
            }



        }
    }
}