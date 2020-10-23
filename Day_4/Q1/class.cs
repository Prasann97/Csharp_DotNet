//Q1. Create a class Account having private instance member Id, Name Balanceamt. Create method deposit who’s job is to increase Balanceamtby the amout deposited buy account holder. Create method withdraw who’s job is to decrease Balanceamtby the amout  withdrwan buy account holder. Write method display which will display name and Balanceamt. This application will be classlibrary.
//Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.


using System;

namespace ClassLibrary5
{
    public class Class1
    {
        private int id;
        private string name;
        private double balanceamt=0;
	static Class1()
	{
	Console.WriteLine("Welcome to Prasann's coding");
	}
        public void deposite(double a)
        {
            this.balanceamt = this.balanceamt + a;
        }
        public void withdraw(double a)
        {
            this.balanceamt = this.balanceamt - a;
        }
        public void display()
        {
            Console.WriteLine("name={0} Balance={1}", name, balanceamt);
        }
    }
}
