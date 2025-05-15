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

namespace STOCK
{
    public partial class frmMain: Form
    {
        SYS_FUNC _func;
        SYS_GROUP _group;
        SYS_RIGHT _right;
        tb_SYS_USER _user;
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(tb_SYS_USER user)
        {
            InitializeComponent();
            this._user = user;
            _func = new SYS_FUNC();
            _group = new SYS_GROUP();
            _right = new SYS_RIGHT();
            leftMenu();
        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton_Tonkho_Click(object sender, EventArgs e)
        {
            string madvi = "";
            TONKHO _tonkho = new TONKHO();
            if (myFunctions._madvi == "")
            {
                madvi = "CNMB";
            }
            else madvi = myFunctions._madvi;
            if (_tonkho.TinhTon(madvi, DateTime.Now))
            {
                MessageBox.Show("Cập nhật tồn kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật tồn kho không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void leftMenu()
        {
            var _IsParent = _func.getParent();
            panel1.Controls.Clear();
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.BackColor = toolStrip1.BackColor;
            foreach (var i in _IsParent)
            {
                Panel groupPanel = new Panel();
                groupPanel.Name = i.FUNC_CODE;
                groupPanel.Tag = i.FUNC_CODE;
                groupPanel.BackColor = toolStrip1.BackColor;

                Button groupButton = new Button();
                groupButton.Text = "  " + i.DESCRIPTION;
                groupButton.Name = i.FUNC_CODE;
                groupButton.Tag = i.FUNC_CODE;
                groupButton.ForeColor = Color.Black;
                groupButton.Dock = DockStyle.Top;
                groupButton.FlatStyle = FlatStyle.Flat;
                groupButton.FlatAppearance.BorderSize = 0;
                groupButton.BackColor = Color.Transparent;
                groupButton.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                groupButton.Height = 40;
                groupButton.Image = imageList1.Images[0];
                groupButton.ImageAlign = ContentAlignment.MiddleLeft;
                groupButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                groupButton.TextAlign = ContentAlignment.MiddleLeft;
                groupButton.Click += (s, e) => ToggleGroup(groupPanel);

                FlowLayoutPanel itemsPanel = new FlowLayoutPanel();
                itemsPanel.Name = i.FUNC_CODE;
                itemsPanel.Dock = DockStyle.Top;
                itemsPanel.FlowDirection = FlowDirection.TopDown;
                itemsPanel.WrapContents = false;
                itemsPanel.Width = groupPanel.Width;
                itemsPanel.Visible = true;
                itemsPanel.BackColor = Color.Transparent;
                itemsPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                itemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                itemsPanel.Padding = new Padding(20, 0, 0, 5);


                var _IsChild = _func.getChild(i.FUNC_CODE);
                foreach (var j in _IsChild)
                {
                    Button itemButton = new Button();
                    itemButton.Text = "  " + j.DESCRIPTION;
                    itemButton.Name = j.FUNC_CODE;
                    itemButton.Tag = j.FUNC_CODE;
                    itemButton.Font = new Font("Segoe UI", 11, FontStyle.Regular);
                    itemButton.Height = 30;
                    itemButton.ForeColor = Color.Black;
                    itemButton.BackColor = Color.Transparent;
                    itemButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                    itemButton.Width = 235;
                    itemButton.FlatStyle = FlatStyle.Flat;
                    itemButton.Margin = new Padding(0, 5, 0, 5);
                    itemButton.FlatAppearance.BorderSize = 0;
                    itemButton.TextAlign = ContentAlignment.MiddleLeft;
                    itemButton.Click += (s, e) => click_ItemButton(itemButton);
                    itemButton.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#7E7471");
                    itemsPanel.Controls.Add(itemButton);
                }
                itemsPanel.Height = itemsPanel.Controls.Count * (30 + 5 + 5) + itemsPanel.Padding.Top + itemsPanel.Padding.Bottom;
                groupPanel.Controls.Add(itemsPanel);
                itemsPanel.Top = groupButton.Height;
                itemsPanel.Left = 0;
                groupPanel.Controls.Add(groupButton);
                groupPanel.Height = groupButton.Height + itemsPanel.Height;
                groupPanel.Dock = DockStyle.Top;
                panel1.Controls.Add(groupPanel);
            }
        }
        private void ToggleGroup(Panel groupPanel)
        {
            Button groupButton = groupPanel.Controls.OfType<Button>().FirstOrDefault();
            FlowLayoutPanel itemsPanel = groupPanel.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            if (groupButton != null && itemsPanel != null)
            {
                itemsPanel.Visible = !itemsPanel.Visible;
                if (itemsPanel.Visible)
                {
                    groupButton.Image = imageList1.Images[0];
                    groupPanel.Height = groupButton.Height + itemsPanel.Height;
                }
                else
                {
                    groupButton.Image = imageList1.Images[1];
                    groupPanel.Height = groupButton.Height;
                }
            }
        }
        private void click_ItemButton(Button itembutton)
        {
            string funcCode = itembutton.Tag.ToString();
            var gr = _group.getGroupByMemBer(_user.IDUSER);
            var r = _right.getRight(_user.IDUSER, funcCode);
            if (gr != null)
            {
                var _groupright = _right.getRight(gr.GROUP, funcCode);
                if (r.USER_RIGHT < _groupright.USER_RIGHT)
                {
                    r.USER_RIGHT = _groupright.USER_RIGHT;
                }
            }
            if (r.USER_RIGHT == 0)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form childForm = null;
                switch (funcCode)
                {
                    case "DONVI":
                        childForm = new frmDonVi(_user, r.USER_RIGHT.Value);
                        break;
                    case "CONGTY":
                        childForm = new frmCongTy(_user, r.USER_RIGHT.Value);
                        break;
                    case "NHACC":
                        childForm = new frmNhaCungCap(_user, r.USER_RIGHT.Value);
                        break;
                    case "DVT":
                        childForm = new frmDVT(_user, r.USER_RIGHT.Value);
                        break;
                    case "XUATXU":
                        childForm = new formXuatxu(_user, r.USER_RIGHT.Value);
                        break;
                    case "NHOMHH":
                        childForm = new frmNhomhh(_user, r.USER_RIGHT.Value);
                        break;
                    case "HANGHOA":
                        childForm = new frmHanghoa(_user, r.USER_RIGHT.Value);
                        break;
                    case "NHAPMUA":
                        childForm = new frmNhapmua(_user, r.USER_RIGHT.Value);
                        break;
                    case "XUATNB":
                        childForm = new frmXuatNoiBo(_user, r.USER_RIGHT.Value);
                        break;
                    case "NHAPNB":
                        childForm = new frmNhapNB(_user, r.USER_RIGHT.Value);
                        break;
                    case "DOIMATKHAU":
                        childForm = new frmChangePassword(_user);
                        break;
                    case "XUATSI":
                        childForm = new frmXuatxi(_user, r.USER_RIGHT.Value);
                        break;
                    case "BACKUP":
                        childForm = new frmBackup(_user, r.USER_RIGHT.Value);
                        break;
                    case "RESTORE":
                        childForm = new frmRestore(_user, r.USER_RIGHT.Value);
                        break;
                    case "BANLE":
                        childForm = new frmBanle(_user, r.USER_RIGHT.Value);
                        break;
                    case "TONKHOCTY":
                        childForm = new frmTonkhoCty(_user, r.USER_RIGHT.Value);
                        break;
                    case "TONKHODVI":
                        childForm = new frmTonkhoDvi(_user, r.USER_RIGHT.Value);
                        break;
                    default:
                        MessageBox.Show("Chức năng chưa được triển khai.");
                        return;
                }
                childForm.Show();
            }
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            label1.Left = (panel2.ClientSize.Width - label1.Width) / 2;
            label1.Top = 50;
            label2.Left = (panel2.ClientSize.Width - label2.Width) / 2;
            label2.Top = label1.Bottom + 10;
        }

        private void toolStripButton_Baocao_Click(object sender, EventArgs e)
        {
            frmBaocao frmBaocao = new frmBaocao(_user);
            frmBaocao.Show();
        }

        private void toolStripButton_Barcode_Click(object sender, EventArgs e)
        {
            frmPrintBarcode f = new frmPrintBarcode();
            f.Show();
        }
    }
}
