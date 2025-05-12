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
    public partial class frmShowGroup: Form
    {
        public frmShowGroup()
        {
            InitializeComponent();
        }
        public string _macty;
        public string _madvi;
        public int _idUser;
        SYS_GROUP _sysGroup;
        VIEW_USER_IN_GROUP _vUserInGroup;

        frmUser objUser = (frmUser)Application.OpenForms["frmUser"];
        /*       private void btnLuu_Click(object sender, EventArgs e)
               {
                   if (_vUserInGroup.checkGroupByUser(_idUser, int.Parse(dgvNhom.CurrentRow.Cells["ID"].ToString())))
                   {
                       MessageBox.Show("Người dùng đã tồn tại trong nhóm. Vui lòng chọn nhóm khác.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                       return;
                   }
                   tb_SYS_GROUP gr = new tb_SYS_GROUP();
                   gr.GROUP = int.Parse(dgvNhom.CurrentRow.Cells["ID"].ToString());
                   gr.MEMBER = _idUser;
                   _sysGroup.add(gr);
                   objUser.loadGroupByUser(_idUser);
               }*/
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvNhom.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một nhóm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy giá trị ID từ cell
            var cellValue = dgvNhom.CurrentRow.Cells["ID"].Value;
            if (cellValue == null ||
                !int.TryParse(cellValue.ToString(), out int groupId))
            {
                MessageBox.Show("ID nhóm không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem User đã có trong nhóm chưa
            if (_vUserInGroup.checkGroupByUser(_idUser, groupId))
            {
                MessageBox.Show("Người dùng đã tồn tại trong nhóm. Vui lòng chọn nhóm khác.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Thêm record vào SYS_GROUP
            var gr = new tb_SYS_GROUP
            {
                GROUP = groupId,
                MEMBER = _idUser
            };
            _sysGroup.add(gr);

            // Làm mới danh sách nhóm của user ở form cha
            objUser?.loadGroupByUser(_idUser);

            // Đóng form sau khi lưu (tuỳ chọn)
            this.Close();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowGroup_Load(object sender, EventArgs e)
        {
            dgvNhom.AutoGenerateColumns = false;
            _sysGroup = new SYS_GROUP();
            _vUserInGroup = new VIEW_USER_IN_GROUP();
            loadGroup();
        }
       
        void loadGroup()
        {
            dgvNhom.DataSource = _vUserInGroup.getGroupByDonVi(_macty, _madvi);
            dgvNhom.ReadOnly = true;
        }

        private void dgvNhom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
