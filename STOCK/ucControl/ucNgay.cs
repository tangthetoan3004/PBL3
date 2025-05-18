using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK.ucControl
{
    public partial class ucNgay: UserControl
    {
        public ucNgay()
        {
            InitializeComponent();
        }
        public DateTimePicker Dtp1
        {
            get { return dtp1; }
        }
        

        public DateTimePicker Dtp2
        {
            get { return dtp2; }
        }

        public ucNgay(bool tonkho)
        {
            InitializeComponent();
            this._tonkho = tonkho;
        }
        bool _tonkho;

        private void ucNgay_Load(object sender, EventArgs e)
        {
            dtp1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtp2.Value = DateTime.Now;
            if(_tonkho)
            {
                dtp1.Enabled = false;
            }
            else
            {
                dtp1.Enabled = true;
            }
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            if(dtp1.Value > dtp2.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp1.Select();
            }
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            if(_tonkho)
            {
                dtp1.Value = new DateTime(dtp2.Value.Year, dtp2.Value.Month, 1);
            }
            if (dtp1.Value > dtp2.Value)
            {
                MessageBox.Show("Ngày không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtp1.Select();
            }
        }
    }
}
