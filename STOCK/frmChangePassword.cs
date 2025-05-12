using BusinessLayer;
using DataLayer;
using DevExpress.Data.TreeList;
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
    public partial class frmChangePassword: Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmChangePassword(tb_SYS_USER user)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this._user = user;
        }
        tb_SYS_USER _user;
        SYS_USER _syser;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(txtMKCu.Text.Trim()=="" && txtMKMoi.Text.Trim()=="" && txtNhaplaiMK.Text.Trim()=="")
            {
                lb_khongdungmkcu.Text = "Không được bỏ trống";
                lb_mkmoi.Text = "Không được bỏ trống";
                lb_khongtrungmk.Text = "Không được bỏ trống";
            }
            else
            {
                if(txtMKCu.Text.Trim()=="")
                {
                    if(txtMKMoi.Text.Trim()=="")
                    {
                        lb_khongdungmkcu.Text = "Không được bỏ trống";
                        lb_mkmoi.Text = "Không được bỏ trống";
                        lb_khongtrungmk.Text = "";
                    }
                    else
                    {
                        if(txtNhaplaiMK.Text.Trim()=="")
                        {
                            lb_khongdungmkcu.Text = "Không được bỏ trống";
                            lb_mkmoi.Text = "";
                            lb_khongtrungmk.Text = "Không được bỏ trống";
                        }
                        else
                        {
                            lb_khongdungmkcu.Text = "Không được bỏ trống";
                            lb_mkmoi.Text = "";
                            lb_khongtrungmk.Text = "";
                        }
                    }
                }
                else
                {
                    if(txtMKMoi.Text.Trim()=="")
                    {
                        if(txtNhaplaiMK.Text.Trim()=="")
                        {
                            lb_khongdungmkcu.Text = "";
                            lb_mkmoi.Text = "Không được bỏ trống";
                            lb_khongtrungmk.Text = "Không được bỏ trống";
                        }
                        else
                        {
                            lb_khongdungmkcu.Text = "";
                            lb_mkmoi.Text = "Không được bỏ trống";
                            lb_khongtrungmk.Text = "";
                        }
                    }
                    else
                    {
                        if(txtNhaplaiMK.Text.Trim()=="")
                        {
                            lb_khongdungmkcu.Text = "";
                            lb_mkmoi.Text = "";
                            lb_khongtrungmk.Text = "";
                        }
                        else
                        {
                            var us = _syser.getItem(_user.IDUSER);
                            if (us.PASSWD != Encryptor.Encrypt(txtMKCu.Text, "qwert@123!poiuy", true))
                            {
                                lb_khongdungmkcu.Text = "Mật khẩu không chính xác";
                                lb_mkmoi.Text = "";
                                lb_khongtrungmk.Text = "";
                            }
                            else
                            {
                                if (txtMKMoi.Text.Equals(txtNhaplaiMK.Text))
                                {
                                    us.PASSWD = Encryptor.Encrypt(txtMKMoi.Text, "qwert@123!poiuy", true);
                                    _syser.update(us);
                                    lb_khongdungmkcu.Text = "";
                                    lb_mkmoi.Text = "";
                                    lb_khongtrungmk.Text = "";
                                    MessageBox.Show("Đổi mật khẩu thành công", "Đổi mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Restart();
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    lb_khongdungmkcu.Text = "";
                                    lb_mkmoi.Text = "";
                                    lb_khongtrungmk.Text = "Mật khẩu mới không trùng khớp";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            _syser = new SYS_USER();
            lb_khongtrungmk.Text = "";
            lb_khongdungmkcu.Text = "";
            lb_mkmoi.Text = "";
        }
    }
}
