using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<String> hset = new HashSet<String>();
            hset.Add("vita");
            hset.Add("shweta");
            hset.Add("vidya");
            hset.Add("sonu");
            hset.Add("vrushali");

            var v = hset.Select(m => m).Where(m =>m.StartsWith("v"));

            foreach (var s in v)
            {
                Console.WriteLine(s);
            }
        }
    }
}
