using System;

namespace ConsoleApplication4
{
    class StringProgram
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a String");
            String s1 = Console.ReadLine();
            String s2 = s1.ToLower();
            Console.WriteLine(s2);
            Console.WriteLine(String.ReferenceEquals(s1,s2));
            Console.WriteLine(String.Equals(s1, s2));
        }
    }
}
