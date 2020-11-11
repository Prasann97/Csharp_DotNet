using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hset = new HashSet<int>();
            hset.Add(5);
            hset.Add(8);
            hset.Add(4);
            hset.Add(5);
            hset.Add(4);

            var v = hset.Select(m => m).Where(m => m % 2 == 0);

            foreach (var s in v)
            {
                Console.WriteLine(s);
            }
        }
    }
}
