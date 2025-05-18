namespace STOCK
{
    partial class frmChietkhau
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
            this.tb_chietkhau = new System.Windows.Forms.TextBox();
            this.lb_chietkhau = new System.Windows.Forms.Label();
            this.bt_capnhat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_chietkhau
            // 
            this.tb_chietkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_chietkhau.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chietkhau.Location = new System.Drawing.Point(166, 37);
            this.tb_chietkhau.Name = "tb_chietkhau";
            this.tb_chietkhau.Size = new System.Drawing.Size(100, 41);
            this.tb_chietkhau.TabIndex = 0;
            this.tb_chietkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_chietkhau_KeyPress);
            // 
            // lb_chietkhau
            // 
            this.lb_chietkhau.AutoSize = true;
            this.lb_chietkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chietkhau.Location = new System.Drawing.Point(23, 44);
            this.lb_chietkhau.Name = "lb_chietkhau";
            this.lb_chietkhau.Size = new System.Drawing.Size(137, 28);
            this.lb_chietkhau.TabIndex = 1;
            this.lb_chietkhau.Text = "Chiết khấu (%)";
            // 
            // bt_capnhat
            // 
            this.bt_capnhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_capnhat.Location = new System.Drawing.Point(301, 37);
            this.bt_capnhat.Name = "bt_capnhat";
            this.bt_capnhat.Size = new System.Drawing.Size(129, 41);
            this.bt_capnhat.TabIndex = 1;
            this.bt_capnhat.Text = "Cập nhật";
            this.bt_capnhat.UseVisualStyleBackColor = true;
            this.bt_capnhat.Click += new System.EventHandler(this.bt_capnhat_Click);
            // 
            // frmChietkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 115);
            this.Controls.Add(this.bt_capnhat);
            this.Controls.Add(this.lb_chietkhau);
            this.Controls.Add(this.tb_chietkhau);
            this.Name = "frmChietkhau";
            this.Text = "Chiết khấu";
            this.Load += new System.EventHandler(this.frmChietkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_chietkhau;
        private System.Windows.Forms.Label lb_chietkhau;
        private System.Windows.Forms.Button bt_capnhat;
    }
}