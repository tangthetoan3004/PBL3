using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK
{
    public partial class frmBackup: Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }
        public frmBackup(tb_SYS_USER user, int right)
        {

            InitializeComponent();
            this._user = user;
            this.right = right;
        }
        tb_SYS_USER _user;
        int right;
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-KJ2T5301\\SQLEXPRESS01; Initial Catalog=QUANLY_KHOHANG; Integrated Security=True;");
        private void frmBackup_Load(object sender, EventArgs e)
        {
            if (right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                tb_file.Enabled = false;
                bt_backup.Enabled = false;
                bt_browse.Image = imageList1.Images[0];
                bt_backup.Image = imageList1.Images[1];
            }

                
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
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    tb_file.Text = dialog.SelectedPath;
                    bt_backup.Enabled = true;
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
                string db = conn.Database.ToString();
                if (!String.IsNullOrEmpty(tb_file.Text))
                {
                    string sql = "BACKUP DATABASE [" + db + "] TO DISK = '" + tb_file.Text + "\\" + db + ".bak'";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Backup dữ liệu thành công.", "Backup dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bt_backup.Enabled = false;
                }
            }
                
        }
    }
}
