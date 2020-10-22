using System;
using System.Text;
namespace ConsoleApplication7
{
    struct abc
    {
        public int x;

        public static void cal(int a)
        {
            for(int i=1;i<a/2;i++)
            {
                int b=a%i;
                if (b == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            abc a1=new abc();
            string a= Console.ReadLine();
            a1.x = Convert.ToInt32(a);
            abc.cal(a1.x);
        }
    }
}
