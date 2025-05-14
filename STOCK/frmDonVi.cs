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
    public partial class frmDonVi: Form
    {
        public frmDonVi()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _background();
            _location();
            _center();
        }
        public frmDonVi(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            this.Size = new Size(1400, 624);
            this.StartPosition = FormStartPosition.CenterScreen;
            _background();
            _location();
            _center();
            _user = user;
            _right = right;
        }
        tb_SYS_USER _user;
        int _right;
        DONVI _donvi;
        CONGTY _congty;
        bool _them = false;
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
            comboBox_Congty.SelectedIndex = -1;
            textBox_MA.Text = "";
            textBox_Ten.Text = "";
            textBox_Dienthoai.Text = "";
            textBox_Fax.Text = "";
            textBox_Email.Text = "";
            textBox_Diachi.Text = "";
            checkBox_Disable.Checked = false;
            checkBox_Kho.Checked = false;
            textBox_Kyhieu.Text = "";
        }
        void _enableControl(bool t)
        {
            comboBox_Congty.Enabled = t;
            textBox_MA.Enabled = t;
            textBox_Ten.Enabled = t;
            textBox_Dienthoai.Enabled = t;
            textBox_Fax.Enabled = t;
            textBox_Email.Enabled = t;
            textBox_Diachi.Enabled = t;
            checkBox_Disable.Enabled = t;
            checkBox_Kho.Enabled = t;
            textBox_Kyhieu.Enabled = t;
        }
        void loadData()
        {
            dataGridView1.DataSource = _donvi.getAll();
        }
        void loadCongTy()
        {
            List<tb_CONGTY> list = _congty.getAll();
            if (list != null)
            {
                comboBox_Congty.DataSource = list;
                comboBox_Congty.DisplayMember = "TENCTY";
                comboBox_Congty.ValueMember = "MACTY";
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            _donvi = new DONVI();
            _congty = new CONGTY();
            loadCongTy();
            loadData();
            showHideControl(true);
            textBox_MA.Enabled = false;
            _enableControl(false);
            _center();
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
                        if (row.Cells["MADV"].Value != null)
                        {
                            list.Add(row.Cells["MADV"].Value.ToString());
                        }
                    }
                    foreach (string madvi in list)
                    {
                        _donvi.delete(madvi);
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
                MessageBox.Show("Bạn chưa nhập tên đơn vị");
                return;
            }
            if (comboBox_Congty.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn công ty");
                return;
            }
            if (string.IsNullOrEmpty(textBox_MA.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã đơn vị");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Diachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Dienthoai.Text))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Fax.Text))
            {
                MessageBox.Show("Bạn chưa nhập số Fax");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Email.Text))
            {
                MessageBox.Show("Bạn chưa nhập email");
                return;
            }
            if (_them)
            {
                tb_DONVI dvi = new tb_DONVI();
                dvi.MACTY = comboBox_Congty.SelectedValue.ToString();
                dvi.MADV = textBox_MA.Text;
                dvi.TENDVI = textBox_Ten.Text;
                dvi.DIENTHOAI = textBox_Dienthoai.Text;
                dvi.FAX = textBox_Fax.Text;
                dvi.EMAIL = textBox_Email.Text;
                dvi.DIACHI = textBox_Diachi.Text;
                dvi.DISABLED = checkBox_Disable.Checked;
                dvi.KHO = checkBox_Kho.Checked;
                dvi.KYHIEU = textBox_Kyhieu.Text ?? "";
                if (_donvi.getItem(dvi.MADV) != null)
                {
                    MessageBox.Show("Mã đơn vị đã tồn tại");
                    return;
                }
                _donvi.add(dvi);
            }
            else
            {
                tb_DONVI dvi = _donvi.getItem(textBox_MA.Text);
                if (dvi != null)
                {
                    dvi.MACTY = comboBox_Congty.SelectedValue.ToString();
                    dvi.TENDVI = textBox_Ten.Text;
                    dvi.DIENTHOAI = textBox_Dienthoai.Text;
                    dvi.FAX = textBox_Fax.Text;
                    dvi.EMAIL = textBox_Email.Text;
                    dvi.DIACHI = textBox_Diachi.Text;
                    dvi.DISABLED = checkBox_Disable.Checked;
                    dvi.KHO = checkBox_Kho.Checked;
                    dvi.KYHIEU = textBox_Kyhieu.Text ?? "";
                    _donvi.update(dvi);
                }
            }
            _them = false;
            loadData();
            showHideControl(true);
            textBox_MA.Enabled = false;
            _enableControl(false);
        }

        private void toolStripButton_Boqua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enableControl(false);
            textBox_MA.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tb_DONVI dvi = (tb_DONVI)dataGridView1.SelectedRows[0].DataBoundItem;
                comboBox_Congty.SelectedValue = dvi.MACTY;
                textBox_MA.Text = dvi.MADV ?? "";
                textBox_Ten.Text = dvi.TENDVI ?? "";
                textBox_Dienthoai.Text = dvi.DIENTHOAI ?? "";
                textBox_Fax.Text = dvi.FAX ?? "";
                textBox_Email.Text = dvi.EMAIL ?? "";
                textBox_Diachi.Text = dvi.DIACHI ?? "";
                checkBox_Disable.Checked = (bool)dvi.DISABLED;
                checkBox_Kho.Checked = (bool)dvi.KHO;
                textBox_Kyhieu.Text = dvi.KYHIEU ?? "";
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
        private void _background()
        {
            textBox_MA.BackColor = panel2.BackColor;
            textBox_MA.BorderStyle = BorderStyle.FixedSingle;

            textBox_Ten.BackColor = panel2.BackColor;
            textBox_Ten.BorderStyle = BorderStyle.FixedSingle;

            textBox_Dienthoai.BackColor = panel2.BackColor;
            textBox_Dienthoai.BorderStyle = BorderStyle.FixedSingle;

            textBox_Fax.BackColor = panel2.BackColor;
            textBox_Fax.BorderStyle = BorderStyle.FixedSingle;

            textBox_Email.BackColor = panel2.BackColor;
            textBox_Email.BorderStyle = BorderStyle.FixedSingle;

            textBox_Diachi.BackColor = panel2.BackColor;
            textBox_Diachi.BorderStyle = BorderStyle.FixedSingle;

            textBox_Kyhieu.BackColor = panel2.BackColor;
            textBox_Kyhieu.BorderStyle = BorderStyle.FixedSingle;

            comboBox_Congty.BackColor = panel2.BackColor;
            comboBox_Congty.FlatStyle = FlatStyle.System;
        }
        private void _center()
        {
            textBox_MA.Width += 10;
            textBox_Kyhieu.Width += 10;
            textBox_Dienthoai.Width += 10;
            textBox_Fax.Width += 10;
            int space1 = (panel2.Width - lb_congty.Width - 3 - comboBox_Congty.Width - lb_madonvi.Width - 3 - textBox_Diachi.Width) / 3;
            int space2 = textBox_Email.Width - textBox_MA.Width - lb_kyhieu.Width - 3 - textBox_Kyhieu.Width;
            int space3 = textBox_Diachi.Width - textBox_Email.Width - checkBox_Disable.Width;
            int space4 = textBox_Ten.Width - textBox_Dienthoai.Width - lb_fax.Width - 3 - textBox_Fax.Width;
            textBox_Email.Width = textBox_Email.Width + 30;
            lb_congty.Left = space1;
            lb_congty.Top = 35;
            comboBox_Congty.Top = lb_congty.Top - 3;
            comboBox_Congty.Left = lb_congty.Right + 3;
            lb_madonvi.Left = comboBox_Congty.Right + space1;
            lb_madonvi.Top = lb_congty.Top;
            textBox_MA.Top = lb_madonvi.Top - 3;
            textBox_MA.Left = lb_madonvi.Right + 3;
            lb_kyhieu.Left = textBox_MA.Right + space2;
            lb_kyhieu.Top = lb_congty.Top;
            textBox_Kyhieu.Top = lb_kyhieu.Top - 3;
            textBox_Kyhieu.Left = lb_kyhieu.Right + 3;
            checkBox_Kho.Left = textBox_Kyhieu.Right + space3;
            checkBox_Kho.Top = lb_congty.Top;

            lb_tendonvi.Top = lb_congty.Bottom + 25;
            lb_tendonvi.Left = lb_congty.Left + (lb_congty.Width - lb_tendonvi.Width);
            textBox_Ten.Top = lb_tendonvi.Top - 3;
            textBox_Ten.Left = comboBox_Congty.Left;
            lb_email.Top = lb_tendonvi.Top;
            lb_email.Left = lb_madonvi.Left + lb_madonvi.Width - lb_email.Width;
            textBox_Email.Top = lb_email.Top - 3;
            textBox_Email.Left = lb_email.Right + 3;
            checkBox_Disable.Left = checkBox_Kho.Left;
            checkBox_Disable.Top = lb_email.Top;

            lb_dienthoai.Top = lb_tendonvi.Bottom + 25;
            lb_dienthoai.Left = lb_congty.Left + (lb_congty.Width - lb_dienthoai.Width);
            textBox_Dienthoai.Top = lb_dienthoai.Top - 3;
            textBox_Dienthoai.Left = comboBox_Congty.Left;
            lb_fax.Top = lb_dienthoai.Top;
            lb_fax.Left = textBox_Dienthoai.Right + space4;
            textBox_Fax.Top = lb_fax.Top - 3;
            textBox_Fax.Left = lb_fax.Right + 3;
            lb_diachi.Top = lb_dienthoai.Top;
            lb_diachi.Left = lb_madonvi.Left + lb_madonvi.Width - lb_diachi.Width;
            textBox_Diachi.Top = lb_diachi.Top - 3;
            textBox_Diachi.Left = lb_diachi.Right + 3;

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

        private void frmDonVi_Resize(object sender, EventArgs e)
        {
            _location();
        }
    }
}
