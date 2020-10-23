using System;

namespace ClassLibrary1
{
    public class Employee
    {
        static int id=0;
        int getid;
        string name;
        double salary;
        double netsalary;
	static Employee()
	{
	Console.WriteLine("Welcome to Prasann's coding");
	}
        public Employee(String name, double salary)
        {
            this.getid = ++id;
            this.name = name;
            this.salary = salary;
        }
        public void calculate_netsalary()
        {
            this.netsalary = this.salary - (this.salary * 0.1);
        }
        public void display()
        {
            Console.WriteLine("Name={0} Netsalary={1}", name, netsalary);
        }
    }
}
