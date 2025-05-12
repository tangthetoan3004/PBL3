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

namespace USERMANAGEMENT
{
    public partial class frmShowMember: Form
    {
        public frmShowMember()
        {
            InitializeComponent();
        }
        private void frmShowMember_Load(object sender, EventArgs e)
        {
            dgvThanhvien.AutoGenerateColumns = false;
            
            _sysGroup = new SYS_GROUP();
            _vNotGroup = new VIEW_USER_NOTIN_GROUP();
            loadUserNotInGroup();

        }
        public string _macty;
        public string _madvi;
        public int _idGroup;
        SYS_GROUP _sysGroup;
        VIEW_USER_NOTIN_GROUP _vNotGroup;
        frmGroup objGroup = (frmGroup)Application.OpenForms["frmGroup"];
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        void loadUserNotInGroup()
        {
            dgvThanhvien.DataSource = _vNotGroup.getUserNotInGroup(_madvi, _macty);
            dgvThanhvien.ReadOnly = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var cellVal = dgvThanhvien.CurrentRow.Cells["ID"].Value;
            if (cellVal == null || !int.TryParse(cellVal.ToString(), out int userId))
            {
                MessageBox.Show("ID người dùng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tb_SYS_GROUP gr = new tb_SYS_GROUP();
            gr.GROUP = _idGroup;
            gr.MEMBER = userId;
            _sysGroup.add(gr);
            objGroup.loadUserInGroup(_idGroup);
            this.Close();
        }
    }
}
