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
    public partial class frmXoaSinhVien : Form
    {
        Form parent;
        public frmXoaSinhVien(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMSSVOrHoTen.Text == "")
            {
                erNguoiDung.SetError(txtMSSVOrHoTen, "Không được để trống!");
                return;
            }

            if (rdbMSSV.Checked)//xóa theo MSSV
            {
                using (var connection = SqlServerConnection.Create())
                {
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = "DELETE FROM SINHVIEN WHERE MSSV='" + txtMSSVOrHoTen.Text + "'";
                    command = new SqlCommand(sql, connection);
                    adapter.UpdateCommand = new SqlCommand(sql, connection);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                }
            }
            else//xóa theo Họ Tên
            {
                using (var connection = SqlServerConnection.Create())
                {
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = "DELETE FROM SINHVIEN WHERE HOTEN='" + txtMSSVOrHoTen.Text + "'";
                    command = new SqlCommand(sql, connection);
                    adapter.UpdateCommand = new SqlCommand(sql, connection);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                }
            }
            txtMSSVOrHoTen.Text = "";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
