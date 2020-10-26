using System;

namespace ConsoleApplication4
{
    class Arrayfun
    {
        static void cube(int[] a,int size)
        {
            for(int i=0;i<size;i++)
            {
                a[i]=a[i]*a[i]*a[i];
            }
        }
        public static void Main(String[] args)
        {
            int[] arr=new int[5];
            int i;

            for (i = 0; i < 5; i++)
            {
                    Console.WriteLine("Enter data at:"+i);
                    int a = int.Parse(Console.ReadLine());
                    arr[i] = a;
            }
            Arrayfun.cube(arr, arr.Length);
            for (i = 0; i < 5; i++)
            {
                Console.Write(arr[i]+" ");                
            }
            Console.WriteLine();
        }
    }
}
