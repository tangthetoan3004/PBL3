using System.Windows.Forms;

namespace STOCK
{
    public partial class frmDonVi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Diachi = new System.Windows.Forms.TextBox();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.textBox_Fax = new System.Windows.Forms.TextBox();
            this.lb_fax = new System.Windows.Forms.Label();
            this.textBox_Dienthoai = new System.Windows.Forms.TextBox();
            this.lb_dienthoai = new System.Windows.Forms.Label();
            this.checkBox_Disable = new System.Windows.Forms.CheckBox();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.lb_tendonvi = new System.Windows.Forms.Label();
            this.textBox_MA = new System.Windows.Forms.TextBox();
            this.lb_madonvi = new System.Windows.Forms.Label();
            this.textBox_Kyhieu = new System.Windows.Forms.TextBox();
            this.checkBox_Kho = new System.Windows.Forms.CheckBox();
            this.lb_kyhieu = new System.Windows.Forms.Label();
            this.comboBox_Congty = new System.Windows.Forms.ComboBox();
            this.lb_congty = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.DISABLE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MADV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KHO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.KYHIEU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Boqua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Thoat = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStripButton_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1666, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DISABLE,
            this.MADV,
            this.TENDVI,
            this.DIENTHOAI,
            this.FAX,
            this.EMAIL,
            this.DIACHI,
            this.MACTY,
            this.KHO,
            this.KYHIEU});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1666, 315);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox_Diachi);
            this.panel2.Controls.Add(this.lb_diachi);
            this.panel2.Controls.Add(this.textBox_Email);
            this.panel2.Controls.Add(this.lb_email);
            this.panel2.Controls.Add(this.textBox_Fax);
            this.panel2.Controls.Add(this.lb_fax);
            this.panel2.Controls.Add(this.textBox_Dienthoai);
            this.panel2.Controls.Add(this.lb_dienthoai);
            this.panel2.Controls.Add(this.checkBox_Disable);
            this.panel2.Controls.Add(this.textBox_Ten);
            this.panel2.Controls.Add(this.lb_tendonvi);
            this.panel2.Controls.Add(this.textBox_MA);
            this.panel2.Controls.Add(this.lb_madonvi);
            this.panel2.Controls.Add(this.textBox_Kyhieu);
            this.panel2.Controls.Add(this.checkBox_Kho);
            this.panel2.Controls.Add(this.lb_kyhieu);
            this.panel2.Controls.Add(this.comboBox_Congty);
            this.panel2.Controls.Add(this.lb_congty);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1666, 174);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // textBox_Diachi
            // 
            this.textBox_Diachi.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Diachi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Diachi.Location = new System.Drawing.Point(743, 116);
            this.textBox_Diachi.Name = "textBox_Diachi";
            this.textBox_Diachi.Size = new System.Drawing.Size(853, 32);
            this.textBox_Diachi.TabIndex = 18;
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.Location = new System.Drawing.Point(659, 119);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(70, 25);
            this.lb_diachi.TabIndex = 17;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // textBox_Email
            // 
            this.textBox_Email.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Email.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(976, 69);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(503, 32);
            this.textBox_Email.TabIndex = 16;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(883, 75);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(58, 25);
            this.lb_email.TabIndex = 15;
            this.lb_email.Text = "Email";
            // 
            // textBox_Fax
            // 
            this.textBox_Fax.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Fax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Fax.Location = new System.Drawing.Point(448, 116);
            this.textBox_Fax.Name = "textBox_Fax";
            this.textBox_Fax.Size = new System.Drawing.Size(194, 32);
            this.textBox_Fax.TabIndex = 13;
            // 
            // lb_fax
            // 
            this.lb_fax.AutoSize = true;
            this.lb_fax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fax.Location = new System.Drawing.Point(393, 119);
            this.lb_fax.Name = "lb_fax";
            this.lb_fax.Size = new System.Drawing.Size(39, 25);
            this.lb_fax.TabIndex = 12;
            this.lb_fax.Text = "Fax";
            // 
            // textBox_Dienthoai
            // 
            this.textBox_Dienthoai.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Dienthoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Dienthoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Dienthoai.Location = new System.Drawing.Point(204, 116);
            this.textBox_Dienthoai.Name = "textBox_Dienthoai";
            this.textBox_Dienthoai.Size = new System.Drawing.Size(164, 32);
            this.textBox_Dienthoai.TabIndex = 11;
            // 
            // lb_dienthoai
            // 
            this.lb_dienthoai.AutoSize = true;
            this.lb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dienthoai.Location = new System.Drawing.Point(75, 119);
            this.lb_dienthoai.Name = "lb_dienthoai";
            this.lb_dienthoai.Size = new System.Drawing.Size(99, 25);
            this.lb_dienthoai.TabIndex = 10;
            this.lb_dienthoai.Text = "Điện thoại";
            // 
            // checkBox_Disable
            // 
            this.checkBox_Disable.AutoSize = true;
            this.checkBox_Disable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Disable.Location = new System.Drawing.Point(1489, 74);
            this.checkBox_Disable.Name = "checkBox_Disable";
            this.checkBox_Disable.Size = new System.Drawing.Size(107, 29);
            this.checkBox_Disable.TabIndex = 9;
            this.checkBox_Disable.Text = "Disabled";
            this.checkBox_Disable.UseVisualStyleBackColor = true;
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Ten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ten.Location = new System.Drawing.Point(204, 68);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(594, 32);
            this.textBox_Ten.TabIndex = 8;
            // 
            // lb_tendonvi
            // 
            this.lb_tendonvi.AutoSize = true;
            this.lb_tendonvi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tendonvi.Location = new System.Drawing.Point(75, 71);
            this.lb_tendonvi.Name = "lb_tendonvi";
            this.lb_tendonvi.Size = new System.Drawing.Size(98, 25);
            this.lb_tendonvi.TabIndex = 7;
            this.lb_tendonvi.Text = "Tên đơn vị";
            // 
            // textBox_MA
            // 
            this.textBox_MA.BackColor = System.Drawing.Color.LightGray;
            this.textBox_MA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MA.Location = new System.Drawing.Point(976, 18);
            this.textBox_MA.Name = "textBox_MA";
            this.textBox_MA.Size = new System.Drawing.Size(156, 32);
            this.textBox_MA.TabIndex = 6;
            // 
            // lb_madonvi
            // 
            this.lb_madonvi.AutoSize = true;
            this.lb_madonvi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_madonvi.Location = new System.Drawing.Point(845, 23);
            this.lb_madonvi.Name = "lb_madonvi";
            this.lb_madonvi.Size = new System.Drawing.Size(96, 25);
            this.lb_madonvi.TabIndex = 5;
            this.lb_madonvi.Text = "Mã đơn vị";
            // 
            // textBox_Kyhieu
            // 
            this.textBox_Kyhieu.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Kyhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Kyhieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Kyhieu.Location = new System.Drawing.Point(1357, 18);
            this.textBox_Kyhieu.Name = "textBox_Kyhieu";
            this.textBox_Kyhieu.Size = new System.Drawing.Size(113, 32);
            this.textBox_Kyhieu.TabIndex = 4;
            // 
            // checkBox_Kho
            // 
            this.checkBox_Kho.AutoSize = true;
            this.checkBox_Kho.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Kho.Location = new System.Drawing.Point(1489, 22);
            this.checkBox_Kho.Name = "checkBox_Kho";
            this.checkBox_Kho.Size = new System.Drawing.Size(67, 29);
            this.checkBox_Kho.TabIndex = 3;
            this.checkBox_Kho.Text = "Kho";
            this.checkBox_Kho.UseVisualStyleBackColor = true;
            // 
            // lb_kyhieu
            // 
            this.lb_kyhieu.AutoSize = true;
            this.lb_kyhieu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kyhieu.Location = new System.Drawing.Point(1252, 25);
            this.lb_kyhieu.Name = "lb_kyhieu";
            this.lb_kyhieu.Size = new System.Drawing.Size(73, 25);
            this.lb_kyhieu.TabIndex = 2;
            this.lb_kyhieu.Text = "Ký hiệu";
            // 
            // comboBox_Congty
            // 
            this.comboBox_Congty.BackColor = System.Drawing.Color.LightGray;
            this.comboBox_Congty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Congty.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Congty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Congty.FormattingEnabled = true;
            this.comboBox_Congty.Location = new System.Drawing.Point(204, 20);
            this.comboBox_Congty.Name = "comboBox_Congty";
            this.comboBox_Congty.Size = new System.Drawing.Size(594, 33);
            this.comboBox_Congty.TabIndex = 1;
            // 
            // lb_congty
            // 
            this.lb_congty.AutoSize = true;
            this.lb_congty.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_congty.Location = new System.Drawing.Point(24, 23);
            this.lb_congty.Name = "lb_congty";
            this.lb_congty.Size = new System.Drawing.Size(182, 25);
            this.lb_congty.TabIndex = 0;
            this.lb_congty.Text = "Công ty - Chi nhánh";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_thongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1666, 44);
            this.panel1.TabIndex = 4;
            // 
            // lb_thongtin
            // 
            this.lb_thongtin.AutoSize = true;
            this.lb_thongtin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thongtin.Location = new System.Drawing.Point(23, 13);
            this.lb_thongtin.Name = "lb_thongtin";
            this.lb_thongtin.Size = new System.Drawing.Size(88, 23);
            this.lb_thongtin.TabIndex = 0;
            this.lb_thongtin.Text = "Thông tin";
            // 
            // DISABLE
            // 
            this.DISABLE.DataPropertyName = "DISABLED";
            this.DISABLE.HeaderText = "DEL";
            this.DISABLE.MinimumWidth = 6;
            this.DISABLE.Name = "DISABLE";
            this.DISABLE.ReadOnly = true;
            this.DISABLE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DISABLE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DISABLE.Width = 50;
            // 
            // MADV
            // 
            this.MADV.DataPropertyName = "MADV";
            this.MADV.HeaderText = "MÃ ĐƠN VỊ";
            this.MADV.MinimumWidth = 6;
            this.MADV.Name = "MADV";
            this.MADV.ReadOnly = true;
            this.MADV.Width = 125;
            // 
            // TENDVI
            // 
            this.TENDVI.DataPropertyName = "TENDVI";
            this.TENDVI.HeaderText = "TÊN ĐƠN VỊ";
            this.TENDVI.MinimumWidth = 6;
            this.TENDVI.Name = "TENDVI";
            this.TENDVI.ReadOnly = true;
            this.TENDVI.Width = 250;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "ĐIỆN THOẠI";
            this.DIENTHOAI.MinimumWidth = 6;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.ReadOnly = true;
            this.DIENTHOAI.Width = 125;
            // 
            // FAX
            // 
            this.FAX.DataPropertyName = "FAX";
            this.FAX.HeaderText = "FAX";
            this.FAX.MinimumWidth = 6;
            this.FAX.Name = "FAX";
            this.FAX.ReadOnly = true;
            this.FAX.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 200;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "ĐỊA CHỈ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 250;
            // 
            // MACTY
            // 
            this.MACTY.DataPropertyName = "MACTY";
            this.MACTY.HeaderText = "MÃ CÔNG TY";
            this.MACTY.MinimumWidth = 6;
            this.MACTY.Name = "MACTY";
            this.MACTY.ReadOnly = true;
            this.MACTY.Width = 80;
            // 
            // KHO
            // 
            this.KHO.DataPropertyName = "KHO";
            this.KHO.HeaderText = "KHO";
            this.KHO.MinimumWidth = 6;
            this.KHO.Name = "KHO";
            this.KHO.ReadOnly = true;
            this.KHO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.KHO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.KHO.Width = 50;
            // 
            // KYHIEU
            // 
            this.KYHIEU.DataPropertyName = "KYHIEU";
            this.KYHIEU.HeaderText = "KÝ HIỆU";
            this.KYHIEU.MinimumWidth = 6;
            this.KYHIEU.Name = "KYHIEU";
            this.KYHIEU.ReadOnly = true;
            this.KYHIEU.Width = 70;
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
            // frmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1666, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDonVi";
            this.Text = "Danh mục Đơn vị";
            this.Load += new System.EventHandler(this.frmDonVi_Load);
            this.Resize += new System.EventHandler(this.frmDonVi_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_Kho;
        private System.Windows.Forms.Label lb_kyhieu;
        private System.Windows.Forms.ComboBox comboBox_Congty;
        private System.Windows.Forms.Label lb_congty;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox textBox_Fax;
        private System.Windows.Forms.Label lb_fax;
        private System.Windows.Forms.TextBox textBox_Dienthoai;
        private System.Windows.Forms.Label lb_dienthoai;
        private System.Windows.Forms.CheckBox checkBox_Disable;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label lb_tendonvi;
        private System.Windows.Forms.TextBox textBox_MA;
        private System.Windows.Forms.Label lb_madonvi;
        private System.Windows.Forms.TextBox textBox_Kyhieu;
        private System.Windows.Forms.TextBox textBox_Diachi;
        private System.Windows.Forms.Label lb_diachi;
        private Panel panel1;
        private Label lb_thongtin;
        private DataGridViewCheckBoxColumn DISABLE;
        private DataGridViewTextBoxColumn MADV;
        private DataGridViewTextBoxColumn TENDVI;
        private DataGridViewTextBoxColumn DIENTHOAI;
        private DataGridViewTextBoxColumn FAX;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn DIACHI;
        private DataGridViewTextBoxColumn MACTY;
        private DataGridViewCheckBoxColumn KHO;
        private DataGridViewTextBoxColumn KYHIEU;
    }
}