namespace Bai2._9
{
    partial class frmDangKy
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
            this.lblThongBao = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblSoCMND = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtSoCMND = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.erDangKy = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblChuY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.erDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblThongBao
            // 
            this.lblThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblThongBao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.Location = new System.Drawing.Point(0, 0);
            this.lblThongBao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(611, 77);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Vui lòng nhập đầy đủ thông tin dưới đây";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblUsername.Location = new System.Drawing.Point(51, 125);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(174, 35);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPassword.Location = new System.Drawing.Point(51, 192);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(174, 35);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRePassword
            // 
            this.lblRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblRePassword.Location = new System.Drawing.Point(51, 260);
            this.lblRePassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(174, 35);
            this.lblRePassword.TabIndex = 3;
            this.lblRePassword.Text = "Re-Password";
            this.lblRePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblSDT.Location = new System.Drawing.Point(51, 326);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(174, 35);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SĐT";
            this.lblSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoCMND
            // 
            this.lblSoCMND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblSoCMND.Location = new System.Drawing.Point(51, 392);
            this.lblSoCMND.Name = "lblSoCMND";
            this.lblSoCMND.Size = new System.Drawing.Size(174, 35);
            this.lblSoCMND.TabIndex = 5;
            this.lblSoCMND.Text = "Số CMND";
            this.lblSoCMND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(247, 125);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(312, 35);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(247, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(312, 35);
            this.txtPassword.TabIndex = 7;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(247, 260);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(312, 35);
            this.txtRePassword.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(247, 326);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(312, 35);
            this.txtSDT.TabIndex = 9;
            // 
            // txtSoCMND
            // 
            this.txtSoCMND.Location = new System.Drawing.Point(247, 392);
            this.txtSoCMND.Name = "txtSoCMND";
            this.txtSoCMND.Size = new System.Drawing.Size(312, 35);
            this.txtSoCMND.TabIndex = 10;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDangKy.Location = new System.Drawing.Point(111, 469);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(165, 49);
            this.btnDangKy.TabIndex = 11;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // erDangKy
            // 
            this.erDangKy.ContainerControl = this;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQuayLai.Location = new System.Drawing.Point(332, 469);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(165, 49);
            this.btnQuayLai.TabIndex = 12;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblChuY
            // 
            this.lblChuY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblChuY.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblChuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuY.Location = new System.Drawing.Point(0, 543);
            this.lblChuY.Name = "lblChuY";
            this.lblChuY.Size = new System.Drawing.Size(611, 44);
            this.lblChuY.TabIndex = 13;
            this.lblChuY.Text = "Chú ý: Hãy nhớ Username, SĐT và Số CMND của bạn, nó sẽ giúp bạn lấy lại mật khẩu " +
    "sau này";
            this.lblChuY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(611, 587);
            this.ControlBox = false;
            this.Controls.Add(this.lblChuY);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.txtSoCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSoCMND);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblThongBao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangKy_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.erDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblSoCMND;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtSoCMND;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ErrorProvider erDangKy;
        private System.Windows.Forms.Label lblChuY;
        private System.Windows.Forms.Button btnQuayLai;
    }
}