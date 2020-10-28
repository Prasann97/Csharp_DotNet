using System;

namespace ConsoleApplication5
{
    class avg_params
    {
        public static int math(params int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine("No arguments passed");
                return 0;
            }
            else
            {
                int sum = 0;
                int avg = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum = sum + nums[i];
                }
                avg = sum / nums.Length;
                return avg;
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 9, 7, 2, 3 };
            int[] b = { 4, 6, 1, 2, 9 };
            int[] c = { 64, 98, 3, 2, 6, 4 };
            Console.WriteLine("a="+math(a));
            Console.WriteLine("b="+math(b));
            Console.WriteLine("c="+math(c));
        }
    }
}
