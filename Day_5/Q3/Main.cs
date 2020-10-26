using System;
using ClassLibrary2;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Prasann", 20000);
            Employee e2 = new Employee("Rishi", 30000);
            e1.calculatenetsal();
            e2.calculatenetsal();
            e1.display();
            e2.display();
            Employee e3 = new Employee("Ajay", 60000);
            Employee e4 = new Employee("ABC", 10000);
            e4.display();
            Employee e5 = new Employee("PQR", 45000);
            Console.ReadLine();
        }
    }
}
