using System;


namespace Day2_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1;
            byte b2;
            Console.WriteLine("Enter 1st no:");
            b1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            b2 = Convert.ToByte(Console.ReadLine());
            checked
            {
                byte sum = (byte)(b1 + b2);
                Console.WriteLine("sum={0}",sum);
            }
        }
    }
}
