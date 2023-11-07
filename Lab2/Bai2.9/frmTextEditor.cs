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
           
        }

       
        private void frmTextEditor_Load(object sender, EventArgs e)
        {
            rtbText.Visible = false;
            mnuFileSave.Visible = false;
            mnuFileMode.Visible = false;
            
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
    }
}
