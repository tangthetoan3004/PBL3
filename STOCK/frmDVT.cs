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
    public partial class frmDVT: Form
    {
        public frmDVT()
        {
            InitializeComponent();
            this.Size = new Size(350,470);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmDVT(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this.Size = new Size(350, 470);
            this.StartPosition = FormStartPosition.CenterScreen;
            _user = user;
            _right = right;
        }
        tb_SYS_USER _user;
        int _right;
        DONVITINH _dvt;
        bool _them = false;
        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void loadData()
        {
            dataGridView1.DataSource = _dvt.getAll();
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void frmDVT_Load(object sender, EventArgs e)
        {
            _dvt = new DONVITINH();
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
        void clearControl()
        {
            textBox_Ten.Text = "";
        }
        void _enableControl(bool t)
        {
            textBox_Ten.Enabled = t;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                tb_DVT dvt = (tb_DVT)dataGridView1.SelectedRows[0].DataBoundItem;
                textBox_Ten.Text = dvt.TEN;
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
                    MessageBox.Show("Bạn chưa chọn đơn vị tính nào để xóa");
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
                        _dvt.delete(i);
                    }
                }
                loadData();
                clearControl();
            }
            
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox_Ten.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đơn vị tính");
                return;
            }
            if (_them)
            {
                tb_DVT dvt = new tb_DVT();
                dvt.TEN = textBox_Ten.Text;
                if(_dvt.getItem(dvt.TEN) != null)
                {
                    MessageBox.Show("Đơn vị tính đã tồn tại");
                    return;
                }
                _dvt.add(dvt);
            }
            else
            {
                tb_DVT dvt = (tb_DVT)dataGridView1.SelectedRows[0].DataBoundItem;
                tb_DVT d = _dvt.getItemID(dvt.ID);
                d.TEN = textBox_Ten.Text;
                _dvt.update(d);
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
            label_Ten.Top = (panel2.Height - label_Ten.Height) / 2;
            label_Ten.Left = (panel2.Width - label_Ten.Width - 3 - textBox_Ten.Width) / 2;

            textBox_Ten.Top = label_Ten.Top - 3;
            textBox_Ten.Left = label_Ten.Right + 3;

            lb_thongtin.Top = (panel1.Height - lb_thongtin.Height) / 2;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            _center();
        }
    }
}
