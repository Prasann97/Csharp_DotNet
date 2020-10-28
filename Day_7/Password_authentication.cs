using System;

namespace ConsoleApplication5
{
    class Authenticate
    {
        String name;
        readonly String password;
        Authenticate(String name, String password)
        {
            this.name = name;
            this.password = password;
        }
        String doAuthenticate(String a)
        {
            if (a == password)
            {
                Console.WriteLine("Valid user");
                return "Valid user";
            }
            else
            {
                Console.WriteLine("Invalid user");
                return "Invalid user";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name to set");
            String nm=Console.ReadLine();
            Console.WriteLine("Enter a Password to set");
            String pass = Console.ReadLine();
            Authenticate a1 = new Authenticate(nm,pass);
            String a2;
            Console.WriteLine("please enter password");
            do
            {
                Console.Write(a1.name + " = ");
                a2 = a1.doAuthenticate(Console.ReadLine());
            }
            while (a2 != "Valid user");
        }
    }
}
