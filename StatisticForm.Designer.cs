namespace WeightProgram {
    partial class StatisticForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.dgvStatistic = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.splitFilter = new System.Windows.Forms.SplitContainer();
            this.tblFilterLeftSplit = new System.Windows.Forms.TableLayoutPanel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.pnlWarehouseName = new System.Windows.Forms.Panel();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.cmbWarehouseName = new System.Windows.Forms.ComboBox();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.pnlCustomerName = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.pnlGoods = new System.Windows.Forms.Panel();
            this.txtGoods = new System.Windows.Forms.TextBox();
            this.cmbGoods = new System.Windows.Forms.ComboBox();
            this.lblGoods = new System.Windows.Forms.Label();
            this.txtVehiclePlateNumber = new System.Windows.Forms.TextBox();
            this.lblVehiclePlateNumber = new System.Windows.Forms.Label();
            this.tblFilterRightSplit = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTotalPrice = new System.Windows.Forms.Panel();
            this.txtTotalPriceMax = new System.Windows.Forms.TextBox();
            this.lblTotalPriceMinMaxSeparator = new System.Windows.Forms.Label();
            this.txtTotalPriceMin = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.pnlDateRangeButtons = new System.Windows.Forms.Panel();
            this.btnAllDays = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnYesterday = new System.Windows.Forms.Button();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblExitDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.tsStatistic = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPrintWeightDataReceipt = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).BeginInit();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitFilter)).BeginInit();
            this.splitFilter.Panel1.SuspendLayout();
            this.splitFilter.Panel2.SuspendLayout();
            this.splitFilter.SuspendLayout();
            this.tblFilterLeftSplit.SuspendLayout();
            this.pnlWarehouseName.SuspendLayout();
            this.pnlCustomerName.SuspendLayout();
            this.pnlGoods.SuspendLayout();
            this.tblFilterRightSplit.SuspendLayout();
            this.pnlTotalPrice.SuspendLayout();
            this.pnlDateRangeButtons.SuspendLayout();
            this.tsStatistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStatistic
            // 
            this.dgvStatistic.AllowUserToDeleteRows = false;
            this.dgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dgvStatistic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatistic.Location = new System.Drawing.Point(0, 271);
            this.dgvStatistic.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvStatistic.Name = "dgvStatistic";
            this.dgvStatistic.ReadOnly = true;
            this.dgvStatistic.Size = new System.Drawing.Size(1124, 331);
            this.dgvStatistic.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Số xe";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Khách hàng";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hàng hóa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TL1";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "TL2";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TL chênh lệch";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "TL bao tổng";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "TL thực tế";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Ghi chú";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Ngày vào";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Ngày ra";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Kiểu cân";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Tên kho";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Số bao";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "TL 1 bao (gr)";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Hóa đơn";
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.splitFilter);
            this.grpFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilter.Location = new System.Drawing.Point(0, 0);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.grpFilter.Size = new System.Drawing.Size(1124, 246);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Bộ lọc";
            // 
            // splitFilter
            // 
            this.splitFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitFilter.IsSplitterFixed = true;
            this.splitFilter.Location = new System.Drawing.Point(5, 25);
            this.splitFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitFilter.Name = "splitFilter";
            // 
            // splitFilter.Panel1
            // 
            this.splitFilter.Panel1.Controls.Add(this.tblFilterLeftSplit);
            // 
            // splitFilter.Panel2
            // 
            this.splitFilter.Panel2.Controls.Add(this.tblFilterRightSplit);
            this.splitFilter.Size = new System.Drawing.Size(1114, 215);
            this.splitFilter.SplitterDistance = 557;
            this.splitFilter.SplitterWidth = 3;
            this.splitFilter.TabIndex = 0;
            // 
            // tblFilterLeftSplit
            // 
            this.tblFilterLeftSplit.ColumnCount = 2;
            this.tblFilterLeftSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblFilterLeftSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblFilterLeftSplit.Controls.Add(this.txtNotes, 1, 4);
            this.tblFilterLeftSplit.Controls.Add(this.lblNotes, 0, 4);
            this.tblFilterLeftSplit.Controls.Add(this.pnlWarehouseName, 1, 3);
            this.tblFilterLeftSplit.Controls.Add(this.lblWarehouseName, 0, 3);
            this.tblFilterLeftSplit.Controls.Add(this.pnlCustomerName, 1, 2);
            this.tblFilterLeftSplit.Controls.Add(this.lblCustomerName, 0, 2);
            this.tblFilterLeftSplit.Controls.Add(this.pnlGoods, 1, 1);
            this.tblFilterLeftSplit.Controls.Add(this.lblGoods, 0, 1);
            this.tblFilterLeftSplit.Controls.Add(this.txtVehiclePlateNumber, 1, 0);
            this.tblFilterLeftSplit.Controls.Add(this.lblVehiclePlateNumber, 0, 0);
            this.tblFilterLeftSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilterLeftSplit.Location = new System.Drawing.Point(0, 0);
            this.tblFilterLeftSplit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tblFilterLeftSplit.Name = "tblFilterLeftSplit";
            this.tblFilterLeftSplit.RowCount = 5;
            this.tblFilterLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterLeftSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblFilterLeftSplit.Size = new System.Drawing.Size(557, 215);
            this.tblFilterLeftSplit.TabIndex = 0;
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(144, 178);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(408, 31);
            this.txtNotes.TabIndex = 9;
            this.txtNotes.Text = "Cân lệch -90kg";
            // 
            // lblNotes
            // 
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotes.Location = new System.Drawing.Point(5, 178);
            this.lblNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblNotes.Size = new System.Drawing.Size(129, 31);
            this.lblNotes.TabIndex = 8;
            this.lblNotes.Text = "Ghi chú";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlWarehouseName
            // 
            this.pnlWarehouseName.Controls.Add(this.txtWarehouseName);
            this.pnlWarehouseName.Controls.Add(this.cmbWarehouseName);
            this.pnlWarehouseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWarehouseName.Location = new System.Drawing.Point(144, 135);
            this.pnlWarehouseName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlWarehouseName.Name = "pnlWarehouseName";
            this.pnlWarehouseName.Size = new System.Drawing.Size(408, 31);
            this.pnlWarehouseName.TabIndex = 7;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(69, 0);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(281, 26);
            this.txtWarehouseName.TabIndex = 1;
            this.txtWarehouseName.Text = "BÌNH MINH";
            // 
            // cmbWarehouseName
            // 
            this.cmbWarehouseName.FormattingEnabled = true;
            this.cmbWarehouseName.Location = new System.Drawing.Point(0, 0);
            this.cmbWarehouseName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbWarehouseName.Name = "cmbWarehouseName";
            this.cmbWarehouseName.Size = new System.Drawing.Size(55, 28);
            this.cmbWarehouseName.TabIndex = 0;
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWarehouseName.Location = new System.Drawing.Point(5, 135);
            this.lblWarehouseName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblWarehouseName.Size = new System.Drawing.Size(129, 31);
            this.lblWarehouseName.TabIndex = 6;
            this.lblWarehouseName.Text = "Tên kho";
            this.lblWarehouseName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlCustomerName
            // 
            this.pnlCustomerName.Controls.Add(this.txtCustomerName);
            this.pnlCustomerName.Controls.Add(this.cmbCustomerName);
            this.pnlCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCustomerName.Location = new System.Drawing.Point(144, 92);
            this.pnlCustomerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlCustomerName.Name = "pnlCustomerName";
            this.pnlCustomerName.Size = new System.Drawing.Size(408, 31);
            this.pnlCustomerName.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(69, 0);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(281, 26);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Text = "BÌNH MINH";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(0, 0);
            this.cmbCustomerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(55, 28);
            this.cmbCustomerName.TabIndex = 0;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomerName.Location = new System.Drawing.Point(5, 92);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblCustomerName.Size = new System.Drawing.Size(129, 31);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Tên khách hàng";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlGoods
            // 
            this.pnlGoods.Controls.Add(this.txtGoods);
            this.pnlGoods.Controls.Add(this.cmbGoods);
            this.pnlGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGoods.Location = new System.Drawing.Point(144, 49);
            this.pnlGoods.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlGoods.Name = "pnlGoods";
            this.pnlGoods.Size = new System.Drawing.Size(408, 31);
            this.pnlGoods.TabIndex = 3;
            // 
            // txtGoods
            // 
            this.txtGoods.Location = new System.Drawing.Point(69, 2);
            this.txtGoods.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGoods.Name = "txtGoods";
            this.txtGoods.Size = new System.Drawing.Size(281, 26);
            this.txtGoods.TabIndex = 1;
            this.txtGoods.Text = "TRẤU";
            // 
            // cmbGoods
            // 
            this.cmbGoods.FormattingEnabled = true;
            this.cmbGoods.Location = new System.Drawing.Point(0, 0);
            this.cmbGoods.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbGoods.Name = "cmbGoods";
            this.cmbGoods.Size = new System.Drawing.Size(55, 28);
            this.cmbGoods.TabIndex = 0;
            // 
            // lblGoods
            // 
            this.lblGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGoods.Location = new System.Drawing.Point(5, 49);
            this.lblGoods.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblGoods.Name = "lblGoods";
            this.lblGoods.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblGoods.Size = new System.Drawing.Size(129, 31);
            this.lblGoods.TabIndex = 2;
            this.lblGoods.Text = "Tên hàng hóa";
            this.lblGoods.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtVehiclePlateNumber
            // 
            this.txtVehiclePlateNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtVehiclePlateNumber.Location = new System.Drawing.Point(144, 6);
            this.txtVehiclePlateNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtVehiclePlateNumber.Name = "txtVehiclePlateNumber";
            this.txtVehiclePlateNumber.Size = new System.Drawing.Size(196, 26);
            this.txtVehiclePlateNumber.TabIndex = 1;
            this.txtVehiclePlateNumber.Text = "79-D7979";
            // 
            // lblVehiclePlateNumber
            // 
            this.lblVehiclePlateNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVehiclePlateNumber.Location = new System.Drawing.Point(5, 6);
            this.lblVehiclePlateNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblVehiclePlateNumber.Name = "lblVehiclePlateNumber";
            this.lblVehiclePlateNumber.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblVehiclePlateNumber.Size = new System.Drawing.Size(129, 31);
            this.lblVehiclePlateNumber.TabIndex = 0;
            this.lblVehiclePlateNumber.Text = "Số xe";
            this.lblVehiclePlateNumber.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tblFilterRightSplit
            // 
            this.tblFilterRightSplit.ColumnCount = 2;
            this.tblFilterRightSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblFilterRightSplit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblFilterRightSplit.Controls.Add(this.pnlTotalPrice, 1, 3);
            this.tblFilterRightSplit.Controls.Add(this.lblTotalPrice, 0, 3);
            this.tblFilterRightSplit.Controls.Add(this.pnlDateRangeButtons, 1, 2);
            this.tblFilterRightSplit.Controls.Add(this.dtpToDate, 1, 1);
            this.tblFilterRightSplit.Controls.Add(this.lblExitDate, 0, 1);
            this.tblFilterRightSplit.Controls.Add(this.dtpFromDate, 1, 0);
            this.tblFilterRightSplit.Controls.Add(this.lblEntryDate, 0, 0);
            this.tblFilterRightSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilterRightSplit.Location = new System.Drawing.Point(0, 0);
            this.tblFilterRightSplit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tblFilterRightSplit.Name = "tblFilterRightSplit";
            this.tblFilterRightSplit.RowCount = 5;
            this.tblFilterRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblFilterRightSplit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFilterRightSplit.Size = new System.Drawing.Size(554, 215);
            this.tblFilterRightSplit.TabIndex = 0;
            // 
            // pnlTotalPrice
            // 
            this.pnlTotalPrice.Controls.Add(this.txtTotalPriceMax);
            this.pnlTotalPrice.Controls.Add(this.lblTotalPriceMinMaxSeparator);
            this.pnlTotalPrice.Controls.Add(this.txtTotalPriceMin);
            this.pnlTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTotalPrice.Location = new System.Drawing.Point(143, 135);
            this.pnlTotalPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pnlTotalPrice.Name = "pnlTotalPrice";
            this.pnlTotalPrice.Size = new System.Drawing.Size(406, 31);
            this.pnlTotalPrice.TabIndex = 6;
            // 
            // txtTotalPriceMax
            // 
            this.txtTotalPriceMax.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTotalPriceMax.Location = new System.Drawing.Point(160, 0);
            this.txtTotalPriceMax.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotalPriceMax.Name = "txtTotalPriceMax";
            this.txtTotalPriceMax.Size = new System.Drawing.Size(129, 26);
            this.txtTotalPriceMax.TabIndex = 2;
            this.txtTotalPriceMax.Text = "1000000";
            // 
            // lblTotalPriceMinMaxSeparator
            // 
            this.lblTotalPriceMinMaxSeparator.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalPriceMinMaxSeparator.Location = new System.Drawing.Point(129, 0);
            this.lblTotalPriceMinMaxSeparator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblTotalPriceMinMaxSeparator.Name = "lblTotalPriceMinMaxSeparator";
            this.lblTotalPriceMinMaxSeparator.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblTotalPriceMinMaxSeparator.Size = new System.Drawing.Size(31, 31);
            this.lblTotalPriceMinMaxSeparator.TabIndex = 1;
            this.lblTotalPriceMinMaxSeparator.Text = "-";
            this.lblTotalPriceMinMaxSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalPriceMin
            // 
            this.txtTotalPriceMin.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTotalPriceMin.Location = new System.Drawing.Point(0, 0);
            this.txtTotalPriceMin.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotalPriceMin.Name = "txtTotalPriceMin";
            this.txtTotalPriceMin.Size = new System.Drawing.Size(129, 26);
            this.txtTotalPriceMin.TabIndex = 0;
            this.txtTotalPriceMin.Text = "0";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPrice.Location = new System.Drawing.Point(5, 135);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblTotalPrice.Size = new System.Drawing.Size(128, 31);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Tổng tiền";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlDateRangeButtons
            // 
            this.pnlDateRangeButtons.Controls.Add(this.btnAllDays);
            this.pnlDateRangeButtons.Controls.Add(this.btnToday);
            this.pnlDateRangeButtons.Controls.Add(this.btnYesterday);
            this.pnlDateRangeButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDateRangeButtons.Location = new System.Drawing.Point(141, 89);
            this.pnlDateRangeButtons.Name = "pnlDateRangeButtons";
            this.pnlDateRangeButtons.Size = new System.Drawing.Size(410, 37);
            this.pnlDateRangeButtons.TabIndex = 4;
            // 
            // btnAllDays
            // 
            this.btnAllDays.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAllDays.Location = new System.Drawing.Point(222, 0);
            this.btnAllDays.Name = "btnAllDays";
            this.btnAllDays.Size = new System.Drawing.Size(111, 37);
            this.btnAllDays.TabIndex = 2;
            this.btnAllDays.Text = "Tất cả";
            this.btnAllDays.UseVisualStyleBackColor = true;
            // 
            // btnToday
            // 
            this.btnToday.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnToday.Location = new System.Drawing.Point(111, 0);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(111, 37);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            // 
            // btnYesterday
            // 
            this.btnYesterday.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYesterday.Location = new System.Drawing.Point(0, 0);
            this.btnYesterday.Name = "btnYesterday";
            this.btnYesterday.Size = new System.Drawing.Size(111, 37);
            this.btnYesterday.TabIndex = 0;
            this.btnYesterday.Text = "Hôm qua";
            this.btnYesterday.UseVisualStyleBackColor = true;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(143, 49);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(406, 26);
            this.dtpToDate.TabIndex = 3;
            this.dtpToDate.TabStop = false;
            // 
            // lblExitDate
            // 
            this.lblExitDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExitDate.Location = new System.Drawing.Point(5, 49);
            this.lblExitDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblExitDate.Size = new System.Drawing.Size(128, 31);
            this.lblExitDate.TabIndex = 2;
            this.lblExitDate.Text = "Đến ngày";
            this.lblExitDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(143, 6);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(406, 26);
            this.dtpFromDate.TabIndex = 1;
            this.dtpFromDate.TabStop = false;
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntryDate.Location = new System.Drawing.Point(5, 6);
            this.lblEntryDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblEntryDate.Size = new System.Drawing.Size(128, 31);
            this.lblEntryDate.TabIndex = 0;
            this.lblEntryDate.Text = "Từ ngày";
            this.lblEntryDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tsStatistic
            // 
            this.tsStatistic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnPrintWeightDataReceipt,
            this.btnExport});
            this.tsStatistic.Location = new System.Drawing.Point(0, 246);
            this.tsStatistic.Name = "tsStatistic";
            this.tsStatistic.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsStatistic.Size = new System.Drawing.Size(1124, 25);
            this.tsStatistic.TabIndex = 1;
            this.tsStatistic.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(104, 22);
            this.btnRefresh.Text = "Làm mới bảng";
            // 
            // btnPrintWeightDataReceipt
            // 
            this.btnPrintWeightDataReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintWeightDataReceipt.Image")));
            this.btnPrintWeightDataReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintWeightDataReceipt.Name = "btnPrintWeightDataReceipt";
            this.btnPrintWeightDataReceipt.Size = new System.Drawing.Size(84, 22);
            this.btnPrintWeightDataReceipt.Text = "In hóa đơn";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(81, 22);
            this.btnExport.Text = "Xuất excel";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 602);
            this.Controls.Add(this.dgvStatistic);
            this.Controls.Add(this.tsStatistic);
            this.Controls.Add(this.grpFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatisticForm";
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistic)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.splitFilter.Panel1.ResumeLayout(false);
            this.splitFilter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitFilter)).EndInit();
            this.splitFilter.ResumeLayout(false);
            this.tblFilterLeftSplit.ResumeLayout(false);
            this.tblFilterLeftSplit.PerformLayout();
            this.pnlWarehouseName.ResumeLayout(false);
            this.pnlWarehouseName.PerformLayout();
            this.pnlCustomerName.ResumeLayout(false);
            this.pnlCustomerName.PerformLayout();
            this.pnlGoods.ResumeLayout(false);
            this.pnlGoods.PerformLayout();
            this.tblFilterRightSplit.ResumeLayout(false);
            this.pnlTotalPrice.ResumeLayout(false);
            this.pnlTotalPrice.PerformLayout();
            this.pnlDateRangeButtons.ResumeLayout(false);
            this.tsStatistic.ResumeLayout(false);
            this.tsStatistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistic;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.SplitContainer splitFilter;
        private System.Windows.Forms.TableLayoutPanel tblFilterLeftSplit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Panel pnlWarehouseName;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.ComboBox cmbWarehouseName;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.Panel pnlCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Panel pnlGoods;
        private System.Windows.Forms.TextBox txtGoods;
        private System.Windows.Forms.ComboBox cmbGoods;
        private System.Windows.Forms.Label lblGoods;
        private System.Windows.Forms.TextBox txtVehiclePlateNumber;
        private System.Windows.Forms.Label lblVehiclePlateNumber;
        private System.Windows.Forms.TableLayoutPanel tblFilterRightSplit;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Button btnYesterday;
        private System.Windows.Forms.Panel pnlDateRangeButtons;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnAllDays;
        private System.Windows.Forms.ToolStrip tsStatistic;
        private System.Windows.Forms.ToolStripButton btnPrintWeightDataReceipt;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Panel pnlTotalPrice;
        private System.Windows.Forms.TextBox txtTotalPriceMax;
        private System.Windows.Forms.Label lblTotalPriceMinMaxSeparator;
        private System.Windows.Forms.TextBox txtTotalPriceMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
    }
}