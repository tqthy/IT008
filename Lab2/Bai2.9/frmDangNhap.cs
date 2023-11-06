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
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy(this);
            frm.Show();
            this.Hide();
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau frm=new frmQuenMatKhau(this);
            frm.Show();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
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
                        frmTextEditor frm = new frmTextEditor(this);
                        frm.Show();
                        this.Hide();
                        return;
                    }

                }
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác"); ;
            }

        }
    }
}
