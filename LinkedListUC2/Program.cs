using System;
using System.Collections.Generic;

namespace LinkedListUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(70);
            l1.Add(30);
            l1.Add(56);
            foreach (var ele in l1)
            {
                Console.WriteLine(ele);
            }
        }
    }
}