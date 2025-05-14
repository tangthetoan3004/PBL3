namespace STOCK
{
    partial class frmRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestore));
            this.bt_browse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tb_file = new System.Windows.Forms.TextBox();
            this.lb_filepath = new System.Windows.Forms.Label();
            this.bt_restore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_browse
            // 
            this.bt_browse.BackColor = System.Drawing.SystemColors.Control;
            this.bt_browse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_browse.ImageList = this.imageList1;
            this.bt_browse.Location = new System.Drawing.Point(384, 113);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(128, 53);
            this.bt_browse.TabIndex = 6;
            this.bt_browse.Text = "Browse";
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
            this.imageList1.Images.SetKeyName(2, "data-recovery (1).png");
            // 
            // tb_file
            // 
            this.tb_file.BackColor = System.Drawing.SystemColors.Menu;
            this.tb_file.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_file.Location = new System.Drawing.Point(154, 49);
            this.tb_file.Name = "tb_file";
            this.tb_file.Size = new System.Drawing.Size(590, 34);
            this.tb_file.TabIndex = 5;
            // 
            // lb_filepath
            // 
            this.lb_filepath.AutoSize = true;
            this.lb_filepath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filepath.Location = new System.Drawing.Point(44, 51);
            this.lb_filepath.Name = "lb_filepath";
            this.lb_filepath.Size = new System.Drawing.Size(85, 28);
            this.lb_filepath.TabIndex = 4;
            this.lb_filepath.Text = "File Path";
            // 
            // bt_restore
            // 
            this.bt_restore.BackColor = System.Drawing.SystemColors.Control;
            this.bt_restore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restore.Location = new System.Drawing.Point(562, 113);
            this.bt_restore.Name = "bt_restore";
            this.bt_restore.Size = new System.Drawing.Size(140, 53);
            this.bt_restore.TabIndex = 7;
            this.bt_restore.Text = "Restore";
            this.bt_restore.UseVisualStyleBackColor = false;
            this.bt_restore.Click += new System.EventHandler(this.bt_backup_Click);
            // 
            // frmRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 195);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.tb_file);
            this.Controls.Add(this.lb_filepath);
            this.Controls.Add(this.bt_restore);
            this.Name = "frmRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore dữ liệu";
            this.Load += new System.EventHandler(this.frmRestore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox tb_file;
        private System.Windows.Forms.Label lb_filepath;
        private System.Windows.Forms.Button bt_restore;
    }
}