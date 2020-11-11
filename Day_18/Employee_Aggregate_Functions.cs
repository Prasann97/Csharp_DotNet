using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApplication27
{
    public class Employee
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public float Salary { set; get; }
    }
    public class BusinessLayer
    {
        public void Calculate()
        {
            String connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("select count(Id) from Employee", con);
                con.Open();
                int record = (int)cmd.ExecuteScalar();
                Console.WriteLine("count=" + record);

                cmd.CommandText = "select max(Salary) from Employee";
                double r = (double)cmd.ExecuteScalar();
                Console.WriteLine("Max Salary=" + r);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer b = new BusinessLayer();
            b.Calculate();
            
        }
    }
}