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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "1";

            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Đăng nhập thành công,nhấn Ok để vào màn làm việc chính.");
                this.Hide();
                frmDanhMucTN frmDanhMucTN = new frmDanhMucTN(this);
                frmDanhMucTN.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("Đăng nhập thất bại.Bạn có muốn thử lại không?", "Thất bại", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Close();
                }
            }
        }
    }
}
