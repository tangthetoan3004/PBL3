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
    public partial class frmSetParam: Form
    {
        public frmSetParam()
        {
            InitializeComponent();
        }
        CONGTY _congty;
        DONVI _donvi;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSetParam_Load(object sender, EventArgs e)
        {
            _congty = new CONGTY();
            _donvi = new DONVI();
            cboCongTy.SelectedValue = "CT01";
            cboCongTy.SelectedIndexChanged += cboCongTy_SelectedIndexChanged;
            loadCongty();
            loadDonvi();
        }
        void loadCongty()
        {
            cboCongTy.DataSource = _congty.getAll();
            cboCongTy.DisplayMember = "TENCTY";
            cboCongTy.ValueMember = "MACTY";
        }
        void loadDonvi()
        {
            cboDonvi.DataSource = _donvi.getAll(cboCongTy.SelectedValue.ToString());
            cboDonvi.DisplayMember = "TENDVI";
            cboDonvi.ValueMember = "MADV";
            cboDonvi.SelectedIndex = -1;
        }

        private void cboCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDonvi();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string macty = cboCongTy.SelectedValue.ToString();
            string madvi = (cboDonvi.Text.Trim() == "") ? "~" : cboDonvi.SelectedValue.ToString();
            SYS_PARAM _sysParam = new SYS_PARAM(macty,madvi);
            _sysParam.SaveFile();
            MessageBox.Show("Xác lập đơn vị sử dụng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
