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
    public partial class frmSuaThongTinSinhVien : Form
    {
        Form parent;
        public frmSuaThongTinSinhVien(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            cboGioiTinh.Text = "";
            txtHoVaTen.Text = "";
            txtMSSVCu.Text = "";
            txtMSSVMoi.Text = "";
            dtpNgaySinh.Text = "";
            txtSDT.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMSSVMoi.Text == "" || txtMSSVCu.Text == "" || txtHoVaTen.Text == "" || cboGioiTinh.Text == "" || dtpNgaySinh.Text == "" || txtDiaChi.Text == "" || txtSDT.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            bool tonTaiMSSV = false;
            try
            {
                //Khởi tạo connection đến SQL Server
                using (var connection = SqlServerConnection.Create())
                {
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sql = "UPDATE SINHVIEN SET MSSV='" + txtMSSVMoi.Text + "', HOTEN=N'" + txtHoVaTen.Text + "', GIOITINH=N'" + cboGioiTinh.Text + "', NGAYSINH='" + MotSoPhuongThucBoTro.fomatDateTimePicker(dtpNgaySinh) + "', DIACHI=N'" + txtDiaChi.Text + "', SDT='" + txtSDT.Text + "', EMAIL='" + txtEmail.Text + "' WHERE MSSV='" + txtMSSVCu.Text + "'";
                    command = new SqlCommand(sql, connection);
                    adapter.UpdateCommand = new SqlCommand(sql, connection);
                    adapter.UpdateCommand.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                }
            }
            catch (SqlException se)
            {
                foreach (SqlError error in se.Errors)
                {
                    if (MotSoPhuongThucBoTro.findPrimary(error.Message))
                    {
                        tonTaiMSSV = true;
                        MessageBox.Show("Đã tồn tại sinh viên có MSSV: " + txtMSSVMoi.Text);
                    }
                }
            }
            if (!tonTaiMSSV)
            {
                MessageBox.Show("Nhập thông tin sinh viên thành công!");
                txtDiaChi.Text = "";
                txtEmail.Text = "";
                cboGioiTinh.Text = "";
                txtHoVaTen.Text = "";
                txtMSSVCu.Text = "";
                txtMSSVMoi.Text = "";
                dtpNgaySinh.Text = "";
                txtSDT.Text = "";
            }
        }
    }
}
