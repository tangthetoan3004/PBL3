using DataLayer;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK
{
    public partial class frmRestore: Form
    {
        public frmRestore()
        {
            InitializeComponent();
        }
        public frmRestore(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;  
            this.right = right;
        }
        tb_SYS_USER _user;
        int right;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-KJ2T5301\\SQLEXPRESS01; Initial Catalog=QUANLY_KHOHANG; Integrated Security=True;");
        private void frmRestore_Load(object sender, EventArgs e)
        {
            tb_file.Enabled = false;
            bt_restore.Enabled = false;
            bt_browse.Image = imageList1.Images[0];
            bt_browse.ImageAlign = ContentAlignment.MiddleLeft;
            bt_browse.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_browse.TextAlign = ContentAlignment.MiddleLeft;
            bt_restore.Image = imageList1.Images[2];
            bt_restore.ImageAlign = ContentAlignment.MiddleLeft;
            bt_restore.TextImageRelation = TextImageRelation.ImageBeforeText;
            bt_restore.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void bt_browse_Click(object sender, EventArgs e)
        {
            if (right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                OpenFileDialog op = new OpenFileDialog();
                op.Filter = "Backup File (.bak)|*.bak";
                op.Title = "Phục hồi dữ liệu";
                if (op.ShowDialog() == DialogResult.OK)
                {
                    tb_file.Text = op.FileName;
                    bt_restore.Enabled = true;
                }
            }
               
        }

        private void bt_backup_Click(object sender, EventArgs e)
        {
            if (right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (string.IsNullOrEmpty(tb_file.Text) || !File.Exists(tb_file.Text))
                {
                    MessageBox.Show("Vui lòng chọn file backup hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string database = conn.Database.ToString();

                try
                {
                    conn.Open();
                    string sql1 = "ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    cmd1.ExecuteNonQuery();

                    string sql2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + tb_file.Text + "' WITH REPLACE";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();

                    string sql3 = "ALTER DATABASE [" + database + "] SET MULTI_USER";
                    SqlCommand cmd3 = new SqlCommand(sql3, conn);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Khôi phục dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt_restore.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Khôi phục không thành công. Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
           
        }
    }
}
