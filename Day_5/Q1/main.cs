using System;
using ClassLibrary2;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("Prasann", "Dasharath", "Borate");
            Employee e2 = new Employee("Rishi", "Kadam");
            e1.display();
            e2.display();
        }
    }
}
