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
            txtSĐT.Text = "";
        }
    }
}
