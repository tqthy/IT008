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
    public partial class frmDanhMucTN : Form
    {
        Form parentFrmDanhMucTN;
        public frmDanhMucTN(Form parent)
        {
            parentFrmDanhMucTN = parent;
            InitializeComponent();
        }

        private void frmDanhMucTN_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentFrmDanhMucTN.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemSinhVien frmThemSinhVien = new frmThemSinhVien(this);
            this.Hide();
            frmThemSinhVien.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
