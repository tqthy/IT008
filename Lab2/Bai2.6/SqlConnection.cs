using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Bai2._6
{
    public class SqlServerConnection
    {
        public static SqlConnection Create()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QuanLySinhVien"].ConnectionString;
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            return cnn;
        }

    }
}
