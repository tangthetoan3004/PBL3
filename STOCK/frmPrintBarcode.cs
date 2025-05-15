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
    public partial class frmPrintBarcode: Form
    {
        public frmPrintBarcode()
        {
            InitializeComponent();
            this.Size = new Size(1073,600);
        }
        NHOMHH _nhh;
        HANGHOA _hh;
        private void frmPrintBarcode_Load(object sender, EventArgs e)
        {
            _nhh = new NHOMHH();
            _hh = new HANGHOA();
            loadNhom();
            cbb_nhom.SelectedIndex = 0;
            loadDanhMuc();
        }
        private void loadNhom()
        {
            cbb_nhom.DataSource = _nhh.getAll();
            cbb_nhom.DisplayMember = "TENNHOM";
            cbb_nhom.ValueMember = "IDNHOM";
        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            lb_nhom.Top = (panel1.Height -  lb_nhom.Height) / 2;
            lb_nhom.Left = (panel1.Width - lb_nhom.Width - 3 - cbb_nhom.Width) / 2;

            cbb_nhom.Top = lb_nhom.Top - 3;
            cbb_nhom.Left = lb_nhom.Right + 3;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            bt_find.Top = (panel2.Height - bt_find.Height) / 2;
            bt_find.Left = panel2.Width - 10 - bt_find.Width;

            tb_find.Top = bt_find.Top;
            tb_find.Left = bt_find.Left - 3 - tb_find.Width;
        }

        private void cbb_nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDanhMuc();
        }
        private void loadDanhMuc()
        {
            dataGridView1.DataSource = _hh.getDanhMucInBarcode(Convert.ToInt32(cbb_nhom.SelectedValue.ToString()));
        }
    }
}
