using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Checked
{
    class Program
    {
        static void Main(string[] args)
        {
           
            checked
            {
                Console.WriteLine("please enter a data");
                string x = Console.ReadLine();
                byte b1 = byte.Parse(x);
                Console.WriteLine(b1);
                Console.ReadLine();
            }

        }
    }
}
