using System;
using ClassLibmath;
namespace Day_2_Shared_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result=ClassLibmath.math.sqr(x);
            int result1= ClassLibmath.math.cube(x);
            Console.WriteLine("The square of giving no is:" + result + "The cube of giving ni is:" + result1);
            Console.ReadLine();
        }
    }
}
