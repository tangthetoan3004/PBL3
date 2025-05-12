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
    public partial class frmChietkhau: Form
    {
        public delegate void MyDel(double s);
        public event MyDel d;
        public frmChietkhau()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void frmChietkhau_Load(object sender, EventArgs e)
        {
            lb_chietkhau.Left = 20;
            tb_chietkhau.Left = lb_chietkhau.Right + 3;
            bt_capnhat.Left = tb_chietkhau.Right + 5;
        }

        private void bt_capnhat_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_chietkhau.Text, out double chietKhau))
            {
                d?.Invoke(chietKhau);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chiết khấu không hợp lệ!!!","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
