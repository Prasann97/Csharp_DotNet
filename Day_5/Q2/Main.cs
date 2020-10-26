using System;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account("Prasann", 15000);
            Account a2 = new Account("Rishi", 10000);
            Account a3 = new Account("Ajay", 5000);
            a1.deposite(1000);
            a2.withdraw(1000);
            a3.withdraw(4000);
            a1.display();
            a2.display();
            a3.display();
            Account a4 = new Account("abc", 2000);
            a3.withdraw(500);
            Account a5 = new Account("pqr", 5000);
            a4.display();
            a5.display();
        }
    }
}
