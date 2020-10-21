using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_StringConcat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 st name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name:");
            string LastName = Console.ReadLine();
            string name = string.Concat(FirstName,LastName);
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
