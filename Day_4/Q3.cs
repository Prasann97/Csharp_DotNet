using System;

namespace ConsoleApplication2
{
    class Customer
    {
        int id;
        string name;
        double billamount;
	static Customer()
	{
	Console.WriteLine("Welcome to Prasann's coding");
	}
        void display()
        {
            Console.WriteLine("id={0} name={1} billamount={2}", id, name, billamount);
        }
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.display();
        }
    }
}
