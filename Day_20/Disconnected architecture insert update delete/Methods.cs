using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Disconnected_update_insert_delete
{
    public class Methods
    {
        String connectionstring;
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds;
        public void display()
        {
            connectionstring = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            con = new SqlConnection(connectionstring);
            ds = new DataSet();
            sda = new SqlDataAdapter("select * from Employee", con);
            sda.FillSchema(ds, SchemaType.Source, "Employee");
            sda.Fill(ds, "Employee");
            Console.WriteLine(ds.Tables[0]);
            DataTable dt = ds.Tables["Employee"];
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                    Console.Write(row[col]+" ");
                Console.WriteLine();
            }
        }
        public void InsertData(Employee e)
        {
            DataRow dr = ds.Tables["Employee"].NewRow();
            //dr["Id"] = e.Id;
            dr["Name"] = e.Name;
            dr["Salary"] = e.Salary;

            ds.Tables["Employee"].Rows.Add(dr);
            Console.WriteLine("Added succesfully in dataset");

            SqlCommandBuilder co = new SqlCommandBuilder(sda);
            sda.Update(ds, "Employee");

            Console.WriteLine(co.GetUpdateCommand().CommandText);
        }

        public void DeleteRecord(int id)
        {
            DataRow dr = ds.Tables["Employee"].Rows.Find(id);
            dr.Delete();
            Console.WriteLine("Record Deleted");

            SqlCommandBuilder co = new SqlCommandBuilder(sda);
            sda.Update(ds, "Employee");

            Console.WriteLine(co.GetUpdateCommand().CommandText);
        }

        public void UpdateName(int id,String name)
        {
            DataRow dr = ds.Tables["Employee"].Rows.Find(id);
            dr["Name"] = name;
            Console.WriteLine("Record Updated");

            SqlCommandBuilder co = new SqlCommandBuilder(sda);
            sda.Update(ds, "Employee");

            Console.WriteLine(co.GetUpdateCommand().CommandText);
        }

        public void displayXML()
        {
            Console.WriteLine(ds.GetXml());
        }
    }
}
