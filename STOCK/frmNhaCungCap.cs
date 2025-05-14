using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK
{
    public partial class frmNhaCungCap: Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public frmNhaCungCap(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this.Size = new Size(1250, 727);
            this.StartPosition = FormStartPosition.CenterScreen;
            _user = user;
            _right = right;
        }
        tb_SYS_USER _user;
        int _right;
        NHACUNGCAP _ncc;
        bool _them = false;
        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            dataGridView1.DataSource = _ncc.getAll();
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            _ncc = new NHACUNGCAP();
            loadData();
            textBox_Mancc.Enabled = false;
            showHideControl(true);
            _enableControl(false);
        }
        void showHideControl(bool t)
        {
            toolStripButton_Them.Visible = t;
            toolStripButton_Sua.Visible = t;
            toolStripButton_Xoa.Visible = t;
            toolStripButton_Thoat.Visible = t;
            toolStripButton_Luu.Visible = !t;
            toolStripButton_Boqua.Visible = !t;
        }
        void clearControl()
        {
            textBox_Mancc.Text = "";
            textBox_Ten.Text = "";
            textBox_Dienthoai.Text = "";
            textBox_Fax.Text = "";
            textBox_Email.Text = "";
            textBox_Diachi.Text = "";
            checkBox_Disable.Checked = false;
        }
        void _enableControl(bool t)
        {
            textBox_Ten.Enabled = t;
            textBox_Dienthoai.Enabled = t;
            textBox_Fax.Enabled = t;
            textBox_Email.Enabled = t;
            textBox_Diachi.Enabled = t;
            checkBox_Disable.Enabled = t;
        }

        private void toolStripButton_Them_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _them = true;
                textBox_Mancc.Enabled = true;
                showHideControl(false);
                _enableControl(true);
                clearControl();
            }
                
        }

        private void toolStripButton_Sua_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _them = false;
                _enableControl(true);
                textBox_Mancc.Enabled = false;
                showHideControl(false);
            }
               
        }

        private void toolStripButton_Boqua_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                _them = false;
                showHideControl(true);
                _enableControl(false);
                textBox_Mancc.Enabled = false;
            }
               
        }
        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Ten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp");
                textBox_Ten.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Mancc.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã nhà cung cấp");
                textBox_Mancc.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Dienthoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                textBox_Dienthoai.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_Diachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                textBox_Diachi.Focus();
                return;
            }
            if (_them)
            {
                tb_NHACUNGCAP ncc = new tb_NHACUNGCAP();
                ncc.MANCC = textBox_Mancc.Text;
                ncc.TENNCC = textBox_Ten.Text;
                ncc.DIENTHOAI = textBox_Dienthoai.Text;
                ncc.FAX = textBox_Fax.Text;
                ncc.EMAIL = textBox_Email.Text;
                ncc.DIACHI = textBox_Diachi.Text;
                ncc.DISABLED = checkBox_Disable.Checked;
                if (_ncc.getItem((ncc.MANCC).ToString()) != null)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại");
                    return;
                }
                _ncc.add(ncc);
            }
            else
            {
                tb_NHACUNGCAP ncc = _ncc.getItem(textBox_Mancc.Text);
                ncc.TENNCC = textBox_Ten.Text;
                ncc.DIENTHOAI = textBox_Dienthoai.Text;
                ncc.FAX = textBox_Fax.Text;
                ncc.EMAIL = textBox_Email.Text;
                ncc.DIACHI = textBox_Diachi.Text;
                ncc.DISABLED = checkBox_Disable.Checked;
                _ncc.update(ncc);
            }
            _them = false;
            showHideControl(true);
            _enableControl(false);
            textBox_Mancc.Enabled = false;
            loadData();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tb_NHACUNGCAP ncc = (tb_NHACUNGCAP)dataGridView1.SelectedRows[0].DataBoundItem;
                textBox_Mancc.Text = ncc.MANCC.ToString();
                textBox_Ten.Text = ncc.TENNCC;
                textBox_Dienthoai.Text = ncc.DIENTHOAI;
                textBox_Fax.Text = ncc.FAX;
                textBox_Email.Text = ncc.EMAIL;
                textBox_Diachi.Text = ncc.DIACHI;
                checkBox_Disable.Checked = (bool)ncc.DISABLED;
                if(checkBox_Disable.Checked)
                {
                    toolStripButton_Xoa.Enabled = false;
                }
                else
                {
                    toolStripButton_Xoa.Enabled = true;
                }
            }
            else clearControl();
        }

        private void toolStripButton_Xoa_Click(object sender, EventArgs e)
        {
            if (_right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn nhà cung cấp nào để xóa");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["MANCC"].Value != null)
                        {
                            list.Add(row.Cells["MANCC"].Value.ToString());
                        }
                    }
                    foreach (string mancc in list)
                    {
                        _ncc.delete(mancc);
                    }
                }
                loadData();
                clearControl();
            }
           
        }
        private void _center()
        {
            int space1 = 120;

            lb_ten.Top = 35;
            lb_ten.Left = 30;

            textBox_Ten.Top = lb_ten.Top - 3;
            textBox_Ten.Left = lb_ten.Right + 3;

            lb_ma.Top = lb_ten.Top;
            lb_ma.Left = textBox_Ten.Right + space1;

            textBox_Mancc.Top = textBox_Ten.Top;
            textBox_Mancc.Left = lb_ma.Right + 3;

            int space2 = ((textBox_Mancc.Right - textBox_Ten.Left) - textBox_Dienthoai.Width - lb_fax.Width - 3 - textBox_Fax.Width - lb_email.Width - 3 - textBox_Email.Width - checkBox_Disable.Width) / 3;

            lb_dienthoai.Top = lb_ten.Bottom + 25;
            lb_dienthoai.Left = lb_ten.Left + lb_ten.Width - lb_dienthoai.Width;

            textBox_Dienthoai.Top = lb_dienthoai.Top - 3;
            textBox_Dienthoai.Left = textBox_Ten.Left;

            lb_fax.Top = lb_dienthoai.Top;
            lb_fax.Left = textBox_Dienthoai.Right + space2;

            textBox_Fax.Top = textBox_Dienthoai.Top;
            textBox_Fax.Left = lb_fax.Right + 3;

            lb_email.Top = lb_fax.Top;
            lb_email.Left = textBox_Fax.Right + space2;

            textBox_Email.Top = textBox_Fax.Top;
            textBox_Email.Left = lb_email.Right + 3;

            checkBox_Disable.Top = textBox_Email.Top;
            checkBox_Disable.Left = textBox_Email.Right + space2;

            lb_diachi.Top = lb_dienthoai.Bottom + 25;
            lb_diachi.Left = lb_ten.Left + lb_ten.Width - lb_diachi.Width;

            textBox_Diachi.Top = lb_diachi.Top - 3;
            textBox_Diachi.Left = textBox_Dienthoai.Left;

            textBox_Diachi.Width = textBox_Mancc.Right - textBox_Ten.Left;

            panel2.Height = lb_diachi.Bottom + 35;

            lb_thongtin.Top = (panel1.Height - lb_thongtin.Height) / 2;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            _center();
        }
        private void _location()
        {
            dataGridView1.Location = new System.Drawing.Point(
           dataGridView1.Location.X,
           toolStrip1.Bottom
           );
            int newHeight = panel1.Top - toolStrip1.Bottom;
            dataGridView1.Height = newHeight;
        }

        private void frmNhaCungCap_Resize(object sender, EventArgs e)
        {
            _location();
        }
    }
}
