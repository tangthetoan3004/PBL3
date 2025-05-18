using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace STOCK.ucControl
{
    public partial class ucDonvi: UserControl
    {
        public ucDonvi()
        {
            InitializeComponent();
        }
        CONGTY _cty;
        DONVI _dvi;

        private void ucDonvi_Load(object sender, EventArgs e)
        {
            _cty = new CONGTY();
            _dvi = new DONVI();
            loadCongTy();
            cbb_Congty.SelectedValue = myFunctions._macty;
            loadDonVi();
            cbb_Donvi.SelectedValue = myFunctions._madvi;
        }
        public ComboBox CbbDonvi
        {
            get { return cbb_Donvi; }
        }
        private void loadCongTy()
        {
            cbb_Congty.DataSource = _cty.getAll();
            cbb_Congty.DisplayMember = "TENCTY";
            cbb_Congty.ValueMember = "MACTY";
        }
        private void loadDonVi()
        {
            cbb_Donvi.DataSource = _dvi.getAll(cbb_Congty.SelectedValue.ToString());
            cbb_Donvi.DisplayMember = "TENDVI";
            cbb_Donvi.ValueMember = "MADV";
        }

        private void cbb_Congty_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadDonVi();
        }
    }
}
