using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
{
    public partial class frmDangNhap : Form
    {
        Form parent;
        bool flagdn = false;//đăng nhập thành công thì bật cờ
        public frmDangNhap(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            using (frmDangKy frm = new frmDangKy(this))
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }


        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            using (frmQuenMatKhau frm = new frmQuenMatKhau(this))
            {
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            flagdn = false;
            erDangNhap.Clear();
            bool flag = true;

            if (!MotSoPhuongThucBoTro.checkUsername(txtUsername.Text))
            {
                erDangNhap.SetError(txtUsername, "Tên tài khoản không được để trống, phải >=6 kí tự và chỉ chấp nhận số và chữ.");
                flag = false;
            }
            if (!MotSoPhuongThucBoTro.checkPassword(txtPassword.Text))
            {
                erDangNhap.SetError(txtPassword, "Mật khẩu không được để trống, phải >=5 ký tự,chỉ chấp nhận các kí tự chữ,số,các kí tự đặc biệt(trừ dấu cách).");
                flag = false;
            }

            if (flag)
            {

                string[] decryptedData = AES128.DecryptFromFile("user.txt");
                foreach (var decryptedString in decryptedData)
                {
                    string[] userPass = decryptedString.Split(' ');
                    string user = userPass[0];
                    string pass = userPass[1];
                    if ((user == txtUsername.Text) && (pass == txtPassword.Text))
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        flagdn = true;
                        this.Close();
                        return;
                    }

                }
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác"); ;
            }

        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flagdn)
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát chứ?", "-.-", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    parent.Close();
                }
                else
                {
                    e.Cancel = true;
                }              
            }
        }
    }
}
