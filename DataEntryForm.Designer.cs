namespace WeightProgram {
    partial class DataEntryForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataEntryForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageWarehouses = new System.Windows.Forms.TabPage();
            this.dgvWarehouses = new System.Windows.Forms.DataGridView();
            this.dgvWarehousesColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvWarehousesColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsWarehouses = new System.Windows.Forms.ToolStrip();
            this.btnNewWarehouse = new System.Windows.Forms.ToolStripButton();
            this.btnSaveWarehouse = new System.Windows.Forms.ToolStripButton();
            this.btnDeselectWarehouse = new System.Windows.Forms.ToolStripButton();
            this.grpWarehouseInput = new System.Windows.Forms.GroupBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.lblWarehouseName = new System.Windows.Forms.Label();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvCustomersColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCustomersColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCustomers = new System.Windows.Forms.ToolStrip();
            this.btnNewCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnDeselectCustomer = new System.Windows.Forms.ToolStripButton();
            this.grpCustomerInput = new System.Windows.Forms.GroupBox();
            this.tabPageGoods = new System.Windows.Forms.TabPage();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.dgvGoodsColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGoodsColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsGoods = new System.Windows.Forms.ToolStrip();
            this.btnNewGoods = new System.Windows.Forms.ToolStripButton();
            this.btnSaveGoods = new System.Windows.Forms.ToolStripButton();
            this.btnDeselectGoods = new System.Windows.Forms.ToolStripButton();
            this.grpGoods = new System.Windows.Forms.GroupBox();
            this.tblWarehouseInput = new System.Windows.Forms.TableLayoutPanel();
            this.txtWarehouseId = new System.Windows.Forms.TextBox();
            this.lblWarehouseId = new System.Windows.Forms.Label();
            this.tblCustomerInput = new System.Windows.Forms.TableLayoutPanel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.tblGoods = new System.Windows.Forms.TableLayoutPanel();
            this.txtGoodsName = new System.Windows.Forms.TextBox();
            this.lblGoodsName = new System.Windows.Forms.Label();
            this.txtGoodsId = new System.Windows.Forms.TextBox();
            this.lblGoodsId = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageWarehouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).BeginInit();
            this.tsWarehouses.SuspendLayout();
            this.grpWarehouseInput.SuspendLayout();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tsCustomers.SuspendLayout();
            this.grpCustomerInput.SuspendLayout();
            this.tabPageGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.tsGoods.SuspendLayout();
            this.grpGoods.SuspendLayout();
            this.tblWarehouseInput.SuspendLayout();
            this.tblCustomerInput.SuspendLayout();
            this.tblGoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageWarehouses);
            this.tabControlMain.Controls.Add(this.tabPageCustomers);
            this.tabControlMain.Controls.Add(this.tabPageGoods);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(6);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1124, 602);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageWarehouses
            // 
            this.tabPageWarehouses.Controls.Add(this.dgvWarehouses);
            this.tabPageWarehouses.Controls.Add(this.tsWarehouses);
            this.tabPageWarehouses.Controls.Add(this.grpWarehouseInput);
            this.tabPageWarehouses.Location = new System.Drawing.Point(4, 34);
            this.tabPageWarehouses.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageWarehouses.Name = "tabPageWarehouses";
            this.tabPageWarehouses.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageWarehouses.Size = new System.Drawing.Size(1116, 564);
            this.tabPageWarehouses.TabIndex = 0;
            this.tabPageWarehouses.Text = "Nhà kho";
            this.tabPageWarehouses.UseVisualStyleBackColor = true;
            // 
            // dgvWarehouses
            // 
            this.dgvWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvWarehousesColumn1,
            this.dgvWarehousesColumn2});
            this.dgvWarehouses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWarehouses.Location = new System.Drawing.Point(6, 153);
            this.dgvWarehouses.Margin = new System.Windows.Forms.Padding(6);
            this.dgvWarehouses.Name = "dgvWarehouses";
            this.dgvWarehouses.Size = new System.Drawing.Size(1104, 405);
            this.dgvWarehouses.TabIndex = 2;
            // 
            // dgvWarehousesColumn1
            // 
            this.dgvWarehousesColumn1.HeaderText = "STT";
            this.dgvWarehousesColumn1.Name = "dgvWarehousesColumn1";
            // 
            // dgvWarehousesColumn2
            // 
            this.dgvWarehousesColumn2.HeaderText = "Tên";
            this.dgvWarehousesColumn2.Name = "dgvWarehousesColumn2";
            // 
            // tsWarehouses
            // 
            this.tsWarehouses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewWarehouse,
            this.btnSaveWarehouse,
            this.btnDeselectWarehouse});
            this.tsWarehouses.Location = new System.Drawing.Point(6, 128);
            this.tsWarehouses.Name = "tsWarehouses";
            this.tsWarehouses.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsWarehouses.Size = new System.Drawing.Size(1104, 25);
            this.tsWarehouses.TabIndex = 1;
            this.tsWarehouses.Text = "toolStrip1";
            // 
            // btnNewWarehouse
            // 
            this.btnNewWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("btnNewWarehouse.Image")));
            this.btnNewWarehouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewWarehouse.Name = "btnNewWarehouse";
            this.btnNewWarehouse.Size = new System.Drawing.Size(70, 22);
            this.btnNewWarehouse.Text = "Tạo mới";
            // 
            // btnSaveWarehouse
            // 
            this.btnSaveWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveWarehouse.Image")));
            this.btnSaveWarehouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveWarehouse.Name = "btnSaveWarehouse";
            this.btnSaveWarehouse.Size = new System.Drawing.Size(47, 22);
            this.btnSaveWarehouse.Text = "Lưu";
            // 
            // btnDeselectWarehouse
            // 
            this.btnDeselectWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselectWarehouse.Image")));
            this.btnDeselectWarehouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeselectWarehouse.Name = "btnDeselectWarehouse";
            this.btnDeselectWarehouse.Size = new System.Drawing.Size(98, 22);
            this.btnDeselectWarehouse.Text = "Hủy lựa chọn";
            // 
            // grpWarehouseInput
            // 
            this.grpWarehouseInput.Controls.Add(this.tblWarehouseInput);
            this.grpWarehouseInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpWarehouseInput.Location = new System.Drawing.Point(6, 6);
            this.grpWarehouseInput.Margin = new System.Windows.Forms.Padding(6);
            this.grpWarehouseInput.Name = "grpWarehouseInput";
            this.grpWarehouseInput.Padding = new System.Windows.Forms.Padding(6);
            this.grpWarehouseInput.Size = new System.Drawing.Size(1104, 122);
            this.grpWarehouseInput.TabIndex = 0;
            this.grpWarehouseInput.TabStop = false;
            this.grpWarehouseInput.Text = "Thông số";
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtWarehouseName.Location = new System.Drawing.Point(114, 49);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(196, 31);
            this.txtWarehouseName.TabIndex = 3;
            // 
            // lblWarehouseName
            // 
            this.lblWarehouseName.AutoSize = true;
            this.lblWarehouseName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWarehouseName.Location = new System.Drawing.Point(55, 49);
            this.lblWarehouseName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblWarehouseName.Name = "lblWarehouseName";
            this.lblWarehouseName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblWarehouseName.Size = new System.Drawing.Size(49, 31);
            this.lblWarehouseName.TabIndex = 2;
            this.lblWarehouseName.Text = "Tên";
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.dgvCustomers);
            this.tabPageCustomers.Controls.Add(this.tsCustomers);
            this.tabPageCustomers.Controls.Add(this.grpCustomerInput);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 34);
            this.tabPageCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageCustomers.Size = new System.Drawing.Size(1116, 564);
            this.tabPageCustomers.TabIndex = 1;
            this.tabPageCustomers.Text = "Khách hàng";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCustomersColumn1,
            this.dgvCustomersColumn2});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 153);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(6);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(1104, 405);
            this.dgvCustomers.TabIndex = 2;
            // 
            // dgvCustomersColumn1
            // 
            this.dgvCustomersColumn1.HeaderText = "STT";
            this.dgvCustomersColumn1.Name = "dgvCustomersColumn1";
            // 
            // dgvCustomersColumn2
            // 
            this.dgvCustomersColumn2.HeaderText = "Tên";
            this.dgvCustomersColumn2.Name = "dgvCustomersColumn2";
            // 
            // tsCustomers
            // 
            this.tsCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCustomer,
            this.btnSaveCustomer,
            this.btnDeselectCustomer});
            this.tsCustomers.Location = new System.Drawing.Point(6, 128);
            this.tsCustomers.Name = "tsCustomers";
            this.tsCustomers.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsCustomers.Size = new System.Drawing.Size(1104, 25);
            this.tsCustomers.TabIndex = 1;
            this.tsCustomers.Text = "toolStrip1";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
            this.btnNewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(70, 22);
            this.btnNewCustomer.Text = "Tạo mới";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCustomer.Image")));
            this.btnSaveCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(47, 22);
            this.btnSaveCustomer.Text = "Lưu";
            // 
            // btnDeselectCustomer
            // 
            this.btnDeselectCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselectCustomer.Image")));
            this.btnDeselectCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeselectCustomer.Name = "btnDeselectCustomer";
            this.btnDeselectCustomer.Size = new System.Drawing.Size(98, 22);
            this.btnDeselectCustomer.Text = "Hủy lựa chọn";
            // 
            // grpCustomerInput
            // 
            this.grpCustomerInput.Controls.Add(this.tblCustomerInput);
            this.grpCustomerInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCustomerInput.Location = new System.Drawing.Point(6, 6);
            this.grpCustomerInput.Margin = new System.Windows.Forms.Padding(6);
            this.grpCustomerInput.Name = "grpCustomerInput";
            this.grpCustomerInput.Padding = new System.Windows.Forms.Padding(6);
            this.grpCustomerInput.Size = new System.Drawing.Size(1104, 122);
            this.grpCustomerInput.TabIndex = 0;
            this.grpCustomerInput.TabStop = false;
            this.grpCustomerInput.Text = "Thông số";
            // 
            // tabPageGoods
            // 
            this.tabPageGoods.Controls.Add(this.dgvGoods);
            this.tabPageGoods.Controls.Add(this.tsGoods);
            this.tabPageGoods.Controls.Add(this.grpGoods);
            this.tabPageGoods.Location = new System.Drawing.Point(4, 34);
            this.tabPageGoods.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageGoods.Name = "tabPageGoods";
            this.tabPageGoods.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageGoods.Size = new System.Drawing.Size(1116, 564);
            this.tabPageGoods.TabIndex = 2;
            this.tabPageGoods.Text = "Hàng hóa";
            this.tabPageGoods.UseVisualStyleBackColor = true;
            // 
            // dgvGoods
            // 
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvGoodsColumn1,
            this.dgvGoodsColumn2});
            this.dgvGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGoods.Location = new System.Drawing.Point(6, 153);
            this.dgvGoods.Margin = new System.Windows.Forms.Padding(6);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.Size = new System.Drawing.Size(1104, 405);
            this.dgvGoods.TabIndex = 2;
            // 
            // dgvGoodsColumn1
            // 
            this.dgvGoodsColumn1.HeaderText = "STT";
            this.dgvGoodsColumn1.Name = "dgvGoodsColumn1";
            // 
            // dgvGoodsColumn2
            // 
            this.dgvGoodsColumn2.HeaderText = "Tên";
            this.dgvGoodsColumn2.Name = "dgvGoodsColumn2";
            // 
            // tsGoods
            // 
            this.tsGoods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewGoods,
            this.btnSaveGoods,
            this.btnDeselectGoods});
            this.tsGoods.Location = new System.Drawing.Point(6, 128);
            this.tsGoods.Name = "tsGoods";
            this.tsGoods.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tsGoods.Size = new System.Drawing.Size(1104, 25);
            this.tsGoods.TabIndex = 1;
            this.tsGoods.Text = "toolStrip1";
            // 
            // btnNewGoods
            // 
            this.btnNewGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGoods.Image")));
            this.btnNewGoods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewGoods.Name = "btnNewGoods";
            this.btnNewGoods.Size = new System.Drawing.Size(70, 22);
            this.btnNewGoods.Text = "Tạo mới";
            // 
            // btnSaveGoods
            // 
            this.btnSaveGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveGoods.Image")));
            this.btnSaveGoods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveGoods.Name = "btnSaveGoods";
            this.btnSaveGoods.Size = new System.Drawing.Size(47, 22);
            this.btnSaveGoods.Text = "Lưu";
            // 
            // btnDeselectGoods
            // 
            this.btnDeselectGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnDeselectGoods.Image")));
            this.btnDeselectGoods.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeselectGoods.Name = "btnDeselectGoods";
            this.btnDeselectGoods.Size = new System.Drawing.Size(98, 22);
            this.btnDeselectGoods.Text = "Hủy lựa chọn";
            // 
            // grpGoods
            // 
            this.grpGoods.Controls.Add(this.tblGoods);
            this.grpGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpGoods.Location = new System.Drawing.Point(6, 6);
            this.grpGoods.Margin = new System.Windows.Forms.Padding(6);
            this.grpGoods.Name = "grpGoods";
            this.grpGoods.Padding = new System.Windows.Forms.Padding(6);
            this.grpGoods.Size = new System.Drawing.Size(1104, 122);
            this.grpGoods.TabIndex = 0;
            this.grpGoods.TabStop = false;
            this.grpGoods.Text = "Thông số";
            // 
            // tblWarehouseInput
            // 
            this.tblWarehouseInput.ColumnCount = 2;
            this.tblWarehouseInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblWarehouseInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblWarehouseInput.Controls.Add(this.txtWarehouseName, 1, 1);
            this.tblWarehouseInput.Controls.Add(this.lblWarehouseName, 0, 1);
            this.tblWarehouseInput.Controls.Add(this.txtWarehouseId, 1, 0);
            this.tblWarehouseInput.Controls.Add(this.lblWarehouseId, 0, 0);
            this.tblWarehouseInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblWarehouseInput.Location = new System.Drawing.Point(6, 30);
            this.tblWarehouseInput.Name = "tblWarehouseInput";
            this.tblWarehouseInput.RowCount = 2;
            this.tblWarehouseInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblWarehouseInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblWarehouseInput.Size = new System.Drawing.Size(1092, 86);
            this.tblWarehouseInput.TabIndex = 0;
            // 
            // txtWarehouseId
            // 
            this.txtWarehouseId.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtWarehouseId.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtWarehouseId.ForeColor = System.Drawing.Color.Lime;
            this.txtWarehouseId.Location = new System.Drawing.Point(114, 6);
            this.txtWarehouseId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtWarehouseId.Name = "txtWarehouseId";
            this.txtWarehouseId.Size = new System.Drawing.Size(196, 31);
            this.txtWarehouseId.TabIndex = 1;
            this.txtWarehouseId.TabStop = false;
            this.txtWarehouseId.Text = "999";
            // 
            // lblWarehouseId
            // 
            this.lblWarehouseId.AutoSize = true;
            this.lblWarehouseId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblWarehouseId.Location = new System.Drawing.Point(52, 6);
            this.lblWarehouseId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblWarehouseId.Name = "lblWarehouseId";
            this.lblWarehouseId.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblWarehouseId.Size = new System.Drawing.Size(52, 31);
            this.lblWarehouseId.TabIndex = 0;
            this.lblWarehouseId.Text = "STT";
            // 
            // tblCustomerInput
            // 
            this.tblCustomerInput.ColumnCount = 2;
            this.tblCustomerInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblCustomerInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblCustomerInput.Controls.Add(this.txtCustomerName, 1, 1);
            this.tblCustomerInput.Controls.Add(this.lblCustomerName, 0, 1);
            this.tblCustomerInput.Controls.Add(this.txtCustomerId, 1, 0);
            this.tblCustomerInput.Controls.Add(this.lblCustomerId, 0, 0);
            this.tblCustomerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCustomerInput.Location = new System.Drawing.Point(6, 30);
            this.tblCustomerInput.Name = "tblCustomerInput";
            this.tblCustomerInput.RowCount = 2;
            this.tblCustomerInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomerInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCustomerInput.Size = new System.Drawing.Size(1092, 86);
            this.tblCustomerInput.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCustomerName.Location = new System.Drawing.Point(114, 49);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(196, 31);
            this.txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCustomerName.Location = new System.Drawing.Point(55, 49);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblCustomerName.Size = new System.Drawing.Size(49, 31);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Tên";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCustomerId.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCustomerId.ForeColor = System.Drawing.Color.Lime;
            this.txtCustomerId.Location = new System.Drawing.Point(114, 6);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(196, 31);
            this.txtCustomerId.TabIndex = 1;
            this.txtCustomerId.TabStop = false;
            this.txtCustomerId.Text = "999";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCustomerId.Location = new System.Drawing.Point(52, 6);
            this.lblCustomerId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblCustomerId.Size = new System.Drawing.Size(52, 31);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "STT";
            // 
            // tblGoods
            // 
            this.tblGoods.ColumnCount = 2;
            this.tblGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblGoods.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblGoods.Controls.Add(this.txtGoodsName, 1, 1);
            this.tblGoods.Controls.Add(this.lblGoodsName, 0, 1);
            this.tblGoods.Controls.Add(this.txtGoodsId, 1, 0);
            this.tblGoods.Controls.Add(this.lblGoodsId, 0, 0);
            this.tblGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblGoods.Location = new System.Drawing.Point(6, 30);
            this.tblGoods.Name = "tblGoods";
            this.tblGoods.RowCount = 2;
            this.tblGoods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGoods.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblGoods.Size = new System.Drawing.Size(1092, 86);
            this.tblGoods.TabIndex = 0;
            // 
            // txtGoodsName
            // 
            this.txtGoodsName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtGoodsName.Location = new System.Drawing.Point(114, 49);
            this.txtGoodsName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGoodsName.Name = "txtGoodsName";
            this.txtGoodsName.Size = new System.Drawing.Size(196, 31);
            this.txtGoodsName.TabIndex = 3;
            // 
            // lblGoodsName
            // 
            this.lblGoodsName.AutoSize = true;
            this.lblGoodsName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGoodsName.Location = new System.Drawing.Point(55, 49);
            this.lblGoodsName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblGoodsName.Name = "lblGoodsName";
            this.lblGoodsName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblGoodsName.Size = new System.Drawing.Size(49, 31);
            this.lblGoodsName.TabIndex = 2;
            this.lblGoodsName.Text = "Tên";
            // 
            // txtGoodsId
            // 
            this.txtGoodsId.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtGoodsId.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtGoodsId.ForeColor = System.Drawing.Color.Lime;
            this.txtGoodsId.Location = new System.Drawing.Point(114, 6);
            this.txtGoodsId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtGoodsId.Name = "txtGoodsId";
            this.txtGoodsId.Size = new System.Drawing.Size(196, 31);
            this.txtGoodsId.TabIndex = 1;
            this.txtGoodsId.TabStop = false;
            this.txtGoodsId.Text = "999";
            // 
            // lblGoodsId
            // 
            this.lblGoodsId.AutoSize = true;
            this.lblGoodsId.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblGoodsId.Location = new System.Drawing.Point(52, 6);
            this.lblGoodsId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lblGoodsId.Name = "lblGoodsId";
            this.lblGoodsId.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.lblGoodsId.Size = new System.Drawing.Size(52, 31);
            this.lblGoodsId.TabIndex = 0;
            this.lblGoodsId.Text = "STT";
            // 
            // DataEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 602);
            this.Controls.Add(this.tabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DataEntryForm";
            this.Text = "Dữ liệu";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageWarehouses.ResumeLayout(false);
            this.tabPageWarehouses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouses)).EndInit();
            this.tsWarehouses.ResumeLayout(false);
            this.tsWarehouses.PerformLayout();
            this.grpWarehouseInput.ResumeLayout(false);
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tsCustomers.ResumeLayout(false);
            this.tsCustomers.PerformLayout();
            this.grpCustomerInput.ResumeLayout(false);
            this.tabPageGoods.ResumeLayout(false);
            this.tabPageGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.tsGoods.ResumeLayout(false);
            this.tsGoods.PerformLayout();
            this.grpGoods.ResumeLayout(false);
            this.tblWarehouseInput.ResumeLayout(false);
            this.tblWarehouseInput.PerformLayout();
            this.tblCustomerInput.ResumeLayout(false);
            this.tblCustomerInput.PerformLayout();
            this.tblGoods.ResumeLayout(false);
            this.tblGoods.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageWarehouses;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageGoods;
        private System.Windows.Forms.DataGridView dgvWarehouses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWarehousesColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvWarehousesColumn2;
        private System.Windows.Forms.GroupBox grpWarehouseInput;
        private System.Windows.Forms.TextBox txtWarehouseName;
        private System.Windows.Forms.Label lblWarehouseName;
        private System.Windows.Forms.ToolStrip tsWarehouses;
        private System.Windows.Forms.ToolStripButton btnNewWarehouse;
        private System.Windows.Forms.ToolStripButton btnSaveWarehouse;
        private System.Windows.Forms.ToolStripButton btnDeselectWarehouse;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomersColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCustomersColumn2;
        private System.Windows.Forms.ToolStrip tsCustomers;
        private System.Windows.Forms.ToolStripButton btnNewCustomer;
        private System.Windows.Forms.ToolStripButton btnSaveCustomer;
        private System.Windows.Forms.ToolStripButton btnDeselectCustomer;
        private System.Windows.Forms.GroupBox grpCustomerInput;
        private System.Windows.Forms.DataGridView dgvGoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGoodsColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGoodsColumn2;
        private System.Windows.Forms.ToolStrip tsGoods;
        private System.Windows.Forms.ToolStripButton btnNewGoods;
        private System.Windows.Forms.ToolStripButton btnSaveGoods;
        private System.Windows.Forms.ToolStripButton btnDeselectGoods;
        private System.Windows.Forms.GroupBox grpGoods;
        private System.Windows.Forms.TableLayoutPanel tblWarehouseInput;
        private System.Windows.Forms.TextBox txtWarehouseId;
        private System.Windows.Forms.Label lblWarehouseId;
        private System.Windows.Forms.TableLayoutPanel tblCustomerInput;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TableLayoutPanel tblGoods;
        private System.Windows.Forms.TextBox txtGoodsName;
        private System.Windows.Forms.Label lblGoodsName;
        private System.Windows.Forms.TextBox txtGoodsId;
        private System.Windows.Forms.Label lblGoodsId;
    }
}