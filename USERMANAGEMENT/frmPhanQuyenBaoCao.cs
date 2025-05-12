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
    public partial class frmPhanQuyenBaoCao: Form
    {
        public frmPhanQuyenBaoCao()
        {
            InitializeComponent();
        }
        SYS_USER _sysUser;
        SYS_RIGHT_REP _sysRightRep;
        public int _idUser;
        public string _macty;
        public string _madvi;

        private void frmPhanQuyenBaoCao_Load(object sender, EventArgs e)
        {
            dgvChucNang.AutoGenerateColumns = false;
            dgvUsers.AutoGenerateColumns = false;
            _sysUser = new SYS_USER();
            _sysRightRep = new SYS_RIGHT_REP();
            loadUsers();
            loadRepByUser();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _idUser = Convert.ToUInt16(dgvUsers.CurrentRow.Cells["IDUSER"].Value);
            loadRepByUser();
        }
        void loadUsers()
        {
            if (_macty == null && _madvi == null)
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
        void loadRepByUser()
        {
            VIEW_REP_SYS_RIGHT_REP _vFuncRight = new VIEW_REP_SYS_RIGHT_REP();
            dgvChucNang.DataSource = _vFuncRight.getRepByUser(_idUser);
            dgvChucNang.ReadOnly = false;
            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                int value = Convert.ToInt32(dgvUsers.Rows[i].Cells["IDUSER"].Value);

                if (value == _idUser)
                {
                    dgvUsers.ClearSelection();
                    dgvUsers.Rows[i].Selected = true;
                    dgvUsers.CurrentCell = dgvUsers.Rows[i].Cells[0];

                }
            }
            dgvChucNang.ClearSelection();
        }

  /*      private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
            for (int i = 0; i < dgvChucNang.RowCount; i++)
            {

                if (dgvChucNang.Rows[i].Selected)
                {
                    int value = Convert.ToInt32(dgvChucNang.Rows[i].Cells["REP_CODE"].Value);

                    _sysRightRep.update(_idUser, value, false);
                }
            }
            loadRepByUser();
        }

        private void toànQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvChucNang.RowCount; i++)
            {
                if (dgvChucNang.Rows[i].Selected)
                {
                    int value = Convert.ToInt32(dgvChucNang.Rows[i].Cells["REP_CODE"].Value);
                    _sysRightRep.update(_idUser, value, true);
                }
            }
            loadRepByUser();
        }
    }
}
