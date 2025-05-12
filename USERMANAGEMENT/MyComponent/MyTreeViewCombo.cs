using DevExpress.Data.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USERMANAGEMENT.MyComponent
{
    public partial class MyTreeViewCombo : System.Windows.Forms.ComboBox

    {
        ToolStripControlHost treeViewHost;
        public ToolStripDropDown dropDown;
        TreeView treeView;

        public MyTreeViewCombo(int _width, int _height)
        {
            treeView = new TreeView();
            treeView.BorderStyle = BorderStyle.None;
            treeView.Width = _width;
            treeView.Height = _height;
            treeView.Font = new System.Drawing.Font("Tahome", 10, System.Drawing.FontStyle.Bold);
            treeViewHost = new ToolStripControlHost(treeView);
            dropDown = new ToolStripDropDown();
            dropDown.Items.Add(treeViewHost);
        }

        public void sizeChanged(int _width, int _height)
        {
            treeView.Width = _width;
            treeView.Height = _height;

        }

        public TreeView TreeView
        {
            get { return treeViewHost.Control as TreeView; }
        }
        public void ShowDropDown()
        {
            if(dropDown != null)
            {
                treeViewHost.Width = DropDownWidth;
                treeViewHost.Height = DropDownHeight;
                dropDown.Show(this, 0, this.Height);
            }
        }

        private const int WM_USER = 0x0400,
                          WM_REFLECT = WM_USER + 0x1C00,
                          WM_COMMAND = 0x0111,
                          CBN_DROPDOWM = 7;
        public static int HIWORD(int n)
        {
            return (n >> 16) & 0xffff;
        }
        protected override void WndProc(ref Message m)
        {
            if(m.Msg == (WM_REFLECT + WM_COMMAND))
            {
                if (HIWORD((int)m.WParam) == CBN_DROPDOWM)
                {
                    ShowDropDown();
                    return;
                }
            }
            base.WndProc(ref m);
        }
        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(dropDown != null)
                {
                    dropDown.Dispose();
                    dropDown = null;
                }
            }
            base.Dispose(disposing);
        }
    }
}
