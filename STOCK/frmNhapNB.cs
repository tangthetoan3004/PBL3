using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using DevExpress.Data.Mask.Internal;
using DevExpress.Data.TreeList;
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
    public partial class frmNhapNB: Form
    {
        public frmNhapNB()
        {
            InitializeComponent();
        }
        public frmNhapNB(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this.right = right;
            this.WindowState = FormWindowState.Maximized;
            tb_soluong1.ReadOnly = true;
            tb_tongtien.ReadOnly = true;
            tb_soluongct.ReadOnly = true;
            tb_tongtienct.ReadOnly = true;
            dataGridView1.ReadOnly = true;
        }

        tb_SYS_USER _user;
        private int right;
        private int creater;
        CONGTY _cty;
        DONVI _dvi;
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

        private void frmNhapNB_Load(object sender, EventArgs e)
        {
            _cty = new CONGTY();
            _dvi = new DONVI();
            _chungtu = new CHUNGTU();
            _chungtuct = new CHUNGTU_CT();
            _seq = new SYS_SEQUENCE();
            _hh = new HANGHOA();
            _bdChungtuCT = new BindingSource();
            _bdChungtu = new BindingSource();

            dtp1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp2.Value = DateTime.Now;

            _bdChungtu.PositionChanged += _bdChungtu_PositionChanged;

            loadCongty();
            cbb_Congty.SelectedValue = myFunctions._macty;

            trangthai = _TRANGTHAI.getList();
            cbb_trangthai.DataSource = trangthai;
            cbb_trangthai.DisplayMember = "_display";
            cbb_trangthai.ValueMember = "_value";


            loadDonvi(cbb_Congty.SelectedValue.ToString());
            loadDonviNhap();
            loadDonvi1();
            cbb_Donvi.Enabled = false;
            cbb_Congty.Enabled = false;
            if (myFunctions._madvi == "~")
            {
                cbb_Donvi.SelectedValue = "CTKH01";
            }
            else
            {
                cbb_Donvi.SelectedValue = myFunctions._madvi;
            }
            _lsChungtu = _chungtu.getPhieuNhap(2, dtp1.Value, dtp2.Value.AddDays(1),cbb_Donvi.SelectedValue.ToString());
            _bdChungtu.DataSource = _lsChungtu;
            dataGridView1.DataSource = _bdChungtu;
            _visible1();

            UpdateTongCongMain();
            xuatThongtin();
           
            toolStripButton_quaylai.Enabled = false;
            toolStripButton_Tao.Enabled = true;
            _enableControl(false);
        }

        private void _bdChungtu_PositionChanged(object sender, EventArgs e)
        {
            xuatThongtin();
        }

        private void toolStripButton_Tao_Click(object sender, EventArgs e)
        {
            if(right == 1)
            {
                MessageBox.Show("Bạn không có quyền thao tác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                tb_CHUNGTU ct;
                string madvi = "";
                if(myFunctions._madvi == "~")
                {
                    madvi = "CTKH01";
                }
                else
                {
                    madvi = cbb_Donvi.SelectedValue.ToString();
                }
                tb_DONVI dvi = _dvi.getItem(cbb_Donvi.SelectedValue.ToString());
                _tbs = _seq.getItem("NNB@" + DateTime.Today.Year.ToString() + "@" + dvi.KYHIEU);
                if (_tbs == null)
                {
                    _tbs = new tb_SYS_SEQUENCE();
                    _tbs.SEQNAME = "NNB@" + DateTime.Today.Year.ToString() + "@" + dvi.KYHIEU;
                    _tbs.SEQVALUE = 1;
                    _seq.add(_tbs);
                }
                if (_bdChungtu.Current == null)
                {
                    MessageBox.Show("Không có phiếu để tạo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ct = (tb_CHUNGTU)_bdChungtu.Current;
                ct = _chungtu.getItem(ct.KHOA);
                ct.SCT2 = _tbs.SEQVALUE.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/NNB/" + dvi.KYHIEU; 
                ct.NGAY2 = DateTime.Now;    
                var resultct = _chungtu.update(ct);
                _seq.update(_tbs);

                _lsChungtu = _chungtu.getPhieuNhap(2, dtp1.Value, dtp2.Value.AddDays(1), cbb_Donvi.SelectedValue.ToString());
                _bdChungtu.DataSource = _lsChungtu;
                dataGridView1.Refresh();
                var obj = _bdChungtu.List.OfType<tb_CHUNGTU>().ToList().Find(p => p.SCT == resultct.SCT);
                _bdChungtu.Position = _bdChungtu.IndexOf(obj);
                UpdateTongCongMain();
                xuatThongtin();

            }
        }

        private void toolStripButton_In_Click(object sender, EventArgs e)
        {
            if (right == 1)
            {
                MessageBox.Show("Bạn không có quyền thao tác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                XuatReport("PHIEU_NHAPNB", "Phiếu nội bộ");

        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void _visible1()
        {
            dataGridView1.Columns["KHOA"].Visible = false;
            dataGridView1.Columns["LCT"].Visible = false;
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

        void _enableControl(bool t)
        {
            tb_sophieu.Enabled = t;
            tb_ghichu.Enabled = t;
            cbb_trangthai.Enabled = t;
            cbb_donvixuat.Enabled = t;
            dtp.Enabled = t;
            dtNgayNhap.Enabled = t;
            txtSoPhieuNhap.Enabled = t;
        }

        private void loadCongty()
        {
            cbb_Congty.DataSource = _cty.getAll();
            cbb_Congty.DisplayMember = "TENCTY";
            cbb_Congty.ValueMember = "MACTY";
        }

        private void loadDonvi(string macty)
        {
            cbb_Donvi.DataSource = _dvi.getAll(macty);
            cbb_Donvi.DisplayMember = "TENDVI";
            cbb_Donvi.ValueMember = "MADV";
        }
        private void loadDonvi1()
        {
            cbb_donvixuat.DataSource = _dvi.getAllbyKho(cbb_Congty.SelectedValue.ToString());
            cbb_donvixuat.DisplayMember = "TENDVI";
            cbb_donvixuat.ValueMember = "MADV";
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

        private void _center2()
        {
            int space1 = 20;
            int width1 = lb_ngay.Width + 3 + dtp.Width + space1 + lb_ngaynhap.Width + 3 + dtNgayNhap.Width + space1 + lb_sophieu.Width + 3 + tb_sophieu.Width + space1 + lb_sophieunhap.Width + 3 + txtSoPhieuNhap.Width + space1 + lb_trangthai.Width + 3 + cbb_trangthai.Width;

            lb_ngay.Left = (panel2.Width - width1) / 2;
            lb_ngay.Top = 25;

            dtp.Top = lb_ngay.Top - 3;
            dtp.Left = lb_ngay.Right + 3;

            lb_ngaynhap.Top = lb_ngay.Top;
            lb_ngaynhap.Left = dtp.Right + space1;

            dtNgayNhap.Top = dtp.Top;
            dtNgayNhap.Left = lb_ngaynhap.Right + 3;

            lb_sophieu.Top = lb_ngay.Top;
            lb_sophieu.Left = dtNgayNhap.Right + space1;

            tb_sophieu.Top = lb_sophieu.Top - 3;
            tb_sophieu.Left = lb_sophieu.Right + 3;

            lb_sophieunhap.Top = lb_ngay.Top;
            lb_sophieunhap.Left = tb_sophieu.Right + space1;

            txtSoPhieuNhap.Top = tb_sophieu.Top;
            txtSoPhieuNhap.Left = lb_sophieunhap.Right + 3;

            lb_trangthai.Top = lb_ngay.Top;
            lb_trangthai.Left = txtSoPhieuNhap.Right + space1;

            cbb_trangthai.Top = lb_trangthai.Top - 3;
            cbb_trangthai.Left = lb_trangthai.Right + 3;

            int space2 = 30;
            int width2 = lb_donvi2.Width + 3 + cbb_donvixuat.Width + space2 + lb_nhacungcap.Width + 3 + cbb_donvinhap.Width;

            lb_donvi2.Left = (panel2.Width - width2) / 2;
            lb_donvi2.Top = lb_ngay.Bottom + 25;

            cbb_donvixuat.Top = lb_donvi2.Top - 3;
            cbb_donvixuat.Left = lb_donvi2.Right + 3;

            lb_nhacungcap.Top = lb_donvi2.Top;
            lb_nhacungcap.Left = cbb_donvixuat.Right + space2;

            cbb_donvinhap.Top = lb_nhacungcap.Top - 3;
            cbb_donvinhap.Left = lb_nhacungcap.Right + 3;

            lb_ghichu.Top = lb_donvi2.Bottom + 25;
            lb_ghichu.Left = lb_donvi2.Left + lb_donvi2.Width - lb_ghichu.Width;

            tb_ghichu.Top = lb_ghichu.Top - 3;
            tb_ghichu.Left = lb_ghichu.Right + 3;

            tb_ghichu.Width = width2 - lb_donvi2.Width - 3;


            panel2.Height = lb_ghichu.Bottom + 50;
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

        private void loadDonviNhap()
        {
            cbb_donvinhap.DataSource = _dvi.getAll(cbb_Congty.SelectedValue.ToString());
            cbb_donvinhap.DisplayMember = "TENDVI";
            cbb_donvinhap.ValueMember = "MADV";
        }

        private void UpdateTongCongMain()
        {
            int tongSL = 0;
            double tongTien = 0;

            foreach (tb_CHUNGTU ct in _lsChungtu)
            {
                if (ct.DELETED_BY != 1)
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

        private void UpdateTongCong()
        {
            int tongSL = 0;
            double tongTien = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;
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

        private void xuatThongtin()
        {
            tb_CHUNGTU ct = (tb_CHUNGTU)_bdChungtu.Current;
            if (ct != null)
            {
                _khoa = ct.KHOA;
                dtp.Value = ct.NGAY.Value;
                tb_sophieu.Text = ct.SCT;
                tb_ghichu.Text = ct.GHICHU;
                cbb_donvixuat.SelectedValue = ct.MADVI;
                cbb_donvinhap.SelectedValue = ct.MADVI2;
                if(ct.NGAY2 != null)
                {
                    dtNgayNhap.Value = ct.NGAY2.Value;
                }
                txtSoPhieuNhap.Text = ct.SCT2;
                cbb_trangthai.SelectedValue = ct.TRANGTHAI;
                creater = ct.CREATED_BY ?? 0;
                _bdChungtuCT.DataSource = _chungtuct.getListByKhoaFull(ct.KHOA);
                dataGridView2.DataSource = _bdChungtuCT;
                _visible2();
                if (ct.SCT2 != null || !string.IsNullOrEmpty((ct.DELETED_BY).ToString()))
                {
                    toolStripButton_Tao.Enabled = false;
                }
                else
                {
                    toolStripButton_Tao.Enabled = true;
                }
                if (ct.SCT2 != null)
                {
                    toolStripButton_In.Enabled = true;
                }
                else
                {
                    toolStripButton_In.Enabled = false;
                }
                    UpdateTongCong();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            allowTabChange = true;
            tabControl1.SelectedTab = tabPage2;
            dataGridView2.ReadOnly = true;
            allowTabChange = false;
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
                if (e.Value != null && e.Value.ToString() == Convert.ToString(creater))
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

        private void panel1_Resize(object sender, EventArgs e)
        {
            _center();
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

        private void panel2_Resize(object sender, EventArgs e)
        {
            _center2();
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

        private void toolStripButton_quaylai_Click(object sender, EventArgs e)
        {
            allowTabChange = true;
            tabControl1.SelectedTab = tabPage1;
            allowTabChange = false;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!allowTabChange)
            {
                e.Cancel = true;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _stt_ct();
            _stt_main();
            if (tabControl1.SelectedIndex == 1)
            {
                toolStripButton_quaylai.Enabled = true;
            }
            else
            {
                toolStripButton_quaylai.Enabled = false;
            }
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
            if (cbb_Donvi.SelectedValue == null)
                return;
            _lsChungtu = _chungtu.getPhieuNhap(2, dtp1.Value, dtp2.Value.AddDays(1), cbb_Donvi.SelectedValue.ToString());
            _bdChungtu.DataSource = _lsChungtu;
            dataGridView1.DataSource = _bdChungtu;
            _visible1();
            UpdateTongCongMain();
            xuatThongtin();
        }
    }
}
