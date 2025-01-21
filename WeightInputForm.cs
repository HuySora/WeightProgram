using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeightProgram.Data;
using WeightProgram.ExForm;
using WeightProgram.Util;

namespace WeightProgram {
    // TODO: Add const
    public partial class WeightInputForm : ExtendedForm<MainForm> {
        #region Inline variables
        public MainForm MainForm => MdiParent;
        public WeightDataService WeightDataService => MdiParent.WeightDataService;
        public ReceiptService ReceiptService => MdiParent.ReceiptService;
        #endregion
        private WeightData m_CurrSelectedWeightData;
        private Timer UpdateTimer;

        public WeightInputForm() {
            InitializeComponent();
        }

        #region Controls event
        private void WeightInputForm_Load(object sender, EventArgs e) {
            // Timer
            UpdateTimer = new Timer();
            UpdateTimer.Interval = 1000;
            UpdateTimer.Tick += UpdateTimer_Tick;
            UpdateTimer.Start();
            // Configure views
            ConfigureWeightDataumView();
            // Refresh views
            UpdateWeightDataumView();
            UpdateFormView();
        }

        private void txtContainerCount_TextChanged(object sender, EventArgs e) {
            UpdateContainerWeightView();
        }
        private void txtContainerWeightPerUnit_TextChanged(object sender, EventArgs e) {
            UpdateContainerWeightView();
        }
        private void btnNewWeightData_Click(object sender, EventArgs e) {
            if(TryCreateWeightData(out WeightData wgtData, out string errorMsg)) {
                WeightDataService.Create(wgtData);
                UpdateWeightDataumView();
            } else {
                MessageBox.Show(errorMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveWeightData_Click(object sender, EventArgs e) {
            if(m_CurrSelectedWeightData == null) {
                return;
            }
            if(TryUpdateWeightData(m_CurrSelectedWeightData, out string errorMsg)) {
                WeightDataService.Update(m_CurrSelectedWeightData);
                UpdateWeightDataumView();
            } else {
                MessageBox.Show(errorMsg, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeselectWeightData_Click(object sender, EventArgs e) {
            if(dgvWeightDatum.Rows.Count > 0) {
                // Move the left selection arrow to last row
                dgvWeightDatum.CurrentCell = dgvWeightDatum.Rows[dgvWeightDatum.Rows.Count - 1].Cells[0];
            }
            dgvWeightDatum.ClearSelection();
        }
        private void btnPrintWeightDataReceipt_Click(object sender, EventArgs e) {
            // Get the current WeightData from the database since m_CurrSelectedWeightData are not real-time
            var wgtData = WeightDataService.Read(m_CurrSelectedWeightData.Id);
            if(wgtData == null) {
                MessageBox.Show($"Không tìm thông số cân Id={m_CurrSelectedWeightData.Id}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Try get or create a receipt
            Receipt receipt = wgtData.Receipts.Any() ? wgtData.Receipts.First() : null;
            if(receipt == null) {
                if(TryCreateReceipt(wgtData.Id, out receipt, out string errorMessage)) {
                    // Successfully created the receipt
                } else {
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            var form = new WeightDataReceiptReportViewerForm(receipt);
            form.Show();
        }
        private void dgvWeightDatum_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if(dgvWeightDatum.Columns[e.ColumnIndex].Name == nameof(WeightData.Receipts)) {
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
        private void dgvWeightDatum_SelectionChanged(object sender, EventArgs e) {
            if(dgvWeightDatum.SelectedCells.Count == 0) {
                m_CurrSelectedWeightData = null;
            } else {
                var selectedRow = dgvWeightDatum.Rows[dgvWeightDatum.SelectedCells[0].RowIndex];
                m_CurrSelectedWeightData = selectedRow.DataBoundItem as WeightData;
            }
            UpdateFormView();
        }
        #endregion

        #region Timer event
        private void UpdateTimer_Tick(object sender, EventArgs e) {
            var random = new Random();
            if(m_CurrSelectedWeightData != null) {
                // Using DateTime.MinValue to decide if entry & exit dates exist
                dtpEntryDate.Value = m_CurrSelectedWeightData.EntryDate == null
                    ? DateTime.Now
                    : (DateTime)m_CurrSelectedWeightData.EntryDate;
                dtpExitDate.Value = m_CurrSelectedWeightData.ExitDate == null
                    ? DateTime.Now
                    : (DateTime)m_CurrSelectedWeightData.ExitDate;
                // Weight values
                if(m_CurrSelectedWeightData.Weight1 == 0) {
                    txtWeight1.Text = MainForm.CurrentScaleWeight.ToString();
                } else if(m_CurrSelectedWeightData.Weight2 == 0) {
                    int weightDiff = Math.Abs(m_CurrSelectedWeightData.Weight1 - MainForm.CurrentScaleWeight);
                    txtWeight2.Text = MainForm.CurrentScaleWeight.ToString();
                    txtWeightDifference.Text = weightDiff.ToString();
                }
                UpdateContainerWeightView();
            } else {
                dtpEntryDate.Value = DateTime.Now;
                dtpExitDate.Value = DateTime.Now;
                txtWeight1.Text = MainForm.CurrentScaleWeight.ToString();
            }
        }
        #endregion

        private void ConfigureWeightDataumView() {
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
            for(int i = 0; i < dgvWeightDatum.ColumnCount; i++) {
                if(!headerTxt2DataPropName.TryGetValue(dgvWeightDatum.Columns[i].HeaderText, out string dataPropName)) {
                    continue;
                }
                dgvWeightDatum.Columns[i].Name = dataPropName;
                dgvWeightDatum.Columns[i].DataPropertyName = dataPropName;
            }
            dgvWeightDatum.CellFormatting += dgvWeightDatum_CellFormatting;
            dgvWeightDatum.SelectionChanged += dgvWeightDatum_SelectionChanged;
        }
        private void UpdateWeightDataumView() {
            // TODO: Optimizable, use BindingList instead
            dgvWeightDatum.DataSource = WeightDataService.ReadAll().ToList();
            if(dgvWeightDatum.Rows.Count > 0) {
                // Move the left selection arrow to last row
                int lastRowIndex = dgvWeightDatum.Rows.Count - 1;
                dgvWeightDatum.CurrentCell = dgvWeightDatum.Rows[lastRowIndex].Cells[0];
                dgvWeightDatum.FirstDisplayedScrollingRowIndex = lastRowIndex;
            }
        }
        private void UpdateContainerWeightView() {
            if(!txtContainerCount.TryParseInt(out int containerCount)) {
                return;
            }
            if(!txtContainerWeightPerUnit.TryParseInt(out int containerWgtPerUnit)) {
                return;
            }
            int containerTotalWeight = (containerCount * containerWgtPerUnit / 1000);
            txtContainerTotalWeight.Text = containerTotalWeight.ToString();
            if(!txtWeightDifference.TryParseInt(out int wgtDiff)) {
                return;
            }
            txtNetGoodsWeight.Text = (wgtDiff - containerTotalWeight).ToString();
        }
        private void UpdateFormView() {
            if(m_CurrSelectedWeightData == null) {
                // Set all form data to default
                txtId.Text = (WeightDataService.GetLastPrimaryKey() + 1).ToString();
                txtCustomerName.Clear();
                txtWarehouseName.Clear();
                txtScaleType.Clear();
                txtVehiclePlateNumber.Clear();
                txtGoods.Clear();
                txtWeight1.Text = "0";
                txtWeight2.Text = "0";
                txtWeightDifference.Text = "0";
                txtContainerCount.Clear();
                txtContainerWeightPerUnit.Clear();
                txtContainerTotalWeight.Text = "0";
                txtNetGoodsWeight.Text = "0";
                txtNotes.Clear();
                dtpEntryDate.Value = DateTime.Now;
                dtpExitDate.Value = DateTime.Now;
                // Toggle buttons
                btnNewWeightData.Enabled = true;
                btnSaveWeightData.Enabled = false;
                btnDeselectWeightData.Enabled = false;
                btnPrintWeightDataReceipt.Enabled = false;
                return;
            } else {
                // Populate the text boxes with the data from the selected row
                txtId.Text = m_CurrSelectedWeightData.Id.ToString();
                txtCustomerName.Text = m_CurrSelectedWeightData.CustomerName.ToString();
                txtWarehouseName.Text = m_CurrSelectedWeightData.WarehouseName.ToString();
                txtScaleType.Text = m_CurrSelectedWeightData.ScaleType.ToString();
                txtVehiclePlateNumber.Text = m_CurrSelectedWeightData.VehiclePlateNumber.ToString();
                txtGoods.Text = m_CurrSelectedWeightData.Goods.ToString();
                txtWeight1.Text = m_CurrSelectedWeightData.Weight1.ToString();
                txtWeight2.Text = m_CurrSelectedWeightData.Weight2.ToString();
                txtWeightDifference.Text = m_CurrSelectedWeightData.WeightDifference.ToString();
                txtContainerCount.Text = m_CurrSelectedWeightData.ContainerCount.ToString();
                txtContainerWeightPerUnit.Text = m_CurrSelectedWeightData.ContainerWeightPerUnit.ToString();
                //txtContainerTotalWeight.Text = m_CurrSelectedWeightData.ContainerTotalWeight.ToString();
                //txtNetGoodsWeight.Text = m_CurrSelectedWeightData.NetGoodsWeight.ToString();
                txtNotes.Text = m_CurrSelectedWeightData.Notes.ToString();
                // Safely convert date values
                dtpEntryDate.Value = m_CurrSelectedWeightData.EntryDate.GetValueOrDefault(DateTime.Now);
                dtpExitDate.Value = m_CurrSelectedWeightData.ExitDate.GetValueOrDefault(DateTime.Now);
                // Toggle buttons
                btnNewWeightData.Enabled = false;
                btnSaveWeightData.Enabled = true;
                btnDeselectWeightData.Enabled = true;
                btnPrintWeightDataReceipt.Enabled = true;
            }
        }

        private bool TryCreateWeightData(out WeightData wgtData, out string errorMsg) {
            wgtData = null;
            errorMsg = string.Empty;
            // We use this as the error message builder as well as validating check
            StringBuilder sb = new StringBuilder();

            // Validate fields and accumulate error messages
            if(!txtCustomerName.TryParseString(out string custName)) {
                //sb.AppendLine("Tên khách hàng là bắt buộc.");
            }
            if(!txtWarehouseName.TryParseString(out string warehouseName)) {
                //sb.AppendLine("Tên kho là bắt buộc.");
            }
            if(!txtScaleType.TryParseString(out string scaleType)) {
                //sb.AppendLine("Loại cân là bắt buộc.");
            }
            if(!txtVehiclePlateNumber.TryParseString(out string plateNum)) {
                sb.AppendLine("Biển số xe là bắt buộc.");
            }
            if(!txtGoods.TryParseString(out string goods)) {
                //sb.AppendLine("Mô tả hàng hóa là bắt buộc.");
            }
            if(!txtWeight1.TryParseInt(out int wgt1)) {
                //sb.AppendLine("Cân nặng 1 là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtWeight2.TryParseInt(out int wgt2)) {
                //sb.AppendLine("Cân nặng 2 là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtContainerCount.TryParseInt(out int containerCount)) {
                //sb.AppendLine("Số lượng bao là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtContainerWeightPerUnit.TryParseInt(out int containerWgtPerUnit)) {
                //sb.AppendLine("Cân nặng mỗi bao là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtNotes.TryParseString(out string notes)) {
                //sb.AppendLine("Ghi chú là bắt buộc.");
            }
            DateTime entryDate = dtpEntryDate.Value;
            DateTime exitDate = dtpExitDate.Value;

            // If all validations pass (no error msg), create the WeightData object
            if(sb.Length == 0) {
                wgtData = new WeightData {
                    CustomerName = custName,
                    WarehouseName = warehouseName,
                    ScaleType = scaleType,
                    VehiclePlateNumber = plateNum,
                    Goods = goods,
                    Weight1 = wgt1,
                    Weight2 = wgt2,
                    ContainerCount = containerCount,
                    ContainerWeightPerUnit = containerWgtPerUnit,
                    Notes = notes,
                    EntryDate = entryDate,
                    ExitDate = null, //exitDate,
                };
                wgtData.Evaluate();

                return true;
            }

            errorMsg = sb.ToString();
            return false;
        }
        private bool TryUpdateWeightData(in WeightData wgtData, out string errorMsg) {
            errorMsg = string.Empty;
            // We use this as the error message builder as well as validating check
            StringBuilder sb = new StringBuilder();

            // Validate fields and accumulate error messages
            if(!txtCustomerName.TryParseString(out string custName)) {
                //sb.AppendLine("Tên khách hàng là bắt buộc.");
            }
            if(!txtWarehouseName.TryParseString(out string warehouseName)) {
                //sb.AppendLine("Tên kho là bắt buộc.");
            }
            if(!txtScaleType.TryParseString(out string scaleType)) {
                //sb.AppendLine("Loại cân là bắt buộc.");
            }
            if(!txtVehiclePlateNumber.TryParseString(out string plateNum)) {
                sb.AppendLine("Biển số xe là bắt buộc.");
            }
            if(!txtGoods.TryParseString(out string goods)) {
                //sb.AppendLine("Mô tả hàng hóa là bắt buộc.");
            }
            if(!txtWeight1.TryParseInt(out int wgt1)) {
                //sb.AppendLine("Cân nặng 1 là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtWeight2.TryParseInt(out int wgt2)) {
                //sb.AppendLine("Cân nặng 2 là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtWeightDifference.TryParseInt(out int wgtDiff)) {
                //sb.AppendLine("Cân nặng chênh lệch là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtContainerCount.TryParseInt(out int containerCount)) {
                //sb.AppendLine("Số lượng bao là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtContainerWeightPerUnit.TryParseInt(out int containerWgtPerUnit)) {
                //sb.AppendLine("Cân nặng mỗi bao là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtContainerTotalWeight.TryParseInt(out int totalContainerWgt)) {
                //sb.AppendLine("Tổng cân nặng bao là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtNetGoodsWeight.TryParseInt(out int netGoodsWgt)) {
                //sb.AppendLine("Cân nặng thực tế là bắt buộc và phải là số nguyên hợp lệ.");
            }
            if(!txtNotes.TryParseString(out string notes)) {
                //sb.AppendLine("Ghi chú là bắt buộc.");
            }
            DateTime entryDate = dtpEntryDate.Value;
            DateTime exitDate = dtpExitDate.Value;

            // If all validations pass (no error msg), update the WeightData object
            if(sb.Length == 0) {
                wgtData.CustomerName = custName;
                wgtData.WarehouseName = warehouseName;
                wgtData.ScaleType = scaleType;
                wgtData.VehiclePlateNumber = plateNum;
                wgtData.Goods = goods;
                wgtData.Weight1 = wgt1;
                wgtData.Weight2 = wgt2;
                wgtData.ContainerCount = containerCount;
                wgtData.ContainerWeightPerUnit = containerWgtPerUnit;
                wgtData.Notes = notes;
                wgtData.EntryDate = entryDate;
                wgtData.ExitDate = exitDate;
                wgtData.Evaluate();

                return true;
            }

            errorMsg = sb.ToString();
            return false;
        }

        private bool TryCreateReceipt(int wgtId, out Receipt receipt, out string errorMsg) {
            receipt = null;
            errorMsg = "";
            var wgtData = WeightDataService.Read(wgtId);
            if(wgtData == null) {
                errorMsg += $"Không tìm thông số cân Id={wgtId}.";
                return false;
            }
            // Validate fields and accumulate error messages
            if(!txtTotalCost.TryParseInt(out int totalCost)) {
                //sb.AppendLine("Tổng tiền là bắt buộc.");
            }
            receipt = new Receipt {
                Date = DateTime.Now,
                TotalCost = totalCost,
                WeightDataId = wgtData.Id,
                WeightData = wgtData
            };
            ReceiptService.Create(receipt);
            return true;
        }
    }
}
