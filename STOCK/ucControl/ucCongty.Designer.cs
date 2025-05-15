namespace STOCK.ucControl
{
    partial class ucCongty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_congty = new System.Windows.Forms.Label();
            this.cbb_Congty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lb_congty
            // 
            this.lb_congty.AutoSize = true;
            this.lb_congty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_congty.Location = new System.Drawing.Point(6, 7);
            this.lb_congty.Name = "lb_congty";
            this.lb_congty.Size = new System.Drawing.Size(176, 25);
            this.lb_congty.TabIndex = 13;
            this.lb_congty.Text = " Công ty/Chi nhánh";
            // 
            // cbb_Congty
            // 
            this.cbb_Congty.BackColor = System.Drawing.Color.LightGray;
            this.cbb_Congty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Congty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Congty.FormattingEnabled = true;
            this.cbb_Congty.Location = new System.Drawing.Point(11, 35);
            this.cbb_Congty.Name = "cbb_Congty";
            this.cbb_Congty.Size = new System.Drawing.Size(579, 33);
            this.cbb_Congty.TabIndex = 12;
            // 
            // ucCongty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_congty);
            this.Controls.Add(this.cbb_Congty);
            this.Name = "ucCongty";
            this.Size = new System.Drawing.Size(604, 84);
            this.Load += new System.EventHandler(this.ucCongty_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_congty;
        private System.Windows.Forms.ComboBox cbb_Congty;
    }
}
