using System;

namespace Day1
{
    class Program
    {
        public static short sum(short a,short b)
        {
            return (short)(a+b);
        }
        static void Main(string[] args)
        {
            short a = 5;
            short b = 10;
            short c = (short)(a + b);
            short d=(short) Program.sum(20,30);
            Console.WriteLine("1st addition={0} 2nd addition={1}" , c , d);
        }
    }
}
