using System;

namespace ConsoleApplication4
{
    class Matrix_3x3
    {
        public static void Main(String[] args)
        {
            int[,] arr=new int[3,3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter data at:"+i+j);
                    int a = int.Parse(Console.ReadLine());
                    arr[i,j] = a;
                }
            }
            for (i = 0; i < 3; i++)
            {
                int sum = 0;
                for (j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]+" ");
                    sum = sum + arr[i, j];
                }
                Console.WriteLine("  =" + sum);
            }
        }
    }
}
