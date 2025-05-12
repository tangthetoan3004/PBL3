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
using static System.Net.WebRequestMethods;

namespace STOCK
{
    public partial class frmBanle: Form
    {
        public frmBanle()
        {
            InitializeComponent();
        }
        public frmBanle(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this._user = user;
            this._right = right;
        }
        private double _s = 0;
        tb_SYS_USER _user;
        int _right;
        CONGTY _cty;
        DONVI _dvi;



        CHUNGTU _chungtu;
        CHUNGTU_CT _chungtuct;
        SYS_SEQUENCE _seq;
        HANGHOA _hh;
        List<obj_CHUNGTU_CT> lstChungTuCT;
        tb_SYS_SEQUENCE _tbs;

        private bool allowTabChange = false;
        private bool isTab2 = true;
        private void frmBanle_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1202, 525);
            _imageButton();
            tb_soluongct.ReadOnly = true;
            tb_tongtienct.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            _cty = new CONGTY();
            _dvi = new DONVI();

            _chungtu = new CHUNGTU();
            _chungtuct = new CHUNGTU_CT();
            _seq = new SYS_SEQUENCE();
            _hh = new HANGHOA();
            lstChungTuCT = new List<obj_CHUNGTU_CT>();
            dataGridView2.AutoGenerateColumns = false;

        }
        private void _imageButton()
        {
            bt_luu.Image = imageList1.Images[2];
            bt_bill.Image = imageList1.Images[1];
            bt_chietkhau.Image = imageList1.Images[3];
            bt_trahang.Image = imageList1.Images[0];
        }

        private void frmBanle_Resize(object sender, EventArgs e)
        {
            bt_luu.Left = tb_barcode.Right + 150;
            bt_bill.Left = bt_luu.Right + 2;
            bt_chietkhau.Left = bt_bill.Right + 2;
            bt_trahang.Left = bt_chietkhau.Right + 2;
        }

        private void bt_chietkhau_Click(object sender, EventArgs e)
        {
            frmChietkhau f = new frmChietkhau();
            f.d += (chietKhau) =>
            {
                _s = chietKhau;
                foreach (var item in lstChungTuCT)
                {
                    if (item.THANHTIEN.HasValue && item.SOLUONGCT.HasValue && item.DONGIA.HasValue)
                    {
                        item.THANHTIEN = (item.DONGIA.Value * item.SOLUONGCT.Value) * (1 - chietKhau / 100);
                    }
                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = lstChungTuCT.ToList();
                UpdateTongCongMain();
            };
            f.ShowDialog();
        }

        private void pn_tong2_Resize(object sender, EventArgs e)
        {
            lb_tong2.Left = 550;
            lb_soluongct.Left = lb_tong2.Right + 25;
            tb_soluongct.Left = lb_soluongct.Right + 3;
            tb_soluongct.Top = lb_soluongct.Top - 3;
            lb_tongtienct.Left = tb_soluongct.Right + 18;
            tb_tongtienct.Left = lb_tongtienct.Right + 3;
            tb_tongtienct.Top = lb_soluongct.Top - 3;
        }
        private void _stt_main()
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells["BARCODE"].Value != null)
                {
                    row.Cells["STT"].Value = i++;
                }
            }
        }
        private void UpdateTongCongMain()
        {
            int tongSL = 0;
            double tongTien = 0;

            foreach (obj_CHUNGTU_CT ct in lstChungTuCT)
            {
                    tongSL += ct.SOLUONGCT ?? 0;
                    tongTien += ct.THANHTIEN ?? 0;
                
            }

            tb_soluongct.Text = tongSL.ToString();
            tb_soluongct.TextAlign = HorizontalAlignment.Right;
            tb_tongtienct.Text = tongTien.ToString("N0");
            tb_tongtienct.TextAlign = HorizontalAlignment.Right;

            _stt_main();
        }
        private void tb_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            int index = 0;
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = tb_barcode.Text.Trim();
                if (!myFunctions.sIsNumber(barcode))
                {
                    MessageBox.Show("Mã hàng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var hh = _hh.getItem(barcode);
                if (hh == null)
                {
                    MessageBox.Show("Mã hàng không có trong danh mục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                obj_CHUNGTU_CT ct = new obj_CHUNGTU_CT();
                obj_HANGHOA _hanghoa = new obj_HANGHOA();
                _hanghoa = _hh.getItemFull(barcode);
                ct.BARCODE = _hanghoa.BARCODE;
                ct.TENHH = _hanghoa.TENHH;
                ct.DVT = _hanghoa.DVT;
                ct.SOLUONGCT = 1;
                ct.DONGIA = _hanghoa.DONGIA;
                ct.THANHTIEN = ct.DONGIA * ct.SOLUONGCT * (1 - _s / 100);
                if (lstChungTuCT.Count > 0)
                {
                    var item = lstChungTuCT.FirstOrDefault(x => x.BARCODE == barcode);
                    if (item != null)
                    {
                        index = lstChungTuCT.IndexOf(item);
                        lstChungTuCT[index].SOLUONGCT = item.SOLUONGCT + 1;
                        lstChungTuCT[index].THANHTIEN = item.DONGIA * lstChungTuCT[index].SOLUONGCT * (1 - _s / 100);

                    }
                    else
                    {
                        lstChungTuCT.Add(ct);
                    }
                }
                else
                lstChungTuCT.Add(ct);
                dataGridView2.DataSource = lstChungTuCT.ToList();
                UpdateTongCongMain();
                tb_barcode.Text = "";
            }
        }
        private void Chungtu_Info(tb_CHUNGTU ct)
        {
            string madvi = "";
            if(myFunctions._macty == "~")
            {
                madvi = "CTKHO01";
            }
            else
            {
                madvi = myFunctions._madvi;
            }
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
            tb_DONVI dvi = _dvi.getItem(madvi);
            _tbs = _seq.getItem("BLE@" + DateTime.Today.Year.ToString() + "@" + dvi.KYHIEU);
            if (_tbs == null)
            {
                _tbs = new tb_SYS_SEQUENCE();
                _tbs.SEQNAME = "BLE@" + DateTime.Today.Year.ToString() + "@" + dvi.KYHIEU;
                _tbs.SEQVALUE = 1;
                _seq.add(_tbs);
            }
            
                ct.KHOA = Guid.NewGuid();
                ct.SCT = _tbs.SEQVALUE.Value.ToString("000000") + @"/" + DateTime.Today.Year.ToString().Substring(2, 2) + @"/BLE/" + dvi.KYHIEU;
                ct.CREATED_BY = _user.IDUSER;
                ct.CREATED_DATE = DateTime.Now;
            
            ct.LCT = 4;
            ct.NGAY = DateTime.Now;
            ct.MACTY = myFunctions._macty;
            ct.MADVI = madvi;
            ct.MADVI2 = "1";
           // ct.GHICHU = tb_ghichu.Text;
            ct.TRANGTHAI = 2;
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
                    ctct.NGAY = DateTime.Now;
                    _chungtuct.add(ctct);
                }
            }
        }

        private void luuthongtin()
        {
            try
            {
                tb_CHUNGTU ct = new tb_CHUNGTU();
                Chungtu_Info(ct);
                var resultct = _chungtu.add(ct);
                _seq.update(_tbs);

                Chungtu_CT_Info(resultct);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra..\r\n" + ex.ToString());
            }
        }
        private void bt_luu_Click(object sender, EventArgs e)
        {
            if(dataGridView2.RowCount == 0)
            {
                MessageBox.Show("Chi tiết đơn hàng không được rỗng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            luuthongtin();
            lstChungTuCT = new List<obj_CHUNGTU_CT>();
            dataGridView2.DataSource   = lstChungTuCT;
            tb_tongtienct.Text = "";
            tb_soluongct.Text = "";
        }

        private void bt_trahang_Click(object sender, EventArgs e)
        {
            frmTrahang f = new frmTrahang(lstChungTuCT,dataGridView2);
            f.ShowDialog();
        }
    }
}
