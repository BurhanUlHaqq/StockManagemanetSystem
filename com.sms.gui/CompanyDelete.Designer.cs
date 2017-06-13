namespace com.sms.gui
{
    partial class CompanyDelete
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCEmail = new Telerik.WinControls.UI.RadTextBox();
            this.txtCCity = new Telerik.WinControls.UI.RadTextBox();
            this.txtCFaxNo = new Telerik.WinControls.UI.RadTextBox();
            this.txtCPHNo = new Telerik.WinControls.UI.RadTextBox();
            this.txtCName = new Telerik.WinControls.UI.RadTextBox();
            this.txtCAddress = new Telerik.WinControls.UI.RadTextBox();
            this.txtCCode = new Telerik.WinControls.UI.RadTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCFaxNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPHNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCode)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Location = new System.Drawing.Point(3, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 270);
            this.panel1.TabIndex = 67;
            // 
            // DataGrid
            // 
            this.DataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Code";
            gridViewTextBoxColumn1.HeaderText = "Zone Code";
            gridViewTextBoxColumn1.Name = "Code";
            gridViewTextBoxColumn1.Width = 155;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Zone Name";
            gridViewTextBoxColumn2.HeaderText = "Zone Name";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 321;
            this.DataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.DataGrid.MasterTemplate.EnableFiltering = true;
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.ShowGroupPanel = false;
            this.DataGrid.Size = new System.Drawing.Size(1055, 270);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "radGridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnCancel);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Location = new System.Drawing.Point(41, 439);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 78);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnExit.Location = new System.Drawing.Point(392, 18);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(201, 57);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCancel.Location = new System.Drawing.Point(191, 18);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(201, 57);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDel.Location = new System.Drawing.Point(3, 18);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(188, 57);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCEmail);
            this.groupBox1.Controls.Add(this.txtCCity);
            this.groupBox1.Controls.Add(this.txtCFaxNo);
            this.groupBox1.Controls.Add(this.txtCPHNo);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.txtCAddress);
            this.groupBox1.Controls.Add(this.txtCCode);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 403);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Form";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(366, 41);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(166, 22);
            this.DatePicker.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "Fax No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Company Code";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(131, 362);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(287, 24);
            this.txtCEmail.TabIndex = 77;
            // 
            // txtCCity
            // 
            this.txtCCity.Location = new System.Drawing.Point(131, 194);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(253, 24);
            this.txtCCity.TabIndex = 74;
            // 
            // txtCFaxNo
            // 
            this.txtCFaxNo.Location = new System.Drawing.Point(131, 303);
            this.txtCFaxNo.Name = "txtCFaxNo";
            this.txtCFaxNo.Size = new System.Drawing.Size(125, 24);
            this.txtCFaxNo.TabIndex = 76;
            // 
            // txtCPHNo
            // 
            this.txtCPHNo.Location = new System.Drawing.Point(131, 245);
            this.txtCPHNo.Name = "txtCPHNo";
            this.txtCPHNo.Size = new System.Drawing.Size(125, 24);
            this.txtCPHNo.TabIndex = 75;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(131, 94);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(316, 24);
            this.txtCName.TabIndex = 67;
            // 
            // txtCAddress
            // 
            this.txtCAddress.Location = new System.Drawing.Point(131, 139);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.Size = new System.Drawing.Size(401, 24);
            this.txtCAddress.TabIndex = 73;
            // 
            // txtCCode
            // 
            this.txtCCode.Enabled = false;
            this.txtCCode.Location = new System.Drawing.Point(131, 41);
            this.txtCCode.Name = "txtCCode";
            this.txtCCode.Size = new System.Drawing.Size(125, 24);
            this.txtCCode.TabIndex = 62;
            // 
            // CompanyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 793);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "CompanyDelete";
            this.Text = "CompanyDelete";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCFaxNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCPHNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadTextBox txtCEmail;
        private Telerik.WinControls.UI.RadTextBox txtCCity;
        private Telerik.WinControls.UI.RadTextBox txtCFaxNo;
        private Telerik.WinControls.UI.RadTextBox txtCPHNo;
        private Telerik.WinControls.UI.RadTextBox txtCName;
        private Telerik.WinControls.UI.RadTextBox txtCAddress;
        private Telerik.WinControls.UI.RadTextBox txtCCode;
    }
}