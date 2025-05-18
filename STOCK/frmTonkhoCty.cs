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
using Excel = Microsoft.Office.Interop.Excel;

namespace STOCK
{
    public partial class frmTonkhoCty: Form
    {
        public frmTonkhoCty()
        {
            InitializeComponent();
        }
        public frmTonkhoCty(tb_SYS_USER user, int right)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this._user = user;
            this._right = right;
        }
        tb_SYS_USER _user;
        int _right;
        TONKHO _tonkho;
        CONGTY _congty;
        List<obj_TONKHO> _lstTK = new List<obj_TONKHO> ();

        private void frmTonkhoCty_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            _congty = new CONGTY();
            _tonkho = new TONKHO();
            loadCty();
            cbb_congty.SelectedValue = myFunctions._macty;
            dtp.Value = DateTime.Now;
            loadTonKho(myFunctions._macty, DateTime.Now.Year, DateTime.Now.Month);
        }
        void loadCty()
        {
            cbb_congty.DataSource = _congty.getAll();
            cbb_congty.DisplayMember = "TENCTY";
            cbb_congty.ValueMember = "MACTY";
        }
        void loadTonKho(string macty, int nam, int ky)
        {
            dataGridView1.DataSource = _tonkho.getTonKhoCty(macty, nam, ky);
            dataGridView1.ReadOnly = true;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            lb_dtp.Top = (panel1.Height - lb_dtp.Height) / 2;
            lb_dtp.Left = 80;

            dtp.Top = lb_dtp.Top - 4;
            dtp.Left = lb_dtp.Right + 3;

            lb_congty.Top = lb_dtp.Top;
            lb_congty.Left = dtp.Right + 200;

            cbb_congty.Top = lb_congty.Top - 4;
            cbb_congty.Left = lb_congty.Right + 3;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            tb_find.Top = (panel2.Height - tb_find.Height) / 2;
            tb_find.Left = 1100;
            bt_find.Top = tb_find.Top;
            bt_find.Left = tb_find.Right + 3;
            bt_find.Height = tb_find.Height;
        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton_Export_Click(object sender, EventArgs e)
        {
            _exportExcel();
        }
        private void _exportExcel()
        {
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 2000-2003 (.xls)|*.xls|Excel 2007 or higher (.xlsx)|*.xlsx";
            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = null;
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;

                try
                {
                    excelApp = new Excel.Application();
                    excelApp.Visible = false;
                    workbook = excelApp.Workbooks.Add(Type.Missing);
                    worksheet = (Excel.Worksheet)workbook.ActiveSheet;
                    worksheet.Name = "Tồn kho công ty";

                    worksheet.Cells[1, 1] = "DANH MỤC TỒN KHO " + cbb_congty.SelectedItem.ToString();
                    Excel.Range sophieuRange = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 12]];
                    sophieuRange.Merge(); 
                    sophieuRange.Font.Size = 20;
                    sophieuRange.Font.Bold = true;
                    sophieuRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    worksheet.Cells[2, 1] = "NGÀY " + dtp.Value.ToString("dd/MM/yyyy");
                    Excel.Range ngay = worksheet.Range[worksheet.Cells[2, 1], worksheet.Cells[2, 12]];
                    ngay.Merge(); 
                    ngay.Font.Size = 16;
                    ngay.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    var visibleColumns = dataGridView1.Columns
                    .Cast<DataGridViewColumn>()
                    .Where(col => col.Visible)
                    .OrderBy(col => col.DisplayIndex)
                    .ToList();

                    int colIndex = 1;
                    foreach (DataGridViewColumn column in visibleColumns)
                    {
                        if (column.Visible)
                        {
                            worksheet.Cells[3, colIndex] = column.HeaderText;
                            colIndex++;
                        }
                    }

                    int rowIndex = 4;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue;

                        colIndex = 1;
                        foreach (DataGridViewColumn column in visibleColumns)
                        {
                            if (column.Visible)
                            {
                                object cellValue = row.Cells[column.Index].Value;
                                worksheet.Cells[rowIndex, colIndex] = cellValue?.ToString() ?? "";
                                colIndex++;
                            }
                        }
                        rowIndex++;
                    }                   
                    worksheet.Cells[rowIndex, 1] = "Tổng cộng";
                    Excel.Range tongCongLabel = worksheet.Range[worksheet.Cells[rowIndex, 1], worksheet.Cells[rowIndex, 11]];
                    tongCongLabel.Merge();
                    tongCongLabel.Font.Size = 14;
                    tongCongLabel.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                    double tong = 0.0;
                    for (int i = 4; i < rowIndex; i++)
                    {
                        var cellValue = worksheet.Cells[i, 12].Value;
                        if (double.TryParse(cellValue?.ToString(), out double thanhTien))
                        {
                            tong += thanhTien;
                        }
                    }
                    worksheet.Cells[rowIndex, 12] = tong;
                    Excel.Range tongThanhTienCell = worksheet.Range[worksheet.Cells[rowIndex, 12], worksheet.Cells[rowIndex, 12]];
                    tongThanhTienCell.NumberFormat = "#,##0";
                    tongThanhTienCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    worksheet.Columns.AutoFit();

                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (worksheet != null) System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                    if (workbook != null)
                    {
                        workbook.Close(false);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                    }
                    if (excelApp != null)
                    {
                        excelApp.Quit();
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                    }
                }
            }
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            string barcode = tb_find.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(barcode))
            {
                var filteredList = _lstTK
                    .Where(x => x.BARCODE != null && x.BARCODE.ToLower().Contains(barcode))
                    .ToList();

                dataGridView1.DataSource = filteredList;
            }
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            loadTonKho(cbb_congty.SelectedValue.ToString(), dtp.Value.Year, dtp.Value.Month);
            _lstTK = _tonkho.getTonKhoCty(cbb_congty.SelectedValue.ToString(), dtp.Value.Year, dtp.Value.Month);
            tb_find.Text = "";
        }

        private void tb_find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                bt_find_Click(sender, e);
            }
        }
    }
}
