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
    }
}
