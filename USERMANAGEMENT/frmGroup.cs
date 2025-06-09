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
    public partial class frmGroup: Form
    {
        public frmGroup()
        {
            InitializeComponent();
        }
        public USERMANAGEMENT.frmMain objMain;
        public string _macty;
        public string _madvi;
        public int _idUser;
        public string _username;
        public string _fullname;
        public bool _them;
        SYS_USER _sysUser;
        tb_SYS_USER _user;
        SYS_GROUP _sysGroup;
        VIEW_USER_IN_GROUP _vUserInGroup;
        private void frmGroup_Load(object sender, EventArgs e)
        {
            dgvThanhvien.AutoGenerateColumns = false;
            _sysUser = new SYS_USER();
            _sysGroup = new SYS_GROUP();
            if(!_them)
            {
                var user = _sysUser.getItem(_idUser);
                txtTenNhom.Text = user.USERNAME;
                _macty = user.MACTY;
                _madvi = user.MADVI;
                txtMota.Text = user.FULLNAME;
                txtTenNhom.ReadOnly = true;
                loadUserInGroup(_idUser);
            }

            else
            {
                txtMota.Text = "";
                txtTenNhom.Text = "";
            }
        }
        public void loadUserInGroup(int idGroup)
        {
            _vUserInGroup = new VIEW_USER_IN_GROUP();
            dgvThanhvien.DataSource = _vUserInGroup.getUserInGroup(_madvi, _macty,idGroup);
            dgvThanhvien.ReadOnly = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenNhom.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên nhóm. Tên nhóm nhập không dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhom.SelectAll();
                txtTenNhom.Focus();
                return;
            }
            SaveData();

        }
        void SaveData()
        {
            if (_them)
            {
                // Dùng SYS_GROUP để kiểm tra nhóm đã tồn tại
                bool exists = _sysGroup.checkGroupExist(_macty, _madvi, txtTenNhom.Text.Trim());
                if (exists)
                {
                    MessageBox.Show(
                        "Nhóm đã tồn tại. Vui lòng kiểm tra lại",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    txtTenNhom.SelectAll();
                    txtTenNhom.Focus();
                    return;
                }

                // Tạo nhóm mới
                var gr = new tb_SYS_USER
                {
                    USERNAME = txtTenNhom.Text.Trim(),
                    FULLNAME = txtMota.Text,
                    ISGROUP = true,
                    DISABLED = false,
                    MACTY = _macty,
                    MADVI = _madvi
                };
                _sysUser.add(gr);
            }
            else
            {
                // Cập nhật tên/Mô tả nhóm
                var gr = _sysUser.getItem(_idUser);
                gr.FULLNAME = txtMota.Text;
                _sysUser.update(gr);
            }

            // Làm mới danh sách trên form chính
            if (objMain != null)
            {
                objMain.LoadUser(_macty, _madvi);
            }

            // Đóng form nếu bạn muốn
            this.Close();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmShowMember frm = new frmShowMember();
            frm._idGroup = _idUser;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (dgvThanhvien.CurrentRow != null && dgvThanhvien.CurrentRow.Cells["ID"].Value != null)
            {
                _sysGroup.delGroup(int.Parse(dgvThanhvien.CurrentRow.Cells["ID"].Value.ToString()),_idUser);
                loadUserInGroup(_idUser);

            }    

        }

        private void dgvThanhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
