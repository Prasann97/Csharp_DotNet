using System;
using System.Data.SqlClient;

namespace ConsoleApplication24
{
    class Program
    {
        public void details()
        {
            String connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Demo;Integrated Security=True";
            using(SqlConnection con=new SqlConnection(connectionstring))
            {
                SqlCommand cmd=new SqlCommand("Select * from Employee",con);
                con.Open();
                SqlDataReader rdr=cmd.ExecuteReader();
                if(rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2}",rdr["id"],rdr["Name"],rdr["Salary"]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.details();
        }
    }
}
