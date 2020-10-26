using System;

namespace ClassLibrary1
{
    public class Account
    {
        int id;
        static int getid;
        string name;
        double balanceamt;
        const int maxacc=3;
        static Account()
        {
            Console.WriteLine("Welcome to Prasann's code");
        }
        public Account(string name, double balanceamt)
        {
            if (getid < maxacc)
            {
                id = ++getid;
                this.name = name;
                this.balanceamt = balanceamt;
            }
            else
                Console.WriteLine("can not create acc");
        }
        public void deposite(double amt)
        {
            this.balanceamt = this.balanceamt + amt;
        }
        public void withdraw(double amt)
        {
            if (balanceamt > 1000)
                this.balanceamt = this.balanceamt - amt;
            else
                Console.WriteLine("Insufficient Balance");
        }
        public void display()
        {
            Console.WriteLine("Id={0} Name={1} Balance={2}",id,name,balanceamt);
        }
    }
}
