namespace USERMANAGEMENT
{
    partial class frmPhanQuyenChucNang
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.khóaQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toànQuyềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉXemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.GROUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChucNang = new System.Windows.Forms.DataGridView();
            this.FUNC_CODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucnang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISGROUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucNang)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khóaQuyềnToolStripMenuItem,
            this.toànQuyềnToolStripMenuItem,
            this.chỉXemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 76);
            // 
            // khóaQuyềnToolStripMenuItem
            // 
            this.khóaQuyềnToolStripMenuItem.Name = "khóaQuyềnToolStripMenuItem";
            this.khóaQuyềnToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.khóaQuyềnToolStripMenuItem.Text = "Khóa quyền";
            this.khóaQuyềnToolStripMenuItem.Click += new System.EventHandler(this.khóaQuyềnToolStripMenuItem_Click);
            // 
            // toànQuyềnToolStripMenuItem
            // 
            this.toànQuyềnToolStripMenuItem.Name = "toànQuyềnToolStripMenuItem";
            this.toànQuyềnToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.toànQuyềnToolStripMenuItem.Text = "Toàn quyền";
            this.toànQuyềnToolStripMenuItem.Click += new System.EventHandler(this.toànQuyềnToolStripMenuItem_Click);
            // 
            // chỉXemToolStripMenuItem
            // 
            this.chỉXemToolStripMenuItem.Name = "chỉXemToolStripMenuItem";
            this.chỉXemToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.chỉXemToolStripMenuItem.Text = "Chỉ xem";
            this.chỉXemToolStripMenuItem.Click += new System.EventHandler(this.chỉXemToolStripMenuItem_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GROUP,
            this.IDUSER,
            this.USERNAME,
            this.FULLNAME});
            this.dgvUsers.Location = new System.Drawing.Point(-1, 0);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 62;
            this.dgvUsers.RowTemplate.Height = 28;
            this.dgvUsers.Size = new System.Drawing.Size(444, 422);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // GROUP
            // 
            this.GROUP.HeaderText = "GROUP";
            this.GROUP.MinimumWidth = 8;
            this.GROUP.Name = "GROUP";
            this.GROUP.Width = 150;
            // 
            // IDUSER
            // 
            this.IDUSER.DataPropertyName = "IDUSER";
            this.IDUSER.HeaderText = "IDUSER";
            this.IDUSER.MinimumWidth = 8;
            this.IDUSER.Name = "IDUSER";
            this.IDUSER.Width = 150;
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "USERNAME";
            this.USERNAME.MinimumWidth = 8;
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Width = 150;
            // 
            // FULLNAME
            // 
            this.FULLNAME.DataPropertyName = "FULLNAME";
            this.FULLNAME.HeaderText = "FULLNAME";
            this.FULLNAME.MinimumWidth = 8;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Width = 150;
            // 
            // dgvChucNang
            // 
            this.dgvChucNang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucNang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FUNC_CODE,
            this.Chucnang,
            this.Quyen,
            this.ISGROUP});
            this.dgvChucNang.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvChucNang.Location = new System.Drawing.Point(449, 0);
            this.dgvChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChucNang.Name = "dgvChucNang";
            this.dgvChucNang.RowHeadersWidth = 62;
            this.dgvChucNang.RowTemplate.Height = 28;
            this.dgvChucNang.Size = new System.Drawing.Size(579, 422);
            this.dgvChucNang.TabIndex = 1;
            // 
            // FUNC_CODE
            // 
            this.FUNC_CODE.DataPropertyName = "FUNC_CODE";
            this.FUNC_CODE.HeaderText = "FUNC_CODE";
            this.FUNC_CODE.MinimumWidth = 8;
            this.FUNC_CODE.Name = "FUNC_CODE";
            this.FUNC_CODE.Visible = false;
            this.FUNC_CODE.Width = 150;
            // 
            // Chucnang
            // 
            this.Chucnang.DataPropertyName = "DESCRIPTION";
            this.Chucnang.HeaderText = "Chức Năng";
            this.Chucnang.MinimumWidth = 8;
            this.Chucnang.Name = "Chucnang";
            this.Chucnang.Width = 200;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "QUYEN";
            this.Quyen.HeaderText = "Quyền";
            this.Quyen.MinimumWidth = 8;
            this.Quyen.Name = "Quyen";
            this.Quyen.Width = 200;
            // 
            // ISGROUP
            // 
            this.ISGROUP.DataPropertyName = "ISGROUP";
            this.ISGROUP.HeaderText = "ISGROUP";
            this.ISGROUP.MinimumWidth = 8;
            this.ISGROUP.Name = "ISGROUP";
            this.ISGROUP.Visible = false;
            this.ISGROUP.Width = 150;
            // 
            // frmPhanQuyenChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 535);
            this.Controls.Add(this.dgvChucNang);
            this.Controls.Add(this.dgvUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhanQuyenChucNang";
            this.Text = "frmPhanQuyenChucNang";
            this.Load += new System.EventHandler(this.frmPhanQuyenChucNang_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucNang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khóaQuyềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toànQuyềnToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvChucNang;
        private System.Windows.Forms.ToolStripMenuItem chỉXemToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GROUP;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn FUNC_CODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucnang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISGROUP;
    }
}