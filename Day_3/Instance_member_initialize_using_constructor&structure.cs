using System;
using System.Text;
namespace ConsoleApplication7
{
    struct emp
    {
        public string name;
        public double salary;
        public emp(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void disp()
        {
            Console.WriteLine("name={0} salary={1}", name, salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            emp e = new emp("abc", 50000);
            e.disp();
        }
    }
}
