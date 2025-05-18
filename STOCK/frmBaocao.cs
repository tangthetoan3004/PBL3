using BusinessLayer;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using DataLayer;
using STOCK.ucControl;
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
    public partial class frmBaocao: Form
    {
        public frmBaocao()
        {
            InitializeComponent();
        }
        public frmBaocao(tb_SYS_USER user)
        {
            InitializeComponent();
            this._user = user;
        }
        tb_SYS_USER _user;
        SYS_USER _sysUser;
        SYS_REPORT _sysReport;
        SYS_RIGHT_REP _sysRightRep;
        Panel _panel;
        ucNgay _ucNgay;
        ucCongty _ucCongty;
        ucDonvi _ucDonvi;

        private void bt_thuchien_Click(object sender, EventArgs e)
        {
            tb_SYS_REPORT rp = _sysReport.getItem(int.Parse(lstDanhSach.SelectedValue.ToString()));
            Form frm = new Form();
            CrystalReportViewer Crv = new CrystalReportViewer();
            Crv.ShowGroupTreeButton = false;
            Crv.ShowParameterPanelButton = false;
            Crv.ToolPanelView = ToolPanelViewType.None;
            TableLogOnInfo Thongtin;
            ReportDocument doc = new ReportDocument();
            doc.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\" + rp.REP_NAME + @".rpt");
            Thongtin = doc.Database.Tables[0].LogOnInfo;
            Thongtin.ConnectionInfo.ServerName = myFunctions._srv;
            Thongtin.ConnectionInfo.DatabaseName = myFunctions._db;
            Thongtin.ConnectionInfo.IntegratedSecurity = true;
            doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);

            if(rp.TUNGAY == true)
            {
                doc.SetParameterValue("@NGAYD", _ucNgay.Dtp1.Value);
                doc.SetParameterValue("@NGAYC", _ucNgay.Dtp2.Value);
            }
            if(rp.MACTY == true)
            {
                doc.SetParameterValue("@MACTY", _ucCongty.CbbCongty.SelectedValue.ToString());
            }
            if(rp.MADVI == true)
            {
  //              doc.SetParameterValue("@MACTY", _ucCongty.CbbCongty.SelectedValue.ToString());
                doc.SetParameterValue("@MADVI", _ucDonvi.CbbDonvi.SelectedValue.ToString());

            }
            Crv.Dock = DockStyle.Fill;
            Crv.ReportSource = doc;
            frm.Controls.Add(Crv);
            Crv.Refresh();
            frm.Text = rp.DESCRIPTION;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
      

        private void bt_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaocao_Load(object sender, EventArgs e)
        {
            _sysReport = new SYS_REPORT();
            _sysUser = new SYS_USER();
            _sysRightRep = new SYS_RIGHT_REP();
            lstDanhSach.DataSource = _sysReport.getListByRight(_sysRightRep.getlistByUser(_user.IDUSER));
            lstDanhSach.DisplayMember = "DESCRIPTION";
            lstDanhSach.ValueMember = "REP_CODE";
            loadUserControls();
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadUserControls();
        }
      
        private void loadUserControls() {
            tb_SYS_REPORT rep = new tb_SYS_REPORT();
            if (lstDanhSach.SelectedValue != null && int.TryParse(lstDanhSach.SelectedValue.ToString(), out int selectedId))
            {
                rep = _sysReport.getItem(selectedId);
                if (_panel != null)
                {
                    _panel.Dispose();
                }
                _panel = new Panel();
                _panel.Dock = DockStyle.Top;
                _panel.BorderStyle = BorderStyle.Fixed3D;
                _panel.MinimumSize = new Size(_panel.Width,280);
                List<Control> _ctrl = new List<Control>();
                if (rep.TUNGAY == true)
                {
                    _ucNgay = new ucNgay();
                    _ucNgay.Dock = DockStyle.Top;
                    _ctrl.Add(_ucNgay);
                }
                if (rep.MACTY == true)
                {
                    _ucCongty = new ucCongty();
                    _ucCongty.Dock = DockStyle.Top;
                    _ctrl.Add(_ucCongty);
                }
                if (rep.MADVI == true)
                {
                    _ucDonvi = new ucDonvi();
                    _ucDonvi.Dock = DockStyle.Top;
                    _ctrl.Add(_ucDonvi);
                }
                _ctrl.Reverse();
                _panel.Controls.AddRange(_ctrl.ToArray());
                this.splitContainer1.Panel1.Controls.Add(_panel);
            } 
        }
    }
}
