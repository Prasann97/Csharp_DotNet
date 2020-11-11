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
        public List<Employee> Getter
        {
            get
            {
                List<Employee> mylist = new List<Employee>();
                String connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select * from Employee", con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            Employee e = new Employee();
                            e.Id = Convert.ToInt32(rdr["Id"]);
                            e.Name = Convert.ToString(rdr["Name"]);
                            e.Salary = Convert.ToSingle(rdr["Salary"]);
                            mylist.Add(e);
                        }
                    }
                    return mylist;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer b = new BusinessLayer();
            var v = b.Getter;
            foreach (var x in v)
                Console.WriteLine("{0} {1} {2}", x.Id, x.Name, x.Salary);
            
        }
    }
}
