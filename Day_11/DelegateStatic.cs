using System;

namespace ConsoleApplication15
{
    delegate void dele(int no);
    static class methods
    {
        public static void sqr(int a)
        {
            Console.WriteLine("sqr=" + a * a);
        }
        public static void cube(int a)
        {
            Console.WriteLine("sqr=" + a * a * a);
        }
        public static void factorial(int a)
        {
            int ans=1;
            for (int i = 2; i <= a; i++)
            {
                ans = ans * i;
            }
            Console.WriteLine("Factorial=" + ans);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            dele d = new dele(methods.sqr);
            d += new dele(methods.cube);
            d += new dele(methods.factorial);
            d(5);
        }
    }
}
