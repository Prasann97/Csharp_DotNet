using System;

namespace ConsoleApplication15
{
    public delegate void givemsg(int id,String name,double salary);
    public abstract class Employee
    {
        public event givemsg give;
        int id;
        static int getid;
        String name;
        double salary;
        public Employee()
        {
            id = ++getid;
        }
        protected int Id
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
                name = value;
            }
            get
            {
                return name;
            }
        }
        public double Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
        public override string ToString()
        {
            return String.Format("Id={0} Name={1} Salary={2}", id, name, salary);
        }
        public abstract void givebonus();
        public void OnBonus(int id,String name,double salary)
        {
            if(give!=null)
                give(id,name,salary);
        }
    }
    public class Temporary_Employee : Employee
    {
        public Temporary_Employee(String name,double salary)
        {
            Name = name;
            Salary = salary;
        }
        public override void givebonus()
        {
            OnBonus(Id, Name, Salary);
        }

    }
    public class Permenent_Employee : Employee
    {
        public Permenent_Employee(String name, double salary)
        {
            Name = name;
            Salary = salary;
        }
        public override void givebonus()
        {
            OnBonus(Id, Name, Salary);
        }
    }
    class Msg
    {
        public void SMS(int id, String name, double salary)
        {
            Console.WriteLine(name+"=SMS=Bonus has been credited");
        }
        public void Email(int id, String name, double salary)
        {
            Console.WriteLine(name+"=Email=Bonus has been credited");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Msg m=new Msg();
            Employee[] emp = new Employee[4];
            emp[0] = new Permenent_Employee("abc", 50000);
            emp[1] = new Permenent_Employee("pqr", 40000);
            emp[2] = new Temporary_Employee("lmn", 30000);
            emp[3] = new Temporary_Employee("xyz", 20000);
            foreach (Employee e in emp)
            {
                e.give += m.SMS;
                e.give += m.Email;
            }
            foreach (Employee e in emp)
            {
                e.givebonus();
            }
         }
    }
}
