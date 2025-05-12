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
            obj_CHUNGTU_CT ct;
            var item = _lst.FirstOrDefault(x => x.BARCODE == tb_barcode.Text);
            if (item != null)
            {
                if(item.SOLUONGCT < Convert.ToInt32(tb_soluong.Text))
                {
                    MessageBox.Show("Số lượng trả không hợp lệ!");
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
                MessageBox.Show("Mã hàng không tồn tại","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
