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
    public partial class frmDanhSachSinhVien : Form
    {
        Form parent;
        public frmDanhSachSinhVien( Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
