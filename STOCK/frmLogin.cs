using BusinessLayer;
using DataLayer;
using DevExpress.Data.TreeList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SYS_PARAM _sysParam;
        SYS_USER _sysUser;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _sysUser = new SYS_USER();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("sysparam.ini", FileMode.Open, FileAccess.Read);
            _sysParam = (SYS_PARAM)bf.Deserialize(fs);
            myFunctions._macty = _sysParam.macty;
            myFunctions._madvi = _sysParam.madvi;
            fs.Close();
            lb_saidangnhap.Text = "";
            lb_saimk.Text = "";
            if (myFunctions._madvi == "KHOMB1")
            {
                txtUserName.Text = "KChi";
                txtPass.Text = "1";
                return;
            }
            if (myFunctions._madvi == "KHOMB2")
            {
                txtUserName.Text = "TOAN";
                txtPass.Text = "1";
                return;
            }
            if (myFunctions._madvi == "KHODN1")
            {
                txtUserName.Text = "TOAN";
                txtPass.Text = "1";
                return;
            }
            if (myFunctions._madvi == "KHODN2")
            {
                txtUserName.Text = "NV";
                txtPass.Text = "1";
                return;
            }
            if (myFunctions._madvi == "CNKC")
            {
                txtUserName.Text = "CHI";
                txtPass.Text = "1";
                return;
            }
            if (myFunctions._madvi == "CNTT")
            {
                txtUserName.Text = "ADMIN";
                txtPass.Text = "12345";
                return;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            _kt();
        }

        private void _kt()
        {
            if (txtUserName.Text.Trim() == "" && txtPass.Text.Trim() == "")
            {
                lb_saidangnhap.Text = "Tên đăng nhập không được để trống";
                lb_saimk.Text = "Mật khẩu không được để trống";
            }
            else
            {
                if (txtUserName.Text.Trim() == "")
                {
                    lb_saidangnhap.Text = "Tên đăng nhập không được để trống";
                    lb_saimk.Text = "";
                }
                else
                {
                    if (txtPass.Text.Trim() == "")
                    {
                        lb_saidangnhap.Text = "";
                        lb_saimk.Text = "Mật khẩu không được để trống";
                    }
                    else
                    {
                        bool us = _sysUser.checkUserExist(_sysParam.macty, _sysParam.madvi, txtUserName.Text.Trim());
                        if (!us)
                        {
                            lb_saidangnhap.Text = "Tên đăng nhập không tồn tại";
                            lb_saimk.Text = "";
                        }
                        else
                        {
                            string pass = Encryptor.Encrypt(txtPass.Text.Trim(), "qwert@123!poiuy", true);
                            tb_SYS_USER user = _sysUser.getItem(txtUserName.Text.Trim(), _sysParam.macty, _sysParam.madvi);
                            if (user.PASSWD.Equals(pass))
                            {
                                lb_saimk.Text = "";
                                lb_saidangnhap.Text = "";
                                frmMain frm = new frmMain(user);
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                lb_saimk.Text = "Sai mật khẩu";
                                lb_saidangnhap.Text = "";
                            }
                        }
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _kt();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _kt();
            }
        }

        private void btnDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _kt();
            }
        }

        private void btnThoat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                _kt();
            }
        }
    }
}
