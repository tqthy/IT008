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
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result =
                    MessageBox.Show("Bạn có muốn thoát",
                                   "Exit?",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
            
        }

        private void btnTimKiem_DanhSach_Click(object sender, EventArgs e)
        {
            frmDanhSachSinhVien form2 = new frmDanhSachSinhVien(this);
            form2.ShowDialog(this);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemSinhVien form2 = new frmThemSinhVien(this);
            form2.ShowDialog(this); 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmXoaSinhVien form2 = new frmXoaSinhVien(this);
            form2.ShowDialog(this);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmSuaThongTinSinhVien form2 = new frmSuaThongTinSinhVien(this);
            form2.ShowDialog(this);
        }
    }
}
