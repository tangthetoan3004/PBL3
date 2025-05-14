namespace STOCK
{
    partial class frmHanghoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DISABLED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbb_Nhom = new System.Windows.Forms.ComboBox();
            this.lb_nhom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_trigia = new System.Windows.Forms.TextBox();
            this.checkBox_disabled = new System.Windows.Forms.CheckBox();
            this.cbb_nhacc = new System.Windows.Forms.ComboBox();
            this.cbb_xuatxu = new System.Windows.Forms.ComboBox();
            this.lb_nhacc = new System.Windows.Forms.Label();
            this.lb_xuatxu = new System.Windows.Forms.Label();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.lb_mota = new System.Windows.Forms.Label();
            this.cbb_dvt = new System.Windows.Forms.ComboBox();
            this.lb_dvt = new System.Windows.Forms.Label();
            this.lb_trigia = new System.Windows.Forms.Label();
            this.tb_tentat = new System.Windows.Forms.TextBox();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.lb_tentat = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.lb_barcode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Boqua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Export = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Them,
            this.toolStripButton_Sua,
            this.toolStripButton_Xoa,
            this.toolStripButton_Luu,
            this.toolStripButton_Boqua,
            this.toolStripButton_Export,
            this.toolStripButton_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1584, 55);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1584, 715);
            this.splitContainer1.SplitterDistance = 1173;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DISABLED,
            this.TENHH,
            this.DVT,
            this.DONGIA,
            this.MOTA});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1173, 641);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // DISABLED
            // 
            this.DISABLED.DataPropertyName = "DISABLE";
            this.DISABLED.HeaderText = "DEL";
            this.DISABLED.MinimumWidth = 6;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.ReadOnly = true;
            this.DISABLED.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DISABLED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DISABLED.Width = 50;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "TÊN HÀNG HÓA";
            this.TENHH.MinimumWidth = 6;
            this.TENHH.Name = "TENHH";
            this.TENHH.ReadOnly = true;
            this.TENHH.Width = 300;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "ĐƠN VỊ TÍNH";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 80;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle7;
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Width = 125;
            // 
            // MOTA
            // 
            this.MOTA.DataPropertyName = "MOTA";
            this.MOTA.HeaderText = "MÔ TẢ";
            this.MOTA.MinimumWidth = 6;
            this.MOTA.Name = "MOTA";
            this.MOTA.ReadOnly = true;
            this.MOTA.Width = 530;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbb_Nhom);
            this.panel3.Controls.Add(this.lb_nhom);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1173, 74);
            this.panel3.TabIndex = 0;
            this.panel3.Resize += new System.EventHandler(this.panel3_Resize);
            // 
            // cbb_Nhom
            // 
            this.cbb_Nhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Nhom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Nhom.FormattingEnabled = true;
            this.cbb_Nhom.Location = new System.Drawing.Point(221, 21);
            this.cbb_Nhom.Name = "cbb_Nhom";
            this.cbb_Nhom.Size = new System.Drawing.Size(778, 33);
            this.cbb_Nhom.TabIndex = 2;
            this.cbb_Nhom.SelectedIndexChanged += new System.EventHandler(this.cbb_Nhom_SelectedIndexChanged);
            // 
            // lb_nhom
            // 
            this.lb_nhom.AutoSize = true;
            this.lb_nhom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhom.Location = new System.Drawing.Point(132, 25);
            this.lb_nhom.Name = "lb_nhom";
            this.lb_nhom.Size = new System.Drawing.Size(74, 25);
            this.lb_nhom.TabIndex = 1;
            this.lb_nhom.Text = "NHÓM";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tb_trigia);
            this.panel2.Controls.Add(this.checkBox_disabled);
            this.panel2.Controls.Add(this.cbb_nhacc);
            this.panel2.Controls.Add(this.cbb_xuatxu);
            this.panel2.Controls.Add(this.lb_nhacc);
            this.panel2.Controls.Add(this.lb_xuatxu);
            this.panel2.Controls.Add(this.tb_mota);
            this.panel2.Controls.Add(this.lb_mota);
            this.panel2.Controls.Add(this.cbb_dvt);
            this.panel2.Controls.Add(this.lb_dvt);
            this.panel2.Controls.Add(this.lb_trigia);
            this.panel2.Controls.Add(this.tb_tentat);
            this.panel2.Controls.Add(this.tb_ten);
            this.panel2.Controls.Add(this.lb_tentat);
            this.panel2.Controls.Add(this.lb_ten);
            this.panel2.Controls.Add(this.tb_barcode);
            this.panel2.Controls.Add(this.lb_barcode);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 671);
            this.panel2.TabIndex = 5;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // tb_trigia
            // 
            this.tb_trigia.BackColor = System.Drawing.SystemColors.Control;
            this.tb_trigia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_trigia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_trigia.Location = new System.Drawing.Point(109, 221);
            this.tb_trigia.Name = "tb_trigia";
            this.tb_trigia.Size = new System.Drawing.Size(320, 32);
            this.tb_trigia.TabIndex = 31;
            // 
            // checkBox_disabled
            // 
            this.checkBox_disabled.AutoSize = true;
            this.checkBox_disabled.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_disabled.Location = new System.Drawing.Point(253, 634);
            this.checkBox_disabled.Name = "checkBox_disabled";
            this.checkBox_disabled.Size = new System.Drawing.Size(107, 29);
            this.checkBox_disabled.TabIndex = 30;
            this.checkBox_disabled.Text = "Disabled";
            this.checkBox_disabled.UseVisualStyleBackColor = true;
            // 
            // cbb_nhacc
            // 
            this.cbb_nhacc.BackColor = System.Drawing.Color.LightGray;
            this.cbb_nhacc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_nhacc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nhacc.FormattingEnabled = true;
            this.cbb_nhacc.Location = new System.Drawing.Point(109, 425);
            this.cbb_nhacc.Name = "cbb_nhacc";
            this.cbb_nhacc.Size = new System.Drawing.Size(320, 33);
            this.cbb_nhacc.TabIndex = 29;
            // 
            // cbb_xuatxu
            // 
            this.cbb_xuatxu.BackColor = System.Drawing.Color.LightGray;
            this.cbb_xuatxu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_xuatxu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_xuatxu.FormattingEnabled = true;
            this.cbb_xuatxu.Location = new System.Drawing.Point(109, 363);
            this.cbb_xuatxu.Name = "cbb_xuatxu";
            this.cbb_xuatxu.Size = new System.Drawing.Size(320, 33);
            this.cbb_xuatxu.TabIndex = 28;
            // 
            // lb_nhacc
            // 
            this.lb_nhacc.AutoSize = true;
            this.lb_nhacc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhacc.Location = new System.Drawing.Point(-26, 425);
            this.lb_nhacc.Name = "lb_nhacc";
            this.lb_nhacc.Size = new System.Drawing.Size(129, 25);
            this.lb_nhacc.TabIndex = 27;
            this.lb_nhacc.Text = "Nhà cung cấp";
            // 
            // lb_xuatxu
            // 
            this.lb_xuatxu.AutoSize = true;
            this.lb_xuatxu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xuatxu.Location = new System.Drawing.Point(15, 363);
            this.lb_xuatxu.Name = "lb_xuatxu";
            this.lb_xuatxu.Size = new System.Drawing.Size(75, 25);
            this.lb_xuatxu.TabIndex = 26;
            this.lb_xuatxu.Text = "Xuất xứ";
            // 
            // tb_mota
            // 
            this.tb_mota.BackColor = System.Drawing.SystemColors.Control;
            this.tb_mota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mota.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mota.Location = new System.Drawing.Point(109, 476);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(320, 152);
            this.tb_mota.TabIndex = 25;
            // 
            // lb_mota
            // 
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(29, 478);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(61, 25);
            this.lb_mota.TabIndex = 24;
            this.lb_mota.Text = "Mô tả";
            // 
            // cbb_dvt
            // 
            this.cbb_dvt.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_dvt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dvt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_dvt.FormattingEnabled = true;
            this.cbb_dvt.Location = new System.Drawing.Point(109, 288);
            this.cbb_dvt.Name = "cbb_dvt";
            this.cbb_dvt.Size = new System.Drawing.Size(320, 33);
            this.cbb_dvt.TabIndex = 23;
            // 
            // lb_dvt
            // 
            this.lb_dvt.AutoSize = true;
            this.lb_dvt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dvt.Location = new System.Drawing.Point(22, 291);
            this.lb_dvt.Name = "lb_dvt";
            this.lb_dvt.Size = new System.Drawing.Size(47, 25);
            this.lb_dvt.TabIndex = 22;
            this.lb_dvt.Text = "ĐVT";
            // 
            // lb_trigia
            // 
            this.lb_trigia.AutoSize = true;
            this.lb_trigia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trigia.Location = new System.Drawing.Point(22, 224);
            this.lb_trigia.Name = "lb_trigia";
            this.lb_trigia.Size = new System.Drawing.Size(63, 25);
            this.lb_trigia.TabIndex = 21;
            this.lb_trigia.Text = "Trị giá";
            // 
            // tb_tentat
            // 
            this.tb_tentat.BackColor = System.Drawing.SystemColors.Control;
            this.tb_tentat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tentat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tentat.Location = new System.Drawing.Point(109, 159);
            this.tb_tentat.Name = "tb_tentat";
            this.tb_tentat.Size = new System.Drawing.Size(320, 32);
            this.tb_tentat.TabIndex = 20;
            // 
            // tb_ten
            // 
            this.tb_ten.BackColor = System.Drawing.SystemColors.Control;
            this.tb_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten.Location = new System.Drawing.Point(109, 97);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(320, 32);
            this.tb_ten.TabIndex = 19;
            // 
            // lb_tentat
            // 
            this.lb_tentat.AutoSize = true;
            this.lb_tentat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tentat.Location = new System.Drawing.Point(22, 162);
            this.lb_tentat.Name = "lb_tentat";
            this.lb_tentat.Size = new System.Drawing.Size(68, 25);
            this.lb_tentat.TabIndex = 18;
            this.lb_tentat.Text = "Tên tắt";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(22, 101);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(46, 25);
            this.lb_ten.TabIndex = 17;
            this.lb_ten.Text = "Tên ";
            // 
            // tb_barcode
            // 
            this.tb_barcode.BackColor = System.Drawing.SystemColors.Control;
            this.tb_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_barcode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barcode.Location = new System.Drawing.Point(109, 42);
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(320, 32);
            this.tb_barcode.TabIndex = 16;
            // 
            // lb_barcode
            // 
            this.lb_barcode.AutoSize = true;
            this.lb_barcode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_barcode.Location = new System.Drawing.Point(22, 45);
            this.lb_barcode.Name = "lb_barcode";
            this.lb_barcode.Size = new System.Drawing.Size(81, 25);
            this.lb_barcode.TabIndex = 15;
            this.lb_barcode.Text = "Barcode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(612, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = ".";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_thongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 44);
            this.panel1.TabIndex = 4;
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtin.Location = new System.Drawing.Point(23, 13);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(187, 25);
            this.lb_thongtin.TabIndex = 0;
            this.lb_thongtin.Text = "Thông tin hàng hóa";
            // 
            // toolStripButton_Them
            // 
            this.toolStripButton_Them.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Them.Image = global::STOCK.Properties.Resources.plus;
            this.toolStripButton_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Them.Name = "toolStripButton_Them";
            this.toolStripButton_Them.Size = new System.Drawing.Size(64, 52);
            this.toolStripButton_Them.Text = "Thêm";
            this.toolStripButton_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Them.Click += new System.EventHandler(this.toolStripButton_Them_Click);
            // 
            // toolStripButton_Sua
            // 
            this.toolStripButton_Sua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Sua.Image = global::STOCK.Properties.Resources.update;
            this.toolStripButton_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sua.Name = "toolStripButton_Sua";
            this.toolStripButton_Sua.Size = new System.Drawing.Size(49, 52);
            this.toolStripButton_Sua.Text = "Sửa";
            this.toolStripButton_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Sua.Click += new System.EventHandler(this.toolStripButton_Sua_Click);
            // 
            // toolStripButton_Xoa
            // 
            this.toolStripButton_Xoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Xoa.Image = global::STOCK.Properties.Resources.trash;
            this.toolStripButton_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Xoa.Name = "toolStripButton_Xoa";
            this.toolStripButton_Xoa.Size = new System.Drawing.Size(50, 52);
            this.toolStripButton_Xoa.Text = "Xóa";
            this.toolStripButton_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Xoa.Click += new System.EventHandler(this.toolStripButton_Xoa_Click);
            // 
            // toolStripButton_Luu
            // 
            this.toolStripButton_Luu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Luu.Image = global::STOCK.Properties.Resources.diskette;
            this.toolStripButton_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Luu.Name = "toolStripButton_Luu";
            this.toolStripButton_Luu.Size = new System.Drawing.Size(48, 52);
            this.toolStripButton_Luu.Text = "Lưu";
            this.toolStripButton_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Luu.Click += new System.EventHandler(this.toolStripButton_Luu_Click);
            // 
            // toolStripButton_Boqua
            // 
            this.toolStripButton_Boqua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripButton_Boqua.Image = global::STOCK.Properties.Resources.fast_forward_button;
            this.toolStripButton_Boqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Boqua.Name = "toolStripButton_Boqua";
            this.toolStripButton_Boqua.Size = new System.Drawing.Size(77, 52);
            this.toolStripButton_Boqua.Text = "Bỏ qua";
            this.toolStripButton_Boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Boqua.Click += new System.EventHandler(this.toolStripButton_Boqua_Click);
            // 
            // toolStripButton_Export
            // 
            this.toolStripButton_Export.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            // frmHanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 770);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmHanghoa";
            this.Text = "Danh mục hàng hóa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHanghoa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Them;
        private System.Windows.Forms.ToolStripButton toolStripButton_Sua;
        private System.Windows.Forms.ToolStripButton toolStripButton_Xoa;
        private System.Windows.Forms.ToolStripButton toolStripButton_Luu;
        private System.Windows.Forms.ToolStripButton toolStripButton_Boqua;
        private System.Windows.Forms.ToolStripButton toolStripButton_Thoat;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_thongtin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbb_Nhom;
        private System.Windows.Forms.Label lb_nhom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_trigia;
        private System.Windows.Forms.TextBox tb_tentat;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.Label lb_tentat;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.Label lb_barcode;
        private System.Windows.Forms.CheckBox checkBox_disabled;
        private System.Windows.Forms.ComboBox cbb_nhacc;
        private System.Windows.Forms.ComboBox cbb_xuatxu;
        private System.Windows.Forms.Label lb_nhacc;
        private System.Windows.Forms.Label lb_xuatxu;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.ComboBox cbb_dvt;
        private System.Windows.Forms.Label lb_dvt;
        private System.Windows.Forms.TextBox tb_trigia;
        private System.Windows.Forms.ToolStripButton toolStripButton_Export;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DISABLED;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTA;
    }
}