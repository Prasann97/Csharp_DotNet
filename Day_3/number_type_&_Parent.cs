using System;
using ClassLibrary4;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
            int a = Convert.ToInt32(s);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.GetType().BaseType);
            Console.WriteLine(a.GetType().BaseType.BaseType);
        }
    }
}
