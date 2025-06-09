namespace STOCK
{
    partial class frmStockMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Barcode = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Baocao = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Tonkho = new System.Windows.Forms.ToolStripButton();
            this.bt_phanquyen = new System.Windows.Forms.ToolStripButton();
            this.bt_dangxuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Thoat = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Barcode,
            this.toolStripButton_Baocao,
            this.toolStripButton_Tonkho,
            this.bt_phanquyen,
            this.bt_dangxuat,
            this.toolStripButton_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1370, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Barcode
            // 
            this.toolStripButton_Barcode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Barcode.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton_Barcode.Image = global::STOCK.Properties.Resources.bar_code;
            this.toolStripButton_Barcode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Barcode.Name = "toolStripButton_Barcode";
            this.toolStripButton_Barcode.Size = new System.Drawing.Size(87, 52);
            this.toolStripButton_Barcode.Text = "Barcode";
            this.toolStripButton_Barcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Barcode.Click += new System.EventHandler(this.toolStripButton_Barcode_Click);
            // 
            // toolStripButton_Baocao
            // 
            this.toolStripButton_Baocao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Baocao.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton_Baocao.Image = global::STOCK.Properties.Resources.report;
            this.toolStripButton_Baocao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Baocao.Name = "toolStripButton_Baocao";
            this.toolStripButton_Baocao.Size = new System.Drawing.Size(85, 52);
            this.toolStripButton_Baocao.Text = "Báo cáo";
            this.toolStripButton_Baocao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Baocao.Click += new System.EventHandler(this.toolStripButton_Baocao_Click);
            // 
            // toolStripButton_Tonkho
            // 
            this.toolStripButton_Tonkho.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton_Tonkho.Image = global::STOCK.Properties.Resources.warehouse;
            this.toolStripButton_Tonkho.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Tonkho.Name = "toolStripButton_Tonkho";
            this.toolStripButton_Tonkho.Size = new System.Drawing.Size(87, 52);
            this.toolStripButton_Tonkho.Text = "Tồn kho";
            this.toolStripButton_Tonkho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Tonkho.Click += new System.EventHandler(this.toolStripButton_Tonkho_Click);
            // 
            // bt_phanquyen
            // 
            this.bt_phanquyen.Image = global::STOCK.Properties.Resources.exchange;
            this.bt_phanquyen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_phanquyen.Name = "bt_phanquyen";
            this.bt_phanquyen.Size = new System.Drawing.Size(118, 52);
            this.bt_phanquyen.Text = "Phân quyền";
            this.bt_phanquyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_phanquyen.Click += new System.EventHandler(this.bt_phanquyen_Click);
            // 
            // bt_dangxuat
            // 
            this.bt_dangxuat.Image = global::STOCK.Properties.Resources.log_out;
            this.bt_dangxuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_dangxuat.Name = "bt_dangxuat";
            this.bt_dangxuat.Size = new System.Drawing.Size(105, 52);
            this.bt_dangxuat.Text = "Đăng xuất";
            this.bt_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_dangxuat.Click += new System.EventHandler(this.bt_dangxuat_Click);
            // 
            // toolStripButton_Thoat
            // 
            this.toolStripButton_Thoat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Thoat.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton_Thoat.Image = global::STOCK.Properties.Resources._switch;
            this.toolStripButton_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Thoat.Name = "toolStripButton_Thoat";
            this.toolStripButton_Thoat.Size = new System.Drawing.Size(66, 52);
            this.toolStripButton_Thoat.Text = "Thoát";
            this.toolStripButton_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Thoat.Click += new System.EventHandler(this.toolStripButton_Thoat_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 662);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 662);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1095, 662);
            this.panel2.TabIndex = 0;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(342, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "QUẢN LÝ BÁN HÀNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(214, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ KHO HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "arrow-down-sign-to-navigate.png");
            this.imageList1.Images.SetKeyName(1, "right-arrow.png");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 717);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Phần mềm quản lý kho hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Barcode;
        private System.Windows.Forms.ToolStripButton toolStripButton_Baocao;
        private System.Windows.Forms.ToolStripButton toolStripButton_Tonkho;
        private System.Windows.Forms.ToolStripButton toolStripButton_Thoat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton bt_dangxuat;
        private System.Windows.Forms.ToolStripButton bt_phanquyen;
    }
}