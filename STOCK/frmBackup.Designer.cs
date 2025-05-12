namespace STOCK
{
    partial class frmBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackup));
            this.lb_filepath = new System.Windows.Forms.Label();
            this.tb_file = new System.Windows.Forms.TextBox();
            this.bt_browse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bt_backup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_filepath
            // 
            this.lb_filepath.AutoSize = true;
            this.lb_filepath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filepath.Location = new System.Drawing.Point(30, 55);
            this.lb_filepath.Name = "lb_filepath";
            this.lb_filepath.Size = new System.Drawing.Size(85, 28);
            this.lb_filepath.TabIndex = 0;
            this.lb_filepath.Text = "File Path";
            // 
            // tb_file
            // 
            this.tb_file.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_file.Location = new System.Drawing.Point(140, 53);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(590, 34);
            this.tb_file.TabIndex = 1;
            // 
            // bt_browse
            // 
            this.bt_browse.BackColor = System.Drawing.Color.Pink;
            this.bt_browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_browse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_browse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_browse.Location = new System.Drawing.Point(218, 129);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(130, 53);
            this.bt_browse.TabIndex = 2;
            this.bt_browse.Text = "Browse";
            this.bt_browse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_browse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_browse.UseVisualStyleBackColor = false;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search.png");
            this.imageList1.Images.SetKeyName(1, "data-recovery.png");
            // 
            // bt_backup
            // 
            this.bt_backup.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_backup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_backup.Location = new System.Drawing.Point(486, 129);
            this.bt_backup.Name = "bt_backup";
            this.bt_backup.Size = new System.Drawing.Size(136, 53);
            this.bt_backup.TabIndex = 3;
            this.bt_backup.Text = "Backup";
            this.bt_backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_backup.UseVisualStyleBackColor = false;
            this.bt_backup.Click += new System.EventHandler(this.bt_backup_Click);
            // 
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(789, 227);
            this.Controls.Add(this.bt_backup);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.tb_file);
            this.Controls.Add(this.lb_filepath);
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup dữ liệu ";
            this.Load += new System.EventHandler(this.frmBackup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_filepath;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bt_backup;
    }
}