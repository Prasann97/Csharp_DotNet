using System;

namespace ConsoleApplication1
{
    class Program
    {
        public static float square(float a)
        {
            return (float)(a * a);
        }
        static void Main(string[] args)
        {
            float a = 5;
            float b = (float)(a * a);
            float c = (float)Program.square(6);
            Console.WriteLine("1st square={0} 2nd square={1}", b, c);
        }
    }
}
