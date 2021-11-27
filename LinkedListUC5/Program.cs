using System;
using System.Collections.Generic;

namespace LinkedListUC5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(56);
            l1.Add(30);
            l1.Add(70);
            foreach (var ele in l1)
            {
                Console.WriteLine(ele);
            }
            l1.RemoveAt(0);
            Console.WriteLine("Afetr removing first ele------------");
            foreach (var ele in l1)
            {
                Console.WriteLine(ele);
            }
        }
    }
}