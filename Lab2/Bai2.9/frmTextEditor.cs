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
    public partial class frmTextEditor : Form
    {
        Form parent;
        public frmTextEditor(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmTextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
