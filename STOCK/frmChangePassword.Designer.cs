namespace STOCK
{
    partial class frmChangePassword
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
            this.txtMKCu = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtMKMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhaplaiMK = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_doimatkhau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_mkmoi = new System.Windows.Forms.Label();
            this.lb_khongdungmkcu = new System.Windows.Forms.Label();
            this.lb_khongtrungmk = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMKCu
            // 
            this.txtMKCu.BackColor = System.Drawing.Color.Azure;
            this.txtMKCu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKCu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKCu.Location = new System.Drawing.Point(275, 37);
            this.txtMKCu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMKCu.Name = "txtMKCu";
            this.txtMKCu.Size = new System.Drawing.Size(408, 34);
            this.txtMKCu.TabIndex = 17;
            this.txtMKCu.UseSystemPasswordChar = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(19, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(119, 28);
            this.label.TabIndex = 13;
            this.label.Text = "Mật khẩu cũ";
            // 
            // txtMKMoi
            // 
            this.txtMKMoi.BackColor = System.Drawing.Color.Azure;
            this.txtMKMoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMKMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMKMoi.Location = new System.Drawing.Point(275, 94);
            this.txtMKMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMKMoi.Name = "txtMKMoi";
            this.txtMKMoi.Size = new System.Drawing.Size(408, 34);
            this.txtMKMoi.TabIndex = 19;
            this.txtMKMoi.UseSystemPasswordChar = true;
            this.txtMKMoi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtNhaplaiMK
            // 
            this.txtNhaplaiMK.BackColor = System.Drawing.Color.Azure;
            this.txtNhaplaiMK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhaplaiMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaplaiMK.Location = new System.Drawing.Point(275, 156);
            this.txtNhaplaiMK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhaplaiMK.Name = "txtNhaplaiMK";
            this.txtNhaplaiMK.Size = new System.Drawing.Size(408, 34);
            this.txtNhaplaiMK.TabIndex = 21;
            this.txtNhaplaiMK.UseSystemPasswordChar = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(174, 227);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(126, 43);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nhập lại mật khẩu mới";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(433, 227);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(126, 43);
            this.btnDong.TabIndex = 26;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.lb_doimatkhau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(731, 49);
            this.panel2.TabIndex = 27;
            // 
            // lb_doimatkhau
            // 
            this.lb_doimatkhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_doimatkhau.AutoSize = true;
            this.lb_doimatkhau.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_doimatkhau.ForeColor = System.Drawing.Color.Blue;
            this.lb_doimatkhau.Location = new System.Drawing.Point(18, 9);
            this.lb_doimatkhau.Name = "lb_doimatkhau";
            this.lb_doimatkhau.Size = new System.Drawing.Size(159, 31);
            this.lb_doimatkhau.TabIndex = 0;
            this.lb_doimatkhau.Text = "Đổi mật khẩu";
            this.lb_doimatkhau.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.lb_mkmoi);
            this.panel1.Controls.Add(this.lb_khongdungmkcu);
            this.panel1.Controls.Add(this.lb_khongtrungmk);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.txtNhaplaiMK);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMKMoi);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.txtMKCu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 314);
            this.panel1.TabIndex = 24;
            // 
            // lb_mkmoi
            // 
            this.lb_mkmoi.AutoSize = true;
            this.lb_mkmoi.BackColor = System.Drawing.SystemColors.Control;
            this.lb_mkmoi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mkmoi.ForeColor = System.Drawing.Color.Red;
            this.lb_mkmoi.Location = new System.Drawing.Point(271, 130);
            this.lb_mkmoi.Name = "lb_mkmoi";
            this.lb_mkmoi.Size = new System.Drawing.Size(0, 19);
            this.lb_mkmoi.TabIndex = 29;
            // 
            // lb_khongdungmkcu
            // 
            this.lb_khongdungmkcu.AutoSize = true;
            this.lb_khongdungmkcu.BackColor = System.Drawing.SystemColors.Control;
            this.lb_khongdungmkcu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khongdungmkcu.ForeColor = System.Drawing.Color.Red;
            this.lb_khongdungmkcu.Location = new System.Drawing.Point(271, 73);
            this.lb_khongdungmkcu.Name = "lb_khongdungmkcu";
            this.lb_khongdungmkcu.Size = new System.Drawing.Size(0, 19);
            this.lb_khongdungmkcu.TabIndex = 28;
            // 
            // lb_khongtrungmk
            // 
            this.lb_khongtrungmk.AutoSize = true;
            this.lb_khongtrungmk.BackColor = System.Drawing.SystemColors.Control;
            this.lb_khongtrungmk.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khongtrungmk.ForeColor = System.Drawing.Color.Red;
            this.lb_khongtrungmk.Location = new System.Drawing.Point(271, 192);
            this.lb_khongtrungmk.Name = "lb_khongtrungmk";
            this.lb_khongtrungmk.Size = new System.Drawing.Size(0, 19);
            this.lb_khongtrungmk.TabIndex = 27;
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 357);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmChangePassword";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMKCu;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtMKMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhaplaiMK;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_doimatkhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_khongtrungmk;
        private System.Windows.Forms.Label lb_khongdungmkcu;
        private System.Windows.Forms.Label lb_mkmoi;
    }
}