using System;

namespace ConsoleApplication5
{
    class Autodemo
    {
        public int[] sqrarray(int[] arr,out int sum)
        {
            int j=0;
            int[] arr1=new int[arr.Length];
            for(int i=0;i<arr.Length;i++)
            {
                j=j+arr[i];
                arr1[i]=arr[i]*arr[i];
            }
            sum=j;
            return arr1;
        }
        static void Main(string[] args)
        {
            Autodemo a=new Autodemo();
            int sum;
            int[] arr=new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int16.Parse(Console.ReadLine());
            }
            int[] temp=a.sqrarray(arr,out sum);
            for (int i = 0; i < temp.Length; i++)
            {
                Console.Write(temp[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("sum=" + sum);
        }
    }
}
