using System;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("abc", 10000);
            Employee e2 = new Employee("pqr", 15000);
            e1.calculate_netsalary();
            e2.calculate_netsalary();
            e1.display();
            e2.display();
        }
    }
}
