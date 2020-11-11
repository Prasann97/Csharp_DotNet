using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Data;

namespace Stored_Procedure
{
    class Product
    {
        public int id { get; set; }
        public String Name{get; set;}
        public float Prize { get; set; }
        public int Qty { get; set; }
        public void products(String sname)
        {
            String connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("SPProductByName", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", sname);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", rdr["id"], rdr["Name"], rdr["Price"], rdr["Qty"]);
                    }
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            String s = "T";
                        //"select * from Product where Name like '"+sname+"%'"
            //String s = "T';delete from Product;select * from Product where Name like 'T";
            p.products(s);
            
        }
    }
}
