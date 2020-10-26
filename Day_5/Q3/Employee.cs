using System;

namespace ClassLibrary2
{
    public class Employee
    {
        int id;
        string name;
        double salary;
        double netsalary;
        static int getid;
        const int maxemp = 3;
        const double maxsal = 50000;
        static double TDS=0.1;
        static Employee()
        {
            Console.WriteLine("Welcome to Prasann's code");
        }
        public Employee(string name, double salary)
        {
            if (getid < maxemp && salary < maxsal)
            {
                id = ++getid;
                this.name = name;
                this.salary = salary;
            }
            else
                Console.WriteLine("can not add employee");
        }
        public void calculatenetsal()
        {
            this.salary = this.salary - (this.salary * TDS);
        }
        public void display()
        {
            Console.WriteLine("ID={0} Name={1} Salary={2}", id, name, salary);
        }
    }
}
