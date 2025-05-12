using BusinessLayer;
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
    public partial class frmPhanQuyenChucNang: Form
    {
        public frmPhanQuyenChucNang()
        {
            InitializeComponent();
        }
        public int _idUser;
        public string _macty;
        public string _madvi;
        SYS_USER _sysUser;
        SYS_RIGHT _sysRight;
        private void frmPhanQuyenChucNang_Load(object sender, EventArgs e)
        {
            dgvChucNang.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
            _sysUser = new SYS_USER();
            _sysRight = new SYS_RIGHT();
            loadUsers();
            loadFuncByUser();
        }
        void loadUsers()
        {
            if(_macty == null && _madvi == null)
            {
                dgvUsers.DataSource = _sysUser.getUserByDVI("CT01", "~");
                dgvUsers.ReadOnly = true;
            }
            else
            {
                dgvUsers.DataSource = _sysUser.getUserByDVI(_macty, _madvi);
                dgvUsers.ReadOnly = true;
            }
        }
        void loadFuncByUser()
        {
            VIEW_FUNC_SYS_RIGHT _vFuncRight = new VIEW_FUNC_SYS_RIGHT();
            dgvChucNang.DataSource = _vFuncRight.getFuncByUser(_idUser);
            dgvChucNang.ReadOnly = false;
            for(int i = 0; i < dgvUsers.RowCount; i++)
            {
                if (!int.TryParse(dgvUsers.Rows[i].Cells["IDUSER"].Value?.ToString(), out int idUser))
                {
                    MessageBox.Show("Giá trị ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int value = idUser;

                if (value == _idUser)
                {
                    dgvUsers.ClearSelection();
                    dgvUsers.Rows[i].Selected = true; 
                    dgvUsers.CurrentCell = dgvUsers.Rows[i].Cells[0]; 
                    
                }
            }
            dgvChucNang.ClearSelection();
        }

 /*       private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "ISGROUP" && e.RowIndex >= 0)
            {
                e.Handled = true;
                e.PaintBackground(e.CellBounds, true);

                bool isGroup = false;
                bool.TryParse(e.Value?.ToString(), out isGroup);

                Image img = isGroup ? Properties.Resources.Team_16x16 : Properties.Resources.Customer_16x16;

                int imgX = e.CellBounds.Left + (e.CellBounds.Width - img.Width) / 2;
                int imgY = e.CellBounds.Top + (e.CellBounds.Height - img.Height) / 2;

                e.Graphics.DrawImage(img, imgX, imgY);
            }
        }*/

        private void khóaQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for( int i = 0; i < dgvChucNang.RowCount; i++)
            {
              
                if (dgvChucNang.Rows[i].Selected)
                {
                    var value = dgvChucNang.Rows[i].Cells["FUNC_CODE"].Value.ToString();

                    _sysRight.update(_idUser, value, 0);
                }
            }
            loadFuncByUser();
        }

        private void chỉXemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < dgvChucNang.RowCount; i++)
            {
                if (dgvChucNang.Rows[i].Selected)
                {
                    var value = dgvChucNang.Rows[i].Cells["FUNC_CODE"].Value.ToString();

                    _sysRight.update(_idUser, value, 1);
                }
            }
            loadFuncByUser();
        }

        private void toànQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvChucNang.RowCount; i++)
            {
                if (dgvChucNang.Rows[i].Selected)
                {
                    var value = dgvChucNang.Rows[i].Cells["FUNC_CODE"].Value.ToString();
                    _sysRight.update(_idUser, value, 2);
                }
            }
            loadFuncByUser();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _idUser = Convert.ToUInt16(dgvUsers.CurrentRow.Cells["IDUSER"].ToString());
            loadFuncByUser();
        }
    }
}
