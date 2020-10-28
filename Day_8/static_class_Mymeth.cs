using System;

namespace ConsoleApplication5
{
    static class Mymeth
    {
        public static int sqr(int a)
        {
            return a * a;
        }
        public static double sqr(double a)
        {
            return a * a;
        }
    }
    class Authenticate
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(Mymeth.sqr(5));
            Console.WriteLine(Mymeth.sqr(5.5));
        }
    }
}
