using System;

namespace ConsoleApplication4
{
    class Arrayfun
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
                    sum = sum + arr[i];
            }
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");                
            }
            Console.WriteLine("  ="+(sum/arr.Length));
        }
    }
}
