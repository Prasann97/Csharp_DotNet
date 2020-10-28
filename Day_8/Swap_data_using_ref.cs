using System;

namespace ConsoleApplication5
{
    class Swapdemo
    {
        public static void swap(ref int x,ref int y)
        {
            int t;
            t = x;
            x = y;
            y = t;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 9;
            swap(ref a, ref b);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
