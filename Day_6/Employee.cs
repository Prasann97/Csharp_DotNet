using System;

namespace ConsoleApplication4
{
    class Employee
    {
        int id;
        static int getid;
        String name;
        double salary;
        const double TDS = 0.1;
        double netsalary;
        const int maxemp=3;
        const double salmax = 50000;
        static Employee()
        {
            Console.WriteLine("Welcome to Prasann's code");
        }
        Employee(String name,double salary)
        {
            if (getid < maxemp && salary > 0 && salary < salmax)
            {
                id = ++getid;
                Name = name;
                Salary = salary;
            }
            else
                throw new Exception();
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public String Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
        public double Netsalary()
        {
           this. netsalary = this.salary - this.Salary * TDS;
           return netsalary;
        }
        public void display()
        {
            Console.WriteLine("Id={0} Name={1} Salary={2}", id, name, salary);
        }
        static void Main(string[] args)
        {
            try
            {
                Employee e1 = new Employee("Abc", 40000);
                e1.Netsalary();
                e1.display();
                Employee e2 = new Employee("Pqr", 45000);
                e2.Netsalary();
                e2.display();
                Employee e3 = new Employee("Lmn", 30000);
                e3.Netsalary();
                e3.display();
                Employee e4 = new Employee("Xyz", 20000);
            }
            catch
            {
                Console.WriteLine("Employee can not create");
            }
        }
    }
}
