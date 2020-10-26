using System;

namespace ClassLibrary2
{
    public class Employee
    {
        string Firstname;
        string Middlename;
        string Lastname;
        static Employee()
        {
            Console.WriteLine("Welcome to Prasann's code");
        }
        public Employee(string firstname, string middlename, string lastname)
        {
            this.Firstname = firstname;
            this.Middlename = middlename;
            this.Lastname = lastname;
        }
        public Employee(string firstname, string lastname)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
        public void display()
        {
            Console.WriteLine(Firstname+" "+Middlename+" "+Lastname);
        }

    }
}
