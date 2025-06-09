using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using USERMANAGEMENT.MyComponent;

namespace USERMANAGEMENT
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        MyTreeViewCombo _treeView;
        CONGTY _congty;
        DONVI _donvi;
        SYS_USER _sysUser;
        bool _isRoot;
        string _macty;
        string _madvi;
        private void frmMain_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            _congty = new CONGTY();
            _donvi = new DONVI();
            _sysUser = new SYS_USER();
            _isRoot = true;
            loadTreeView();
            LoadUser("CT01", "~"); 
        }
        void loadTreeView()
        {
            _treeView = new MyTreeViewCombo(pnNhom.Width-30, 400);
            _treeView.Font = new Font("Tahoma", 10, FontStyle.Bold);
            var lstCTY = _congty.getAll();
            foreach (var item in lstCTY)
            {
                TreeNode parentNode = new TreeNode();
                parentNode.Text = item.MACTY + " - " + item.TENCTY;
                parentNode.Tag = item.MACTY;
                parentNode.Name = item.MACTY;
                _treeView.TreeView.Nodes.Add(parentNode);
                /* foreach (var dv in _donvi.getAll(item.MACTY))
                 {
                     TreeNode childnode = new TreeNode();
                     childnode.Text = dv.MADV + " - " + dv.TENDVI;
                     childnode.Tag = dv.MACTY + "." + dv.MADV;
                     childnode.Name = dv.MACTY + "." + dv.MADV;//CT01.CTKSNW
                     _treeView.TreeView.Nodes[parentNode.Name].Nodes.Add(childnode);

                 } */
                foreach (var dv in _donvi.getAll(item.MACTY))
                {
                    TreeNode childnode = new TreeNode();
                    childnode.Text = dv.MADV + " - " + dv.TENDVI;
                    childnode.Tag = dv.MACTY + "." + dv.MADV; // Lưu cả MACTY và MADVI vào Tag
                    childnode.Name = dv.MACTY + "." + dv.MADV; // Định dạng "MACTY.MADVI"
                    _treeView.TreeView.Nodes[parentNode.Name].Nodes.Add(childnode);
                }
            }
            _treeView.TreeView.ExpandAll();
            pnNhom.Controls.Add(_treeView);
            _treeView.Width = pnNhom.Width;
            _treeView.Height = pnNhom.Height;
            _treeView.TreeView.AfterSelect += TreeView_AfterSelect;
            _treeView.TreeView.Click += TreeView_Click;
        }

        private void TreeView_Click(object sender, EventArgs e)
        {
            _treeView.dropDown.Focus();
            _treeView.SelectAll();
        }
        /* private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
         {
             _treeView.Text = _treeView.TreeView.SelectedNode.Text;
             if(_treeView.TreeView.SelectedNode.Parent == null)
             {
                 _isRoot = true;
                 _macty = _treeView.TreeView.SelectedNode.Tag.ToString();
                 _madvi = "~";//truc thuoc van phong cty
             }
             else
             {
                 _isRoot = false;
                 _macty = _treeView.TreeView.SelectedNode.Name.Substring(0,4);
                 _madvi = _treeView.TreeView.SelectedNode.Name.Substring(5);
             }
             LoadUser(_macty, _madvi);
             _treeView.dropDown.Close();

         }*/
        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _treeView.Text = _treeView.TreeView.SelectedNode.Text;

            // Xác định node cha (công ty) hoặc node con (đơn vị)
            if (_treeView.TreeView.SelectedNode.Parent == null)
            {
                _isRoot = true;
                _macty = _treeView.TreeView.SelectedNode.Tag.ToString(); // Lấy MACTY từ Tag
                _madvi = "~"; // Đơn vị gốc (trực thuộc công ty)
            }
            else
            {
                _isRoot = false;
                // Tách MACTY và MADVI từ Name của node (định dạng "MACTY.MADVI")
                string[] parts = _treeView.TreeView.SelectedNode.Name.Split('.');
                _macty = parts[0];
                _madvi = parts[1];
            }

            LoadUser(_macty, _madvi); // Tải dữ liệu người dùng
            _treeView.dropDown.Close();
        }
        public void LoadUser(string macty, string madvi)
        {
            _sysUser = new SYS_USER();
            dataGridView1.DataSource = _sysUser.getUserByDVI(macty,madvi);
            dataGridView1.ReadOnly = true ;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            if (_treeView.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }
            frmGroup frm = new frmGroup();
            frm._them = true;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*        private void dataGridView1_DoubleClick(object sender, EventArgs e)
                {
                    if (dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Cells["GROUP"].Value.Equals(true) )
                    {
                        frmGroup frm = new frmGroup();
                        frm._them = false;
                        frm._idUser = int.Parse(dataGridView1.CurrentRow.Cells["ID"].ToString());
                        frm.ShowDialog();
                    }
                    else
                    {
                        frmUser frm = new frmUser();
                        frm._them = false;
                        frm._idUser = int.Parse(dataGridView1.CurrentRow.Cells["ID"].ToString());
                        frm.ShowDialog();
                    }
                }*/
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // 1) Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.CurrentRow == null) return;

            // 2) Lấy và parse ID an toàn
            object idValue = dataGridView1.CurrentRow.Cells["ID"].Value;
            if (idValue == null || !int.TryParse(idValue.ToString(), out int id))
            {
                MessageBox.Show("ID không hợp lệ!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3) Lấy và parse cờ GROUP an toàn (giả sử cột GROUP chứa bool hoặc "True"/"False")
            object grpValue = dataGridView1.CurrentRow.Cells["GROUP"].Value;
            bool isGroup = false;
            if (grpValue != null)
                bool.TryParse(grpValue.ToString(), out isGroup);

            // 4) Mở form tương ứng
            if (isGroup)
            {
                var frm = new frmGroup
                {
                    _them = false,
                    _idUser = id
                };
                frm.ShowDialog();
            }
            else
            {
                var frm = new frmUser
                {
                    _them = false,
                    _idUser = id
                };
                frm.ShowDialog();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*  private void btnCapnhat_Click(object sender, EventArgs e)
          {
              if (dataGridView1.RowCount > 0 && dataGridView1.CurrentRow.Cells["GROUP"].Value.Equals(true))
              {
                  frmGroup frm = new frmGroup();
                  frm._them = false;
                  frm._idUser = int.Parse(dataGridView1.CurrentRow.Cells["ID"].ToString());
                  frm.ShowDialog();
              }
              else
              {
                  frmUser frm = new frmUser();
                  frm._them = false;
                  frm._idUser = int.Parse(dataGridView1.CurrentRow.Cells["ID"].ToString());
                  frm.ShowDialog();
              }
          }*/
        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra giá trị ID có hợp lệ không
            if (!int.TryParse(dataGridView1.CurrentRow.Cells["ID"].Value?.ToString(), out int idUser))
            {
                MessageBox.Show("Giá trị ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra điều kiện GROUP một cách an toàn
            bool isGroup = false;
            if (dataGridView1.CurrentRow.Cells["GROUP"].Value != null)
            {
                bool.TryParse(dataGridView1.CurrentRow.Cells["GROUP"].Value.ToString(), out isGroup);
            }

            // Xử lý logic
            if (isGroup)
            {
                frmGroup frm = new frmGroup();
                frm._them = false;
                frm._idUser = idUser; // Sử dụng giá trị đã được kiểm tra
                frm.ShowDialog();
            }
            else
            {
                frmUser frm = new frmUser();
                frm._them = false;
                frm._idUser = idUser; // Sử dụng giá trị đã được kiểm tra
                frm.ShowDialog();
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (_treeView.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đơn vị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
 /*           if (!int.TryParse(dataGridView1.CurrentRow.Cells["ID"].Value?.ToString(), out int idUser) )
            {
                MessageBox.Show("Giá trị ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/


            frmUser  frm = new frmUser();
            frm._them = true;
            frm._macty = _macty;
            frm._madvi = _madvi;
          //  frm._idUser = idUser; //int.Parse(dataGridView1.CurrentRow.Cells["ID"].ToString());
            frm.ShowDialog();
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells["ID"].Value != null)
            {
                if (int.TryParse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString(), out int idUser))
                {
                    frm._idUser = idUser;
                }
            }


        } 
      

        private void btnChucnang_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dataGridView1.CurrentRow.Cells["ID"].Value?.ToString(), out int idUser))
            {
                MessageBox.Show("Giá trị ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPhanQuyenChucNang frm = new frmPhanQuyenChucNang();
            frm._idUser = idUser;  
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dataGridView1.CurrentRow.Cells["ID"].Value?.ToString(), out int idUser))
            {
                MessageBox.Show("Giá trị ID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmPhanQuyenBaoCao frm = new frmPhanQuyenBaoCao();
            frm._idUser = idUser;
            frm._macty = _macty;
            frm._madvi = _madvi;
            frm.ShowDialog();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex < dataGridView1.Columns.Count && dataGridView1.Columns[e.ColumnIndex].Name == "ISGROUP" && e.RowIndex >= 0)

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
        }
    }
}
