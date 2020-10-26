using System;

namespace ConsoleApplication4
{
    class ArrayReverse
    {
        public static void Main(String[] args)
        {
            int[] arr=new int[5];
            int i;
            int sum = 0;
            for (i = 0; i < arr.Length; i++)
            {
                    Console.WriteLine("Enter data at:"+i);
                    int a = int.Parse(Console.ReadLine());
                    arr[i] = a;
            }
            Array.Reverse(arr);
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
