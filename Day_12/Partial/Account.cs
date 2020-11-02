using System;

namespace Partial
{
    public abstract partial class Account
    {
        public void deposite(double amt)
        {
            Balance = Balance + amt;
        }
        public override String ToString()
        {
            return "Id=" + Id + " Name=" + Name + " Balane=" + Balance;
            //Console.WriteLine("Id={0} Name={1} Balance={2}", Id, Name, Balance);
        }
        public abstract void withdraw(double amt);
    }
    class Saving : Account
    {
        public Saving(String name, double balance)
        {
            Name = name;
            if (balance > 1000)
                Balance = balance;
            else
                throw new Exception("Min balanace 1000rs reuqired to open saving account");
        }
        public override void withdraw(double amt)
        {
            double a = Balance;
            a = Balance - amt;
            if (a > 1000)
                Balance = Balance - amt;
            else
                Console.WriteLine("Insufficient Balance to withdraw");
        }
    }
    class Current : Account
    {
        public Current(String name, double balance)
        {
            Name = name;
            Balance = balance;
        }
        public override void withdraw(double amt)
        {
            Balance = Balance - amt;
        }
    }
        
}

