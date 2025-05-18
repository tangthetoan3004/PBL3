namespace STOCK
{
    partial class frmPrintBarcode
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
            this.cbb_nhom = new System.Windows.Forms.ComboBox();
            this.lb_nhom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.bt_find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMAGE = new System.Windows.Forms.DataGridViewImageColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linqInstantFeedbackSource1 = new DevExpress.Data.Linq.LinqInstantFeedbackSource();
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
            this.toolStrip1.Size = new System.Drawing.Size(1047, 55);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Export
            // 
            this.toolStripButton_Export.Image = global::STOCK.Properties.Resources.printer;
            this.toolStripButton_Export.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Export.Name = "toolStripButton_Export";
            this.toolStripButton_Export.Size = new System.Drawing.Size(57, 52);
            this.toolStripButton_Export.Text = "Print";
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
            this.panel1.Controls.Add(this.cbb_nhom);
            this.panel1.Controls.Add(this.lb_nhom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 62);
            this.panel1.TabIndex = 7;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // cbb_nhom
            // 
            this.cbb_nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nhom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nhom.FormattingEnabled = true;
            this.cbb_nhom.Location = new System.Drawing.Point(260, 11);
            this.cbb_nhom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_nhom.Name = "cbb_nhom";
            this.cbb_nhom.Size = new System.Drawing.Size(596, 33);
            this.cbb_nhom.TabIndex = 0;
            this.cbb_nhom.SelectedIndexChanged += new System.EventHandler(this.cbb_nhom_SelectedIndexChanged);
            // 
            // lb_nhom
            // 
            this.lb_nhom.AutoSize = true;
            this.lb_nhom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhom.Location = new System.Drawing.Point(137, 14);
            this.lb_nhom.Name = "lb_nhom";
            this.lb_nhom.Size = new System.Drawing.Size(112, 25);
            this.lb_nhom.TabIndex = 1;
            this.lb_nhom.Text = "Nhóm hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tb_find);
            this.panel2.Controls.Add(this.bt_find);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 54);
            this.panel2.TabIndex = 8;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // tb_find
            // 
            this.tb_find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_find.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_find.Location = new System.Drawing.Point(508, 12);
            this.tb_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(414, 27);
            this.tb_find.TabIndex = 1;
            this.tb_find.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_find_KeyPress);
            // 
            // bt_find
            // 
            this.bt_find.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_find.Location = new System.Drawing.Point(938, 8);
            this.bt_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(92, 30);
            this.bt_find.TabIndex = 2;
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
            this.IMAGE,
            this.TENHH,
            this.TENTAT,
            this.DONGIA,
            this.SOTEM});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 442);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // BARCODE
            // 
            this.BARCODE.DataPropertyName = "BARCODE";
            this.BARCODE.HeaderText = "BARCODE";
            this.BARCODE.MinimumWidth = 8;
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Width = 175;
            // 
            // IMAGE
            // 
            this.IMAGE.HeaderText = "IMAGE";
            this.IMAGE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.IMAGE.MinimumWidth = 6;
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IMAGE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IMAGE.Width = 125;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "TÊN HÀNG HÓA";
            this.TENHH.MinimumWidth = 8;
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 400;
            // 
            // TENTAT
            // 
            this.TENTAT.DataPropertyName = "TENTAT";
            this.TENTAT.HeaderText = "TÊN TẮT";
            this.TENTAT.MinimumWidth = 8;
            this.TENTAT.Name = "TENTAT";
            this.TENTAT.Width = 225;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.MinimumWidth = 8;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 150;
            // 
            // SOTEM
            // 
            this.SOTEM.DataPropertyName = "SOTEM";
            this.SOTEM.HeaderText = "SỐ TEM";
            this.SOTEM.MinimumWidth = 6;
            this.SOTEM.Name = "SOTEM";
            this.SOTEM.Width = 50;
            // 
            // frmPrintBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 613);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPrintBarcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Barcode";
            this.Load += new System.EventHandler(this.frmPrintBarcode_Load);
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
        private System.Windows.Forms.ComboBox cbb_nhom;
        private System.Windows.Forms.Label lb_nhom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewImageColumn IMAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTEM;
        private DevExpress.Data.Linq.LinqInstantFeedbackSource linqInstantFeedbackSource1;
    }
}