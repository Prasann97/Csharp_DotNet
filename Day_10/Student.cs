using System;

namespace ConsoleApplication14
{
    class Student
    {
        static int getid;
        int rollno;
        String name;
        int marks;
        static Student()
        {
            Console.WriteLine("Welcome to SM-VITA");
        }
        public Student(String name, int marks)
        {
            rollno = ++getid;
            Name = name;
            Marks = marks;
        }
        public int Rollno
        {
            get
            {
                return rollno;
            }
        }
        public String Name
        {
            set;
            get;
        }
        public int Marks
        {
            set;
            get;
        }
        public override string ToString()
        {
            return String.Format("RollNo={0} Name={1} Marks={2}", Rollno, Name, Marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stud = new Student[5];
            stud[0] = new Student("amar", 32);
            stud[1] = new Student("ashok", 45);
            stud[2] = new Student("shweta", 100);
            stud[3] = new Student("suraj", 70);
            stud[4] = new Student("sohil", 80);

            foreach (Student s in stud)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
