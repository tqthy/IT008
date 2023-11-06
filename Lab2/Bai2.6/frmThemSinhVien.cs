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
        public frmThemSinhVien()
        {
            InitializeComponent();
        }

        private void frmThemSinhVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.SelectedIndex = 2;//mặc định khi chưa nhập thông tin cho giới tính thì là chọn giới tính khác 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;

            //if (txtMSSV.Text.Length != 8)
            //{
            //    flag = false;
            //    erNguoiDung.SetError(txtMSSV, "MSSV phải có đúng 8 ký tự");
            //}


            //nếu người dùng không nhập lỗi gì thì cho phép thêm sinh viên
            if (flag)
            {
                //Khởi tạo connection đến SQL Server
                using (var connection = SqlServerConnection.Create())
                {
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";
                    //Lệnh SQL Insert ở dưới, sau khi sửa xong định dạng của dtpNgaySinh thì bỏ ẩn (bỏ //) để insert
                    sql = "INSERT INTO SINHVIEN VALUES ('" + txtMSSV.Text + "', '" + txtHoTen.Text + "', '" + cboGioiTinh.SelectedItem.ToString() + "', '" + MotSoPhuongThucBoTro.fomatDateTimePicker(dtpNgaySinh) + "', '" + txtDiaChi.Text + "', '" + txtSDT.Text + "', '" + txtEmail.Text + "')";
                    command = new SqlCommand(sql, connection);
                    adapter.InsertCommand = new SqlCommand(sql, connection);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                }
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
           
        }
    }
}
