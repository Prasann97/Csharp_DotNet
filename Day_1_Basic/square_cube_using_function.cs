using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static float square(float a)
        {
            return (float)(a * a);
        }
        static float cube(float a)
        {
            return (float)(a * a * a);
        }
        static void Main(string[] args)
        {
            float a = 5;
            float b = (float)Program.square(a);
            float c = (float)Program.cube(a);
            Console.WriteLine("1st square={0} 2nd cube={1}",b,c);
        }
    }
}
