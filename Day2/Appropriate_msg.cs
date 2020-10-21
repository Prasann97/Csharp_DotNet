using System;


   
namespace Day2_Appropriate_msg
{
 class Program
    {
        public static int sqr(int x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no");
            string x = Console.ReadLine();
            int f;
            bool a1 = int.TryParse(x,out f);
            Console.WriteLine(a1);
            if (a1 == true)
            {
                int result = sqr(f);
                Console.WriteLine("the square of no is :" + result);
                Console.ReadLine();
            }
            else {
                Console.WriteLine("please enter proper input");
                Console.ReadLine();
            }
        }
    }
}