using System;

namespace ConsoleApplication4
{
    class Matrix_3x3
    {
        public static void Main(String[] args)
        {
            int[] arr=new int[5];
            int[] arr1 = new int[5];
            int i,sum=0;

            for (i = 0; i < 5; i++)
            {
                    Console.WriteLine("Enter data at:"+i);
                    int a = int.Parse(Console.ReadLine());
                    arr[i] = a;
                    arr1[i] = a * a;
                    sum = sum + arr[i];
            }
            Console.WriteLine("sum=" + sum);
            for (i = 0; i < 5; i++)
            {
                Console.Write(arr1[i]+" ");                
            }
            Console.WriteLine();
        }
    }
}
