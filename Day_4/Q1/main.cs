using System;
using ClassLibrary5;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1, "abc", 10000);
            Account a2 = new Account(2, "pqr", 15000);
            a1.display();
            a2.display();
            a1.deposite(2000);
            a2.deposite(1000);
            Console.WriteLine("After deposite");
            a1.display();
            a2.display();
            a1.withdraw(4000);
            a2.withdraw(6000);
            Console.WriteLine("After withdraw");
            a1.display();
            a2.display();
        }
    }
}
