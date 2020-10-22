using System;
using ClassLibrary4;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetType().BaseType);
        }
    }
}
