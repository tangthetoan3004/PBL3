﻿namespace STOCK
{
    partial class frmNhomhh
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
            this.DISABLED = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TENNHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_thongtin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_ghichu = new System.Windows.Forms.TextBox();
            this.lb_ghichu = new System.Windows.Forms.Label();
            this.checkBox_DISABLED = new System.Windows.Forms.CheckBox();
            this.textBox_Ten = new System.Windows.Forms.TextBox();
            this.label_Ten = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1032, 52);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_Them
            // 
            this.toolStripButton_Them.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButton_Them.Image = global::STOCK.Properties.Resources.plus;
            this.toolStripButton_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Them.Name = "toolStripButton_Them";
            this.toolStripButton_Them.Size = new System.Drawing.Size(63, 49);
            this.toolStripButton_Them.Text = "Thêm";
            this.toolStripButton_Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Them.Click += new System.EventHandler(this.toolStripButton_Them_Click);
            // 
            // toolStripButton_Sua
            // 
            this.toolStripButton_Sua.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButton_Sua.Image = global::STOCK.Properties.Resources.update;
            this.toolStripButton_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Sua.Name = "toolStripButton_Sua";
            this.toolStripButton_Sua.Size = new System.Drawing.Size(47, 49);
            this.toolStripButton_Sua.Text = "Sửa";
            this.toolStripButton_Sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Sua.Click += new System.EventHandler(this.toolStripButton_Sua_Click);
            // 
            // toolStripButton_Xoa
            // 
            this.toolStripButton_Xoa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButton_Xoa.Image = global::STOCK.Properties.Resources.trash;
            this.toolStripButton_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Xoa.Name = "toolStripButton_Xoa";
            this.toolStripButton_Xoa.Size = new System.Drawing.Size(48, 49);
            this.toolStripButton_Xoa.Text = "Xóa";
            this.toolStripButton_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Xoa.Click += new System.EventHandler(this.toolStripButton_Xoa_Click);
            // 
            // toolStripButton_Luu
            // 
            this.toolStripButton_Luu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButton_Luu.Image = global::STOCK.Properties.Resources.diskette;
            this.toolStripButton_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Luu.Name = "toolStripButton_Luu";
            this.toolStripButton_Luu.Size = new System.Drawing.Size(47, 49);
            this.toolStripButton_Luu.Text = "Lưu";
            this.toolStripButton_Luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Luu.Click += new System.EventHandler(this.toolStripButton_Luu_Click);
            // 
            // toolStripButton_Boqua
            // 
            this.toolStripButton_Boqua.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButton_Boqua.Image = global::STOCK.Properties.Resources.fast_forward_button;
            this.toolStripButton_Boqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Boqua.Name = "toolStripButton_Boqua";
            this.toolStripButton_Boqua.Size = new System.Drawing.Size(75, 49);
            this.toolStripButton_Boqua.Text = "Bỏ qua";
            this.toolStripButton_Boqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton_Boqua.Click += new System.EventHandler(this.toolStripButton_Boqua_Click_1);
            // 
            // toolStripButton_Thoat
            // 
            this.toolStripButton_Thoat.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.toolStripButton_Thoat.Image = global::STOCK.Properties.Resources.exit;
            this.toolStripButton_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Thoat.Name = "toolStripButton_Thoat";
            this.toolStripButton_Thoat.Size = new System.Drawing.Size(64, 49);
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
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DISABLED,
            this.TENNHOM,
            this.GHICHU});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 333);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // DISABLED
            // 
            this.DISABLED.DataPropertyName = "DISABLED";
            this.DISABLED.HeaderText = "DEL";
            this.DISABLED.MinimumWidth = 6;
            this.DISABLED.Name = "DISABLED";
            this.DISABLED.ReadOnly = true;
            this.DISABLED.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DISABLED.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DISABLED.Width = 50;
            // 
            // TENNHOM
            // 
            this.TENNHOM.DataPropertyName = "TENNHOM";
            this.TENNHOM.HeaderText = "TÊN";
            this.TENNHOM.MinimumWidth = 6;
            this.TENNHOM.Name = "TENNHOM";
            this.TENNHOM.ReadOnly = true;
            this.TENNHOM.Width = 200;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "GHI CHÚ";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.GHICHU.Width = 450;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_thongtin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 44);
            this.panel1.TabIndex = 6;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBox_ghichu);
            this.panel2.Controls.Add(this.lb_ghichu);
            this.panel2.Controls.Add(this.checkBox_DISABLED);
            this.panel2.Controls.Add(this.textBox_Ten);
            this.panel2.Controls.Add(this.label_Ten);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 172);
            this.panel2.TabIndex = 7;
            // 
            // textBox_ghichu
            // 
            this.textBox_ghichu.BackColor = System.Drawing.Color.LightGray;
            this.textBox_ghichu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ghichu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ghichu.Location = new System.Drawing.Point(124, 83);
            this.textBox_ghichu.Multiline = true;
            this.textBox_ghichu.Name = "textBox_ghichu";
            this.textBox_ghichu.Size = new System.Drawing.Size(841, 56);
            this.textBox_ghichu.TabIndex = 23;
            // 
            // lb_ghichu
            // 
            this.lb_ghichu.AutoSize = true;
            this.lb_ghichu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ghichu.Location = new System.Drawing.Point(40, 83);
            this.lb_ghichu.Name = "lb_ghichu";
            this.lb_ghichu.Size = new System.Drawing.Size(77, 25);
            this.lb_ghichu.TabIndex = 22;
            this.lb_ghichu.Text = "Ghi chú";
            // 
            // checkBox_DISABLED
            // 
            this.checkBox_DISABLED.AutoSize = true;
            this.checkBox_DISABLED.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DISABLED.Location = new System.Drawing.Point(859, 28);
            this.checkBox_DISABLED.Name = "checkBox_DISABLED";
            this.checkBox_DISABLED.Size = new System.Drawing.Size(107, 29);
            this.checkBox_DISABLED.TabIndex = 21;
            this.checkBox_DISABLED.Text = "Disabled";
            this.checkBox_DISABLED.UseVisualStyleBackColor = true;
            // 
            // textBox_Ten
            // 
            this.textBox_Ten.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Ten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ten.Location = new System.Drawing.Point(124, 29);
            this.textBox_Ten.Name = "textBox_Ten";
            this.textBox_Ten.Size = new System.Drawing.Size(636, 32);
            this.textBox_Ten.TabIndex = 0;
            // 
            // label_Ten
            // 
            this.label_Ten.AutoSize = true;
            this.label_Ten.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ten.Location = new System.Drawing.Point(24, 32);
            this.label_Ten.Name = "label_Ten";
            this.label_Ten.Size = new System.Drawing.Size(95, 25);
            this.label_Ten.TabIndex = 20;
            this.label_Ten.Text = "Tên nhóm";
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
            // frmNhomhh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmNhomhh";
            this.Text = "Nhóm hàng hóa";
            this.Load += new System.EventHandler(this.frmNhomhh_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_thongtin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox_DISABLED;
        private System.Windows.Forms.TextBox textBox_Ten;
        private System.Windows.Forms.Label label_Ten;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_ghichu;
        private System.Windows.Forms.TextBox textBox_ghichu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DISABLED;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
    }
}