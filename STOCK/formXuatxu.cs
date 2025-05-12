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
    public partial class formXuatxu: Form
    {
        public formXuatxu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public formXuatxu(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _user = user;
            _right = right;
        }
        tb_SYS_USER _user;
        int _right;
        XUATXU _xx;
        bool _them = false;
        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
        void loadData()
        {
            dataGridView1.DataSource = _xx.getAll();
            dataGridView1.Columns["ID"].Visible = false;
        }
        void _enableControl(bool t)
        {
            textBox_Ten.Enabled = t;
            checkBox_DISABLED.Enabled = t;
        }
        void clearControl()
        {
            textBox_Ten.Text = "";
            checkBox_DISABLED.Checked = false;
        }
        private void formXuatxu_Load(object sender, EventArgs e)
        {
            _xx = new XUATXU();
            loadData();
            showHideControl(true);
            _enableControl(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tb_XUATXU xx = (tb_XUATXU)dataGridView1.SelectedRows[0].DataBoundItem;
                textBox_Ten.Text = xx.TEN;
                checkBox_DISABLED.Checked = (bool)xx.DISABLED;
                if (checkBox_DISABLED.Checked)
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
                    MessageBox.Show("Bạn chưa chọn nơi xuất xứ nào để xóa");
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
                        _xx.delete(i);
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
                MessageBox.Show("Bạn chưa nhập tên xuất xứ");
                return;
            }
            if (_them)
            {
                tb_XUATXU xx = new tb_XUATXU();
                xx.TEN = textBox_Ten.Text;
                xx.DISABLED = checkBox_DISABLED.Checked;
                if (_xx.getItem(xx.TEN) != null)
                {
                    MessageBox.Show("Nơi xuất xứ đã tồn tại");
                    return;
                }
                _xx.add(xx);
            }
            else
            {
                tb_XUATXU xx = (tb_XUATXU)dataGridView1.SelectedRows[0].DataBoundItem;
                tb_XUATXU x = _xx.getItem(xx.ID);
                x.TEN = textBox_Ten.Text;
                x.DISABLED = checkBox_DISABLED.Checked;
                _xx.update(xx);
            }
            loadData();
            _them = false;
            showHideControl(true);
            _enableControl(false);
        }

        private void toolStripButton_Boqua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enableControl(false);
        }
        private void _center()
        {
            label_Ten.Top = 25;
            label_Ten.Left = (panel2.Width - label_Ten.Width - 3 - textBox_Ten.Width) / 2;

            textBox_Ten.Top = label_Ten.Top - 3;
            textBox_Ten.Left = label_Ten.Right + 3;

            checkBox_DISABLED.Top = textBox_Ten.Bottom + 15;
            checkBox_DISABLED.Left = textBox_Ten.Left +  (textBox_Ten.Width - checkBox_DISABLED.Width) / 2;

            label1.Top = (panel1.Height - label1.Height) / 2;
        }
        private void panel2_Resize(object sender, EventArgs e)
        {
            _center();
        }
    }
}
