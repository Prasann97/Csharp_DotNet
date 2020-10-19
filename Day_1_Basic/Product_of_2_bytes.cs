using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static byte product(byte a, byte b)
        {
            return (byte)(a * b);
        }
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 6;
            byte c = (byte)(a * b);
            byte d = (byte)Program.product(9, 10);
            Console.WriteLine("1st product={0} 2nd product={1}", c, d);
        }
    }
}
