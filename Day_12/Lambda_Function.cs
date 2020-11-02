using System;

namespace Anonymus_Method
{
    delegate void mydel(int a);
    static class Program
    {
        public static void sqr(int a)
        {
            Console.WriteLine("Sqr=" + a * a);
        }
        public static void cube(int a)
        {
            Console.WriteLine("Sqr=" + a * a * a);
        }
        public static void fact(int a)
        {
            int ans = 1;
            for (int i = 2; i <= a; i++)
            {
                ans = ans * i;
            }
               Console.WriteLine("Factorial=" + ans);
        }

        static void Main(string[] args)
        {
            mydel md = (a)=>
            {
                sqr(a);
                cube(a);
                fact(a);
            };
            md(5);
        }
    }
}
