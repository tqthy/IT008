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
    public partial class frmTenFile : Form
    {
        Form parent;
        
        public frmTenFile(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public frmTenFile()
        {
            InitializeComponent();
        }


        string fileName = "";
        private void btnOk_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!MotSoPhuongThucBoTro.checkFileName(txtTenFile.Text))
            {
                errorProvider1.SetError(txtTenFile, "Tên file chỉ chấp nhận chuỗi chứa ký tự chữ,số");
            }
            else
            {
                fileName = txtTenFile.Text + cboDinhDang.Items[0].ToString();
                frmTextEditor.fileName = fileName;
                Close();
            }
        }

        private void frmTenFile_Load(object sender, EventArgs e)
        {
            cboDinhDang.SelectedIndex = 0;
        }

        private void frmTenFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
