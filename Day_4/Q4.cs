using System;

namespace ConsoleApplication2
{
    class Printer
    {
        static int id = 0;
	static Printer()
	{
	Console.WriteLine("Welcome to Prasann's coding");
	}
        private Printer()
        {
            if (id == 0)
                Console.WriteLine("object is created");
            else
                Console.WriteLine("can not create object");
            id++;
        }
        static void Main(string[] args)
        {
            Printer p1 = new Printer();
            Printer p2 = new Printer();

        }
    }
}
