using System;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            var a=new[] {new {name="Abc", Salary=5000},new{name="pqr" ,Salary=6000},new{name="lmn" ,Salary=7000}};
            foreach (var v in a)
            {
                Console.Write("Name=" + v.name+" ");
                Console.WriteLine("Salary=" + v.Salary);
            }
        }
    }
}
