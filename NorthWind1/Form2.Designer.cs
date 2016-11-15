namespace NorthWind1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbRDate = new System.Windows.Forms.Label();
            this.lbSDate = new System.Windows.Forms.Label();
            this.lbODate = new System.Windows.Forms.Label();
            this.dtpODate = new System.Windows.Forms.DateTimePicker();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRDate = new System.Windows.Forms.DateTimePicker();
            this.lbSVia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSVia = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lbSName = new System.Windows.Forms.Label();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.lbSAddress = new System.Windows.Forms.Label();
            this.txtSCity = new System.Windows.Forms.TextBox();
            this.lbSCity = new System.Windows.Forms.Label();
            this.txtSRegion = new System.Windows.Forms.TextBox();
            this.lbSRegion = new System.Windows.Forms.Label();
            this.txtSPostalCode = new System.Windows.Forms.TextBox();
            this.lbSPostalCode = new System.Windows.Forms.Label();
            this.txtSCountry = new System.Windows.Forms.TextBox();
            this.lbSCountry = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requiredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shippedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfo.SuspendLayout();
            this.gbOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRDate
            // 
            this.lbRDate.AutoSize = true;
            this.lbRDate.Location = new System.Drawing.Point(25, 72);
            this.lbRDate.Name = "lbRDate";
            this.lbRDate.Size = new System.Drawing.Size(73, 13);
            this.lbRDate.TabIndex = 0;
            this.lbRDate.Text = "RequiredDate";
            // 
            // lbSDate
            // 
            this.lbSDate.AutoSize = true;
            this.lbSDate.Location = new System.Drawing.Point(25, 113);
            this.lbSDate.Name = "lbSDate";
            this.lbSDate.Size = new System.Drawing.Size(69, 13);
            this.lbSDate.TabIndex = 2;
            this.lbSDate.Text = "ShippedDate";
            // 
            // lbODate
            // 
            this.lbODate.AutoSize = true;
            this.lbODate.Location = new System.Drawing.Point(25, 36);
            this.lbODate.Name = "lbODate";
            this.lbODate.Size = new System.Drawing.Size(56, 13);
            this.lbODate.TabIndex = 4;
            this.lbODate.Text = "OrderDate";
            // 
            // dtpODate
            // 
            this.dtpODate.Location = new System.Drawing.Point(147, 36);
            this.dtpODate.Name = "dtpODate";
            this.dtpODate.Size = new System.Drawing.Size(200, 20);
            this.dtpODate.TabIndex = 5;
            // 
            // dtpSDate
            // 
            this.dtpSDate.Location = new System.Drawing.Point(147, 107);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSDate.TabIndex = 6;
            // 
            // dtpRDate
            // 
            this.dtpRDate.Location = new System.Drawing.Point(147, 72);
            this.dtpRDate.Name = "dtpRDate";
            this.dtpRDate.Size = new System.Drawing.Size(200, 20);
            this.dtpRDate.TabIndex = 7;
            // 
            // lbSVia
            // 
            this.lbSVia.AutoSize = true;
            this.lbSVia.Location = new System.Drawing.Point(28, 153);
            this.lbSVia.Name = "lbSVia";
            this.lbSVia.Size = new System.Drawing.Size(43, 13);
            this.lbSVia.TabIndex = 8;
            this.lbSVia.Text = "ShipVia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Freight";
            // 
            // txtSVia
            // 
            this.txtSVia.Location = new System.Drawing.Point(147, 153);
            this.txtSVia.Name = "txtSVia";
            this.txtSVia.Size = new System.Drawing.Size(149, 20);
            this.txtSVia.TabIndex = 10;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(147, 189);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(149, 20);
            this.txtFreight.TabIndex = 11;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(147, 229);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(149, 20);
            this.txtSName.TabIndex = 13;
            // 
            // lbSName
            // 
            this.lbSName.AutoSize = true;
            this.lbSName.Location = new System.Drawing.Point(31, 232);
            this.lbSName.Name = "lbSName";
            this.lbSName.Size = new System.Drawing.Size(56, 13);
            this.lbSName.TabIndex = 12;
            this.lbSName.Text = "ShipName";
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(577, 40);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(149, 20);
            this.txtSAddress.TabIndex = 15;
            // 
            // lbSAddress
            // 
            this.lbSAddress.AutoSize = true;
            this.lbSAddress.Location = new System.Drawing.Point(461, 43);
            this.lbSAddress.Name = "lbSAddress";
            this.lbSAddress.Size = new System.Drawing.Size(66, 13);
            this.lbSAddress.TabIndex = 14;
            this.lbSAddress.Text = "ShipAddress";
            // 
            // txtSCity
            // 
            this.txtSCity.Location = new System.Drawing.Point(577, 76);
            this.txtSCity.Name = "txtSCity";
            this.txtSCity.Size = new System.Drawing.Size(149, 20);
            this.txtSCity.TabIndex = 17;
            // 
            // lbSCity
            // 
            this.lbSCity.AutoSize = true;
            this.lbSCity.Location = new System.Drawing.Point(461, 79);
            this.lbSCity.Name = "lbSCity";
            this.lbSCity.Size = new System.Drawing.Size(45, 13);
            this.lbSCity.TabIndex = 16;
            this.lbSCity.Text = "ShipCity";
            // 
            // txtSRegion
            // 
            this.txtSRegion.Location = new System.Drawing.Point(577, 111);
            this.txtSRegion.Name = "txtSRegion";
            this.txtSRegion.Size = new System.Drawing.Size(149, 20);
            this.txtSRegion.TabIndex = 19;
            // 
            // lbSRegion
            // 
            this.lbSRegion.AutoSize = true;
            this.lbSRegion.Location = new System.Drawing.Point(461, 114);
            this.lbSRegion.Name = "lbSRegion";
            this.lbSRegion.Size = new System.Drawing.Size(62, 13);
            this.lbSRegion.TabIndex = 18;
            this.lbSRegion.Text = "ShipRegion";
            // 
            // txtSPostalCode
            // 
            this.txtSPostalCode.Location = new System.Drawing.Point(577, 157);
            this.txtSPostalCode.Name = "txtSPostalCode";
            this.txtSPostalCode.Size = new System.Drawing.Size(149, 20);
            this.txtSPostalCode.TabIndex = 21;
            // 
            // lbSPostalCode
            // 
            this.lbSPostalCode.AutoSize = true;
            this.lbSPostalCode.Location = new System.Drawing.Point(461, 160);
            this.lbSPostalCode.Name = "lbSPostalCode";
            this.lbSPostalCode.Size = new System.Drawing.Size(82, 13);
            this.lbSPostalCode.TabIndex = 20;
            this.lbSPostalCode.Text = "ShipPostalCode";
            // 
            // txtSCountry
            // 
            this.txtSCountry.Location = new System.Drawing.Point(577, 193);
            this.txtSCountry.Name = "txtSCountry";
            this.txtSCountry.Size = new System.Drawing.Size(149, 20);
            this.txtSCountry.TabIndex = 23;
            // 
            // lbSCountry
            // 
            this.lbSCountry.AutoSize = true;
            this.lbSCountry.Location = new System.Drawing.Point(461, 196);
            this.lbSCountry.Name = "lbSCountry";
            this.lbSCountry.Size = new System.Drawing.Size(64, 13);
            this.lbSCountry.TabIndex = 22;
            this.lbSCountry.Text = "ShipCountry";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lbODate);
            this.gbInfo.Controls.Add(this.txtSCountry);
            this.gbInfo.Controls.Add(this.lbRDate);
            this.gbInfo.Controls.Add(this.lbSCountry);
            this.gbInfo.Controls.Add(this.lbSDate);
            this.gbInfo.Controls.Add(this.txtSPostalCode);
            this.gbInfo.Controls.Add(this.dtpODate);
            this.gbInfo.Controls.Add(this.lbSPostalCode);
            this.gbInfo.Controls.Add(this.dtpSDate);
            this.gbInfo.Controls.Add(this.txtSRegion);
            this.gbInfo.Controls.Add(this.dtpRDate);
            this.gbInfo.Controls.Add(this.lbSRegion);
            this.gbInfo.Controls.Add(this.lbSVia);
            this.gbInfo.Controls.Add(this.txtSCity);
            this.gbInfo.Controls.Add(this.label1);
            this.gbInfo.Controls.Add(this.lbSCity);
            this.gbInfo.Controls.Add(this.txtSVia);
            this.gbInfo.Controls.Add(this.txtSAddress);
            this.gbInfo.Controls.Add(this.txtFreight);
            this.gbInfo.Controls.Add(this.lbSAddress);
            this.gbInfo.Controls.Add(this.lbSName);
            this.gbInfo.Controls.Add(this.txtSName);
            this.gbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInfo.Location = new System.Drawing.Point(0, 0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(1442, 262);
            this.gbInfo.TabIndex = 24;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Information";
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.btnDelete);
            this.gbOptions.Controls.Add(this.btnUpdate);
            this.gbOptions.Controls.Add(this.btnAdd);
            this.gbOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbOptions.Location = new System.Drawing.Point(0, 262);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(1442, 118);
            this.gbOptions.TabIndex = 25;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(641, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(363, 48);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.requiredDateDataGridViewTextBoxColumn,
            this.shippedDateDataGridViewTextBoxColumn,
            this.shipViaDataGridViewTextBoxColumn,
            this.freightDataGridViewTextBoxColumn,
            this.shipNameDataGridViewTextBoxColumn,
            this.shipAddressDataGridViewTextBoxColumn,
            this.shipCityDataGridViewTextBoxColumn,
            this.shipRegionDataGridViewTextBoxColumn,
            this.shipPostalCodeDataGridViewTextBoxColumn,
            this.shipCountryDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.contactNameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.orderBindingSource;
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 380);
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1442, 268);
            this.dgvOrders.TabIndex = 26;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requiredDateDataGridViewTextBoxColumn
            // 
            this.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate";
            this.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn";
            this.requiredDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shippedDateDataGridViewTextBoxColumn
            // 
            this.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate";
            this.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn";
            this.shippedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipViaDataGridViewTextBoxColumn
            // 
            this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
            this.shipViaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // freightDataGridViewTextBoxColumn
            // 
            this.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight";
            this.freightDataGridViewTextBoxColumn.HeaderText = "Freight";
            this.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn";
            this.freightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipNameDataGridViewTextBoxColumn
            // 
            this.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName";
            this.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn";
            this.shipNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipAddressDataGridViewTextBoxColumn
            // 
            this.shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress";
            this.shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress";
            this.shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn";
            this.shipAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipCityDataGridViewTextBoxColumn
            // 
            this.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity";
            this.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn";
            this.shipCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipRegionDataGridViewTextBoxColumn
            // 
            this.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion";
            this.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn";
            this.shipRegionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipPostalCodeDataGridViewTextBoxColumn
            // 
            this.shipPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipPostalCode";
            this.shipPostalCodeDataGridViewTextBoxColumn.HeaderText = "ShipPostalCode";
            this.shipPostalCodeDataGridViewTextBoxColumn.Name = "shipPostalCodeDataGridViewTextBoxColumn";
            this.shipPostalCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shipCountryDataGridViewTextBoxColumn
            // 
            this.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry";
            this.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn";
            this.shipCountryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "ContactName";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(Entities.Order);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 648);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbInfo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbRDate;
        private System.Windows.Forms.Label lbSDate;
        private System.Windows.Forms.Label lbODate;
        private System.Windows.Forms.DateTimePicker dtpODate;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.DateTimePicker dtpRDate;
        private System.Windows.Forms.Label lbSVia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSVia;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label lbSName;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.Label lbSAddress;
        private System.Windows.Forms.TextBox txtSCity;
        private System.Windows.Forms.Label lbSCity;
        private System.Windows.Forms.TextBox txtSRegion;
        private System.Windows.Forms.Label lbSRegion;
        private System.Windows.Forms.TextBox txtSPostalCode;
        private System.Windows.Forms.Label lbSPostalCode;
        private System.Windows.Forms.TextBox txtSCountry;
        private System.Windows.Forms.Label lbSCountry;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requiredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shippedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipViaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
    }
}