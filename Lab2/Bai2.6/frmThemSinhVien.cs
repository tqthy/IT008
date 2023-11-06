using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (txtMSSV.Text.Length != 8)
            {
                erNguoiDung.SetError(txtMSSV, "MSSV phải có đúng 8 ký tự");
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
            //test xíu
            // MessageBox.Show(MotSoPhuongThucBoTro.fomatDateTimePicker(dtpNgaySinh));
        }
    }
}
