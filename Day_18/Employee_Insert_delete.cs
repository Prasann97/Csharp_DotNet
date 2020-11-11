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
        public void Insert()
        {
            String connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("Insert into Employee values ('hello',5000)", con);
                con.Open();
                int record = cmd.ExecuteNonQuery();
                Console.WriteLine("Row Effected" + record);

                cmd.CommandText = "delete from Employee where id=2";
                int r = cmd.ExecuteNonQuery();
                Console.WriteLine("Row Effected" + r);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            BusinessLayer b = new BusinessLayer();
            b.Insert();
            
        }
    }
}