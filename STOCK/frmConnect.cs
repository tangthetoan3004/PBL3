using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace STOCK
{
    public partial class frmConnect: Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }
        SqlConnection GetCon(string server/*, string username, string pass*/, string database)
        {
          //  if (string.IsNullOrWhiteSpace(username))
           // {
                return new SqlConnection("Data Source = " + server + "; Initial Catalog = " + database + "; Integrated Security=True;");
           // }
           // else
           // {
             //   return new SqlConnection("Data Source = " + server + "; Initial Catalog = " + database + "; User ID=" + username + "; Password=" + pass + ";");
            //}
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            SqlConnection con = GetCon(txtServer.Text/*, txtUser.Text, txtPassword.Text*/, cbbDatabase.Text);
            try
            {
                con.Open();
                MessageBox.Show("Kết nối thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            SqlConnection testCon = GetCon(txtServer.Text/*, txtUser.Text, txtPassword.Text*/, cbbDatabase.Text);
            try
            {
                testCon.Open();
                testCon.Close();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối đến CSDL, vui lòng kiểm tra lại trước khi lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string enCryptServ = Encryptor.Encrypt(txtServer.Text, "qwertyuiop", true);
            //string enCryptPass = Encryptor.Encrypt(txtPassword.Text, "qwertyuiop", true);
            string enCryptData = Encryptor.Encrypt(cbbDatabase.Text, "qwertyuiop", true);
            //string enCryptUser = Encryptor.Encrypt(txtUser.Text, "qwertyuiop", true);

            connect cn = new connect(enCryptServ,/* enCryptUser, enCryptPass,*/ enCryptData);
            cn.SaveFile();
            MessageBox.Show("Lưu file thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbbDatabase_MouseClick(object sender, MouseEventArgs e)
        {
            cbbDatabase.Items.Clear();
            try
            {
                string Conn = "Data Source=" + txtServer.Text + "; Integrated Security=True;"; SqlConnection con = new SqlConnection(Conn);
                con.Open();
                string sql = "select name from sys.databases WHERE name NOT IN ('master' , 'tempds', 'model', 'msdb')";
                SqlCommand cmd = new SqlCommand(sql, con);
                IDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    cbbDatabase.Items.Add(dr[0].ToString());
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
