using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Disconnected_update_insert_delete
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods m = new Methods();
            Employee e = new Employee() { Name = "hiee", Salary = 6000 };
            m.display();
            //m.InsertData(e);
            //m.DeleteRecord(3004);
            //m.UpdateName(3, "Vita");
            m.displayXML();
        }
    }
}