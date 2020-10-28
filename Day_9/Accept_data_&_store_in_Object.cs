using System;

namespace ConsoleApplication9
{
    class Program
    {
        int a;
        Program(int a)
        {
            this.a = a;
        }
        public override string ToString()
        {
            return Convert.ToString(a);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a data to store in object:");
            int a = int.Parse(Console.ReadLine());
            Program p=new Program(a);
            Console.WriteLine(p.ToString());
        }
    }
}
