using System;

namespace ConsoleApplication12
{
    public class Person
    {
        public virtual String dojob()
        {
            return "Doing job";
        }
    }
    public class Programmer: Person
    {
        public override String dojob()
        {
            return "Doing Code";
        }
        public void test()
        {
            Console.WriteLine("I am testing code also");
        }
    }
    public class singer : Person
    {
        public override String dojob()
        {
            return "singing";
        }
    }
    class dancer : Person
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] p = new Person[3];
            p[0] = new Programmer();
            p[1] = new singer();
            p[2] = new dancer();
            foreach (Person person in p)
            {
                Console.WriteLine(person.dojob());
                if (person is Programmer)
                    ((Programmer)person).test();
            }
        }
    }
}
