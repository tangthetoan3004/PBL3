namespace POS
{
    partial class frmBanle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanle));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_tong2 = new System.Windows.Forms.Panel();
            this.tb_tongtienct = new System.Windows.Forms.TextBox();
            this.lb_tongtienct = new System.Windows.Forms.Label();
            this.lb_soluongct = new System.Windows.Forms.Label();
            this.tb_soluongct = new System.Windows.Forms.TextBox();
            this.lb_tong2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_trahang = new System.Windows.Forms.Button();
            this.bt_chietkhau = new System.Windows.Forms.Button();
            this.bt_bill = new System.Windows.Forms.Button();
            this.tb_barcode = new System.Windows.Forms.TextBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pn_tong2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.LightGray;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.BARCODE,
            this.TENHH,
            this.DVT,
            this.SOLUONGCT,
            this.DONGIA,
            this.THANHTIEN});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1323, 419);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 80;
            // 
            // BARCODE
            // 
            this.BARCODE.DataPropertyName = "BARCODE";
            this.BARCODE.HeaderText = "BARCODE";
            this.BARCODE.MinimumWidth = 6;
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.Width = 175;
            // 
            // TENHH
            // 
            this.TENHH.DataPropertyName = "TENHH";
            this.TENHH.HeaderText = "TÊN HÀNG HÓA";
            this.TENHH.MinimumWidth = 6;
            this.TENHH.Name = "TENHH";
            this.TENHH.Width = 400;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "ĐƠN VỊ TÍNH";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 125;
            // 
            // SOLUONGCT
            // 
            this.SOLUONGCT.DataPropertyName = "SOLUONGCT";
            this.SOLUONGCT.HeaderText = "SỐ LƯỢNG";
            this.SOLUONGCT.MinimumWidth = 6;
            this.SOLUONGCT.Name = "SOLUONGCT";
            this.SOLUONGCT.Width = 125;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            dataGridViewCellStyle23.Format = "N0";
            dataGridViewCellStyle23.NullValue = null;
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle23;
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            dataGridViewCellStyle24.Format = "N0";
            dataGridViewCellStyle24.NullValue = null;
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle24;
            this.THANHTIEN.HeaderText = "THÀNH TIỀN";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.Width = 125;
            // 
            // pn_tong2
            // 
            this.pn_tong2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pn_tong2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_tong2.Controls.Add(this.tb_tongtienct);
            this.pn_tong2.Controls.Add(this.lb_tongtienct);
            this.pn_tong2.Controls.Add(this.lb_soluongct);
            this.pn_tong2.Controls.Add(this.tb_soluongct);
            this.pn_tong2.Controls.Add(this.lb_tong2);
            this.pn_tong2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_tong2.Location = new System.Drawing.Point(0, 419);
            this.pn_tong2.Name = "pn_tong2";
            this.pn_tong2.Size = new System.Drawing.Size(1323, 62);
            this.pn_tong2.TabIndex = 9;
            this.pn_tong2.Resize += new System.EventHandler(this.pn_tong2_Resize);
            // 
            // tb_tongtienct
            // 
            this.tb_tongtienct.BackColor = System.Drawing.Color.LightGray;
            this.tb_tongtienct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tongtienct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tongtienct.Location = new System.Drawing.Point(1027, 13);
            this.tb_tongtienct.Name = "tb_tongtienct";
            this.tb_tongtienct.Size = new System.Drawing.Size(250, 32);
            this.tb_tongtienct.TabIndex = 17;
            this.tb_tongtienct.TabStop = false;
            // 
            // lb_tongtienct
            // 
            this.lb_tongtienct.AutoSize = true;
            this.lb_tongtienct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongtienct.Location = new System.Drawing.Point(906, 15);
            this.lb_tongtienct.Name = "lb_tongtienct";
            this.lb_tongtienct.Size = new System.Drawing.Size(92, 25);
            this.lb_tongtienct.TabIndex = 16;
            this.lb_tongtienct.Text = "Tổng tiền";
            // 
            // lb_soluongct
            // 
            this.lb_soluongct.AutoSize = true;
            this.lb_soluongct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soluongct.Location = new System.Drawing.Point(616, 15);
            this.lb_soluongct.Name = "lb_soluongct";
            this.lb_soluongct.Size = new System.Drawing.Size(87, 25);
            this.lb_soluongct.TabIndex = 15;
            this.lb_soluongct.Text = "Số lượng";
            // 
            // tb_soluongct
            // 
            this.tb_soluongct.BackColor = System.Drawing.Color.LightGray;
            this.tb_soluongct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_soluongct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_soluongct.Location = new System.Drawing.Point(728, 13);
            this.tb_soluongct.Name = "tb_soluongct";
            this.tb_soluongct.Size = new System.Drawing.Size(150, 32);
            this.tb_soluongct.TabIndex = 14;
            this.tb_soluongct.TabStop = false;
            // 
            // lb_tong2
            // 
            this.lb_tong2.AutoSize = true;
            this.lb_tong2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tong2.Location = new System.Drawing.Point(430, 15);
            this.lb_tong2.Name = "lb_tong2";
            this.lb_tong2.Size = new System.Drawing.Size(119, 25);
            this.lb_tong2.TabIndex = 0;
            this.lb_tong2.Text = "Tổng cộng :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS.Properties.Resources.bar_code;
            this.pictureBox1.Location = new System.Drawing.Point(63, 496);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // bt_trahang
            // 
            this.bt_trahang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_trahang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_trahang.Location = new System.Drawing.Point(1111, 508);
            this.bt_trahang.Name = "bt_trahang";
            this.bt_trahang.Size = new System.Drawing.Size(185, 67);
            this.bt_trahang.TabIndex = 4;
            this.bt_trahang.Text = "  Trả hàng";
            this.bt_trahang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_trahang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_trahang.UseVisualStyleBackColor = true;
            this.bt_trahang.Click += new System.EventHandler(this.bt_trahang_Click);
            this.bt_trahang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bt_trahang_KeyPress);
            // 
            // bt_chietkhau
            // 
            this.bt_chietkhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chietkhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chietkhau.Location = new System.Drawing.Point(897, 508);
            this.bt_chietkhau.Name = "bt_chietkhau";
            this.bt_chietkhau.Size = new System.Drawing.Size(208, 67);
            this.bt_chietkhau.TabIndex = 3;
            this.bt_chietkhau.Text = "  Chiết khấu";
            this.bt_chietkhau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_chietkhau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_chietkhau.UseVisualStyleBackColor = true;
            this.bt_chietkhau.Click += new System.EventHandler(this.bt_chietkhau_Click);
            this.bt_chietkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bt_chietkhau_KeyPress);
            // 
            // bt_bill
            // 
            this.bt_bill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bill.Location = new System.Drawing.Point(714, 508);
            this.bt_bill.Name = "bt_bill";
            this.bt_bill.Size = new System.Drawing.Size(177, 67);
            this.bt_bill.TabIndex = 2;
            this.bt_bill.Text = "  In Bill";
            this.bt_bill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_bill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_bill.UseVisualStyleBackColor = true;
            this.bt_bill.Click += new System.EventHandler(this.bt_bill_Click);
            this.bt_bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bt_bill_KeyPress);
            // 
            // tb_barcode
            // 
            this.tb_barcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_barcode.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barcode.Location = new System.Drawing.Point(155, 508);
            this.tb_barcode.Multiline = true;
            this.tb_barcode.Name = "tb_barcode";
            this.tb_barcode.Size = new System.Drawing.Size(348, 67);
            this.tb_barcode.TabIndex = 0;
            this.tb_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_barcode_KeyDown);
            // 
            // bt_luu
            // 
            this.bt_luu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.Location = new System.Drawing.Point(567, 508);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(141, 67);
            this.bt_luu.TabIndex = 1;
            this.bt_luu.Text = "  Lưu";
            this.bt_luu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            this.bt_luu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bt_luu_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "product-return.png");
            this.imageList1.Images.SetKeyName(1, "transaction.png");
            this.imageList1.Images.SetKeyName(2, "diskette.png");
            this.imageList1.Images.SetKeyName(3, "percentage.png");
            // 
            // frmBanle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1323, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_trahang);
            this.Controls.Add(this.bt_chietkhau);
            this.Controls.Add(this.bt_bill);
            this.Controls.Add(this.tb_barcode);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.pn_tong2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "frmBanle";
            this.Text = "Phiếu bán lẻ";
            this.Load += new System.EventHandler(this.frmBanle_Load);
            this.Resize += new System.EventHandler(this.frmBanle_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pn_tong2.ResumeLayout(false);
            this.pn_tong2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.Panel pn_tong2;
        private System.Windows.Forms.TextBox tb_tongtienct;
        private System.Windows.Forms.Label lb_tongtienct;
        private System.Windows.Forms.Label lb_soluongct;
        private System.Windows.Forms.TextBox tb_soluongct;
        private System.Windows.Forms.Label lb_tong2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_trahang;
        private System.Windows.Forms.Button bt_chietkhau;
        private System.Windows.Forms.Button bt_bill;
        private System.Windows.Forms.TextBox tb_barcode;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.ImageList imageList1;
    }
}