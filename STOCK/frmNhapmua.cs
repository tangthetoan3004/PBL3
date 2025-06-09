using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Rectangle = System.Drawing.Rectangle;

namespace STOCK
{
    public partial class frmNhapmua : Form
    {
        public frmNhapmua()
        {
            InitializeComponent();
        }
        public frmNhapmua(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tb_soluong1.ReadOnly = true;
            tb_tongtien.ReadOnly = true;
            tb_soluongct.ReadOnly = true;
            tb_tongtienct.ReadOnly = true;
            _user = user;
            this.right = right;
            dataGridView1.ReadOnly = true;
        }
        tb_SYS_USER _user;
        int right;
        CONGTY _cty;
        DONVI _dvi;
        NHACUNGCAP _ncc;
        bool _them = false;
        bool _sua = false;
        bool _kt = false;
        List<string> _lsBarcode;
        string err = "";
        List<_TRANGTHAI> trangthai;
        CHUNGTU _chungtu;
        CHUNGTU_CT _chungtuct;
        SYS_SEQUENCE _seq;
        HANGHOA _hh;
        BindingSource _bdChungtuCT;
        BindingSource _bdChungtu;
        Guid _khoa;
        tb_SYS_SEQUENCE _tbs;
        List<tb_CHUNGTU> _lsChungtu;
        private bool allowTabChange = false;
        private bool isTab2 = true;
        Guid pKhoa;
        void showHideControl(bool t)
        {
            toolStripButton_Them.Visible = t;
            toolStripButton_Sua.Visible = t;
            toolStripButton_Xoa.Visible = t;
            toolStripButton_Thoat.Visible = t;
            toolStripButton_Luu.Visible = !t;
            toolStripButton_Boqua.Visible = !t;
            toolStripButton_Export.Visible = t;
            toolStripButton_quaylai.Visible = t;
        }

        void _enableControl(bool t)
        {
            tb_sophieu.Enabled = t;
            tb_ghichu.Enabled = t;
            cbb_trangthai.Enabled = t;
            cbb_nhacc.Enabled = t;
            dtp.Enabled = t;
        }

        void clearControl()
        {
            tb_sophieu.Text = "";
            tb_ghichu.Text = "";
            dtp.Value = DateTime.Now;
            cbb_nhacc.SelectedIndex = -1;
            cbb_trangthai.SelectedIndex = -1;
        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNhapmua_Load(object sender, EventArgs e)
        {
            _cty = new CONGTY();
            _dvi = new DONVI();
            _ncc = new NHACUNGCAP();
            _chungtu = new CHUNGTU();
            _chungtuct = new CHUNGTU_CT();
            _seq = new SYS_SEQUENCE();
            _hh = new HANGHOA();
            _bdChungtuCT = new BindingSource();
            _bdChungtu = new BindingSource();

            dtp1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp2.Value = DateTime.Now;

            _bdChungtu.PositionChanged += _bdChungtu_PositionChanged;

            showHideControl(true);

            toolStripButton_quaylai.Enabled = false;  

            loadCongty();
            cbb_Congty.SelectedValue = myFunctions._macty;

            trangthai = _TRANGTHAI.getList();
            cbb_trangthai.DataSource = trangthai;
            cbb_trangthai.DisplayMember = "_display";
            cbb_trangthai.ValueMember = "_value";

            loadDonvi(cbb_Congty.SelectedValue.ToString());
            loadNhacungcap();
            loadDonvi1();

            cbb_Donvi.SelectedValue = myFunctions._madvi;

            _lsChungtu = _chungtu.getList(1, dtp1.Value, dtp2.Value.AddDays(1), cbb_Donvi.SelectedValue.ToString());
            _bdChungtu.DataSource = _lsChungtu;
            dataGridView1.DataSource = _bdChungtu;
            _visible1();

            UpdateTongCongMain(); 
            xuatThongtin();
            contextMenuStrip1.Enabled = false;
        }

        private void _visible1()
        {
            dataGridView1.Columns["KHOA"].Visible = false;
            dataGridView1.Columns["SCT2"].Visible = false;
            dataGridView1.Columns["LCT"].Visible = false;
            dataGridView1.Columns["NGAY2"].Visible = false;
            dataGridView1.Columns["MACTY"].Visible = false;
            dataGridView1.Columns["MADVI"].Visible = false;
            dataGridView1.Columns["MADVI2"].Visible = false;
            dataGridView1.Columns["CREATED_DATE"].Visible = false;
            dataGridView1.Columns["CREATED_BY"].Visible = false;
            dataGridView1.Columns["UPDATED_DATE"].Visible = false;
            dataGridView1.Columns["UPDATED_BY"].Visible = false;
            dataGridView1.Columns["DELETED_DATE"].Visible = false;
            dataGridView1.Columns["CHIETKHAU"].Visible = false;
        }

        private void _visible2()
        {
            dataGridView2.Columns["KHOACT"].Visible = false;
            dataGridView2.Columns["KHOA"].Visible = false;
            dataGridView2.Columns["NGAY"].Visible = false;
            dataGridView2.Columns["CHIETKHAU"].Visible = false;
        }

        private void _bdChungtu_PositionChanged(object sender, EventArgs e)
        {
            xuatThongtin();
        }

        private void loadCongty()
        {
            cbb_Congty.DataSource = _cty.getAll();
            cbb_Congty.DisplayMember = "TENCTY";
            cbb_Congty.ValueMember = "MACTY";
        }

        private void loadDonvi(string macty)
        {
            cbb_Donvi.DataSource = _dvi.getAllbyKho(macty);
            cbb_Donvi.DisplayMember = "TENDVI";
            cbb_Donvi.ValueMember = "MADV";
        }

        private void loadNhacungcap()
        {
            cbb_nhacc.DataSource = _ncc.getAll();
            cbb_nhacc.DisplayMember = "TENNCC";
            cbb_nhacc.ValueMember = "MANCC";
        }

        private void loadDonvi1()
        {
            cbb_donvi1.DataSource = _dvi.getAllbyKho(cbb_Congty.SelectedValue.ToString());
            cbb_donvi1.DisplayMember = "TENDVI";
            cbb_donvi1.ValueMember = "MADV";
        }

        void _center()
        {
            lb_tungay.Left = (panel1.Width - lb_tungay.Width - 3 - cbb_Congty.Width) / 2;
            lb_tungay.Top = 20;
            dtp1.Left = lb_tungay.Right + 3;
            dtp1.Top = lb_tungay.Top - 3;
            lb_denngay.Top = lb_tungay.Top;
            dtp2.Top = dtp1.Top;
            lb_denngay.Left = dtp1.Left + (cbb_Congty.Width - dtp2.Width - 3 - lb_denngay.Width);
            dtp2.Left = lb_denngay.Right + 3;
            lb_congty.Top = lb_denngay.Bottom + 20;
            cbb_Congty.Top = lb_congty.Top - 3;
            cbb_Congty.Left = dtp1.Left;
            lb_congty.Left = cbb_Congty.Left - 3 - lb_congty.Width;
            lb_donvi.Top = lb_congty.Bottom + 20;
            cbb_Donvi.Top = lb_donvi.Top - 3;
            cbb_Donvi.Left = cbb_Congty.Left;
            lb_donvi.Left = cbb_Donvi.Left - 3 - lb_donvi.Width;
            panel1.Height = lb_donvi.Bottom + 20;
        }

        private void xuatThongtin()
        {
            tb_CHUNGTU ct = (tb_CHUNGTU)_bdChungtu.Current;
            if (ct != null)
            {
                _khoa = ct.KHOA;
                dtp.Value = ct.NGAY.Value;
                tb_sophieu.Text = ct.SCT;
                tb_ghichu.Text = ct.GHICHU;
                cbb_donvi1.SelectedValue = ct.MADVI;
                cbb_nhacc.SelectedValue = ct.MADVI2;

                cbb_trangthai.SelectedValue = ct.TRANGTHAI;

                if (ct.DELETED_BY != null && ct.DELETED_BY == _user.IDUSER)
                {
                    toolStripButton_Xoa.Enabled = false;
                    toolStripButton_Sua.Enabled = false;
                }
                else
                {
                    toolStripButton_Xoa.Enabled = true;
                    toolStripButton_Sua.Enabled = true;
                }
                _bdChungtuCT.DataSource = _chungtuct.getListByKhoaFull(ct.KHOA);
                dataGridView2.DataSource = _bdChungtuCT;
                _visible2();
                UpdateTongCong(); 
            }
        }
        private void _stt_ct()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["TENHH"].Value != null)
                {
                    row.Cells["STT"].Value = i++;
                }
            }
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            _center();
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
                _bdChungtuCT.DataSource = _chungtuct.getListByKhoaFull(pKhoa);
                dataGridView2.DataSource = _bdChungtuCT;
                _visible2();
                dataGridView2.ReadOnly = false;
                dataGridView2.AllowUserToAddRows = true;
                allowTabChange = true;
                tabControl1.SelectedTab = tabPage2;
                allowTabChange = false;
                _them = true;
                _sua = false;
                showHideControl(false);
                _enableControl(true);
                clearControl();
                contextMenuStrip1.Enabled = true;
                isTab2 = false;
            }
        }

        private void toolStripButton_Sua_Click(object sender, EventArgs e)
        {
            if(right == 1)
            {
                MessageBox.Show("Bạn không có quyền chỉnh sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                tb_CHUNGTU ct = (tb_CHUNGTU)_bdChungtu.Current;
                if (ct == null)
                {
                    MessageBox.Show("Vui lòng chọn một phiếu để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _them = false;
                _sua = true;
                showHideControl(false);
                _enableControl(true);
                allowTabChange = true;
                tabControl1.SelectedTab = tabPage2;
                allowTabChange = false;
                dataGridView2.AllowUserToAddRows = true;
                dataGridView2.ReadOnly = false;
                contextMenuStrip1.Enabled = true;
                isTab2 = true;
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
                if (_bdChungtu.Current != null)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        tb_CHUNGTU ct = (tb_CHUNGTU)_bdChungtu.Current;
                        _chungtu.delete(ct.KHOA, _user.IDUSER);
                        toolStripButton_Sua.Enabled = false;
                        toolStripButton_Xoa.Enabled = false;
                        dataGridView1.Refresh();
                        UpdateTongCongMain();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một phiếu để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void toolStripButton_Luu_Click(object sender, EventArgs e)
        {
            luuthongtin();
            if (_kt)
            {
                showHideControl(true);
                _enableControl(false);
                contextMenuStrip1.Enabled = false;
                allowTabChange = true;
                if (!isTab2)
                    tabControl1.SelectedTab = tabPage1;
                else
                {
                    tabControl1.SelectedTab = tabPage2;
                    toolStripButton_quaylai.Enabled = true;
                    toolStripButton_Them.Enabled = false;
                    toolStripButton_Xoa.Enabled = false;
                }
                allowTabChange = false;
            } 
        }

        private void toolStripButton_Boqua_Click(object sender, EventArgs e)
        {
            _them = false;
            _sua = false;
            showHideControl(true);
            clearControl();
            contextMenuStrip1.Enabled = false;
            xuatThongtin();
            allowTabChange = true;
            if (!isTab2)
                tabControl1.SelectedTab = tabPage1;
            else
            {
                tabControl1.SelectedTab = tabPage2;
                toolStripButton_quaylai.Enabled = true;
                toolStripButton_Them.Enabled = false;
                toolStripButton_Xoa.Enabled = false;
            }
            allowTabChange = false;
        }

        private void _center2()
        {
            int space1 = 90;
            int width1 = lb_ngay.Width + 3 + dtp.Width + space1 + lb_sophieu.Width + 3 + tb_sophieu.Width + space1 + lb_trangthai.Width + 3 + cbb_trangthai.Width;

            lb_ngay.Left = (panel2.Width - width1) / 2;
            lb_ngay.Top = 25;

            dtp.Top = lb_ngay.Top - 3;
            dtp.Left = lb_ngay.Right + 3;

            lb_sophieu.Top = lb_ngay.Top;
            lb_sophieu.Left = dtp.Right + space1;

            tb_sophieu.Top = lb_sophieu.Top - 3;
            tb_sophieu.Left = lb_sophieu.Right + 3;

            lb_trangthai.Top = lb_ngay.Top;
            lb_trangthai.Left = tb_sophieu.Right + space1;

            cbb_trangthai.Top = lb_trangthai.Top - 3;
            cbb_trangthai.Left = lb_trangthai.Right + 3;

            int space2 = 30;
            int width2 = lb_donvi2.Width + 3 + cbb_donvi1.Width + space2 + lb_nhacungcap.Width + 3 + cbb_nhacc.Width;

            lb_donvi2.Left = (panel2.Width - width2) / 2;
            lb_donvi2.Top = lb_ngay.Bottom + 25;

            cbb_donvi1.Top = lb_donvi2.Top - 3;
            cbb_donvi1.Left = lb_donvi2.Right + 3;

            lb_nhacungcap.Top = lb_donvi2.Top;
            lb_nhacungcap.Left = cbb_donvi1.Right + space2;

            cbb_nhacc.Top = lb_nhacungcap.Top - 3;
            cbb_nhacc.Left = lb_nhacungcap.Right + 3;

            lb_ghichu.Top = lb_donvi2.Bottom + 25;
            lb_ghichu.Left = lb_donvi2.Left + lb_donvi2.Width - lb_ghichu.Width;

            tb_ghichu.Top = lb_ghichu.Top - 3;
            tb_ghichu.Left = lb_ghichu.Right + 3;

            tb_ghichu.Width = width2 - lb_donvi2.Width - 3;


            panel2.Height = lb_ghichu.Bottom + 50;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            _center2();
        }
        private void Chungtu_Info(tb_CHUNGTU ct)
        {
            int _SOLUONG = 0;
            double _TONGTIEN = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells["TENHH"].Value != null)
                {
                    if (dataGridView2.Rows[i].Cells["SOLUONGCT"].Value != null)
                    {
                        _SOLUONG += Convert.ToInt32(dataGridView2.Rows[i].Cells["SOLUONGCT"].Value);
                    }
                    if (dataGridView2.Rows[i].Cells["THANHTIEN"].Value != null)
                    {
                        _TONGTIEN += Convert.ToDouble(dataGridView2.Rows[i].Cells["THANHTIEN"].Value);
                    }
                }
            }
            tb_DONVI dvi = _dvi.getItem(cbb_donvi1.SelectedValue.ToString());
            _tbs = _seq.getItem("NHM@" + DateTime.Today.Year.ToString() + "@" + dvi.KYHIEU);
            if (_tbs == null)
            {
                _tbs = new tb_SYS_SEQUENCE();
                _tbs.SEQNAME = "NHM@" + DateTime.Today.Year.ToString() + "@" + dvi.KYHIEU;
                _tbs.SEQVALUE = 1;
                _seq.add(_tbs);
            }
            if (_them)
            {
                ct.KHOA = Guid.NewGuid();
                ct.SCT = _tbs.SEQVALUE.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/NHM/" + dvi.KYHIEU;
                ct.CREATED_BY = _user.IDUSER;
                ct.CREATED_DATE = DateTime.Now;
            }
            ct.LCT = 1;
            ct.NGAY = dtp.Value;
            ct.MACTY = cbb_Congty.SelectedValue.ToString();
            ct.MADVI = cbb_donvi1.SelectedValue.ToString();
            ct.MADVI2 = cbb_nhacc.SelectedValue.ToString();
            ct.GHICHU = tb_ghichu.Text;
            ct.TRANGTHAI = Convert.ToInt32(cbb_trangthai.SelectedValue.ToString());
            ct.SOLUONG = _SOLUONG;
            ct.TONGTIEN = _TONGTIEN;
            ct.UPDATED_BY = _user.IDUSER;
            ct.UPDATED_DATE = DateTime.Now;
        }

        private void Chungtu_CT_Info(tb_CHUNGTU ct)
        {
            _chungtuct.deleteAll(ct.KHOA);
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells["TENHH"].Value != null)
                {
                    tb_CHUNGTU_CT ctct = new tb_CHUNGTU_CT();
                    ctct.KHOACT = Guid.NewGuid();
                    ctct.KHOA = ct.KHOA;
                    ctct.BARCODE = dataGridView2.Rows[i].Cells["BARCODE"].Value.ToString();
                    ctct.SOLUONGCT = Convert.ToInt32(dataGridView2.Rows[i].Cells["SOLUONGCT"].Value);
                    ctct.DONGIA = Convert.ToDouble(dataGridView2.Rows[i].Cells["DONGIA"].Value);
                    ctct.THANHTIEN = Convert.ToDouble(dataGridView2.Rows[i].Cells["THANHTIEN"].Value);
                    ctct.STT = i + 1;
                    ctct.NGAY = dtp.Value;
                    _chungtuct.add(ctct);
                }
            }
        }

        private void luuthongtin()
        {
            err = "";
            tb_CHUNGTU ct;
            if (dataGridView2.RowCount == 0 || (dataGridView2.RowCount == 1 && dataGridView2.Rows[0].Cells["BARCODE"].Value == null))
            {
                err += "Chi tiết phiếu xuất không được rỗng.\n";
                _kt = false;
                MessageBox.Show(err, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbb_donvi1.SelectedValue == null)
                err += "Đơn vị không được trống.\n";
            if (cbb_nhacc.SelectedValue == null)
                err += "Nhà cung cấp không được trống.\n";
            if (cbb_trangthai.SelectedValue == null)
                err += "Trạng thái không được trống.\n";

            if (!string.IsNullOrEmpty(err))
            {
                MessageBox.Show(err, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _kt = false;
                return;
            }
            if (_them)
            {
                ct = new tb_CHUNGTU();
                Chungtu_Info(ct);
                var resultct = _chungtu.add(ct);
                _seq.update(_tbs);

                Chungtu_CT_Info(resultct);
                _bdChungtu.Add(resultct);
                _bdChungtu.MoveLast();
            }
            else
            {
                ct = (tb_CHUNGTU)_bdChungtu.Current;
                ct = _chungtu.getItem(ct.KHOA);
                Chungtu_Info(ct);
                var resultct = _chungtu.update(ct);
                Chungtu_CT_Info(resultct);

                _lsChungtu = _chungtu.getList(1, dtp1.Value, dtp2.Value.AddDays(1), cbb_Donvi.SelectedValue.ToString());
                _bdChungtu.DataSource = _lsChungtu;
                dataGridView1.Refresh();
                var obj = _bdChungtu.List.OfType<tb_CHUNGTU>().ToList().Find(p => p.SCT == resultct.SCT);
                _bdChungtu.Position = _bdChungtu.IndexOf(obj);
            }
            UpdateTongCongMain(); 
            xuatThongtin();
            _them = false;
            _sua = false;
            _kt = true;
        }

        private void pn_tong1_Resize(object sender, EventArgs e)
        {
            lb_tong.Top = 15;
            lb_tong.Left = 800;

            lb_soluong1.Top = lb_tong.Top;
            lb_soluong1.Left = lb_tong.Right + 80;

            tb_soluong1.Top = lb_soluong1.Top - 3;
            tb_soluong1.Left = lb_soluong1.Right + 3;

            lb_tongtien.Top = lb_tong.Top;
            lb_tongtien.Left = tb_soluong1.Right + 50;

            tb_tongtien.Top = lb_tongtien.Top - 3;
            tb_tongtien.Left = lb_tongtien.Right + 3;

            pn_tong1.Height = lb_tong.Bottom + 15;

            dataGridView1.Location = new System.Drawing.Point(
                dataGridView1.Location.X,
                panel1.Bottom
            );
            int newHeight = pn_tong1.Top - panel1.Bottom;
            dataGridView1.Height = newHeight;
        }

        private void pn_tong2_Resize(object sender, EventArgs e)
        {
            lb_tong2.Top = 15;
            lb_tong2.Left = 800;

            lb_soluongct.Top = lb_tong2.Top;
            lb_soluongct.Left = lb_tong2.Right + 80;

            tb_soluongct.Top = lb_soluongct.Top - 3;
            tb_soluongct.Left = lb_soluongct.Right + 3;

            lb_tongtienct.Top = lb_tong2.Top;
            lb_tongtienct.Left = tb_soluongct.Right + 50;

            tb_tongtienct.Top = lb_tongtienct.Top - 3;
            tb_tongtienct.Left = lb_tongtienct.Right + 3;

            pn_tong2.Height = lb_tong2.Bottom + 15;

            dataGridView2.Location = new System.Drawing.Point(
                dataGridView2.Location.X,
                panel2.Bottom
            );
            int newHeight = pn_tong2.Top - panel2.Bottom;
            dataGridView2.Height = newHeight;
        }

        private void UpdateTongCong()
        {
            int tongSL = 0;
            double tongTien = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if(row.IsNewRow) continue;
                if (row.Cells["SOLUONGCT"].Value != null && row.Cells["THANHTIEN"].Value != null)
                {
                    tongSL += Convert.ToInt32(row.Cells["SOLUONGCT"].Value);
                    tongTien += Convert.ToDouble(row.Cells["THANHTIEN"].Value);
                }
            }

            tb_soluongct.Text = tongSL.ToString();
            tb_soluongct.TextAlign = HorizontalAlignment.Right;
            tb_tongtienct.Text = tongTien.ToString("N0");
            tb_tongtienct.TextAlign = HorizontalAlignment.Right;

            _stt_ct();
        }

        private void UpdateTongCongMain()
        {
            int tongSL = 0;
            double tongTien = 0;

            foreach (tb_CHUNGTU ct in _lsChungtu)
            {
                if (ct.DELETED_BY != _user.IDUSER)
                {
                    tongSL += ct.SOLUONG ?? 0;
                    tongTien += ct.TONGTIEN ?? 0;
                }
            }

            tb_soluong1.Text = tongSL.ToString();
            tb_soluong1.TextAlign = HorizontalAlignment.Right;
            tb_tongtien.Text = tongTien.ToString("N0");
            tb_tongtien.TextAlign = HorizontalAlignment.Right;

            _stt_main();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _stt_ct();
            _stt_main();
            if(tabControl1.SelectedIndex == 1 && !_them && !_sua)
            {
                _enableControl(false);
                toolStripButton_quaylai.Enabled = true;
                toolStripButton_Xoa.Enabled = false;
                toolStripButton_Them.Enabled = false;
            }
            else
            {
                toolStripButton_quaylai.Enabled = false;
                toolStripButton_Xoa.Enabled = true;
                toolStripButton_Them.Enabled = true;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TRANGTHAIDS")
            {
                if (e.Value != null && e.Value.ToString() == "1")
                {
                    e.Value = "Chưa hoàn tất";
                    e.FormattingApplied = true;
                }
                else if (e.Value != null && e.Value.ToString() == "2")
                {
                    e.Value = "Đã hoàn tất";
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETED_BY")
            {
                if (e.Value != null && e.Value.ToString() == Convert.ToString(_user.IDUSER))
                {
                    using (SolidBrush whiteBrush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillRectangle(whiteBrush, e.CellBounds);
                    }
                    Image image = imageList1.Images[0];
                    int x = e.CellBounds.X + (e.CellBounds.Width - image.Width) / 2;
                    int y = e.CellBounds.Y + (e.CellBounds.Height - image.Height) / 2;
                    e.Graphics.DrawImage(image, x, y);
                    using (Pen borderPen = new Pen(Color.Black))
                    {
                        Rectangle borderRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width - 1, e.CellBounds.Height - 1);
                        e.Graphics.DrawRectangle(borderPen, borderRect);
                    }
                    e.Handled = true;
                }
            }
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            ReloadChungTuList();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            ReloadChungTuList();
        }

        private void ReloadChungTuList()
        {
            if(cbb_Donvi.SelectedValue == null)
                return;
            _lsChungtu = _chungtu.getList(1, dtp1.Value, dtp2.Value.AddDays(1), cbb_Donvi.SelectedValue.ToString());
            _bdChungtu.DataSource = _lsChungtu;
            dataGridView1.DataSource = _bdChungtu;
            _visible1();
            UpdateTongCongMain();
            xuatThongtin();
        }
        private void _stt_main()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["SCT"].Value != null)
                {
                    row.Cells["STT1"].Value = i++;
                }
            }
        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            UpdateTongCong(); 
        }

        private void dataGridView2_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTongCong(); 
        }

        private void _exportExcel()
        {
            if (dataGridView2.Rows.Count == 0 || (dataGridView2.Rows.Count == 1 && dataGridView2.Rows[0].IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(tb_sophieu.Text))
            {
                MessageBox.Show("Số phiếu không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 2000-2003 (.xls)|*.xls|Excel 2007 or higher (.xlsx)|*.xlsx";
            saveFileDialog.FileName = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = null;
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;

                try
                {
                    excelApp = new Excel.Application();
                    excelApp.Visible = false;
                    workbook = excelApp.Workbooks.Add(Type.Missing);
                    worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                    worksheet.Name = "ChiTietChungTu";

                    worksheet.Cells[1, 1] = "Số phiếu:  " + tb_sophieu.Text;
                    Excel.Range sophieuRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1,7]];
                    sophieuRange.Merge(); 
                    sophieuRange.Font.Size = 20;
                    sophieuRange.Font.Bold = true; 
                    sophieuRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    var visibleColumns = dataGridView2.Columns
                    .Cast<DataGridViewColumn>()
                    .Where(col => col.Visible)
                    .OrderBy(col => col.DisplayIndex)
                    .ToList();

                    int colIndex = 1;
                    foreach (DataGridViewColumn column in visibleColumns)
                    {
                        if (column.Visible)
                        {
                            worksheet.Cells[2, colIndex] = column.HeaderText;
                            colIndex++;
                        }
                    }

                    int rowIndex = 3;
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        if (row.IsNewRow) continue;

                        colIndex = 1;
                        foreach (DataGridViewColumn column in visibleColumns)
                        {
                            if (column.Visible)
                            {
                                object cellValue = row.Cells[column.Index].Value;
                                worksheet.Cells[rowIndex, colIndex] = cellValue?.ToString() ?? "";
                                colIndex++;
                            }
                        }
                        rowIndex++;
                    }

                    int totalRow = rowIndex;
                    worksheet.Cells[totalRow, 1] = "Tổng cộng";
                    Excel.Range tongCongLabel = worksheet.Range[worksheet.Cells[totalRow, 1], worksheet.Cells[totalRow, 4]];
                    tongCongLabel.Merge();
                    tongCongLabel.Font.Size = 14;
                    tongCongLabel.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    worksheet.Cells[totalRow, 5] = tb_soluongct.Text;
                    worksheet.Cells[totalRow, 6] = tb_tongtienct.Text;
                    Excel.Range tongCongValue = worksheet.Range[worksheet.Cells[totalRow, 6], worksheet.Cells[totalRow, 7]];
                    tongCongValue.Merge();
                    tongCongValue.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    worksheet.Columns.AutoFit();

                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (worksheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    if (workbook != null)
                    {
                        workbook.Close(false);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    }
                    if (excelApp != null)
                    {
                        excelApp.Quit();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    }
                }
            }
        }

        private void toolStripButton_Export_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1 && !_them && !_sua)
            {
                _exportExcel();
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một phiếu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("Chỉ được chọn một phiếu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _exportExcel();
        }

        private void xóaDòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                if (!selectedRow.IsNewRow)
                {
                    dataGridView2.Rows.Remove(selectedRow);
                    UpdateTongCong();
                }
            }
        }

        private void xóaTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView2.Rows.Count - 1; i >= 0; i--)
            {
                if (!dataGridView2.Rows[i].IsNewRow)
                {
                    dataGridView2.Rows.RemoveAt(i);
                }
            }
            UpdateTongCong();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            allowTabChange = true;
            tabControl1.SelectedTab = tabPage2;
            dataGridView2.ReadOnly = true;
            allowTabChange = false;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if (dataGridView2.Columns[e.ColumnIndex].Name == "BARCODE")
            {
                object cv = dataGridView2[e.ColumnIndex, e.RowIndex].Value;
                if (cv != null)
                {
                    string barcode = cv.ToString();

                    if (barcode.StartsWith("."))
                    {
                        string tenhh = dataGridView2.Rows[e.RowIndex].Cells["TENHH"].Value?.ToString();
                        frmDanhMuc f = new frmDanhMuc(_bdChungtuCT, barcode,e.RowIndex,tenhh);
                        f.ShowDialog();
                        if (!String.IsNullOrEmpty(tenhh))
                        {
                            tb_HANGHOA hh = _hh.getItemByTen(tenhh);
                            if (hh != null)
                            {
                                dataGridView2.Rows[e.RowIndex].Cells["BARCODE"].Value = hh.BARCODE;
                            }
                        }
                    }
                    else
                    {
                        tb_HANGHOA hh = _hh.getItem(barcode);
                        if (hh != null)
                        {
                            dataGridView2.Rows[e.RowIndex].Cells["TENHH"].Value = hh.TENHH;
                            dataGridView2.Rows[e.RowIndex].Cells["DVT"].Value = hh.DVT;
                            dataGridView2.Rows[e.RowIndex].Cells["SOLUONGCT"].Value = 1;
                            dataGridView2.Rows[e.RowIndex].Cells["DONGIA"].Value = hh.DONGIA;
                            dataGridView2.Rows[e.RowIndex].Cells["THANHTIEN"].Value = Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["SOLUONGCT"].Value) * Convert.ToDouble(dataGridView2.Rows[e.RowIndex].Cells["DONGIA"].Value);
                        }
                        else
                        {
                            MessageBox.Show("Mã hàng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            if (dataGridView2.Columns[e.ColumnIndex].Name == "SOLUONGCT" || dataGridView2.Columns[e.ColumnIndex].Name == "DONGIA")
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                if (row.Cells["SOLUONGCT"].Value != null && row.Cells["DONGIA"].Value != null)
                {
                    int soLuong = Convert.ToInt32(row.Cells["SOLUONGCT"].Value);
                    double donGia = Convert.ToDouble(row.Cells["DONGIA"].Value);
                    row.Cells["THANHTIEN"].Value = soLuong * donGia;
                }
            }
            UpdateTongCong();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if(!allowTabChange)
            {
                e.Cancel = true;
            }
        }

        private void toolStripButton_quaylai_Click(object sender, EventArgs e)
        {
            allowTabChange = true;
            tabControl1.SelectedTab = tabPage1;
            allowTabChange = false;
        }
        private void toolStripButton_In_Click(object sender, EventArgs e)
        {
            XuatReport("PHIEU_NHAPMUA_NCC", "Phiếu nhập mua nhà cung cấp");
        }
        private void XuatReport(string _reportName, string _tieude)
        {
                    if (_khoa != null)
                    {
                        Form frm = new Form();
                        CrystalReportViewer Crv = new CrystalReportViewer();
                        Crv.ShowGroupTreeButton = false;
                        Crv.ShowParameterPanelButton = false;
                        Crv.ToolPanelView = ToolPanelViewType.None;
                        TableLogOnInfo Thongtin;
                        ReportDocument doc = new ReportDocument(); 
                        doc.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\" + _reportName + @".rpt");
                        Thongtin = doc.Database.Tables[0].LogOnInfo;

                        Thongtin.ConnectionInfo.ServerName = myFunctions._srv;
                        Thongtin.ConnectionInfo.DatabaseName = myFunctions._db;
                        Thongtin.ConnectionInfo.IntegratedSecurity = true;
                        doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
                        try
                        {
                            doc.SetParameterValue("khoa", _khoa.ToString());
                            Crv.Dock = DockStyle.Fill;
                            Crv.ReportSource = doc;
                            frm.Controls.Add(Crv);
                            Crv.Refresh();
                            frm.Text = _tieude;
                            frm.WindowState = FormWindowState.Maximized;
                            frm.ShowDialog();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}\nChi tiết: {ex.InnerException?.Message}");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }
    }
}