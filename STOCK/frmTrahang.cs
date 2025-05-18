using BusinessLayer;
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
    public partial class frmTrahang: Form
    {
        DataGridView _dgv;
        List<obj_CHUNGTU_CT> _lst;
        public frmTrahang()
        {
            InitializeComponent();
        }
        public frmTrahang(List<obj_CHUNGTU_CT> lst,DataGridView dgv)
        {
            InitializeComponent();
            this._dgv = dgv;
            this._lst = lst;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _trahang();
        }
        private void _trahang()
        {
            if(string.IsNullOrEmpty(tb_barcode.Text) && string.IsNullOrEmpty(tb_soluong.Text) || string.IsNullOrEmpty(tb_barcode.Text) || string.IsNullOrEmpty(tb_soluong.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            obj_CHUNGTU_CT ct;
            var item = _lst.FirstOrDefault(x => x.BARCODE == tb_barcode.Text && x.SOLUONGCT > 0);
            if (item != null)
            {
                if (item.SOLUONGCT < Convert.ToInt32(tb_soluong.Text) || Convert.ToInt32(tb_soluong.Text) <= 0)
                {
                    MessageBox.Show("Số lượng trả không hợp lệ!");
                    return;
                }
                int tongtra = (int)_lst.Where(x => x.BARCODE == tb_barcode.Text && x.SOLUONGCT < 0)
                           .Sum(x => x.SOLUONGCT);
                int soluongtra = Convert.ToInt32(tb_soluong.Text);
                int soluongconlai = Convert.ToInt32(item.SOLUONGCT) + tongtra;
                if (soluongconlai < soluongtra)
                {
                    MessageBox.Show($"Số lượng trả không hợp lệ! Chỉ còn {soluongconlai} sản phẩm có thể trả.");
                    return;
                }
                ct = new obj_CHUNGTU_CT();
                ct.BARCODE = item.BARCODE;
                ct.TENHH = item.TENHH;
                ct.DVT = item.DVT;
                ct.SOLUONGCT = Convert.ToInt32("-" + tb_soluong.Text);
                ct.DONGIA = item.DONGIA;
                ct.THANHTIEN = ct.SOLUONGCT * ct.DONGIA;
                _lst.Add(ct);
                _dgv.DataSource = _lst.ToList();
            }
            else
            {
                MessageBox.Show("Mã hàng không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                e.Handled = true; 
                _trahang();
            }
        }

        private void tb_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _trahang();
            }
        }

        private void frmTrahang_Load(object sender, EventArgs e)
        {

        }
    }
}
