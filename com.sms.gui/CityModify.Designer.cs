namespace com.sms.gui
{
    partial class CityModify
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combZoneName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.txtCCode2 = new com.sms.gui.AdvanceTextControl();
            this.txtCName = new com.sms.gui.AdvanceTextControl();
            this.txtCCode1 = new com.sms.gui.AdvanceTextControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(63, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 584);
            this.panel1.TabIndex = 62;
            // 
            // DataGrid
            // 
            this.DataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(7, 292);
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "ZoneCode";
            gridViewTextBoxColumn1.HeaderText = "Zone Code";
            gridViewTextBoxColumn1.Name = "Code";
            gridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending;
            gridViewTextBoxColumn1.Width = 155;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "ZoneName";
            gridViewTextBoxColumn2.HeaderText = "Zone Name";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 321;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "CityCode";
            gridViewTextBoxColumn3.HeaderText = "City Code";
            gridViewTextBoxColumn3.Name = "column1";
            gridViewTextBoxColumn3.Width = 180;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "CityName";
            gridViewTextBoxColumn4.HeaderText = "City Name";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 274;
            this.DataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.DataGrid.MasterTemplate.EnableFiltering = true;
            sortDescriptor1.PropertyName = "Code";
            this.DataGrid.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.ShowGroupPanel = false;
            this.DataGrid.Size = new System.Drawing.Size(958, 234);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.Text = "radGridView1";
            this.DataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(198, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(593, 81);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(378, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 60);
            this.button3.TabIndex = 100;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(182, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 60);
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
            this.button1.Size = new System.Drawing.Size(179, 60);
            this.button1.TabIndex = 90;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCCode2);
            this.groupBox1.Controls.Add(this.txtCName);
            this.groupBox1.Controls.Add(this.txtCCode1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combZoneName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(198, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 193);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "City Code";
            // 
            // combZoneName
            // 
            this.combZoneName.FormattingEnabled = true;
            this.combZoneName.Location = new System.Drawing.Point(203, 37);
            this.combZoneName.Name = "combZoneName";
            this.combZoneName.Size = new System.Drawing.Size(189, 24);
            this.combZoneName.TabIndex = 5;
            this.combZoneName.SelectedIndexChanged += new System.EventHandler(this.combZoneName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone Name";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(356, 640);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(536, 40);
            this.txtMessage.TabIndex = 65;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // txtCCode2
            // 
            this.txtCCode2.AdvanceText = "0";
            this.txtCCode2.Enabled = false;
            this.txtCCode2.InvalidMessage = null;
            this.txtCCode2.IsRequired = false;
            this.txtCCode2.Location = new System.Drawing.Point(299, 67);
            this.txtCCode2.Name = "txtCCode2";
            this.txtCCode2.RequiredChar = '*';
            this.txtCCode2.Size = new System.Drawing.Size(79, 45);
            this.txtCCode2.TabIndex = 66;
            this.txtCCode2.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtCName
            // 
            this.txtCName.AdvanceText = "";
            this.txtCName.InvalidMessage = null;
            this.txtCName.IsRequired = false;
            this.txtCName.Location = new System.Drawing.Point(205, 129);
            this.txtCName.Name = "txtCName";
            this.txtCName.RequiredChar = '*';
            this.txtCName.Size = new System.Drawing.Size(218, 45);
            this.txtCName.TabIndex = 65;
            this.txtCName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCCode1
            // 
            this.txtCCode1.AdvanceText = "0";
            this.txtCCode1.Enabled = false;
            this.txtCCode1.InvalidMessage = null;
            this.txtCCode1.IsRequired = false;
            this.txtCCode1.Location = new System.Drawing.Point(205, 68);
            this.txtCCode1.Name = "txtCCode1";
            this.txtCCode1.RequiredChar = '*';
            this.txtCCode1.Size = new System.Drawing.Size(79, 45);
            this.txtCCode1.TabIndex = 64;
            this.txtCCode1.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // CityModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 841);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "CityModify";
            this.Text = "CityModify";
            this.Load += new System.EventHandler(this.CityModify_Load);
            this.FontChanged += new System.EventHandler(this.CityModify_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CityModify_KeyDown);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combZoneName;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.Label txtMessage;
        private AdvanceTextControl txtCCode2;
        private AdvanceTextControl txtCName;
        private AdvanceTextControl txtCCode1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}