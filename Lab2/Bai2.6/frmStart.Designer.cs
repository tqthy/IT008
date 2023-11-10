namespace Bai2._6
{
    partial class frmStart
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
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.lblTrangchu = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem_DanhSach = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Controls.Add(this.btnTimKiem_DanhSach);
            this.grbChucNang.Location = new System.Drawing.Point(145, 116);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(468, 294);
            this.grbChucNang.TabIndex = 0;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // lblTrangchu
            // 
            this.lblTrangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTrangchu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangchu.Location = new System.Drawing.Point(0, 0);
            this.lblTrangchu.Name = "lblTrangchu";
            this.lblTrangchu.Size = new System.Drawing.Size(739, 84);
            this.lblTrangchu.TabIndex = 1;
            this.lblTrangchu.Text = "Trang chủ";
            this.lblTrangchu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(36, 103);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(396, 46);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTimKiem_DanhSach
            // 
            this.btnTimKiem_DanhSach.Location = new System.Drawing.Point(36, 48);
            this.btnTimKiem_DanhSach.Name = "btnTimKiem_DanhSach";
            this.btnTimKiem_DanhSach.Size = new System.Drawing.Size(396, 46);
            this.btnTimKiem_DanhSach.TabIndex = 0;
            this.btnTimKiem_DanhSach.Text = "Tìm kiếm + Danh sách sinh viên";
            this.btnTimKiem_DanhSach.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(36, 158);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(396, 46);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(36, 213);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(396, 46);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frmStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(739, 443);
            this.Controls.Add(this.lblTrangchu);
            this.Controls.Add(this.grbChucNang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Label lblTrangchu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTimKiem_DanhSach;
    }
}