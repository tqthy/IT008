using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Bai2._6
{
    
    public partial class frmThemSinhVien : Form
    {
        Form parent;
        public frmThemSinhVien(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedIndex = 2;//mặc định khi chưa nhập thông tin cho giới tính thì là chọn giới tính khác 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            erNguoiDung.Clear();
            bool flag = true;

            if (!MotSoPhuongThucBoTro.checkMSSV(txtMSSV.Text))
            {
                flag = false;
                erNguoiDung.SetError(txtMSSV, "MSSV phải có đúng 8 ký tự,và không được có kí tự đặc biệt!");
            }

            if (!MotSoPhuongThucBoTro.checkHoTen(txtHoTen.Text))
            {
                flag=false;
                erNguoiDung.SetError(txtHoTen, "Họ tên không được để trống, không quá 50 kí tự!"); ;
            }

            if (!MotSoPhuongThucBoTro.checkDiaChi(txtDiaChi.Text))
            {
                flag = false;
                erNguoiDung.SetError(txtDiaChi, "Địa chỉ không được để trống và không được quá 70 kí tự!");
            }

            if (!MotSoPhuongThucBoTro.checkEmail(txtEmail.Text))
            {
                flag = false;
                erNguoiDung.SetError(txtEmail, "Email không hợp lệ!");
            }

            if (!MotSoPhuongThucBoTro.checkSDT(txtSDT.Text))
            {
                flag = false;
                erNguoiDung.SetError(txtSDT, "sdt không được để trống,chỉ chấp nhận có kí tự số, sđt phải có trên 8 số k quá 20 số!");
            }


            //nếu người dùng không nhập lỗi gì thì cho phép thêm sinh viên
            if (flag)
            {
                bool tonTaiMSSV = false;
                try
                {
                    //Khởi tạo connection đến SQL Server
                    using (var connection = SqlServerConnection.Create())
                    {
                        SqlCommand command;
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        string sql = "INSERT INTO SINHVIEN VALUES ('" + txtMSSV.Text + "', N'" + txtHoTen.Text + "', N'" + cboGioiTinh.SelectedItem.ToString() + "', '" + MotSoPhuongThucBoTro.fomatDateTimePicker(dtpNgaySinh) + "', N'" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "')";
                        command = new SqlCommand(sql, connection);
                        adapter.InsertCommand = new SqlCommand(sql, connection);
                        adapter.InsertCommand.ExecuteNonQuery();
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
                            MessageBox.Show("Đã tồn tại sinh viên có MSSV: " + txtMSSV.Text);
                        }
                    }
                }
                if (!tonTaiMSSV)
                {
                    MessageBox.Show("Nhập thông tin sinh viên thành công!");
                }
                txtMSSV.Text = "";
                txtHoTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtEmail.Text = "";
            }

        }


        //cái nút này kiểu sẽ cho mấy cái thuộc tính về mặc định hết 
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMSSV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
