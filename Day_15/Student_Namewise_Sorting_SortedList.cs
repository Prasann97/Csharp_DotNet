using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication23
{
    class Student
    {
        int id;
        static int getid;
        String name;
        double maths, sci, eng, total;
        Student(String name, double maths, double sci, double eng)
        {
            id = ++getid;
            this.name = name;
            this.sci = sci;
            this.eng = eng;
            this.total = Total();
        }
        double Total()
        {
            this.total = this.maths + this.sci + this.eng;
            return this.total;
        }
        public String Name
        {
            get { return name; }
        }
        public double TotalP
        {
            get { return total; }
        }
        public override string ToString()
        {
            return String.Format("Name={0} Total={1}", this.Name, this.TotalP);
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("soham", 55, 66, 82);
            Student s2 = new Student("shweta", 88, 98, 78);
            Student s3 = new Student("aman", 57, 62, 29);

            SortedList<int, Student> slist = new SortedList<int, Student>();
            slist.Add(1, s1);
            slist.Add(2, s2);
            slist.Add(3, s3);

            var v = slist.Select(m => m).OrderBy(m => m.Value.name);

            foreach (var s in v)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
