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
    public partial class frmDangKy : Form
    {
        Form parent;
        public frmDangKy(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmDangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            erDangKy.Clear();
            bool flag = true;

            if (!MotSoPhuongThucBoTro.checkUsername(txtUsername.Text))
            {
                erDangKy.SetError(txtUsername, "Tên tài khoản không được để trống, phải >=6 kí tự và chỉ chấp nhận số và chữ.");
                flag = false;
            }

            if (MotSoPhuongThucBoTro.checkUsernameInData(txtUsername.Text))
            {
                erDangKy.SetError(txtUsername, "Tên tài khoản đã tồn tại, vui lòng chọn tên khác.");
                flag = false;
            }

            if(!MotSoPhuongThucBoTro.checkPassword(txtPassword.Text))
            {
                erDangKy.SetError(txtPassword, "Mật khẩu không được để trống, phải >=5 ký tự,chỉ chấp nhận các kí tự chữ,số,các kí tự đặc biệt(trừ dấu cách).");
                flag = false;
            }

            if (txtPassword.Text != txtRePassword.Text)
            {
                flag = false;
                erDangKy.SetError(txtRePassword, "Mật khẩu nhập lại không được để trống, phải trùng nhau.");
            }

            if (!MotSoPhuongThucBoTro.checkSDT(txtSDT.Text))
            {
                flag = false;
                erDangKy.SetError(txtSDT, "SĐT không được để trống, chỉ chấp nhận kí tự số và chỉ chấp nhận số có 10 số");
            }

            if (!MotSoPhuongThucBoTro.checkSoCMND(txtSoCMND.Text))
            {
                flag = false;
                erDangKy.SetError(txtSoCMND, "Số CMND không được để trống, chỉ chấp nhận kiểu số và dao động từ 10 đến 12 số");
            }

            if (flag)
            {
                string dataToEncrypt = txtUsername.Text + " " + txtPassword.Text + " " + txtSDT.Text + " " + txtSoCMND.Text;
                AES128.EncryptToFile(dataToEncrypt, "user.txt");
                DialogResult result= MessageBox.Show("Đăng ký tài khoản thành công, bạn có muốn quay lại trang đăng nhập không?", "Chúc mừng",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    btnQuayLai_Click(sender, e);
                }
            }
        }
    }
}
