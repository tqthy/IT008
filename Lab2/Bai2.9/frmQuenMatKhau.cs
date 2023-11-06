using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._9
{
    public partial class frmQuenMatKhau : Form
    {

        Form parent;
        public frmQuenMatKhau(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmQuenMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
            parent.Show();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            erQMK.Clear();
            bool flag = true;

            if (!MotSoPhuongThucBoTro.checkUsername(txtUsername.Text))
            {
                erQMK.SetError(txtUsername, "Tên tài khoản không được để trống, phải >=6 kí tự và chỉ chấp nhận số và chữ.");
                flag = false;
            }

            if (!MotSoPhuongThucBoTro.checkSDT(txtSDT.Text))
            {
                flag = false;
                erQMK.SetError(txtSDT, "SĐT không được để trống, chỉ chấp nhận kí tự số và chỉ chấp nhận số có 10 số");
            }

            if (!MotSoPhuongThucBoTro.checkSoCMND(txtSCMND.Text))
            {
                flag = false;
                erQMK.SetError(txtSCMND, "Số CMND không được để trống, chỉ chấp nhận kiểu số và dao động từ 10 đến 12 số");
            }

            if (flag)
            {
                bool tontai = false;
                string[] decryptedData = AES128.DecryptFromFile("user.txt");
                foreach (var decryptedString in decryptedData)
                {
                    string[] userPass = decryptedString.Split(' ');
                    string user = userPass[0];
                    string sdt = userPass[2];
                    string soCMND = userPass[3];
                    if ((user == txtUsername.Text) && (sdt == txtSDT.Text) && (soCMND == txtSCMND.Text))
                    {
                        tontai = true;
                    }
                }
                if (tontai)
                {
                    MessageBox.Show("Mật khẩu đã được gửi về SMS.", "Thành công", MessageBoxButtons.OK);
                    btnQuayLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thông tin bạn nhập không có trong dữ liệu hệ thống", "Thất bại", MessageBoxButtons.OK);
                }
            }
        }
    }
}
