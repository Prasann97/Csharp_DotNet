using System;

namespace ConsoleApplication18
{
    class Employee
    {
        int id;
        String name;
        double salary;
        public Employee(int i,String nm,double sal)
        {
            this.id = i;
            this.name = nm;
            this.salary = sal;
        }
        public override string ToString()
        {
            return String.Format("Id={0} Name={1} Salary={2}", id, name, salary);
        }
        //~Employee()
        //{
        //    Console.WriteLine("destroyed=" + this.id);
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] e = new Employee[100000];
            //Employee e1 = new Employee(5, "abc", 500);
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(GC.MaxGeneration);

            for (int i = 1; i < e.Length; i++)
            {
                e[i] = new Employee(i, "abc", i);
                Console.WriteLine(e[i].ToString());
                Console.WriteLine(GC.GetGeneration(e[i]));
            }

            Console.WriteLine("o=" + GC.CollectionCount(0));
            Console.WriteLine("1=" + GC.CollectionCount(1));
            Console.WriteLine("2=" + GC.CollectionCount(2));

            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();

            Console.WriteLine(GC.GetGeneration(e));

            if (e[0] != null)
                Console.WriteLine(e[1].ToString());
            else
                Console.WriteLine("null");


            
        }
    }
}
