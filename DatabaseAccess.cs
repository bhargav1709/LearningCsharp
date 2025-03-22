using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LearningCsharp
{
    internal class DatabaseAccess
    {
        public DataTable GetAllEmployeeRecord()
        {
            SqlConnection con = new SqlConnection("Data source=DESKTOP-F6SN8GN\\SQLEXPRESS;Integrated Security=true;Database=scott;TrustedServerCertificate=true");
            SqlDataAdapter sda= new SqlDataAdapter("select * from emp", con);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            return dt;            
        }




    }
}
