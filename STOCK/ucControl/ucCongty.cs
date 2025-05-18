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
    public partial class ucCongty: UserControl
    {
        public ucCongty()
        {
            InitializeComponent();
        }
        public ComboBox CbbCongty
        {
            get { return cbb_Congty; }
        }

        private void ucCongty_Load(object sender, EventArgs e)
        {
            CONGTY cty = new CONGTY();
            cbb_Congty.DataSource = cty.getAll();
            cbb_Congty.DisplayMember = "TENCTY";
            cbb_Congty.ValueMember = "MACTY";
            cbb_Congty.SelectedValue = myFunctions._macty;
        }
    }
}
