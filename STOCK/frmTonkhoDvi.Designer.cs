namespace STOCK
{
    partial class frmTonkhoDvi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Export = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Thoat = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_xem = new System.Windows.Forms.Button();
            this.cbb_congty = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.lb_congty = new System.Windows.Forms.Label();
            this.lb_dtp = new System.Windows.Forms.Label();
            this.lb_donvi = new System.Windows.Forms.Label();
            this.cbb_donvi = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.bt_find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LG_DAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LG_NHAPMUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LG_NHAPNB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LG_XUATNB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LG_XUATSI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LG_BANLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LG_CUOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEN_CUOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Export,
            this.toolStripButton_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1403, 55);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Export
            // 
            this.toolStripButton_Export.Image = global::STOCK.Properties.Resources.excel;
            this.toolStripButton_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Export.Name = "toolStripButton_Export";
            this.toolStripButton_Export.Size = new System.Drawing.Size(73, 52);
            this.toolStripButton_Export.Text = "Export";
            this.toolStripButton_Export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Export.Click += new System.EventHandler(this.toolStripButton_Export_Click);
            // 
            // toolStripButton_Thoat
            // 
            this.toolStripButton_Thoat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Thoat.Image = global::STOCK.Properties.Resources.exit;
            this.toolStripButton_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Thoat.Name = "toolStripButton_Thoat";
            this.toolStripButton_Thoat.Size = new System.Drawing.Size(66, 52);
            this.toolStripButton_Thoat.Text = "Thoát";
            this.toolStripButton_Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Thoat.Click += new System.EventHandler(this.toolStripButton_Thoat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbb_donvi);
            this.panel1.Controls.Add(this.lb_donvi);
            this.panel1.Controls.Add(this.bt_xem);
            this.panel1.Controls.Add(this.cbb_congty);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.lb_congty);
            this.panel1.Controls.Add(this.lb_dtp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 118);
            this.panel1.TabIndex = 7;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // bt_xem
            // 
            this.bt_xem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xem.Location = new System.Drawing.Point(1209, 10);
            this.bt_xem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(108, 82);
            this.bt_xem.TabIndex = 4;
            this.bt_xem.Text = "Xem";
            this.bt_xem.UseVisualStyleBackColor = true;
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click);
            // 
            // cbb_congty
            // 
            this.cbb_congty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_congty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_congty.FormattingEnabled = true;
            this.cbb_congty.Location = new System.Drawing.Point(559, 11);
            this.cbb_congty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_congty.Name = "cbb_congty";
            this.cbb_congty.Size = new System.Drawing.Size(596, 33);
            this.cbb_congty.TabIndex = 3;
            this.cbb_congty.SelectedIndexChanged += new System.EventHandler(this.cbb_congty_SelectedIndexChanged);
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(116, 10);
            this.dtp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(195, 32);
            this.dtp.TabIndex = 2;
            // 
            // lb_congty
            // 
            this.lb_congty.AutoSize = true;
            this.lb_congty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_congty.Location = new System.Drawing.Point(365, 14);
            this.lb_congty.Name = "lb_congty";
            this.lb_congty.Size = new System.Drawing.Size(171, 25);
            this.lb_congty.TabIndex = 1;
            this.lb_congty.Text = "Công ty/Chi nhánh";
            // 
            // lb_dtp
            // 
            this.lb_dtp.AutoSize = true;
            this.lb_dtp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dtp.Location = new System.Drawing.Point(23, 14);
            this.lb_dtp.Name = "lb_dtp";
            this.lb_dtp.Size = new System.Drawing.Size(85, 25);
            this.lb_dtp.TabIndex = 0;
            this.lb_dtp.Text = " Chọn kỳ";
            // 
            // lb_donvi
            // 
            this.lb_donvi.AutoSize = true;
            this.lb_donvi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_donvi.Location = new System.Drawing.Point(365, 63);
            this.lb_donvi.Name = "lb_donvi";
            this.lb_donvi.Size = new System.Drawing.Size(66, 25);
            this.lb_donvi.TabIndex = 5;
            this.lb_donvi.Text = "Đơn vị";
            // 
            // cbb_donvi
            // 
            this.cbb_donvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_donvi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_donvi.FormattingEnabled = true;
            this.cbb_donvi.Location = new System.Drawing.Point(559, 60);
            this.cbb_donvi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_donvi.Name = "cbb_donvi";
            this.cbb_donvi.Size = new System.Drawing.Size(596, 33);
            this.cbb_donvi.TabIndex = 6;
            this.cbb_donvi.SelectedIndexChanged += new System.EventHandler(this.vbb_donvi_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tb_find);
            this.panel2.Controls.Add(this.bt_find);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 173);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1403, 54);
            this.panel2.TabIndex = 8;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // tb_find
            // 
            this.tb_find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_find.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_find.Location = new System.Drawing.Point(851, 12);
            this.tb_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(414, 27);
            this.tb_find.TabIndex = 6;
            // 
            // bt_find
            // 
            this.bt_find.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_find.Location = new System.Drawing.Point(1281, 8);
            this.bt_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(92, 30);
            this.bt_find.TabIndex = 5;
            this.bt_find.Text = "Find";
            this.bt_find.UseVisualStyleBackColor = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BARCODE,
            this.TENHH,
            this.DVT,
            this.LG_DAU,
            this.LG_NHAPMUA,
            this.LG_NHAPNB,
            this.LG_XUATNB,
            this.LG_XUATSI,
            this.LG_BANLE,
            this.LG_CUOI,
            this.DONGIA,
            this.TIEN_CUOI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1403, 295);
            this.dataGridView1.TabIndex = 9;
            // 
            // BARCODE
            // 
            this.BARCODE.DataPropertyName = "BARCODE";
            this.BARCODE.HeaderText = "BARCODE";
            this.BARCODE.MinimumWidth = 8;
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Width = 175;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "TÊN HÀNG HÓA";
            this.TENHH.MinimumWidth = 8;
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 400;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "ĐVT";
            this.DVT.MinimumWidth = 8;
            this.DVT.Name = "DVT";
            this.DVT.Width = 50;
            // 
            // LG_DAU
            // 
            this.LG_DAU.DataPropertyName = "LG_DAU";
            this.LG_DAU.HeaderText = "TỒN ĐẦU";
            this.LG_DAU.MinimumWidth = 8;
            this.LG_DAU.Name = "LG_DAU";
            this.LG_DAU.Width = 60;
            // 
            // LG_NHAPMUA
            // 
            this.LG_NHAPMUA.DataPropertyName = "LG_NHAPMUA";
            this.LG_NHAPMUA.HeaderText = "NHẬP MUA";
            this.LG_NHAPMUA.MinimumWidth = 8;
            this.LG_NHAPMUA.Name = "LG_NHAPMUA";
            this.LG_NHAPMUA.Width = 60;
            // 
            // LG_NHAPNB
            // 
            this.LG_NHAPNB.DataPropertyName = "LG_NHAPNB";
            this.LG_NHAPNB.HeaderText = "NHẬP NỘI BỘ";
            this.LG_NHAPNB.MinimumWidth = 8;
            this.LG_NHAPNB.Name = "LG_NHAPNB";
            this.LG_NHAPNB.Width = 60;
            // 
            // LG_XUATNB
            // 
            this.LG_XUATNB.DataPropertyName = "LG_XUATNB";
            this.LG_XUATNB.HeaderText = "XUẤT NỘI BỘ";
            this.LG_XUATNB.MinimumWidth = 8;
            this.LG_XUATNB.Name = "LG_XUATNB";
            this.LG_XUATNB.Width = 60;
            // 
            // LG_XUATSI
            // 
            this.LG_XUATSI.DataPropertyName = "LG_XUATSI";
            this.LG_XUATSI.HeaderText = "XUẤT SỈ";
            this.LG_XUATSI.MinimumWidth = 8;
            this.LG_XUATSI.Name = "LG_XUATSI";
            this.LG_XUATSI.Width = 60;
            // 
            // LG_BANLE
            // 
            this.LG_BANLE.DataPropertyName = "LG_BANLE";
            this.LG_BANLE.HeaderText = "XUẤT BÁN LẺ";
            this.LG_BANLE.MinimumWidth = 8;
            this.LG_BANLE.Name = "LG_BANLE";
            this.LG_BANLE.Width = 60;
            // 
            // LG_CUOI
            // 
            this.LG_CUOI.DataPropertyName = "LG_CUOI";
            this.LG_CUOI.HeaderText = "TỒN CUỐI";
            this.LG_CUOI.MinimumWidth = 8;
            this.LG_CUOI.Name = "LG_CUOI";
            this.LG_CUOI.Width = 60;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "TRIGIA";
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.MinimumWidth = 8;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 150;
            // 
            // TIEN_CUOI
            // 
            this.TIEN_CUOI.DataPropertyName = "TIEN_CUOI";
            this.TIEN_CUOI.HeaderText = "THÀNH TIỀN";
            this.TIEN_CUOI.MinimumWidth = 8;
            this.TIEN_CUOI.Name = "TIEN_CUOI";
            this.TIEN_CUOI.Width = 175;
            // 
            // frmTonkhoDvi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 522);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTonkhoDvi";
            this.Text = "Theo dõi tồn kho đơn vị";
            this.Load += new System.EventHandler(this.frmTonkhoDvi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Export;
        private System.Windows.Forms.ToolStripButton toolStripButton_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_xem;
        private System.Windows.Forms.ComboBox cbb_congty;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label lb_congty;
        private System.Windows.Forms.Label lb_dtp;
        private System.Windows.Forms.Label lb_donvi;
        private System.Windows.Forms.ComboBox cbb_donvi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LG_DAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn LG_NHAPMUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LG_NHAPNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LG_XUATNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn LG_XUATSI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LG_BANLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LG_CUOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEN_CUOI;
    }
}