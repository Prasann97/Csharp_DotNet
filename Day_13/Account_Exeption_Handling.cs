using System;

namespace ConsoleApplication8
{
    abstract class Account
    {
        public static int getid;
        int id;
        String name;
        double balance;
        public Account()
        {
            id = ++getid;
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        public String Name
        {
            set
            {
                if (value.Length < 15)
                    this.name = value;
                else
                    throw new Exception("Name shouldn't greater that 15 characters");
            }
            get
            {
                return this.name;
            }
        }
        protected Double Balance
        {
            set
            {
                this.balance = value;
            }
            get
            {
                return this.balance;
            }
        }
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
            if (balance < 1000)
                throw new Exception("Min balanace 1000rs reuqired to open saving account");
            else
            {
                Name = name;
                Balance = balance;
            }
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
    class Program
    {
        static void Main(string[] args)
        {
            Account[] acc = new Account[3];
            acc[0] = new Saving("ABC", 5000);
            acc[1] = new Current("PQR", 6000);
            try
            {
                acc[0].deposite(500);
                acc[0].withdraw(6000);
                acc[1].withdraw(600);
                acc[2] = new Saving("LMN", 100);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(acc[0].ToString());
            Console.WriteLine(acc[1].ToString());
        }
    }
}
