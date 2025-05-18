namespace STOCK.ucControl
{
    partial class ucNgay
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
            this.lb_denngay = new System.Windows.Forms.Label();
            this.lb_tungay = new System.Windows.Forms.Label();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lb_denngay
            // 
            this.lb_denngay.AutoSize = true;
            this.lb_denngay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_denngay.Location = new System.Drawing.Point(276, 24);
            this.lb_denngay.Name = "lb_denngay";
            this.lb_denngay.Size = new System.Drawing.Size(92, 25);
            this.lb_denngay.TabIndex = 10;
            this.lb_denngay.Text = "Đến ngày";
            // 
            // lb_tungay
            // 
            this.lb_tungay.AutoSize = true;
            this.lb_tungay.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tungay.Location = new System.Drawing.Point(13, 24);
            this.lb_tungay.Name = "lb_tungay";
            this.lb_tungay.Size = new System.Drawing.Size(79, 25);
            this.lb_tungay.TabIndex = 9;
            this.lb_tungay.Text = "Từ ngày";
            // 
            // dtp2
            // 
            this.dtp2.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtp2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp2.Location = new System.Drawing.Point(374, 18);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(150, 32);
            this.dtp2.TabIndex = 8;
            this.dtp2.ValueChanged += new System.EventHandler(this.dtp2_ValueChanged);
            // 
            // dtp1
            // 
            this.dtp1.CalendarMonthBackground = System.Drawing.Color.LightGray;
            this.dtp1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp1.Location = new System.Drawing.Point(98, 18);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(150, 32);
            this.dtp1.TabIndex = 7;
            this.dtp1.ValueChanged += new System.EventHandler(this.dtp1_ValueChanged);
            // 
            // ucNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_denngay);
            this.Controls.Add(this.lb_tungay);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Name = "ucNgay";
            this.Size = new System.Drawing.Size(552, 68);
            this.Load += new System.EventHandler(this.ucNgay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_denngay;
        private System.Windows.Forms.Label lb_tungay;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}
