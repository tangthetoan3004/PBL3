using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USERMANAGEMENT
{
    public partial class frmUser: Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
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
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*        private void frmUser_Load(object sender, EventArgs e)
                {
                    _sysUser = new SYS_USER();
                    _sysGroup = new SYS_GROUP();
                    if (!_them)
                    {
                        var user = _sysUser.getItem(_idUser);
                        txtUsername.Text = user.USERNAME;
                        _macty = user.MACTY;
                        _madvi = user.MADVI;
                        txtHoten.Text = user.FULLNAME;
                        chkDisabled.Checked =user.DISABLED.Value;
                        txtUsername.ReadOnly = true;
                        txtPass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
                        txtRePass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
                        loadGroupByUser(_idUser);
                    }

                    else
                    {
                        txtHoten.Text = "";
                        txtPass.Text = "";
                        txtRePass.Text = "";

                        chkDisabled.Checked = false;
                    }
                }*/
        private void frmUser_Load(object sender, EventArgs e)
        {
            dgvThanhvien.AutoGenerateColumns = false;
            _sysUser = new SYS_USER();
            _sysGroup = new SYS_GROUP();
            if (!_them)
            {
                var user = _sysUser.getItem(_idUser);
                if (user != null)
                {
                    txtUsername.Text = user.USERNAME;
                    _macty = user.MACTY;
                    _madvi = user.MADVI;
                    txtHoten.Text = user.FULLNAME;
                    chkDisabled.Checked = user.DISABLED.Value;
                    txtUsername.ReadOnly = true;

                    try
                    {
                        if (!string.IsNullOrEmpty(user.PASSWD))
                        {
                            txtPass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
                            txtRePass.Text = Encryptor.Decrypt(user.PASSWD, "qwert@123!poiuy", true);
                        }
                        else
                        {
                            txtPass.Text = "";
                            txtRePass.Text = "";
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (CryptographicException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    loadGroupByUser(_idUser);
                }
            }
            else
            {
                txtHoten.Text = "";
                txtPass.Text = "";
                txtRePass.Text = "";
                chkDisabled.Checked = false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên người dùng. Tên nhóm nhập không dấu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.SelectAll();
                txtUsername.Focus();
                return;
            }
            if (!txtPass.Text.Equals(txtRePass.Text))
            {
                MessageBox.Show("Mật khẩu không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.SelectAll();
                txtUsername.Focus();
                return;
            }
            SaveData();
        }
        /*       void SaveData()
               {
                   if (_them)
                   {
                       bool checkedUser = _sysUser.checkUserExist(_macty, _madvi, txtUsername.Text.Trim());
                       if (checkedUser)
                       {
                           MessageBox.Show("Tên người dùng đã tồn tại. Vui lòng kiểm tra lại", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           txtUsername.SelectAll();
                           txtUsername.Focus();
                           return;
                       }
                       _user = new tb_SYS_USER();
                       _user.USERNAME = txtUsername.Text.Trim();
                       _user.FULLNAME = txtHoten.Text;
                       _user.PASSWD = Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
                       _user.ISGROUP = false;
                       _user.DISABLED = false;
                       _user.MACTY = _macty;
                       _user.MADVI = _madvi;
                       _sysUser.add(_user);

                   }
                   else
                   {
                       _user = _sysUser.getItem(_idUser);

                       _user.FULLNAME = txtHoten.Text;
                       _user.PASSWD = Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
                       _user.ISGROUP = false;
                       _user.DISABLED = chkDisabled.Checked;
                       _user.MACTY = _macty;
                       _user.MADVI = _madvi;
                       _sysUser.update(_user);
                   }
                   objMain.LoadUser(_macty, _madvi);
               } */
        void SaveData()
        {
            try
            {
                // Kiểm tra mật khẩu và xác nhận mật khẩu
                if (string.IsNullOrEmpty(txtPass.Text.Trim()))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Focus();
                    return;
                }

                if (!txtPass.Text.Equals(txtRePass.Text))
                {
                    MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRePass.Focus();
                    return;
                }

                // Mã hóa mật khẩu
                string encryptedPassword;
                try
                {
                    encryptedPassword = Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Lỗi mã hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (CryptographicException ex)
                {
                    MessageBox.Show($"Lỗi mã hóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xử lý thêm mới hoặc cập nhật
                if (_them)
                {
                    // Kiểm tra username tồn tại
                    bool isUserExist = _sysUser.checkUserExist(_macty, _madvi, txtUsername.Text.Trim());
                    if (isUserExist)
                    {
                        MessageBox.Show("Tên người dùng đã tồn tại trong đơn vị này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }

                    // Tạo đối tượng user mới
                    _user = new tb_SYS_USER
                    {
                        USERNAME = txtUsername.Text.Trim(),
                        FULLNAME = txtHoten.Text.Trim(),
                        PASSWD = encryptedPassword,
                        ISGROUP = false,
                        DISABLED = chkDisabled.Checked,
                        MACTY = _macty,
                        MADVI = _madvi
                    };

                    // Thêm vào CSDL
                    _sysUser.add(_user);
                    MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Lấy thông tin user hiện tại
                    _user = _sysUser.getItem(_idUser);
                    if (_user == null)
                    {
                        MessageBox.Show("Không tìm thấy người dùng để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Cập nhật thông tin
                    _user.FULLNAME = txtHoten.Text.Trim();
                    _user.PASSWD = encryptedPassword;
                    _user.DISABLED = chkDisabled.Checked;
                    _user.MACTY = _macty;
                    _user.MADVI = _madvi;

                    // Lưu thay đổi
                    _sysUser.update(_user);
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Cập nhật lại DataGridView trong form main
                objMain.LoadUser(_macty, _madvi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi không xác định: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmShowGroup frm = new frmShowGroup();
            frm._idUser = _idUser;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void btnBot_Click(object sender, EventArgs e)
        {
            if (dgvThanhvien.CurrentRow != null && dgvThanhvien.CurrentRow.Cells["ID"].Value != null)
            {
                _sysGroup.delGroup(_idUser,int.Parse( dgvThanhvien.CurrentRow.Cells["ID"].Value.ToString()));
                loadGroupByUser(_idUser);
            }
        }
        public void loadGroupByUser(int idUser)
        {
            _vUserInGroup = new VIEW_USER_IN_GROUP();
            dgvThanhvien.DataSource = _vUserInGroup.getGroupByUser(_macty, _madvi, _idUser);
            dgvThanhvien.ReadOnly = true;
        }
    }
}
