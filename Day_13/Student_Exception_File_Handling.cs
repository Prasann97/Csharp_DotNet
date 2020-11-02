using System;
using System.IO;
namespace Student_Exception_FileHandling
{
    class Student
    {
        int id;
        static int getid;
        String name;
        int marks;
        public Student(String name,int marks)
        {
            id = ++getid;
            this.name = name;
            this.marks = marks;
        }
        public void give_gracemarks(int marks)
        {
            if (marks != 0 && marks <= 5)
            {
                this.marks = this.marks + marks;
            }
            else
                throw new Exception("cannot give gracemarks greater than 5");
        }
        public override string ToString()
        {
            return string.Format("Id={0} Name={1} Marks={2}", id, name, marks);
        }
        static void Main(string[] args)
        {
            Student s1 = new Student("abc", 55);
            Student s2 = new Student("pqr", 35);
            try
            {
                s1.give_gracemarks(5);
                s2.give_gracemarks(8);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            FileStream fs = new FileStream("stud.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine(s1.ToString());
                sw.WriteLine(s2.ToString());
                sw.Flush();
            }
            catch
            {
                Console.WriteLine("Error while writing");
            }
            sw.Close();

            Console.WriteLine("Now Reading part \n");

            String s;
            FileStream fs1 = new FileStream("stud.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs1);
            try
            {
                while ((s = sr.ReadLine()) != null)
                    Console.WriteLine(s);
            }
            catch
            {
                Console.WriteLine("Error while reading");
            }
            sr.Close();
            Console.WriteLine("Done with all");
        }
    }
}
