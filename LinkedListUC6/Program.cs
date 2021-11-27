using System;
using System.Collections.Generic;

namespace LinkedListUC6
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
            int size = l1.Count;
            l1.RemoveAt(size - 1);
            Console.WriteLine("Afetr removing last ele------------");
            foreach (var ele in l1)
            {
                Console.WriteLine(ele);
            }
        }
    }
}