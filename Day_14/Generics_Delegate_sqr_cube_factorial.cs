using System;
using System.Collections.Generic;

namespace ConsoleApplication21
{
    delegate void mydel<T>(int t);
    class Program
    {
        public static void sqr<T>(int t)
        {
            Console.WriteLine("sqr={0}", t * t);
        }
        public static void cube<T>(int t)
        {
            Console.WriteLine("cube={0}", t * t * t);
        }
        public static void fact<T>(int t)
        {
            int ans = 1;
            for (int i = 2; i <= t; i++)
                ans = ans * t;
            Console.WriteLine("fact={0}", ans);
        }
        static void Main(string[] args)
        {
            mydel<int> md = new mydel<int>(sqr<int>);
            md += new mydel<int>(cube<int>);
            md += new mydel<int>(fact<int>);

            md(5);

        }
    }
}
