using System;
namespace ConsoleApplication7
{
    struct abc
    {
        public int x;

        public static int sqr(int a)
        {
            return a * a;
        }
        public static int cube(int a)
        {
            return a*a*a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            abc a1=new abc();
            string a= Console.ReadLine();
            a1.x = Convert.ToInt32(a);
            Console.WriteLine("sqr="+abc.sqr(a1.x));
            Console.WriteLine("cube="+abc.cube(a1.x));
        }
    }
}
