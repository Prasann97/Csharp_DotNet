using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication23
{
    class Employee
    {
        public int id;
        public String name, address;
        public double salary;
        public override string ToString()
        {
            return String.Format("Id={0} Name={1} Address={2} Salary={3}", this.id, this.name, this.address, this.salary);
        }
        static void Main(string[] args)
        {
            Employee[] emp =
            {
                new Employee{id=1,name="suraj",address="vile parle",salary=50000},
                new Employee{id=2,name="vimal",address="andheri",salary=15000},
                new Employee{id=3,name="soham",address="kandivli",salary=65000},
            };

            Console.WriteLine("\n**********1st**********");
            var v1 = emp.Select(m => m);
            foreach (var s in v1)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("\n**********2nd**********");
            var v2 = emp.Select(m => m).Where(m => m.address.Contains("andheri"));
            foreach (var s in v2)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("\n**********3rd**********");
            var v3 = emp.Select(m => m).Sum(m => m.salary);
            Console.WriteLine(v3);

            Console.WriteLine("\n**********4th**********");
            var v4 = emp.Select(m => m).Where(m => m.name.StartsWith("v"));
            foreach (var s in v4)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("\n**********5th**********");
            var v5 = emp.Select(m => m).Count();
            Console.WriteLine(v5);

            Console.WriteLine("\n**********6th**********");
            var v6 = emp.Select(m => m).Where(m => m.salary > 50000);
            foreach (var s in v6)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("\n**********7th**********");
            var v7_1 = emp.Select(m => m).Min(m => m.salary);
            var v7_2 = emp.Select(m => m).Max(m => m.salary);
            var v7_3 = emp.Select(m => m).Average(m => m.salary);
            Console.WriteLine("Min={0} Max={1} Avg={2}", v7_1, v7_2, v7_3);

            Console.WriteLine("\n**********8th**********");
            var v8 = emp.Select(m => m.name).OrderBy(m=>m);
            foreach (var s in v8)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("\n**********9th**********");
            var v9 = emp.Select(m => m).OrderBy(m=>m.salary);
            foreach (var s in v9)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("\n**********10th**********");
            var v10 = emp.Select(m => m).Where(m => m.salary < 20000);
            foreach (var s in v10)
            {
                Console.WriteLine(s.id+" "+s.name);
            } 
        }
    }
}
