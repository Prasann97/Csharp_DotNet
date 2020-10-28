using System;

namespace ConsoleApplication5
{
    class animal
    {
        public virtual String speak()
        {
            return ("I don't know how to speak");
        }
    }
    class dog : animal
    {
        public override string speak()
        {
            return ("Bhow Bhow");
        }
    }
    class cat : animal
    {
        public override string speak()
        {
            return ("Mewo Mewo");
        }
    }
    class donkey : animal
    {
       
    }
    class showpoly
    {
        public static void call(animal a)
        {
            Console.WriteLine(a.speak());
        }
        static void Main(string[] args)
        {
            dog d1 = new dog();
            call(d1);
            cat c1 = new cat();
            call(c1);
            donkey d2=new donkey();
            call(d2);
        }
    }
}
