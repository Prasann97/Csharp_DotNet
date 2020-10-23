using System;

namespace ConsoleApplication2
{
    class calculator
    {
	static calculator()
	{
	Console.WriteLine("Welcome to Prasann's coding");
	}
        public static void sqr(int a)
        {
            Console.WriteLine("sqr={0}",a * a);
        }
        public static void cube(int a)
        {
            Console.WriteLine("cube={0}", a * a * a);
        }
        public static void absolute(double a)
        {
            int b = Convert.ToInt32(a);
            Console.WriteLine("absolute={0}", b);
        }
        public static void floor(double a)
        {
            int b = Convert.ToInt32(a);
            Console.WriteLine("floor={0}", b);
        }
        public static void ceil(double a)
        {
            int b = Convert.ToInt32(a);
            Console.WriteLine("ceil={0}", b+1);
        }
    }
    class Printer
    {
        
        static void Main(string[] args)
        {
            calculator.sqr(5);
            calculator.cube(5);
            calculator.absolute(5.88);
            calculator.floor(8.89);
            calculator.ceil(8.89);
        }
    }
}
