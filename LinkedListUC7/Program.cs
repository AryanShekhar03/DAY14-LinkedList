using System;
using System.Collections.Generic;

namespace LinkedListUC7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int>();
            L1.Add(56);
            L1.Add(30);
            L1.Add(70);
            L1.Add(99);

            Console.WriteLine(L1.Contains(30));

        }
    }
}