using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK
{
    public partial class frmCongTy: Form
    {
        public frmCongTy()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        public frmCongTy(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this.Size = new Size(1200, 727);
            this.StartPosition = FormStartPosition.CenterScreen;
            _user = user;
            _right = right;
        }
        tb_SYS_USER _user;
        int _right;
        CONGTY _congty;
        bool _them = false;
        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmCongTy_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            loadData();
            showHideControl(true);
            textBox_MA.Enabled = false;
            _enableControl(false);
        }
        void loadData()
        {
            dataGridView1.DataSource = _congty.getAll();
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
            textBox_MA.Text = "";
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
                textBox_MA.Enabled = true;
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
                textBox_MA.Enabled = false;
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
                textBox_MA.Enabled = false;
            }
               
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MA.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập mã công ty");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Ten.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập tên công ty");
                return;
            }
            if (_them)
            {
                tb_CONGTY cty = new tb_CONGTY();
                cty.MACTY = textBox_MA.Text;
                cty.TENCTY = textBox_Ten.Text;
                cty.DIENTHOAI = textBox_Dienthoai.Text;
                cty.FAX = textBox_Fax.Text;
                cty.EMAIL = textBox_Email.Text;
                cty.DIACHI = textBox_Diachi.Text;
                cty.DISABLED = checkBox_Disable.Checked;
                if (_congty.getItem(cty.MACTY) != null)
                {
                    MessageBox.Show("Mã công ty đã tồn tại");
                    return;
                }
                _congty.add(cty);
            }
            else
            {
                tb_CONGTY cty = _congty.getItem(textBox_MA.Text);
                if (cty != null)
                {
                    cty.TENCTY = textBox_Ten.Text;
                    cty.DIENTHOAI = textBox_Dienthoai.Text;
                    cty.FAX = textBox_Fax.Text;
                    cty.EMAIL = textBox_Email.Text;
                    cty.DIACHI = textBox_Diachi.Text;
                    cty.DISABLED = checkBox_Disable.Checked;
                    _congty.update(cty);
                }
            }
            _them = false;
            loadData();
            showHideControl(true);
            textBox_MA.Enabled = false;
            _enableControl(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                tb_CONGTY cty = (tb_CONGTY)dataGridView1.SelectedRows[0].DataBoundItem;
                textBox_MA.Text = cty.MACTY ?? "";
                textBox_Ten.Text = cty.TENCTY ?? "";
                textBox_Dienthoai.Text = cty.DIENTHOAI ?? "";
                textBox_Fax.Text = cty.FAX ?? "";
                textBox_Email.Text = cty.EMAIL ?? "";
                textBox_Diachi.Text = cty.DIACHI ?? "";
                checkBox_Disable.Checked = (bool)cty.DISABLED;
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
                    MessageBox.Show("Bạn chưa chọn bản ghi nào để xóa");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["MACTY"].Value != null)
                        {
                            list.Add(row.Cells["MACTY"].Value.ToString());
                        }
                    }
                    foreach (string macty in list)
                    {
                        _congty.delete(macty);
                    }
                }
                loadData();
                clearControl();
            }
           
        }
        private void _center()
        {
            int space1 = 20;
            int space3 = 10;
            int space2 = textBox_Fax.Width + space3 + lb_email.Width + 3 + textBox_Email.Width - checkBox_Disable.Width - textBox_Ten.Width;

            lb_ma.Top = 35;
            lb_ma.Left = space1;

            textBox_MA.Top = lb_ma.Top - 3;
            textBox_MA.Left = lb_ma.Right + 3;

            lb_ten.Top = lb_ma.Top;
            lb_ten.Left = textBox_MA.Right + space1 + 50;

            textBox_Ten.Top = textBox_MA.Top;
            textBox_Ten.Left = lb_ten.Right + 3;

            checkBox_Disable.Top = textBox_Ten.Top;
            checkBox_Disable.Left = textBox_Ten.Right + space2;

            lb_dienthoai.Left = lb_ma.Left + lb_ma.Width - lb_dienthoai.Width;
            lb_dienthoai.Top = lb_ma.Bottom + 25;

            textBox_Dienthoai.Top = lb_dienthoai.Top - 3;
            textBox_Dienthoai.Left = textBox_MA.Left;

            lb_fax.Top = lb_dienthoai.Top;
            lb_fax.Left = lb_ten.Left + lb_ten.Width - lb_fax.Width;

            textBox_Fax.Left = textBox_Ten.Left;
            textBox_Fax.Top = textBox_Dienthoai.Top;

            lb_email.Top = lb_fax.Top;
            lb_email.Left = textBox_Fax.Right + space3;

            textBox_Email.Top = textBox_Fax.Top;
            textBox_Email.Left = lb_email.Right + 3;

            lb_diachi.Top = lb_dienthoai.Bottom + 25;
            lb_diachi.Left = lb_ma.Left + lb_ma.Width - lb_diachi.Width;

            textBox_Diachi.Top = lb_diachi.Top - 3;
            textBox_Diachi.Left = textBox_Dienthoai.Left;

            textBox_Diachi.Width = textBox_Email.Right - textBox_Diachi.Left;

            panel2.Height = lb_diachi.Bottom + 35;

            lb_thongtin.Top = (panel1.Height - lb_thongtin.Height) / 2;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            _center();
        }
        void _location()
        {
            dataGridView1.Location = new System.Drawing.Point(
            dataGridView1.Location.X,
            toolStrip1.Bottom          
            );
            int newHeight = panel1.Top - toolStrip1.Bottom;
            dataGridView1.Height = newHeight;
        }
        private void frmCongTy_Resize(object sender, EventArgs e)
        {
            _location();
        }
    }
}
