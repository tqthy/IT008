namespace Bai2._6
{
    partial class frmXoaSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.grbLuaChon = new System.Windows.Forms.GroupBox();
            this.txtMSSVOrHoTen = new System.Windows.Forms.TextBox();
            this.rdbMSSV = new System.Windows.Forms.RadioButton();
            this.rdbHoTen = new System.Windows.Forms.RadioButton();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.erNguoiDung = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbLuaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLuaChon
            // 
            this.grbLuaChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grbLuaChon.Controls.Add(this.rdbHoTen);
            this.grbLuaChon.Controls.Add(this.rdbMSSV);
            this.grbLuaChon.Controls.Add(this.txtMSSVOrHoTen);
            this.grbLuaChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLuaChon.Location = new System.Drawing.Point(2, 0);
            this.grbLuaChon.Name = "grbLuaChon";
            this.grbLuaChon.Size = new System.Drawing.Size(383, 214);
            this.grbLuaChon.TabIndex = 0;
            this.grbLuaChon.TabStop = false;
            this.grbLuaChon.Text = "Lựa chọn";
            // 
            // txtMSSVOrHoTen
            // 
            this.txtMSSVOrHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSVOrHoTen.Location = new System.Drawing.Point(156, 89);
            this.txtMSSVOrHoTen.Name = "txtMSSVOrHoTen";
            this.txtMSSVOrHoTen.Size = new System.Drawing.Size(198, 35);
            this.txtMSSVOrHoTen.TabIndex = 2;
            // 
            // rdbMSSV
            // 
            this.rdbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMSSV.Location = new System.Drawing.Point(14, 50);
            this.rdbMSSV.Name = "rdbMSSV";
            this.rdbMSSV.Size = new System.Drawing.Size(114, 33);
            this.rdbMSSV.TabIndex = 3;
            this.rdbMSSV.TabStop = true;
            this.rdbMSSV.Text = "MSSV";
            this.rdbMSSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbMSSV.UseVisualStyleBackColor = true;
            // 
            // rdbHoTen
            // 
            this.rdbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHoTen.Location = new System.Drawing.Point(14, 118);
            this.rdbHoTen.Name = "rdbHoTen";
            this.rdbHoTen.Size = new System.Drawing.Size(114, 33);
            this.rdbHoTen.TabIndex = 4;
            this.rdbHoTen.TabStop = true;
            this.rdbHoTen.Text = "Họ tên";
            this.rdbHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbHoTen.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDongY.Location = new System.Drawing.Point(411, 30);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(132, 53);
            this.btnDongY.TabIndex = 1;
            this.btnDongY.Text = "Đồng  ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnQuayLai.Location = new System.Drawing.Point(411, 111);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(132, 53);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // erNguoiDung
            // 
            this.erNguoiDung.ContainerControl = this;
            // 
            // frmXoaSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(569, 214);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.grbLuaChon);
            this.MaximizeBox = false;
            this.Name = "frmXoaSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa sinh viên";
            this.grbLuaChon.ResumeLayout(false);
            this.grbLuaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLuaChon;
        private System.Windows.Forms.TextBox txtMSSVOrHoTen;
        private System.Windows.Forms.RadioButton rdbHoTen;
        private System.Windows.Forms.RadioButton rdbMSSV;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.ErrorProvider erNguoiDung;
    }
}