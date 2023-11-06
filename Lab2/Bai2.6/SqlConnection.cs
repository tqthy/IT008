using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bai2._6
{
    public class SqlServerConnection
    {
        public static SqlConnection Create()
        {
            string connectionString = "Server=tcp:22521461.database.windows.net,1433;Initial Catalog=QuanLySinhVien;Persist Security Info=False;User ID=tqthy;Password=!Thy1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;
        }

        public static void Close(SqlConnection cnn)
        {
            cnn.Close();
        }
    }
}
