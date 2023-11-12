using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._6
{
    public partial class frmDanhSachSinhVien : Form
    {
        Form parent;
        public frmDanhSachSinhVien( Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtmssv.Text == "" || txtmssv.Text.Length != 8)
            {
                MessageBox.Show("MSSV chưa đúng định dạng, vui lòng nhập lại");
            } else
            {
                using (var connection = SqlServerConnection.Create())
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    string sql = "SELECT * FROM SINHVIEN";
                    command = new SqlCommand(sql, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dataReader.GetString(0) == txtmssv.Text)
                        {
                            string[] row = {dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader[3].ToString(), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6)};
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);

                        }
                        
                    }
                    command.Dispose();
                    connection.Close();
                }
            }
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            using (var connection = SqlServerConnection.Create())
            {
                SqlCommand command;
                SqlDataReader dataReader;
                string sql = "SELECT * FROM SINHVIEN";
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string[] row = { dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader[3].ToString(), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6) };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
                command.Dispose();
                connection.Close();
            }
        }
    }
}
