using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Bai2._6
{
    public partial class test : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string address = "Server=tcp:22521461.database.windows.net,1433;Initial Catalog=QuanLySinhVien;Persist Security Info=False;User ID=tqthy;Password=!Thy1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection cnn;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from SINHVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvSINHVIEN.DataSource = table;
        }
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(address);
            connection.Open();
            loadData();
        }
    }
}
