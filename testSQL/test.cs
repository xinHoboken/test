using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSQL
{
    class test
    {
        static void Main(string[] args)
        {
            string source = "Data Source=XIN;Initial Catalog=student;Integrated Security=True";
            string insert = "insert student.dbo.tb2(name,age,address) values('licong',24,'RenMin University Beijing')";
            SqlConnection conn = new SqlConnection(source);
            conn.Open();
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Console.Read();
        }
    }
}
