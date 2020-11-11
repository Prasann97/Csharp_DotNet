using System;
using System.Threading;

namespace ConsoleApplication23
{
    class MyThread
    {
        String tname;
        MyThread(String name)
        {
            this.tname = name;
        }
        public void run()
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine(this.tname + " " + i);
            }
        }
        static void Main(string[] args)
        {
            MyThread th1 = new MyThread("1st Thread");
            MyThread th2 = new MyThread("2nd Thread");
            Thread t1 = new Thread(th1.run);
            Thread t2 = new Thread(th2.run);
            t1.Start();
            t2.Start();
        }
    }
}
