using System;
using ClassLibmath;

namespace Day2__private_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Enter a no :");
            x = Convert.ToInt32(Console.ReadLine());
            int result1=ClassLibmath.math.sqr(x);
            int result2 = ClassLibmath.math.cube(x);
            Console.WriteLine("Squqre is:"+result1+"Cube is :"+result2);
            Console.ReadLine();
        }
    }
}
