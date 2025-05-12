using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace STOCK
{
    public partial class frmDanhMuc: Form
    {
        private string _barcode;
        private BindingSource _bds;
        private int _index;
        private string _tenhh;

        public frmDanhMuc(BindingSource bds, string barcode, int index,string tenhh)
        {
            InitializeComponent();
            this._bds = bds;
            this._barcode = barcode;
            this._index = index;
            this._tenhh = tenhh;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(924, 567);
        }
        HANGHOA _hh;
        private void panel1_Resize(object sender, EventArgs e)
        {
            bt_import.Top = (panel1.Height - bt_import.Height) / 2;
            bt_exit.Top = bt_import.Top;
        }
        private void _visible()
        {
            dataGridView1.Columns["MANCC"].Visible = false;
            dataGridView1.Columns["IDNHOM"].Visible = false;
            dataGridView1.Columns["MAXX"].Visible = false;
            dataGridView1.Columns["CREATED_DATE"].Visible = false;
            dataGridView1.Columns["CREATED_BY"].Visible = false;
            dataGridView1.Columns["TENTAT"].Visible = false;
            dataGridView1.Columns["MOTA"].Visible = false;
            dataGridView1.Columns["DISABLE"].Visible = false;
        }
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            bt_import.Image = imageList1.Images[0];
            bt_import.ImageAlign = ContentAlignment.MiddleLeft;
            bt_import.TextAlign = ContentAlignment.MiddleCenter;
            bt_exit.Image = imageList1.Images[1];
            bt_exit.ImageAlign = ContentAlignment.MiddleLeft;
            bt_exit.TextAlign = ContentAlignment.MiddleCenter;

            _hh = new HANGHOA();
            if(_barcode.Trim().Length == 1) dataGridView1.DataSource = _hh.getList();
            else dataGridView1.DataSource = _hh.getListByKeyword(_barcode.Substring(1, _barcode.Length - 1).TrimStart().ToString());
            _visible();
        }

        private void _insert()
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hàng hóa để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> _selected = new List<string>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow && row.Cells["BARCODE"].Value != null)
                {
                    _selected.Add(row.Cells["BARCODE"].Value.ToString());
                }
            }

            if (_selected.Count == 0)
            {
                MessageBox.Show("Không có mã hàng hợp lệ để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<errExport> _err = new List<errExport>();
            List<string> _valid = new List<string>();
            HashSet<string> _exist = new HashSet<string>();

            var ds = _bds.DataSource as List<obj_CHUNGTU_CT>;
            if(ds != null)
            {
                foreach (var item in ds)
                {
                    if (item.BARCODE != null)
                        _exist.Add(item.BARCODE);
                }
            }

            foreach (string barcode in _selected)
            {
                if (_exist.Contains(barcode))
                {
                    errExport _errItem = new errExport
                    {
                        _barcode = barcode,
                        _soluong = 1,
                        _errcode = "Mã hàng đã tồn tại trong danh sách"
                    };
                    _err.Add(_errItem);
                }
                else
                {
                    _valid.Add(barcode);
                }
            }
            if (_err.Count > 0)
            {
                string errorMessage = "Các mã hàng sau đã tồn tại trong danh sách:\n";
                foreach (var err in _err)
                {
                    errorMessage += $"- {err._barcode}\n";
                }
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (_valid.Count == 0)
            {
                MessageBox.Show("Không có mã hàng mới nào để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if(ds == null)
            {
                ds = new List<obj_CHUNGTU_CT>();
                _bds.DataSource = ds;
            }

            int insertindex;
            if(string.IsNullOrEmpty(_tenhh))
            {
                if (_index >= 0 && _index < ds.Count)
                {
                    ds.RemoveAt(_index);
                }
                insertindex = _index;
            }
            else
            {
                insertindex = _index + 1;
            }

            int stt = insertindex + 1;
            foreach(string barcode in _valid)
            {
                tb_HANGHOA hh = _hh.getItem(barcode);
                if (hh != null)
                {
                    obj_CHUNGTU_CT obj = new obj_CHUNGTU_CT
                    {
                        KHOACT = Guid.NewGuid(),
                        KHOA = Guid.NewGuid(),
                        BARCODE = hh.BARCODE,
                        TENHH = hh.TENHH,
                        DVT = hh.DVT,
                        SOLUONGCT = 1,
                        DONGIA = hh.DONGIA,
                        THANHTIEN = hh.DONGIA,
                        STT = stt++,
                        NGAY = DateTime.Now
                    };
                    ds.Insert(insertindex, obj);
                    insertindex++;
                }
            }
            for(int i=0;i<ds.Count; i++)
            {
                ds[i].STT = i + 1;
            }
            _bds.ResetBindings(false);
            this.Close();
        }
        private void bt_import_Click(object sender, EventArgs e)
        {
            _insert();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
