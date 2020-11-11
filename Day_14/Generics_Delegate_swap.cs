using System;
using System.Collections.Generic;

namespace Generics_Delegate
{
    delegate void mydel<T>(T t1,T t2);
    class Employee
    {
        int a;
        Employee(int a)
        {
            this.a = a;
        }
        public static void swap<T>(T t1, T t2)
        {
            T temp;
            temp = t1;
            t1 = t2;
            t2 = temp;
            if (t1 is Employee && t2 is Employee)
            {
                Employee e1 = t1 as Employee;
                Employee e2 = t2 as Employee;
                Console.WriteLine("After Swapping {0} {1}", e1.a, e2.a);
            }
            else
                Console.WriteLine("After Swapping {0} {1}", t1, t2);
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 8;
            mydel<int> md1 = new mydel<int>(swap);
            Console.WriteLine("Before Swapping {0} {1}", a, b);
            swap<int>(a, b);

            String c = "hello";
            String d = "bye";
            mydel<String> md2 = new mydel<String>(swap);
            Console.WriteLine("Before Swapping {0} {1}", c, d);
            swap<String>(c, d);

            bool f = true;
            bool g = false;
            mydel<bool> md3 = new mydel<bool>(swap);
            Console.WriteLine("Before Swapping {0} {1}", f, g);
            swap(f, g);


            Employee e1 = new Employee(10);
            Employee e2 = new Employee(20);
            mydel<Employee> md4 = new mydel<Employee>(swap);
            Console.WriteLine("Before Swapping {0} {1}", e1.a, e2.a);
            swap<Employee>(e1, e2);
        }
    }
}
