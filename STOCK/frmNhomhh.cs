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
    public partial class frmNhomhh: Form
    {
        public frmNhomhh()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmNhomhh(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _user = user;
            _right = right;
        }
        tb_SYS_USER _user;
        int _right;
        NHOMHH _nhh;
        bool _them = false;
        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            dataGridView1.DataSource = _nhh.getAll();
            dataGridView1.Columns["IDNHOM"].Visible = false;
        }
        private void frmNhomhh_Load(object sender, EventArgs e)
        {
            _nhh = new NHOMHH();
            loadData();
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
        void _enableControl(bool t)
        {
            textBox_Ten.Enabled = t;
            textBox_ghichu.Enabled = t;
            checkBox_DISABLED.Enabled = t;
        }
        void clearControl()
        {
            textBox_Ten.Text = "";
            textBox_ghichu.Text = "";
            checkBox_DISABLED.Checked = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                tb_NHOMHH nhh = (tb_NHOMHH)dataGridView1.SelectedRows[0].DataBoundItem;
                textBox_Ten.Text = nhh.TENNHOM;
                textBox_ghichu.Text = nhh.GHICHU;
                checkBox_DISABLED.Checked = (bool)nhh.DISABLED;
                if(checkBox_DISABLED.Checked)
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
                showHideControl(false);
            }
                
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
                    MessageBox.Show("Bạn chưa chọn nhóm hàng hóa nào để xóa");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["TEN"].Value != null)
                        {
                            list.Add(row.Cells["TEN"].Value.ToString());
                        }
                    }
                    foreach (string i in list)
                    {
                        _nhh.delete(i);
                    }
                }
                loadData();
                clearControl();
            }
           
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Ten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhóm");
                return;
            }
            if (_them)
            {
                tb_NHOMHH nhh = new tb_NHOMHH();
                nhh.TENNHOM = textBox_Ten.Text;
                nhh.GHICHU = textBox_ghichu.Text;
                nhh.DISABLED = checkBox_DISABLED.Checked;
                if (_nhh.getItem(nhh.TENNHOM) != null)
                {
                    MessageBox.Show("Nhóm đã tồn tại");
                    return;
                }
                _nhh.add(nhh);
            }
            else
            {
                tb_NHOMHH nhh = (tb_NHOMHH)dataGridView1.SelectedRows[0].DataBoundItem;
                tb_NHOMHH n = _nhh.getItem(nhh.IDNHOM);
                n.TENNHOM = textBox_Ten.Text;
                n.GHICHU = textBox_ghichu.Text;
                n.DISABLED = checkBox_DISABLED.Checked;
                _nhh.update(n);
            }
            loadData();
            _them = false;
            showHideControl(true);
            _enableControl(false);
        }
        private void toolStripButton_Boqua_Click_1(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enableControl(false);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            lb_thongtin.Top = (panel1.Height - lb_thongtin.Height) / 2;
        }
    }
}
