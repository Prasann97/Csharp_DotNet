using System;

namespace Partial
{
    public partial class Account
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
        public Double Balance
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
        static void Main(string[] args)
        {
            Account[] acc = new Account[5];
            acc[0] = new Saving("raj", 5000);
            acc[0].deposite(500);
            acc[0].withdraw(6000);
            acc[1] = new Current("ravi", 6000);
            acc[1].withdraw(600);
            acc[2] = new Saving("amar", 5100);
            acc[3] = new Saving("ashok", 8000);
            acc[4] = new Current("shweta", 10000);

            
            foreach (Account a in acc)
            {
                Console.WriteLine(a.ToString());
            }

        }
    }
}
