using System;

namespace ConsoleApplication16
{
    //delegate void mydel(int a);
    class Employee
    {
        int id;
        String name;
        double salary;

        public Employee(int id, String name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {

            return String.Format("Id={0} Name={1} Salary={2}", id, name, salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var a = new Employee(1, "abc", 5000);
            object b = new Employee(2, "pqr", 6000);
            dynamic c = new Employee(3, "lmn", 7000);
            //c = new Program();//we can change it to same type or in diffrent type because dynamic resolves at runtime
            //a = new Program();//we can change it in same type only if we try to change type we will get compilation error

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            Console.WriteLine(c.ToString());
        }
    }
}
