using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel=Microsoft.Office.Interop.Excel;

namespace STOCK
{
    public partial class frmHanghoa: Form
    {
        public frmHanghoa()
        {
            InitializeComponent();
            tb_barcode.Enabled = false;
        }
        public frmHanghoa(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            tb_barcode.Enabled = false;
            _user = user;
            this.right = right;
        }
        tb_SYS_USER _user;
        int right;
        HANGHOA _hh;
        bool _them = false;
        NHOMHH _nhh;
        DONVITINH _dvt;
        NHACUNGCAP _ncc;
        XUATXU _xx;
        SYS_SEQUENCE _seq;
        tb_SYS_SEQUENCE _ss;
        List<tb_HANGHOA> _lstHH = new List<tb_HANGHOA>();

        void loadData() 
        {
            if (cbb_Nhom.SelectedValue != null && int.TryParse(cbb_Nhom.SelectedValue.ToString(), out int idnhom))
            {
                dataGridView1.DataSource = _hh.getListbyNhom(idnhom);
                dataGridView1.Columns["MANCC"].Visible = false;
                dataGridView1.Columns["IDNHOM"].Visible = false;
                dataGridView1.Columns["MAXX"].Visible = false;
                dataGridView1.Columns["CREATED_DATE"].Visible = false;
                dataGridView1.Columns["CREATED_BY"].Visible = false;
                dataGridView1.Columns["TENTAT"].Visible = false;
                dataGridView1.Columns["BARCODE"].Visible = false;
                _lstHH = _hh.getListbyNhom(idnhom);
            }
            
        }
        void loadNhom()
        {
            cbb_Nhom.DataSource = _nhh.getAll();
            cbb_Nhom.DisplayMember = "TENNHOM";
            cbb_Nhom.ValueMember = "IDNHOM";
        }
        void loadDVT()
        {
            cbb_dvt.DataSource = _dvt.getAll();
            cbb_dvt.DisplayMember = "TEN";
            cbb_dvt.ValueMember = "ID";
        }
        void loadNCC()
        {
            cbb_nhacc.DataSource = _ncc.getAll();
            cbb_nhacc.DisplayMember = "TENNCC";
            cbb_nhacc.ValueMember = "MANCC";
        }
        void loadXX()
        {
            cbb_xuatxu.DataSource = _xx.getAll();
            cbb_xuatxu.DisplayMember = "TEN";
            cbb_xuatxu.ValueMember = "ID";
        }
        void showHideControl(bool t)
        {
            toolStripButton_Them.Visible = t;
            toolStripButton_Sua.Visible = t;
            toolStripButton_Xoa.Visible = t;
            toolStripButton_Thoat.Visible = t;
            toolStripButton_Luu.Visible = !t;
            toolStripButton_Boqua.Visible = !t;
            toolStripButton_Export.Visible = t;
        }
        void _enableControl(bool t)
        {
            tb_ten.Enabled = t;
            tb_tentat.Enabled = t;
            tb_trigia.Enabled = t;
            cbb_dvt.Enabled = t;
            tb_mota.Enabled = t;
            cbb_xuatxu.Enabled = t;
            cbb_nhacc.Enabled = t;
            checkBox_disabled.Enabled = t;
        }
        void clearControl()
        {
            tb_barcode.Text = "";
            cbb_dvt.SelectedIndex = -1;
            tb_mota.Text = "";
            tb_ten.Text = "";
            tb_trigia.Text = "";
            cbb_xuatxu.SelectedIndex = -1;
            cbb_nhacc.SelectedIndex = -1;
            checkBox_disabled.Checked = false;
            tb_tentat.Text = "";
        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            Center();
        }
        private void Center()
        {
            int space = (panel2.ClientSize.Width - lb_nhacc.Width - tb_barcode.Width - 5) / 2 - 10;
            lb_barcode.Top = 30;
            lb_barcode.Left = space + lb_nhacc.Width - lb_barcode.Width;
            tb_barcode.Top = lb_barcode.Top - 3;
            tb_barcode.Left = lb_barcode.Right + 5;

            lb_ten.Top = lb_barcode.Bottom + 35;
            lb_ten.Left = space + lb_nhacc.Width - lb_ten.Width;
            tb_ten.Top = lb_ten.Top - 3;
            tb_ten.Left = tb_barcode.Left;

            lb_tentat.Top = lb_ten.Bottom + 35;
            lb_tentat.Left = space + lb_nhacc.Width - lb_tentat.Width;
            tb_tentat.Top = lb_tentat.Top - 3;
            tb_tentat.Left = tb_barcode.Left;

            lb_trigia.Top = lb_tentat.Bottom + 35;
            lb_trigia.Left = space + lb_nhacc.Width - lb_trigia.Width;
            tb_trigia.Top = lb_trigia.Top - 3;
            tb_trigia.Left = tb_barcode.Left;

            lb_dvt.Top = lb_trigia.Bottom + 35;
            lb_dvt.Left = space + lb_nhacc.Width - lb_dvt.Width;
            cbb_dvt.Top = lb_dvt.Top - 3;
            cbb_dvt.Left = tb_barcode.Left;

            lb_xuatxu.Top = lb_dvt.Bottom + 35;
            lb_xuatxu.Left = space + lb_nhacc.Width - lb_xuatxu.Width;
            cbb_xuatxu.Top = lb_xuatxu.Top - 3;
            cbb_xuatxu.Left = tb_barcode.Left;

            lb_nhacc.Top = lb_xuatxu.Bottom + 35;
            lb_nhacc.Left = space;
            cbb_nhacc.Top = lb_nhacc.Top - 3;
            cbb_nhacc.Left = tb_barcode.Left;

            lb_mota.Top = lb_nhacc.Bottom + 35;
            lb_mota.Left = space + lb_nhacc.Width - lb_mota.Width;
            tb_mota.Top = lb_mota.Top - 3;
            tb_mota.Left = tb_barcode.Left;

            tb_mota.Height = 250;

            checkBox_disabled.Top = tb_mota.Bottom + 10;
            checkBox_disabled.Left = tb_mota.Left + tb_mota.Width / 2;

            lb_thongtin.Top = (panel1.ClientSize.Height - lb_thongtin.Height) / 2;
        }

        private void panel3_Resize(object sender, EventArgs e)
        {
            lb_nhom.Left = (panel3.ClientSize.Width - lb_nhom.Width - cbb_Nhom.Width - 3) / 2;
            lb_nhom.Top = (panel3.ClientSize.Height - lb_nhom.Height) / 2;
            cbb_Nhom.Top = lb_nhom.Top - 3;
            cbb_Nhom.Left = lb_nhom.Right + 3;
        }

        private void toolStripButton_Them_Click(object sender, EventArgs e)
        {
            if (right == 1)
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
            if (right == 1)
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
            if (right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Bạn chưa chọn mặt hàng nào để xóa");
                    return;
                }
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["BARCODE"].Value != null)
                        {
                            list.Add(row.Cells["BARCODE"].Value.ToString());
                        }
                    }
                    foreach (string i in list)
                    {
                        _hh.delete(i);
                    }
                }
                loadData();
                clearControl();
            }
           
        }
        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_ten.Text.Trim()))
            {
                MessageBox.Show("Tên hàng hóa không được để trống");
                tb_ten.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tb_trigia.Text.Trim()))
            {
                MessageBox.Show("Đơn giá không được để trống");
                tb_trigia.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbb_dvt.Text.Trim()))
            {
                MessageBox.Show("Đơn vị tính không được để trống");
                cbb_dvt.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbb_xuatxu.Text.Trim()))
            {
                MessageBox.Show("Xuất xứ không được để trống");
                cbb_xuatxu.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cbb_nhacc.Text.Trim()))
            {
                MessageBox.Show("Nhà cung cấp không được để trống");
                cbb_nhacc.Focus();
                return;
            }
            if (_them)
            {
                tb_HANGHOA hh = new tb_HANGHOA();
                _ss = _seq.getItem("HH@" + DateTime.Now.Year.ToString() + "@" + cbb_Nhom.SelectedValue.ToString());
                if(_ss == null)
                {
                    _ss = new tb_SYS_SEQUENCE();
                    _ss.SEQNAME = "HH@" + DateTime.Now.Year.ToString() + "@" + cbb_Nhom.SelectedValue.ToString();
                    _ss.SEQVALUE = 1;
                    _seq.add(_ss);
                }
                hh.BARCODE = BARCODEEAN13.BuildEAN13(DateTime.Now.Year.ToString() + cbb_Nhom.SelectedValue.ToString() +  _ss.SEQVALUE.Value.ToString("0000000"));
                hh.TENHH = tb_ten.Text;
                hh.TENTAT = tb_tentat.Text;
                hh.DONGIA = Convert.ToDouble(tb_trigia.Text);
                hh.DVT = cbb_dvt.Text;
                hh.MOTA = tb_mota.Text;
                hh.MAXX = Convert.ToInt32(cbb_xuatxu.SelectedValue.ToString());
                hh.MANCC = cbb_nhacc.SelectedValue.ToString();
                hh.IDNHOM = Convert.ToInt32(cbb_Nhom.SelectedValue.ToString());
                hh.CREATED_DATE = DateTime.Now;
                hh.CREATED_BY = 1;
                hh.DISABLE = checkBox_disabled.Checked;
                var hh1 = _hh.add(hh);
                tb_barcode.Text = hh1.BARCODE;
                _seq.update(_ss);
            }
            else {
                tb_HANGHOA hh = _hh.getItem(tb_barcode.Text);
                hh.TENHH = tb_ten.Text;
                hh.TENTAT = tb_tentat.Text;
                hh.DONGIA = Convert.ToDouble(tb_trigia.Text);
                hh.DVT = cbb_dvt.Text;
                hh.MOTA = tb_mota.Text;
                hh.MAXX = Convert.ToInt32(cbb_xuatxu.SelectedValue.ToString());
                hh.MANCC = cbb_nhacc.SelectedValue.ToString();
                hh.IDNHOM = Convert.ToInt32(cbb_Nhom.SelectedValue.ToString());
                hh.DISABLE = checkBox_disabled.Checked;
                _hh.update(hh);
            }
            _them = false;
            showHideControl(true);
            _enableControl(false);
            loadData();
        }

        private void toolStripButton_Boqua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
            _enableControl(false);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                tb_HANGHOA hh = (tb_HANGHOA)dataGridView1.SelectedRows[0].DataBoundItem;
                tb_barcode.Text = hh.BARCODE;
                tb_ten.Text = hh.TENHH;
                tb_tentat.Text = hh.TENTAT;
                tb_trigia.Text = hh.DONGIA.ToString();
                cbb_dvt.Text = hh.DVT;
                tb_mota.Text = hh.MOTA;
                cbb_xuatxu.SelectedValue = hh.MAXX;
                cbb_nhacc.SelectedValue = hh.MANCC;
                checkBox_disabled.Checked = hh.DISABLE.Value;
                if (hh.DISABLE.Value)
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

        private void frmHanghoa_Load(object sender, EventArgs e)
        {
            _hh = new HANGHOA();
            _nhh = new NHOMHH();
            _dvt = new DONVITINH();
            _ncc = new NHACUNGCAP();
            _xx = new XUATXU();
            _seq = new SYS_SEQUENCE();

            loadNhom();
            loadDVT();
            loadNCC();
            loadXX();
            loadData();

            showHideControl(true);
            _enableControl(false);
            clearControl();

            cbb_Nhom.SelectedIndex = 0;
        }

        private void toolStripButton_Export_Click(object sender, EventArgs e)
        {
            if (right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
                _export();
        }

        private void cbb_Nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_Nhom.SelectedIndex >= 0)
            {
                loadData();
            }
        }
        void _export()
        {
            string tenFile = "";
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Excel 2000-2003 (.xls)|*.xls|Excel 2007 or higher (.xlsx)|*.xlsx";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                tenFile = sf.FileName;
            }
            else return;
            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Excel._Worksheet sheet = null;
            try
            {
                sheet = wb.ActiveSheet;
                sheet.Name = "Danh mục " + cbb_Nhom.Text;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 12]].Merge();
                sheet.Cells[1,1].horizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, 12]].BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic);
                sheet.Cells[1, 1].Value = "DANH MỤC " + cbb_Nhom.Text.ToUpper();
                sheet.Cells[1, 1].Font.Size = 20;
                sheet.Cells[2, 1].Value = "BARCODE";
                sheet.Cells[2, 2].Value = "TÊN HÀNG HÓA";
                sheet.Cells[2, 3].Value = "TÊN TẮT";
                sheet.Cells[2, 4].Value = "ĐƠN VỊ TÍNH";
                sheet.Cells[2, 5].Value = "ĐƠN GIÁ";
                sheet.Cells[2, 6].Value = "MÔ TẢ";
                sheet.Cells[2, 7].Value = "MÃ NHÓM";
                sheet.Cells[2, 8].Value = "TÊN NHÓM";
                sheet.Cells[2, 9].Value = "MÃ NHÀ CUNG CẤP";
                sheet.Cells[2, 10].Value = "TÊN NHÀ CUNG CẤP";
                sheet.Cells[2, 11].Value = "MÃ XUẤT XỨ";
                sheet.Cells[2, 12].Value = "XUẤT XỨ";

                for(int i = 1; i<= _lstHH.Count; i++)
                {
                    tb_HANGHOA hh = _lstHH[i - 1];
                    sheet.Cells[i + 2, 1].Value = hh.BARCODE;
                    sheet.Cells[i + 2, 2].Value = hh.TENHH;
                    sheet.Cells[i + 2, 3].Value = hh.TENTAT;
                    sheet.Cells[i + 2, 4].Value = hh.DVT;
                    sheet.Cells[i + 2, 5].Value = hh.DONGIA;
                    sheet.Cells[i + 2, 6].Value = hh.MOTA;
                    sheet.Cells[i + 2, 7].Value = hh.IDNHOM;
                    sheet.Cells[i + 2, 8].Value = _nhh.getItem(Convert.ToInt32(hh.IDNHOM)).TENNHOM;
                    sheet.Cells[i + 2, 9].Value = hh.MANCC;
                    sheet.Cells[i + 2, 10].Value = _ncc.getItem((hh.MANCC).ToString()).TENNCC;
                    sheet.Cells[i + 2, 11].Value = hh.MAXX;
                    sheet.Cells[i + 2, 12].Value = _xx.getItem(Convert.ToInt32(hh.MAXX)).TEN;
                }

                wb.SaveAs(tenFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xuất dữ liệu. " + ex.Message);
            }
            finally
            {
                wb.Close();
                app.Quit();
                releaseObject(wb);
                releaseObject(app);
                MessageBox.Show("Xuất File thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi khi giải phóng đối tượng Excel: " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
