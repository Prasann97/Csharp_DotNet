using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
delegate void wd(double x, double bal, string nm);
[Serializable]
abstract class Account
{
    public event wd wdevent;
    static int id;
    int Accid;
    string name;
    double balance;
    protected const double minbal = 10000;

    public Account(String name, double balance)
    {
        Accid = ++id;
        Name = name;
        Balance = balance;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Balance
    {
        get { return balance; }
        protected set { balance = value; }
    }

    public void deposit(double a)
    {
        Balance = Balance + a;
    }

    public void OnWithdraw(double a, double Balance, string name)
    {
        if (wdevent != null)
            wdevent(a, Balance, name);
    }
    public abstract void withdraw(double e);

    public static void SaveAsSoapFormat(object objgraph)
    {
        SoapFormatter sf = new SoapFormatter();
        using (FileStream fs = new FileStream("tt.txt", FileMode.Create, FileAccess.Write))
        {
            sf.Serialize(fs, objgraph);
        }
        Console.WriteLine("done with writting");
    }
    public static void LoadFrormFile(string s)
    {
        SoapFormatter sf1 = new SoapFormatter();
        using (FileStream fs1 = new FileStream("tt.txt", FileMode.Open, FileAccess.Read))
        {
            Account[] acc = (Account[])sf1.Deserialize(fs1);
            foreach (Account a in acc)
                Console.WriteLine("Id={0} Name={1} Balance={2}", a.Accid, a.Name, a.Balance);

        }
    }

}
[Serializable]
class Current : Account
{
    public Current(String name, Double bal)
        : base(name, bal)
    {
    }
    public override void withdraw(double a)
    {
        Balance = Balance - a;
        OnWithdraw(a, Balance, Name);
    }
}
[Serializable]
class Saving : Account
{
    public Saving(String name, Double bal)
        : base(name, bal)
    {
    }

    public override void withdraw(double a)
    {


        Balance = Balance - a;
        OnWithdraw(a, Balance, Name);

    }
}
[Serializable]
class Program
{
    
    static void Main(string[] args)
    {

        Account[] a = new Account[3];

        a[0] = new Saving("A", 35000);
        a[1] = new Saving("B", 18000);
        a[2] = new Current("C", 40000);

        wd w = (amt, Balance, name) =>
        {
            Console.WriteLine("E-mail : Amount withdrawn : {0} new bal={1} name={2}", amt, Balance, name);
        };

        w += (amt, Balance, name) =>
        {
            Console.WriteLine("Mobile : Amount withdrawn : {0} new bal={1} name={2}", amt, Balance, name);
        };

        for (int i = 0; i < a.Length; i++)
        {
            a[i].wdevent += w;
        }
        

        a[0].deposit(10000);
        a[1].withdraw(1000);
        a[2].withdraw(12000);

        Console.WriteLine("Serialization");

        Account.SaveAsSoapFormat(a);

        Console.WriteLine("De-Serialization");

        String s = "emp.soap";
        Account.LoadFrormFile(s);

        Console.WriteLine("done");
    }
}