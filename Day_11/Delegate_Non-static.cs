using System;

namespace ConsoleApplication15
{
    delegate void dele(int no);
    class methods
    {
        public void sqr(int a)
        {
            Console.WriteLine("sqr=" + a * a);
        }
        public void cube(int a)
        {
            Console.WriteLine("sqr=" + a * a * a);
        }
        public void factorial(int a)
        {
            int ans=1;
            for (int i = 2; i <= a; i++)
            {
                ans = ans * i;
            }
            Console.WriteLine("Factorial=" + ans);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            methods m = new methods();
            dele d = new dele(m.sqr);
            d += new dele(m.cube);
            d += new dele(m.factorial);
            d(5);
        }
    }
}
