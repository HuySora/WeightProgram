using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WeightProgram.Data;
using WeightProgram.ExForm;
using WeightProgram.Util;
using Excel = Microsoft.Office.Interop.Excel;

namespace WeightProgram {
    public partial class StatisticForm : ExtendedForm<MainForm> {
        #region Inline variables
        public MainForm MainForm => MdiParent;
        public WeightDataService WeightDataService => MdiParent.WeightDataService;
        public ReceiptService ReceiptService => MdiParent.ReceiptService;
        #endregion

        private WeightData m_CurrSelectedWeightData;

        public StatisticForm() {
            InitializeComponent();
        }

        #region Controls event
        private void StatisticForm_Load(object sender, EventArgs e) {
            // Configure views
            ConfigureStatisticView();
            // Refresh views
            UpdateFormView();
        }
        private void btnToday_Click(object sender, EventArgs e) {
            dtpFromDate.Value = DateTime.Today; // This sets the time to 00:00:00
            dtpToDate.Value = dtpFromDate.Value.AddDays(1).AddTicks(-1); // This sets the time to 23:59:59.9999999
        }
        private void btnYesterday_Click(object sender, EventArgs e) {
            dtpFromDate.Value = DateTime.Today.AddDays(-1); // This sets the time to 00:00:00 of yesterday
            dtpToDate.Value = DateTime.Today.AddTicks(-1); // This sets the time to 23:59:59.9999999 of yesterday
        }
        private void btnAllDays_Click(object sender, EventArgs e) {
            dtpFromDate.Value = dtpFromDate.MinDate; // This sets the time to the minimum date
            dtpToDate.Value = dtpToDate.MaxDate; // This sets the time to the maximum date
        }
        private void btnRefresh_Click(object sender, EventArgs e) {
            UpdateStatisticView();
        }
        private void btnPrintWeightDataReceipt_Click(object sender, EventArgs e) {
            if (m_CurrSelectedWeightData == null) {
                MessageBox.Show($"Chưa chọn khách hàng để in hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get the current customer from the database since m_CurrSelectedWeightData are not real-time
            var customer = WeightDataService.Read(m_CurrSelectedWeightData.Id);
            if(customer == null) {
                MessageBox.Show($"Không tìm thông số cân có Id={m_CurrSelectedWeightData.Id}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Try get or create a receipt
            Receipt receipt = customer.Receipts.Any() ? customer.Receipts.First() : null;
            if(receipt == null) {
                MessageBox.Show($"Không tìm thấy hóa đơn nào liên kết với thông số cân có Id={m_CurrSelectedWeightData.Id}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = new WeightDataReceiptReportViewerForm(receipt);
            form.Show();
        }
        private void btnExport_Click(object sender, EventArgs e) {
            // Create a new Excel application with workbook and sheet
            Excel.Application excelApp = new Excel.Application();
            // Set to true if you want to see the Excel file being created
            excelApp.Visible = false;
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];
            // Export the DataGridView to Excel
            worksheet.GetDataFrom(dgvStatistic);
            // Export to .xls file
            try {
                // Save the workbook
                var saveFileDialog = new SaveFileDialog {
                    Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx|Excel Macro-Enabled Workbook|*.xlsm",
                    Title = "Save an Excel File"
                };
                if(saveFileDialog.ShowDialog() == DialogResult.OK) {
                    // Save as xlExcel8 (.xls) format for compatibility with Excel 2003
                    workbook.SaveAs(saveFileDialog.FileName, Excel.XlFileFormat.xlExcel8);
                    MessageBox.Show("Thành công", "Xuất file excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }
        private void dgvStatistic_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if(dgvStatistic.Columns[e.ColumnIndex].Name == nameof(WeightData.Receipts)) {
                if(e.Value is ICollection<Receipt> receipts) {
                    // Comma-separated string of ReceiptCodes (truncated to max 7 characters each)
                    e.Value = string.Join(", ",
                        receipts.Select(
                            r => r.GetReceiptCodeShort
                        )
                    );
                    e.FormattingApplied = true;
                }
            }
        }
        private void dgvStatistic_SelectionChanged(object sender, EventArgs e) {
            if(dgvStatistic.SelectedCells.Count == 0) {
                m_CurrSelectedWeightData = null;
            } else {
                var selectedRow = dgvStatistic.Rows[dgvStatistic.SelectedCells[0].RowIndex];
                m_CurrSelectedWeightData = selectedRow.DataBoundItem as WeightData;
            }
        }
        #endregion

        private void ConfigureStatisticView() {
            Dictionary<string, string> headerTxt2DataPropName = new Dictionary<string, string> {
                { "STT", "Id" },
                { "Số xe", "VehiclePlateNumber" },
                { "Khách hàng", "CustomerName" },
                { "Hàng hóa", "Goods" },
                { "TL1", "Weight1" },
                { "TL2", "Weight2" },
                { "TL chênh lệch", "WeightDifference" },
                { "TL bao tổng", "ContainerTotalWeight" },
                { "TL thực tế", "NetGoodsWeight" },
                { "Ghi chú", "Notes" },
                { "Ngày vào", "EntryDate" },
                { "Ngày ra", "ExitDate" },
                { "Kiểu cân", "ScaleType" },
                { "Tên kho", "WarehouseName" },
                { "Số bao", "ContainerCount" },
                { "TL 1 bao (gr)", "ContainerWeightPerUnit" },
                { "Hóa đơn", "Receipts" }
            };
            for(int i = 0; i < dgvStatistic.ColumnCount; i++) {
                if(!headerTxt2DataPropName.TryGetValue(dgvStatistic.Columns[i].HeaderText, out string dataPropName)) {
                    continue;
                }
                dgvStatistic.Columns[i].Name = dataPropName;
                dgvStatistic.Columns[i].DataPropertyName = dataPropName;
            }
            dgvStatistic.CellFormatting += dgvStatistic_CellFormatting;
            dgvStatistic.SelectionChanged += dgvStatistic_SelectionChanged;
        }
        private void UpdateStatisticView() {
            // TODO: Optimizable
            dgvStatistic.DataSource = WeightDataService.ReadAll().Where(c =>
                (string.IsNullOrEmpty(txtVehiclePlateNumber.Text) || c.VehiclePlateNumber.Contains(txtVehiclePlateNumber.Text)) &&
                (string.IsNullOrEmpty(txtCustomerName.Text) || c.CustomerName.Contains(txtCustomerName.Text)) &&
                (string.IsNullOrEmpty(txtGoods.Text) || c.Goods.Contains(txtGoods.Text)) &&
                (string.IsNullOrEmpty(txtWarehouseName.Text) || c.WarehouseName.Contains(txtWarehouseName.Text)) &&
                (string.IsNullOrEmpty(txtNotes.Text) || c.Notes.Contains(txtNotes.Text)) &&
                (c.EntryDate.Value >= dtpFromDate.Value) &&
                (c.EntryDate.Value <= dtpToDate.Value))
                .ToList();
        }
        private void UpdateFormView() {
            // Set all form data to default
            txtCustomerName.Clear();
            txtWarehouseName.Clear();
            txtVehiclePlateNumber.Clear();
            txtGoods.Clear();
            txtNotes.Clear();
            btnToday.PerformClick();
            btnRefresh.PerformClick();
        }
    }
}
