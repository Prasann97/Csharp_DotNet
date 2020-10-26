using System;

namespace ConsoleApplication4
{
    class ArrayCopy
    {
        public static void Main(String[] args)
        {
            int[] arr=new int[5];
            int[] arr1 = new int[5];
            int i;
            int sum = 0;
            for (i = 0; i < arr.Length; i++)
            {
                    Console.WriteLine("Enter data at:"+i);
                    int a = int.Parse(Console.ReadLine());
                    arr[i] = a;
            }
            Array.Copy(arr, arr1, arr.Length);
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
