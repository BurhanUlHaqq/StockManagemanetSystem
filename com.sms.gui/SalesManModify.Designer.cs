namespace com.sms.gui
{
    partial class SalesManModify
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new com.sms.gui.AdvanceTextControl();
            this.txtSalesManCode = new com.sms.gui.AdvanceTextControl();
            this.txtZoneCode = new com.sms.gui.AdvanceTextControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combZone = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 511);
            this.panel1.TabIndex = 62;
            // 
            // DataGrid
            // 
            this.DataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(3, 300);
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "z_code";
            gridViewTextBoxColumn5.HeaderText = "Zone Code";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "z_code";
            gridViewTextBoxColumn5.Width = 155;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "zone";
            gridViewTextBoxColumn6.HeaderText = "Zone Name";
            gridViewTextBoxColumn6.Name = "zone";
            gridViewTextBoxColumn6.Width = 321;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "sm_code";
            gridViewTextBoxColumn7.HeaderText = "Sales Man Code";
            gridViewTextBoxColumn7.Name = "sm_code";
            gridViewTextBoxColumn7.Width = 249;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "sm_name";
            gridViewTextBoxColumn8.HeaderText = "Sales Man Name";
            gridViewTextBoxColumn8.Name = "sm_name";
            gridViewTextBoxColumn8.Width = 335;
            this.DataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.DataGrid.MasterTemplate.EnableFiltering = true;
            this.DataGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.ShowGroupPanel = false;
            this.DataGrid.Size = new System.Drawing.Size(941, 203);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "radGridView1";
            this.DataGrid.SelectionChanged += new System.EventHandler(this.MasterTemplate_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(198, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 81);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(355, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 60);
            this.button3.TabIndex = 100;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(165, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 60);
            this.button2.TabIndex = 95;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(3, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 60);
            this.button1.TabIndex = 90;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(668, 624);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(186, 61);
            this.txtMessage.TabIndex = 66;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSalesManCode);
            this.groupBox1.Controls.Add(this.txtZoneCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combZone);
            this.groupBox1.Location = new System.Drawing.Point(198, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 204);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Man Form";
            // 
            // txtName
            // 
            this.txtName.AdvanceText = "";
            this.txtName.InvalidMessage = null;
            this.txtName.IsRequired = false;
            this.txtName.Location = new System.Drawing.Point(186, 113);
            this.txtName.Name = "txtName";
            this.txtName.RequiredChar = '*';
            this.txtName.Size = new System.Drawing.Size(218, 45);
            this.txtName.TabIndex = 71;
            this.txtName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtSalesManCode
            // 
            this.txtSalesManCode.AdvanceText = "0";
            this.txtSalesManCode.Enabled = false;
            this.txtSalesManCode.InvalidMessage = null;
            this.txtSalesManCode.IsRequired = false;
            this.txtSalesManCode.Location = new System.Drawing.Point(281, 62);
            this.txtSalesManCode.Name = "txtSalesManCode";
            this.txtSalesManCode.RequiredChar = '*';
            this.txtSalesManCode.Size = new System.Drawing.Size(88, 45);
            this.txtSalesManCode.TabIndex = 70;
            this.txtSalesManCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtZoneCode
            // 
            this.txtZoneCode.AdvanceText = "0";
            this.txtZoneCode.Enabled = false;
            this.txtZoneCode.InvalidMessage = null;
            this.txtZoneCode.IsRequired = false;
            this.txtZoneCode.Location = new System.Drawing.Point(189, 62);
            this.txtZoneCode.Name = "txtZoneCode";
            this.txtZoneCode.RequiredChar = '*';
            this.txtZoneCode.Size = new System.Drawing.Size(86, 45);
            this.txtZoneCode.TabIndex = 69;
            this.txtZoneCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Sales Man Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Sales Man Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Select Zone";
            // 
            // combZone
            // 
            this.combZone.FormattingEnabled = true;
            this.combZone.Location = new System.Drawing.Point(186, 32);
            this.combZone.Name = "combZone";
            this.combZone.Size = new System.Drawing.Size(246, 24);
            this.combZone.TabIndex = 62;
            this.combZone.SelectedIndexChanged += new System.EventHandler(this.combZone_SelectedIndexChanged);
            // 
            // SalesManModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 868);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "SalesManModify";
            this.Text = "SalesManModify";
            this.Load += new System.EventHandler(this.SalesManModify_Load);
            this.FontChanged += new System.EventHandler(this.SalesManModify_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesManModify_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private AdvanceTextControl txtName;
        private AdvanceTextControl txtSalesManCode;
        private AdvanceTextControl txtZoneCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combZone;
    }
}