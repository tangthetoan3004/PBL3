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
using Zen.Barcode;
using System.IO;
using System.Drawing.Printing;
using DevExpress.Data.Svg;

namespace STOCK
{
    public partial class frmPrintBarcode: Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewControl printPreviewControl1 = new PrintPreviewControl();
        private int currentRowIndex = 0; 
        private int margin = 50; 
        private int horizontalSpacing = 35; 
        private int verticalSpacing = 70; 
        private int maxBarcodesPerRow = 3; 
        private int barcodeWidth = 220; 
        private int barcodeHeight = 100;
        public frmPrintBarcode()
        {
            InitializeComponent();
            this.Size = new Size(1190,600);
        }
        NHOMHH _nhh;
        HANGHOA _hh;
        private void frmPrintBarcode_Load(object sender, EventArgs e)
        {
            _nhh = new NHOMHH();
            _hh = new HANGHOA();
            loadNhom();
            cbb_nhom.SelectedIndex = 0;
            loadDanhMuc();
        }
        private Bitmap GenerateBarcode(string barcode)
        {
            if (string.IsNullOrEmpty(barcode) || barcode.Length != 13 || !barcode.All(char.IsDigit))
            {
                throw new ArgumentException("Mã vạch EAN-13 phải chính xác 13 chữ số!");
            }

            try
            {
                var barcodeDraw = BarcodeDrawFactory.Code128WithChecksum;
                Image image = barcodeDraw.Draw(barcode, 4);
                return (Bitmap)image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo barcode: {ex.Message}");
                return null;
            }
        }
        private void loadNhom()
        {
            cbb_nhom.DataSource = _nhh.getAll();
            cbb_nhom.DisplayMember = "TENNHOM";
            cbb_nhom.ValueMember = "IDNHOM";
        }
        private void _imageBarcode()
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                string barcode = row.Cells["BARCODE"].Value?.ToString();
                if (!string.IsNullOrEmpty(barcode)) {
                    Bitmap image = GenerateBarcode(barcode);
                    row.Cells["IMAGE"].Value = image;
                }
            }
        }

        private void toolStripButton_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            lb_nhom.Top = (panel1.Height -  lb_nhom.Height) / 2;
            lb_nhom.Left = (panel1.Width - lb_nhom.Width - 3 - cbb_nhom.Width) / 2;

            cbb_nhom.Top = lb_nhom.Top - 3;
            cbb_nhom.Left = lb_nhom.Right + 3;
        }

        private void panel2_Resize(object sender, EventArgs e)
        {
            bt_find.Top = (panel2.Height - bt_find.Height) / 2;
            bt_find.Left = panel2.Width - 10 - bt_find.Width;

            tb_find.Top = bt_find.Top;
            tb_find.Left = bt_find.Left - 3 - tb_find.Width;
        }

        private void cbb_nhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDanhMuc();
        }
        private void loadDanhMuc()
        {
            if (cbb_nhom.SelectedValue == null || !int.TryParse(cbb_nhom.SelectedValue.ToString(), out int idNhom))
            {
                return;
            }
            dataGridView1.DataSource = _hh.getDanhMucInBarcode(idNhom);
            _imageBarcode();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["IMAGE"].Index && e.RowIndex >= 0)
            {
                Bitmap barcodeImage = (Bitmap)dataGridView1.Rows[e.RowIndex].Cells["IMAGE"].Value;
                if (barcodeImage != null)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = barcodeImage,
                        SizeMode = PictureBoxSizeMode.StretchImage, 
                        Dock = DockStyle.Fill
                    };
                    Form previewForm = new Form
                    {
                        Text = "Xem trước Barcode",
                        StartPosition = FormStartPosition.CenterScreen,
                        Size = new Size(700, 400),
                        MaximizeBox = false,
                        FormBorderStyle = FormBorderStyle.FixedDialog
                    };

                    previewForm.Controls.Add(pictureBox);
                    previewForm.ShowDialog();
                }
            }
        }

        private void toolStripButton_Export_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để in!");
                return;
            }

            currentRowIndex = 0;

            printDocument1.PrintPage += PrintDocument1_PrintPage;

            using (PrintPreviewDialog previewDialog = new PrintPreviewDialog())
            {
                previewDialog.Document = printDocument1;
                previewDialog.WindowState = FormWindowState.Maximized;
                previewDialog.ShowDialog();
            }

            printDocument1.PrintPage -= PrintDocument1_PrintPage;
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float xPos = margin; 
            float yPos = margin; 
            int currentColumn = 0; 

            Font fontTenHang = new Font("Seoge UI", 13);
            Font fontDonGia = new Font("Seoge UI", 13);
            SolidBrush brush = new SolidBrush(Color.Black);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            stringFormat.FormatFlags = StringFormatFlags.LineLimit;
            List<(string tenHang, Bitmap barcodeImage, string donGia, float xPos, float textHeight)> rowItems = new List<(string, Bitmap, string, float, float)>();

            while (currentRowIndex < dataGridView1.Rows.Count)
            {
                if (dataGridView1.Rows[currentRowIndex].IsNewRow)
                {
                    currentRowIndex++;
                    continue;
                }

                var soTemCell = dataGridView1.Rows[currentRowIndex].Cells["SOTEM"];
                if (soTemCell.Value == null ||
                    !int.TryParse(soTemCell.Value.ToString(), out int soTem) ||
                    soTem <= 0)
                {
                    currentRowIndex++;
                    continue;
                }
                string tenHang = dataGridView1.Rows[currentRowIndex].Cells["TENTAT"].Value?.ToString();
                Bitmap barcodeImage = (Bitmap)dataGridView1.Rows[currentRowIndex].Cells["IMAGE"].Value;
                object donGiaValue = dataGridView1.Rows[currentRowIndex].Cells["DONGIA"].Value;

                string donGia = "N/A";
                if (donGiaValue != null && decimal.TryParse(donGiaValue.ToString(), out decimal gia))
                {
                    donGia = gia.ToString("N0");
                }

                if (barcodeImage == null)
                {
                    currentRowIndex++;
                    continue;
                }

                for (int i = 0; i < soTem; i++)
                {
                    if (currentColumn >= maxBarcodesPerRow)
                    {
                        float maxTextHeight = rowItems.Max(item => item.textHeight);
                        if (yPos + maxTextHeight + barcodeHeight + 50 > e.PageBounds.Height - margin)
                        {
                            e.HasMorePages = true;
                            fontTenHang.Dispose();
                            fontDonGia.Dispose();
                            stringFormat.Dispose();
                            return;
                        }
                        float barcodeYPos = yPos + maxTextHeight + 10;
                        foreach (var item in rowItems)
                        {
                            RectangleF _textRect = new RectangleF(item.xPos, yPos, barcodeWidth, 100);
                            e.Graphics.DrawString(item.tenHang, fontTenHang, brush, _textRect, stringFormat);
                            e.Graphics.DrawImage(item.barcodeImage, item.xPos, barcodeYPos, barcodeWidth, barcodeHeight);
                            e.Graphics.DrawString("Giá: " + item.donGia + " VNĐ", fontDonGia, brush, item.xPos, barcodeYPos + barcodeHeight + 10);
                        }
                        yPos += maxTextHeight + barcodeHeight + verticalSpacing + 40;
                        currentColumn = 0;
                        xPos = margin;
                        rowItems.Clear();
                    }
                    RectangleF textRect = new RectangleF(xPos, yPos, barcodeWidth, 100);
                    SizeF textSize = e.Graphics.MeasureString(tenHang, fontTenHang, (int)barcodeWidth, stringFormat);
                    float textHeight = Math.Min(textSize.Height, 100);
                    rowItems.Add((tenHang, barcodeImage, donGia, xPos, textHeight));

                    xPos += barcodeWidth + horizontalSpacing;
                    currentColumn++;
                }

                currentRowIndex++;
            }
            if (rowItems.Count > 0)
            {
                float maxTextHeight = rowItems.Max(item => item.textHeight);

                if (yPos + maxTextHeight + barcodeHeight + 50 > e.PageBounds.Height - margin)
                {
                    e.HasMorePages = true;
                    fontTenHang.Dispose();
                    fontDonGia.Dispose();
                    stringFormat.Dispose();
                    return;
                }

                float barcodeYPos = yPos + maxTextHeight + 10;
                foreach (var item in rowItems)
                {
                    RectangleF textRect = new RectangleF(item.xPos, yPos, barcodeWidth, 100);
                    e.Graphics.DrawString(item.tenHang, fontTenHang, brush, textRect, stringFormat);
                    e.Graphics.DrawImage(item.barcodeImage, item.xPos, barcodeYPos, barcodeWidth, barcodeHeight);
                    e.Graphics.DrawString("Giá: " + item.donGia + " VNĐ", fontDonGia, brush, item.xPos, barcodeYPos + barcodeHeight + 10);
                }
            }
            e.HasMorePages = false;
            fontTenHang.Dispose();
            fontDonGia.Dispose();
            stringFormat.Dispose();
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            string barcode = tb_find.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(barcode))
            {
                loadDanhMuc();
            }
            else
            {
                if (cbb_nhom.SelectedValue == null || !int.TryParse(cbb_nhom.SelectedValue.ToString(), out int idNhom))
                {
                    return;
                }
                dataGridView1.DataSource = _hh.getListByKey(idNhom,tb_find.Text);
                _imageBarcode();
            }
        }

        private void tb_find_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                string barcode = tb_find.Text.Trim().ToLower();

                if (string.IsNullOrEmpty(barcode))
                {
                    loadDanhMuc();
                }
                else
                {
                    if (cbb_nhom.SelectedValue == null || !int.TryParse(cbb_nhom.SelectedValue.ToString(), out int idNhom))
                    {
                        return;
                    }
                    dataGridView1.DataSource = _hh.getListByKey(idNhom, tb_find.Text);
                    _imageBarcode();
                }
            }
        }
    }
}
