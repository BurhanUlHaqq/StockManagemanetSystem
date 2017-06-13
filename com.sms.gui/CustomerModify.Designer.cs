namespace com.sms.gui
{
    partial class CustomerModify
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CityDataGrid = new Telerik.WinControls.UI.RadGridView();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isCusIgnoreExp = new System.Windows.Forms.CheckBox();
            this.txtCusExpDate = new System.Windows.Forms.DateTimePicker();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCusLicense = new com.sms.gui.AdvanceTextControl();
            this.txtCusPH = new com.sms.gui.AdvanceTextControl();
            this.txtCusCity = new com.sms.gui.AdvanceTextControl();
            this.txtCusAddr = new com.sms.gui.AdvanceTextControl();
            this.txtCusName = new com.sms.gui.AdvanceTextControl();
            this.txtCusCusCode = new com.sms.gui.AdvanceTextControl();
            this.txtCusCCode = new com.sms.gui.AdvanceTextControl();
            this.txtCusZCode = new com.sms.gui.AdvanceTextControl();
            this.txtCustomerCity = new com.sms.gui.AdvanceTextControl();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityDataGrid.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(3, 455);
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "cust_code";
            gridViewTextBoxColumn1.HeaderText = "Customer ID";
            gridViewTextBoxColumn1.Name = "cust_code";
            gridViewTextBoxColumn1.Width = 135;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "cus_name";
            gridViewTextBoxColumn2.HeaderText = "Customer Name";
            gridViewTextBoxColumn2.Name = "cus_name";
            gridViewTextBoxColumn2.Width = 239;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "z_code";
            gridViewTextBoxColumn3.HeaderText = "Zone ID";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.Name = "z_code";
            gridViewTextBoxColumn3.Width = 133;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "zone";
            gridViewTextBoxColumn4.HeaderText = "Zone";
            gridViewTextBoxColumn4.Name = "zone";
            gridViewTextBoxColumn4.Width = 176;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "city_code";
            gridViewTextBoxColumn5.HeaderText = "City ID";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "city_code";
            gridViewTextBoxColumn5.Width = 129;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "city";
            gridViewTextBoxColumn6.HeaderText = "City Name";
            gridViewTextBoxColumn6.Name = "city";
            gridViewTextBoxColumn6.Width = 202;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "addr";
            gridViewTextBoxColumn7.HeaderText = "Address";
            gridViewTextBoxColumn7.Name = "addr";
            gridViewTextBoxColumn7.Width = 238;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "ph";
            gridViewTextBoxColumn8.HeaderText = "Phone#";
            gridViewTextBoxColumn8.Name = "ph";
            gridViewTextBoxColumn8.Width = 149;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "licence";
            gridViewTextBoxColumn9.HeaderText = "Licence";
            gridViewTextBoxColumn9.Name = "licence";
            gridViewTextBoxColumn9.Width = 184;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "cust_date";
            gridViewTextBoxColumn10.HeaderText = "Added Date";
            gridViewTextBoxColumn10.Name = "cust_date";
            gridViewTextBoxColumn10.Width = 183;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "lic_exp_date";
            gridViewTextBoxColumn11.HeaderText = "Licence Exp Date";
            gridViewTextBoxColumn11.Name = "lic_exp_date";
            gridViewTextBoxColumn11.Width = 214;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "chk_exp_date";
            gridViewCheckBoxColumn1.HeaderText = "Ignore Expiry?";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "chk_exp_date";
            gridViewCheckBoxColumn1.Width = 174;
            this.DataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewCheckBoxColumn1});
            this.DataGrid.MasterTemplate.EnableFiltering = true;
            this.DataGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.ShowGroupPanel = false;
            this.DataGrid.Size = new System.Drawing.Size(1098, 229);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "radGridView1";
            this.DataGrid.SelectionChanged += new System.EventHandler(this.MasterTemplate_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(1107, 455);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 161);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 108);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 45);
            this.button3.TabIndex = 100;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 45);
            this.button2.TabIndex = 95;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 45);
            this.button1.TabIndex = 90;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CityDataGrid);
            this.groupBox3.Controls.Add(this.lblMode);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(511, 441);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select City and Zone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "F8: ID and F9 Name Search";
            // 
            // CityDataGrid
            // 
            this.CityDataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.CityDataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.CityDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CityDataGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CityDataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CityDataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CityDataGrid.Location = new System.Drawing.Point(3, 88);
            // 
            // 
            // 
            this.CityDataGrid.MasterTemplate.AllowAddNewRow = false;
            this.CityDataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "CityCode";
            gridViewTextBoxColumn12.HeaderText = "ID";
            gridViewTextBoxColumn12.Name = "CityCode";
            gridViewTextBoxColumn12.Width = 103;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "CityName";
            gridViewTextBoxColumn13.HeaderText = "Name";
            gridViewTextBoxColumn13.Name = "CityName";
            gridViewTextBoxColumn13.Width = 223;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "ZoneName";
            gridViewTextBoxColumn14.HeaderText = "Zone";
            gridViewTextBoxColumn14.Name = "ZoneName";
            gridViewTextBoxColumn14.Width = 126;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "ZoneCode";
            gridViewTextBoxColumn15.HeaderText = "ZoneCode";
            gridViewTextBoxColumn15.IsVisible = false;
            gridViewTextBoxColumn15.Name = "ZoneCode";
            this.CityDataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15});
            this.CityDataGrid.MasterTemplate.EnableGrouping = false;
            this.CityDataGrid.MasterTemplate.EnableSorting = false;
            this.CityDataGrid.MasterTemplate.ShowColumnHeaders = false;
            this.CityDataGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.CityDataGrid.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.CityDataGrid.Name = "CityDataGrid";
            this.CityDataGrid.ReadOnly = true;
            this.CityDataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CityDataGrid.ShowGroupPanel = false;
            this.CityDataGrid.Size = new System.Drawing.Size(505, 350);
            this.CityDataGrid.TabIndex = 5;
            this.CityDataGrid.Text = "radGridView1";
            this.CityDataGrid.SelectionChanged += new System.EventHandler(this.CityDataGrid_SelectionChanged);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(6, 60);
            this.lblMode.Name = "lblMode";
            this.lblMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMode.Size = new System.Drawing.Size(73, 17);
            this.lblMode.TabIndex = 11;
            this.lblMode.Text = "Search By";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.Location = new System.Drawing.Point(194, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCusLicense);
            this.groupBox1.Controls.Add(this.txtCusPH);
            this.groupBox1.Controls.Add(this.txtCusCity);
            this.groupBox1.Controls.Add(this.txtCusAddr);
            this.groupBox1.Controls.Add(this.txtCusName);
            this.groupBox1.Controls.Add(this.txtCusCusCode);
            this.groupBox1.Controls.Add(this.txtCusCCode);
            this.groupBox1.Controls.Add(this.txtCusZCode);
            this.groupBox1.Controls.Add(this.txtCustomerCity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.isCusIgnoreExp);
            this.groupBox1.Controls.Add(this.txtCusExpDate);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(525, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 441);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Form";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 17);
            this.label9.TabIndex = 101;
            this.label9.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 106;
            this.label3.Text = "Customer Code";
            // 
            // isCusIgnoreExp
            // 
            this.isCusIgnoreExp.AutoSize = true;
            this.isCusIgnoreExp.Location = new System.Drawing.Point(435, 390);
            this.isCusIgnoreExp.Name = "isCusIgnoreExp";
            this.isCusIgnoreExp.Size = new System.Drawing.Size(176, 21);
            this.isCusIgnoreExp.TabIndex = 65;
            this.isCusIgnoreExp.Text = "Ignore Customer Expiry";
            this.isCusIgnoreExp.UseVisualStyleBackColor = true;
            // 
            // txtCusExpDate
            // 
            this.txtCusExpDate.CustomFormat = "yyyy-MM-dd";
            this.txtCusExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtCusExpDate.Location = new System.Drawing.Point(187, 390);
            this.txtCusExpDate.Name = "txtCusExpDate";
            this.txtCusExpDate.Size = new System.Drawing.Size(214, 22);
            this.txtCusExpDate.TabIndex = 60;
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(497, 39);
            this.DatePicker.MinDate = new System.DateTime(2017, 5, 4, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(228, 22);
            this.DatePicker.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(413, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 105;
            this.label10.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 102;
            this.label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "License#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "License Exp Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Customer City";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(1490, 170);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(215, 65);
            this.txtMessage.TabIndex = 70;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 691);
            this.panel1.TabIndex = 1;
            // 
            // txtCusLicense
            // 
            this.txtCusLicense.AdvanceText = "";
            this.txtCusLicense.InvalidMessage = null;
            this.txtCusLicense.IsRequired = false;
            this.txtCusLicense.Location = new System.Drawing.Point(185, 322);
            this.txtCusLicense.Name = "txtCusLicense";
            this.txtCusLicense.RequiredChar = '*';
            this.txtCusLicense.Size = new System.Drawing.Size(218, 45);
            this.txtCusLicense.TabIndex = 114;
            this.txtCusLicense.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCusPH
            // 
            this.txtCusPH.AdvanceText = "";
            this.txtCusPH.InvalidMessage = null;
            this.txtCusPH.IsRequired = false;
            this.txtCusPH.Location = new System.Drawing.Point(187, 271);
            this.txtCusPH.Name = "txtCusPH";
            this.txtCusPH.RequiredChar = '*';
            this.txtCusPH.Size = new System.Drawing.Size(218, 45);
            this.txtCusPH.TabIndex = 113;
            this.txtCusPH.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCusCity
            // 
            this.txtCusCity.AdvanceText = "";
            this.txtCusCity.InvalidMessage = null;
            this.txtCusCity.IsRequired = false;
            this.txtCusCity.Location = new System.Drawing.Point(187, 220);
            this.txtCusCity.Name = "txtCusCity";
            this.txtCusCity.RequiredChar = '*';
            this.txtCusCity.Size = new System.Drawing.Size(218, 45);
            this.txtCusCity.TabIndex = 112;
            this.txtCusCity.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCusAddr
            // 
            this.txtCusAddr.AdvanceText = "";
            this.txtCusAddr.InvalidMessage = null;
            this.txtCusAddr.IsRequired = false;
            this.txtCusAddr.Location = new System.Drawing.Point(187, 169);
            this.txtCusAddr.Name = "txtCusAddr";
            this.txtCusAddr.RequiredChar = '*';
            this.txtCusAddr.Size = new System.Drawing.Size(503, 45);
            this.txtCusAddr.TabIndex = 111;
            this.txtCusAddr.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCusName
            // 
            this.txtCusName.AdvanceText = "";
            this.txtCusName.InvalidMessage = null;
            this.txtCusName.IsRequired = false;
            this.txtCusName.Location = new System.Drawing.Point(187, 118);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.RequiredChar = '*';
            this.txtCusName.Size = new System.Drawing.Size(218, 45);
            this.txtCusName.TabIndex = 110;
            this.txtCusName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCusCusCode
            // 
            this.txtCusCusCode.AdvanceText = "0";
            this.txtCusCusCode.Enabled = false;
            this.txtCusCusCode.InvalidMessage = null;
            this.txtCusCusCode.IsRequired = false;
            this.txtCusCusCode.Location = new System.Drawing.Point(365, 67);
            this.txtCusCusCode.Name = "txtCusCusCode";
            this.txtCusCusCode.RequiredChar = '*';
            this.txtCusCusCode.Size = new System.Drawing.Size(83, 45);
            this.txtCusCusCode.TabIndex = 109;
            this.txtCusCusCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtCusCCode
            // 
            this.txtCusCCode.AdvanceText = "0";
            this.txtCusCCode.Enabled = false;
            this.txtCusCCode.InvalidMessage = null;
            this.txtCusCCode.IsRequired = false;
            this.txtCusCCode.Location = new System.Drawing.Point(276, 67);
            this.txtCusCCode.Name = "txtCusCCode";
            this.txtCusCCode.RequiredChar = '*';
            this.txtCusCCode.Size = new System.Drawing.Size(83, 45);
            this.txtCusCCode.TabIndex = 108;
            this.txtCusCCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtCusZCode
            // 
            this.txtCusZCode.AdvanceText = "0";
            this.txtCusZCode.Enabled = false;
            this.txtCusZCode.InvalidMessage = null;
            this.txtCusZCode.IsRequired = false;
            this.txtCusZCode.Location = new System.Drawing.Point(187, 67);
            this.txtCusZCode.Name = "txtCusZCode";
            this.txtCusZCode.RequiredChar = '*';
            this.txtCusZCode.Size = new System.Drawing.Size(83, 45);
            this.txtCusZCode.TabIndex = 107;
            this.txtCusZCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.AdvanceText = "";
            this.txtCustomerCity.Enabled = false;
            this.txtCustomerCity.InvalidMessage = null;
            this.txtCustomerCity.IsRequired = false;
            this.txtCustomerCity.Location = new System.Drawing.Point(185, 16);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.RequiredChar = '*';
            this.txtCustomerCity.Size = new System.Drawing.Size(218, 45);
            this.txtCustomerCity.TabIndex = 57;
            this.txtCustomerCity.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // CustomerModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1769, 771);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.Name = "CustomerModify";
            this.Text = "CustomerModify";
            this.Load += new System.EventHandler(this.CustomerModify_Load);
            this.FontChanged += new System.EventHandler(this.CustomerModify_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerModify_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CityDataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView CityDataGrid;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private AdvanceTextControl txtCusLicense;
        private AdvanceTextControl txtCusPH;
        private AdvanceTextControl txtCusCity;
        private AdvanceTextControl txtCusAddr;
        private AdvanceTextControl txtCusName;
        private AdvanceTextControl txtCusCusCode;
        private AdvanceTextControl txtCusCCode;
        private AdvanceTextControl txtCusZCode;
        private AdvanceTextControl txtCustomerCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox isCusIgnoreExp;
        private System.Windows.Forms.DateTimePicker txtCusExpDate;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Panel panel1;
    }
}