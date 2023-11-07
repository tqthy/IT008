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
    public partial class frmTextEditor : Form
    {    
        public frmTextEditor()
        {
            InitializeComponent();
        }

        private void frmTextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (rtbText.Visible)
            {
                if (!MotSoPhuongThucBoTro.CompareContentWithFile(pathOpen, rtbText.Text))
                {
                    DialogResult result = MessageBox.Show("Bạn quên lưu file rùi nè, bấm yes để lưu nào!", ">.<", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        mnuFileSave_Click(sender, e);
                    }
                }
            }
        }

       
        private void frmTextEditor_Load(object sender, EventArgs e)
        {
            rtbText.Visible = false;
            mnuFileSave.Visible = false;
            mnuFileMode.Visible = false;
            mnuFileClose.Visible = false;
        }


        string pathOpen = "";
        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "File text|*.txt";//chỉ cho mở file .txt thôi
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pathOpen = ofd.FileName;
                    //mặc định mở ra là ở chế độ đọc
                    using (FileStream fStream = new FileStream(pathOpen, FileMode.Open, FileAccess.Read))
                    {
                        using (StreamReader sr = new StreamReader(fStream))
                        {
                            rtbText.Visible = true;
                            rtbText.Text = sr.ReadToEnd();
                            rtbText.ReadOnly = true;

                            //mở xong thì cho phép chọn FileMode
                            mnuFileMode.Visible=true;
                            //mở xong thì menu save hiện,close hiện
                            mnuFileSave.Visible=true;
                            mnuFileClose.Visible = true;
                        }
                    }
                }
            }
        }


        public static string fileName = "";
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            frmTenFile frm =new frmTenFile(this);
        
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn thư mục đã chọn
                    string folderPath = folderBrowserDialog.SelectedPath;

                    frm.ShowDialog();//hiện form để nhập tên file

                    // Đường dẫn đầy đủ đến file mới
                    string filePath = Path.Combine(folderPath, fileName);

                   
                    if (!File.Exists(filePath))
                    {
                        using(FileStream fStream =new FileStream(filePath,FileMode.Create))
                        MessageBox.Show($"File '{fileName}' đã được tạo tại '{folderPath}'");
                    }
                    else
                    {
                        MessageBox.Show($"File '{fileName}' đã tồn tại.");
                    }
                }
            }
        }

        private void frmTextEditor_Shown(object sender, EventArgs e)
        {

            using (frmDangNhap frm = new frmDangNhap(this))
            {
                frm.ShowDialog();
            }
        }

        private void mnuFileModeRead_Click(object sender, EventArgs e)
        {
            if (rtbText.Visible == true)
            {
                rtbText.ReadOnly = true;
            }
        }

        private void mnuFileModeWrite_Click(object sender, EventArgs e)
        {
            if(rtbText.Visible == true)
            {
                rtbText.ReadOnly = false;
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            using(FileStream fStream = new FileStream(pathOpen, FileMode.Create, FileAccess.Write))//tạm thời này ik,lười tối ưu quá
            {
                using (StreamWriter sw = new StreamWriter(fStream))
                {
                    sw.Write(rtbText.Text);
                }
            }
        }

        private void mnuFileClose_Click(object sender, EventArgs e)
        {
            if (!MotSoPhuongThucBoTro.CompareContentWithFile(pathOpen, rtbText.Text))
            {
                DialogResult result = MessageBox.Show("Bạn quên lưu file rùi nè, bạn có muốn lưu hông?", ">.<", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    mnuFileSave_Click(sender, e);
                }
            }
            rtbText.Visible = false;
            rtbText.ReadOnly = true;
            mnuFileClose.Visible = false;
            mnuFileMode.Visible = false;
        }
    }
}
