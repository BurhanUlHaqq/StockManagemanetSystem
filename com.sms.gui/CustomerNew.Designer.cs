namespace com.sms.gui
{
    partial class CustomerNew
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCusLicense = new com.sms.gui.AdvanceTextControl();
            this.txtCusPH = new com.sms.gui.AdvanceTextControl();
            this.txtCusCity = new com.sms.gui.AdvanceTextControl();
            this.txtCusAddr = new com.sms.gui.AdvanceTextControl();
            this.txtCusName = new com.sms.gui.AdvanceTextControl();
            this.txtCusCusCode = new com.sms.gui.AdvanceTextControl();
            this.txtCusCCode = new com.sms.gui.AdvanceTextControl();
            this.txtCusZCode = new com.sms.gui.AdvanceTextControl();
            this.txtCustomerCity = new com.sms.gui.AdvanceTextControl();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(524, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 69);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnList.Location = new System.Drawing.Point(497, 18);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(156, 48);
            this.btnList.TabIndex = 105;
            this.btnList.Text = "Customer List";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Location = new System.Drawing.Point(333, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 48);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(173, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 48);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(3, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 48);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCusLicense);
            this.groupBox2.Controls.Add(this.txtCusPH);
            this.groupBox2.Controls.Add(this.txtCusCity);
            this.groupBox2.Controls.Add(this.txtCusAddr);
            this.groupBox2.Controls.Add(this.txtCusName);
            this.groupBox2.Controls.Add(this.txtCusCusCode);
            this.groupBox2.Controls.Add(this.txtCusCCode);
            this.groupBox2.Controls.Add(this.txtCusZCode);
            this.groupBox2.Controls.Add(this.txtCustomerCity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.isCusIgnoreExp);
            this.groupBox2.Controls.Add(this.txtCusExpDate);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(524, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 423);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Form";
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.DataGrid);
            this.groupBox3.Controls.Add(this.lblMode);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Location = new System.Drawing.Point(6, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 496);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select City and Zone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "F8: ID and F9 Name Search";
            // 
            // DataGrid
            // 
            this.DataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(3, 107);
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "CityCode";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "CityCode";
            gridViewTextBoxColumn1.Width = 103;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "CityName";
            gridViewTextBoxColumn2.HeaderText = "Name";
            gridViewTextBoxColumn2.Name = "CityName";
            gridViewTextBoxColumn2.Width = 223;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "ZoneName";
            gridViewTextBoxColumn3.HeaderText = "Zone";
            gridViewTextBoxColumn3.Name = "ZoneName";
            gridViewTextBoxColumn3.Width = 126;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ZoneCode";
            gridViewTextBoxColumn4.HeaderText = "ZoneCode";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "ZoneCode";
            this.DataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.DataGrid.MasterTemplate.EnableGrouping = false;
            this.DataGrid.MasterTemplate.EnableSorting = false;
            this.DataGrid.MasterTemplate.ShowColumnHeaders = false;
            this.DataGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.ShowGroupPanel = false;
            this.DataGrid.Size = new System.Drawing.Size(506, 386);
            this.DataGrid.TabIndex = 5;
            this.DataGrid.Text = "radGridView1";
            this.DataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            this.DataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrid_KeyDown);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(6, 48);
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
            this.txtSearch.Location = new System.Drawing.Point(194, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(123, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(1045, 641);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(244, 51);
            this.txtMessage.TabIndex = 109;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(34, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 512);
            this.panel1.TabIndex = 110;
            // 
            // CustomerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.Name = "CustomerNew";
            this.Text = "CustomerNew";
            this.Load += new System.EventHandler(this.CustomerNew_Load);
            this.FontChanged += new System.EventHandler(this.CustomerNew_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerNew_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker txtCusExpDate;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox isCusIgnoreExp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtMessage;
        private AdvanceTextControl txtCustomerCity;
        private AdvanceTextControl txtCusCusCode;
        private AdvanceTextControl txtCusCCode;
        private AdvanceTextControl txtCusZCode;
        private AdvanceTextControl txtCusLicense;
        private AdvanceTextControl txtCusPH;
        private AdvanceTextControl txtCusCity;
        private AdvanceTextControl txtCusAddr;
        private AdvanceTextControl txtCusName;
        private System.Windows.Forms.Panel panel1;
    }
}