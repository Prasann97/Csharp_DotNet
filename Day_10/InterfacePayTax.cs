using System;

namespace ConsoleApplication15
{
    interface Itaxology
    {
        void paytax(double amount);
    }
    class MyIndia : Itaxology
    {
        public void paytax(double amount)
        {
            double tax = amount * 0.4;
            Console.WriteLine("Indian Tax=" + tax);
        }
    }
    class MyEurope : Itaxology
    {
        public void paytax(double amount)
        {
            double tax = amount * 0.3;
            Console.WriteLine("Eurpoe Tax=" + tax);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyIndia mi = new MyIndia();
            MyEurope me = new MyEurope();
            mi.paytax(5000);
            me.paytax(8000);
        }
    }
}
