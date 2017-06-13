namespace com.sms.gui
{
    partial class CompanyModify
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.txtMessage = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCEmail = new com.sms.gui.AdvanceTextControl();
            this.txtCFaxNo = new com.sms.gui.AdvanceTextControl();
            this.txtCPHNo = new com.sms.gui.AdvanceTextControl();
            this.txtCCity = new com.sms.gui.AdvanceTextControl();
            this.txtCAddress = new com.sms.gui.AdvanceTextControl();
            this.txtCName = new com.sms.gui.AdvanceTextControl();
            this.txtCCode = new com.sms.gui.AdvanceTextControl();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(784, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 204);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(3, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 60);
            this.button3.TabIndex = 100;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(3, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 60);
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
            this.button1.Size = new System.Drawing.Size(175, 60);
            this.button1.TabIndex = 90;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AutoScroll = true;
            this.DataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(3, 370);
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "C_CODE";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.Name = "C_CODE";
            gridViewTextBoxColumn1.Width = 72;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "C_NAME";
            gridViewTextBoxColumn2.HeaderText = "Company Name";
            gridViewTextBoxColumn2.Name = "C_NAME";
            gridViewTextBoxColumn2.Width = 299;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "C_DATE";
            gridViewTextBoxColumn3.HeaderText = "Date";
            gridViewTextBoxColumn3.Name = "C_DATE";
            gridViewTextBoxColumn3.Width = 325;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "ADDR";
            gridViewTextBoxColumn4.HeaderText = "Address";
            gridViewTextBoxColumn4.Name = "ADDR";
            gridViewTextBoxColumn4.Width = 435;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "CITY";
            gridViewTextBoxColumn5.HeaderText = "City";
            gridViewTextBoxColumn5.Name = "CITY";
            gridViewTextBoxColumn5.Width = 273;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "PH";
            gridViewTextBoxColumn6.HeaderText = "Phone No";
            gridViewTextBoxColumn6.Name = "PH";
            gridViewTextBoxColumn6.Width = 230;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "FAX";
            gridViewTextBoxColumn7.HeaderText = "FAX";
            gridViewTextBoxColumn7.Name = "FAX";
            gridViewTextBoxColumn7.Width = 247;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "E_MAIL";
            gridViewTextBoxColumn8.HeaderText = "Email";
            gridViewTextBoxColumn8.Name = "E_MAIL";
            gridViewTextBoxColumn8.Width = 278;
            this.DataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.DataGrid.MasterTemplate.EnableFiltering = true;
            this.DataGrid.MasterTemplate.ShowRowHeaderColumn = false;
            sortDescriptor1.PropertyName = "column1";
            this.DataGrid.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.ShowGroupPanel = false;
            this.DataGrid.Size = new System.Drawing.Size(1078, 277);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.Text = "radGridView1";
            this.DataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(1097, 9);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(267, 39);
            this.txtMessage.TabIndex = 109;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCEmail);
            this.groupBox1.Controls.Add(this.txtCFaxNo);
            this.groupBox1.Controls.Add(this.txtCPHNo);
            this.groupBox1.Controls.Add(this.txtCCity);
            this.groupBox1.Controls.Add(this.txtCAddress);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.txtCCode);
            this.groupBox1.Controls.Add(this.DatePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(152, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 359);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company Form";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(395, 40);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(214, 22);
            this.DatePicker.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 84;
            this.label7.Text = "Fax No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "Phone No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 82;
            this.label5.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 81;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 79;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 78;
            this.label1.Text = "Company Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 658);
            this.panel1.TabIndex = 110;
            // 
            // txtCEmail
            // 
            this.txtCEmail.AdvanceText = "";
            this.txtCEmail.InvalidMessage = "Invalid Email";
            this.txtCEmail.IsRequired = false;
            this.txtCEmail.Location = new System.Drawing.Point(156, 276);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.RequiredChar = '*';
            this.txtCEmail.Size = new System.Drawing.Size(218, 45);
            this.txtCEmail.TabIndex = 93;
            this.txtCEmail.Type = com.sms.gui.AdvanceTextControl.TextType.EMAIL;
            // 
            // txtCFaxNo
            // 
            this.txtCFaxNo.AdvanceText = "";
            this.txtCFaxNo.InvalidMessage = null;
            this.txtCFaxNo.IsRequired = false;
            this.txtCFaxNo.Location = new System.Drawing.Point(429, 223);
            this.txtCFaxNo.Name = "txtCFaxNo";
            this.txtCFaxNo.RequiredChar = '*';
            this.txtCFaxNo.Size = new System.Drawing.Size(180, 45);
            this.txtCFaxNo.TabIndex = 92;
            this.txtCFaxNo.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCPHNo
            // 
            this.txtCPHNo.AdvanceText = "";
            this.txtCPHNo.InvalidMessage = null;
            this.txtCPHNo.IsRequired = false;
            this.txtCPHNo.Location = new System.Drawing.Point(156, 225);
            this.txtCPHNo.Name = "txtCPHNo";
            this.txtCPHNo.RequiredChar = '*';
            this.txtCPHNo.Size = new System.Drawing.Size(166, 45);
            this.txtCPHNo.TabIndex = 91;
            this.txtCPHNo.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCCity
            // 
            this.txtCCity.AdvanceText = "";
            this.txtCCity.InvalidMessage = null;
            this.txtCCity.IsRequired = false;
            this.txtCCity.Location = new System.Drawing.Point(156, 174);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.RequiredChar = '*';
            this.txtCCity.Size = new System.Drawing.Size(202, 45);
            this.txtCCity.TabIndex = 90;
            this.txtCCity.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCAddress
            // 
            this.txtCAddress.AdvanceText = "";
            this.txtCAddress.InvalidMessage = null;
            this.txtCAddress.IsRequired = false;
            this.txtCAddress.Location = new System.Drawing.Point(156, 123);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.RequiredChar = '*';
            this.txtCAddress.Size = new System.Drawing.Size(453, 45);
            this.txtCAddress.TabIndex = 89;
            this.txtCAddress.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCName
            // 
            this.txtCName.AdvanceText = "";
            this.txtCName.InvalidMessage = null;
            this.txtCName.IsRequired = false;
            this.txtCName.Location = new System.Drawing.Point(156, 72);
            this.txtCName.Name = "txtCName";
            this.txtCName.RequiredChar = '*';
            this.txtCName.Size = new System.Drawing.Size(241, 45);
            this.txtCName.TabIndex = 88;
            this.txtCName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCCode
            // 
            this.txtCCode.AdvanceText = "0";
            this.txtCCode.Enabled = false;
            this.txtCCode.InvalidMessage = null;
            this.txtCCode.IsRequired = false;
            this.txtCCode.Location = new System.Drawing.Point(156, 21);
            this.txtCCode.Name = "txtCCode";
            this.txtCCode.RequiredChar = '*';
            this.txtCCode.Size = new System.Drawing.Size(166, 45);
            this.txtCCode.TabIndex = 87;
            this.txtCCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // CompanyModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.Name = "CompanyModify";
            this.Text = "CompanyModify";
            this.Load += new System.EventHandler(this.CompanyModify_Load);
            this.FontChanged += new System.EventHandler(this.CompanyModify_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompanyModify_KeyDown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private AdvanceTextControl txtCEmail;
        private AdvanceTextControl txtCFaxNo;
        private AdvanceTextControl txtCPHNo;
        private AdvanceTextControl txtCCity;
        private AdvanceTextControl txtCAddress;
        private AdvanceTextControl txtCName;
        private AdvanceTextControl txtCCode;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}