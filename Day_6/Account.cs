using System;

namespace ConsoleApplication3
{
    class Account
    {
        static int getid;
        int id;
        string name;
        double balance;
        const double minbal = 1000;
        static double InterestRate = 0.07;
        double IntRecived;
        static Account()
        {
            Console.WriteLine("Welcome to Central Bank Of India");
        }
        Account(string name,double amt)
        {
            if (amt>1000)
            {
                id = ++getid;
                Name = name;
                Balance = amt;
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
        public string Name
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
        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }
        void deposite(double amt)
        {
            if (amt <= 0)
                Console.WriteLine("Please enter valid ammount to deposite");
            else
                Balance = Balance + amt;
        }
        void withdraw(double amt)
        {
            if (amt > 0)
            {
                double a = this.balance;
                if (a - amt < minbal)
                    Console.WriteLine("Insufficient Balance");
                else
                    this.balance = this.balance - amt;
            }
            else
                Console.WriteLine("Please Enter valid ammount to withdraw");
        }
        double payint()
        {
            this.IntRecived=Balance*InterestRate;
            Balance = Balance + this.IntRecived;
            return (IntRecived);
        }
        void display()
        {
            Console.WriteLine("Id={0} Name={1} Balance={2} InterestRecived={3}", id, name, balance, IntRecived);
        }
        static void Main(string[] args)
        {
            Account a1 = new Account("Abc", 5000);
            try
            {
                Account a2 = new Account("Pqr", 500);
            }
            catch
            {
                Console.WriteLine("can not create acc deposite 1000rs atleast");
            }
            Account a3 = new Account("lmn", 3000);
            a3.withdraw(2500);
            a3.deposite(600);
            a3.withdraw(2000);
            a3.payint();
            a1.payint();
            a1.display();
            a3.display();
        }
    }
}
