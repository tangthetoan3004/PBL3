using System.Drawing;
using System.Windows.Forms;

namespace STOCK
{
    partial class frmCongTy
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
            this.toolStripButton_Them = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Sua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Xoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Luu = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Boqua = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Thoat = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DISABLE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MACTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENCTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_MA = new System.Windows.Forms.TextBox();
            this.lb_ma = new System.Windows.Forms.Label();
            this.checkBox_Disable = new System.Windows.Forms.CheckBox();
            this.textBox_Diachi = new System.Windows.Forms.TextBox();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Fax = new System.Windows.Forms.TextBox();
            this.lb_fax = new System.Windows.Forms.Label();
            this.textBox_Dienthoai = new System.Windows.Forms.TextBox();
            this.lb_dienthoai = new System.Windows.Forms.Label();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.lb_ten = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
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
            this.toolStrip1.Size = new System.Drawing.Size(1405, 55);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DISABLE,
            this.MACTY,
            this.TENCTY,
            this.DIENTHOAI,
            this.EMAIL,
            this.FAX,
            this.DIACHI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 381);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            // MACTY
            // 
            this.MACTY.DataPropertyName = "MACTY";
            this.MACTY.HeaderText = "MÃ CÔNG TY";
            this.MACTY.MinimumWidth = 6;
            this.MACTY.Name = "MACTY";
            this.MACTY.ReadOnly = true;
            this.MACTY.Width = 125;
            // 
            // TENCTY
            // 
            this.TENCTY.DataPropertyName = "TENCTY";
            this.TENCTY.HeaderText = "TÊN CÔNG TY";
            this.TENCTY.MinimumWidth = 6;
            this.TENCTY.Name = "TENCTY";
            this.TENCTY.ReadOnly = true;
            this.TENCTY.Width = 250;
            // 
            // DIENTHOAI
            // 
            this.DIENTHOAI.DataPropertyName = "DIENTHOAI";
            this.DIENTHOAI.HeaderText = "ĐIỆN THOẠI";
            this.DIENTHOAI.MinimumWidth = 6;
            this.DIENTHOAI.Name = "DIENTHOAI";
            this.DIENTHOAI.ReadOnly = true;
            this.DIENTHOAI.Width = 150;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 225;
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
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "ĐỊA CHỈ";
            this.DIACHI.MinimumWidth = 6;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            this.DIACHI.Width = 250;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_MA);
            this.panel2.Controls.Add(this.lb_ma);
            this.panel2.Controls.Add(this.checkBox_Disable);
            this.panel2.Controls.Add(this.textBox_Diachi);
            this.panel2.Controls.Add(this.lb_diachi);
            this.panel2.Controls.Add(this.textBox_Email);
            this.panel2.Controls.Add(this.lb_email);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBox_Fax);
            this.panel2.Controls.Add(this.lb_fax);
            this.panel2.Controls.Add(this.textBox_Dienthoai);
            this.panel2.Controls.Add(this.lb_dienthoai);
            this.panel2.Controls.Add(this.textBox_Ten);
            this.panel2.Controls.Add(this.lb_ten);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 214);
            this.panel2.TabIndex = 4;
            this.panel2.Resize += new System.EventHandler(this.panel2_Resize);
            // 
            // textBox_MA
            // 
            this.textBox_MA.BackColor = System.Drawing.Color.LightGray;
            this.textBox_MA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_MA.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MA.Location = new System.Drawing.Point(130, 29);
            this.textBox_MA.Name = "textBox_MA";
            this.textBox_MA.Size = new System.Drawing.Size(196, 32);
            this.textBox_MA.TabIndex = 0;
            // 
            // lb_ma
            // 
            this.lb_ma.AutoSize = true;
            this.lb_ma.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ma.Location = new System.Drawing.Point(18, 32);
            this.lb_ma.Name = "lb_ma";
            this.lb_ma.Size = new System.Drawing.Size(106, 25);
            this.lb_ma.TabIndex = 20;
            this.lb_ma.Text = "Mã công ty";
            // 
            // checkBox_Disable
            // 
            this.checkBox_Disable.AutoSize = true;
            this.checkBox_Disable.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Disable.Location = new System.Drawing.Point(1258, 29);
            this.checkBox_Disable.Name = "checkBox_Disable";
            this.checkBox_Disable.Size = new System.Drawing.Size(107, 29);
            this.checkBox_Disable.TabIndex = 19;
            this.checkBox_Disable.Text = "Disabled";
            this.checkBox_Disable.UseVisualStyleBackColor = true;
            // 
            // textBox_Diachi
            // 
            this.textBox_Diachi.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Diachi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Diachi.Location = new System.Drawing.Point(130, 139);
            this.textBox_Diachi.Name = "textBox_Diachi";
            this.textBox_Diachi.Size = new System.Drawing.Size(1225, 32);
            this.textBox_Diachi.TabIndex = 18;
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.Location = new System.Drawing.Point(46, 142);
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
            this.textBox_Email.Location = new System.Drawing.Point(724, 83);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(631, 32);
            this.textBox_Email.TabIndex = 16;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(640, 86);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(58, 25);
            this.lb_email.TabIndex = 15;
            this.lb_email.Text = "Email";
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
            // textBox_Fax
            // 
            this.textBox_Fax.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Fax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Fax.Location = new System.Drawing.Point(411, 83);
            this.textBox_Fax.Name = "textBox_Fax";
            this.textBox_Fax.Size = new System.Drawing.Size(213, 32);
            this.textBox_Fax.TabIndex = 13;
            // 
            // lb_fax
            // 
            this.lb_fax.AutoSize = true;
            this.lb_fax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fax.Location = new System.Drawing.Point(352, 89);
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
            this.textBox_Dienthoai.Location = new System.Drawing.Point(130, 83);
            this.textBox_Dienthoai.Name = "textBox_Dienthoai";
            this.textBox_Dienthoai.Size = new System.Drawing.Size(196, 32);
            this.textBox_Dienthoai.TabIndex = 11;
            // 
            // lb_dienthoai
            // 
            this.lb_dienthoai.AutoSize = true;
            this.lb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dienthoai.Location = new System.Drawing.Point(23, 86);
            this.lb_dienthoai.Name = "lb_dienthoai";
            this.lb_dienthoai.Size = new System.Drawing.Size(99, 25);
            this.lb_dienthoai.TabIndex = 10;
            this.lb_dienthoai.Text = "Điện thoại";
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Ten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ten.Location = new System.Drawing.Point(489, 29);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(706, 32);
            this.textBox_Ten.TabIndex = 8;
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.Location = new System.Drawing.Point(375, 32);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(108, 25);
            this.lb_ten.TabIndex = 7;
            this.lb_ten.Text = "Tên công ty";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_thongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 44);
            this.panel1.TabIndex = 5;
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
            // frmCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCongTy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Công ty";
            this.Load += new System.EventHandler(this.frmCongTy_Load);
            this.Resize += new System.EventHandler(this.frmCongTy_Resize);
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
        private System.Windows.Forms.TextBox textBox_Diachi;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Fax;
        private System.Windows.Forms.Label lb_fax;
        private System.Windows.Forms.TextBox textBox_Dienthoai;
        private System.Windows.Forms.Label lb_dienthoai;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label lb_ten;
        private System.Windows.Forms.CheckBox checkBox_Disable;
        private TextBox textBox_MA;
        private Label lb_ma;
        private Panel panel1;
        private Label lb_thongtin;
        private DataGridViewCheckBoxColumn DISABLE;
        private DataGridViewTextBoxColumn MACTY;
        private DataGridViewTextBoxColumn TENCTY;
        private DataGridViewTextBoxColumn DIENTHOAI;
        private DataGridViewTextBoxColumn EMAIL;
        private DataGridViewTextBoxColumn FAX;
        private DataGridViewTextBoxColumn DIACHI;
    }
}