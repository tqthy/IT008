namespace Bai2._6
{
    partial class frmDanhSachSinhVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lbnhapmssv = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clnMssv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnHoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNgaysinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDiachi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSdt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.BackColor = System.Drawing.Color.SteelBlue;
            this.lblDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSach.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.Color.White;
            this.lblDanhSach.Location = new System.Drawing.Point(0, 0);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(973, 56);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "DANH SÁCH SINH VIÊN";
            this.lblDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbnhapmssv
            // 
            this.lbnhapmssv.BackColor = System.Drawing.Color.White;
            this.lbnhapmssv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbnhapmssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnhapmssv.Location = new System.Drawing.Point(138, 79);
            this.lbnhapmssv.Name = "lbnhapmssv";
            this.lbnhapmssv.Size = new System.Drawing.Size(153, 35);
            this.lbnhapmssv.TabIndex = 1;
            this.lbnhapmssv.Text = "Nhập MSSV ";
            this.lbnhapmssv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmssv
            // 
            this.txtmssv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmssv.Location = new System.Drawing.Point(335, 81);
            this.txtmssv.Multiline = true;
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(326, 33);
            this.txtmssv.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(730, 80);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(122, 34);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDanhSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.Location = new System.Drawing.Point(299, 130);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(387, 37);
            this.btnDanhSach.TabIndex = 4;
            this.btnDanhSach.Text = "Hiển thị toàn bộ danh sách sinh viên";
            this.btnDanhSach.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnMssv,
            this.clnHoten,
            this.clnGioitinh,
            this.clnNgaysinh,
            this.clnDiachi,
            this.clnSdt,
            this.clnEmail});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(973, 310);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clnMssv
            // 
            this.clnMssv.Text = "MSSV";
            this.clnMssv.Width = 97;
            // 
            // clnHoten
            // 
            this.clnHoten.Text = "Họ và tên";
            this.clnHoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnHoten.Width = 116;
            // 
            // clnGioitinh
            // 
            this.clnGioitinh.Text = "Giới tính";
            this.clnGioitinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnGioitinh.Width = 98;
            // 
            // clnNgaysinh
            // 
            this.clnNgaysinh.Text = "Ngày sinh";
            this.clnNgaysinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnNgaysinh.Width = 130;
            // 
            // clnDiachi
            // 
            this.clnDiachi.Text = "Địa chỉ";
            this.clnDiachi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnDiachi.Width = 247;
            // 
            // clnSdt
            // 
            this.clnSdt.Text = "SĐT";
            this.clnSdt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnSdt.Width = 178;
            // 
            // clnEmail
            // 
            this.clnEmail.Text = "Email";
            this.clnEmail.Width = 190;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Location = new System.Drawing.Point(730, 130);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(122, 34);
            this.btnQuayLai.TabIndex = 6;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // frmDanhSachSinhVien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(973, 510);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDanhSach);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.lbnhapmssv);
            this.Controls.Add(this.lblDanhSach);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDanhSachSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lbnhapmssv;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clnMssv;
        private System.Windows.Forms.ColumnHeader clnHoten;
        private System.Windows.Forms.ColumnHeader clnGioitinh;
        private System.Windows.Forms.ColumnHeader clnNgaysinh;
        private System.Windows.Forms.ColumnHeader clnDiachi;
        private System.Windows.Forms.ColumnHeader clnSdt;
        private System.Windows.Forms.ColumnHeader clnEmail;
        private System.Windows.Forms.Button btnQuayLai;
    }
}