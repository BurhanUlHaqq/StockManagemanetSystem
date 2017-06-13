namespace com.sms.gui
{
    partial class ZoneDelete
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.txtMessage = new System.Windows.Forms.Label();
            this.txtZName = new com.sms.gui.AdvanceTextControl();
            this.txtZCode = new com.sms.gui.AdvanceTextControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtZName);
            this.groupBox1.Controls.Add(this.txtZCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 146);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Form";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnCancel);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Location = new System.Drawing.Point(41, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 78);
            this.groupBox2.TabIndex = 60;
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
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Location = new System.Drawing.Point(3, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 327);
            this.panel1.TabIndex = 61;
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
            this.DataGrid.Size = new System.Drawing.Size(1107, 327);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "radGridView1";
            this.DataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(782, 111);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(321, 40);
            this.txtMessage.TabIndex = 63;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // txtZName
            // 
            this.txtZName.AdvanceText = "";
            this.txtZName.InvalidMessage = null;
            this.txtZName.IsRequired = false;
            this.txtZName.Location = new System.Drawing.Point(174, 76);
            this.txtZName.Name = "txtZName";
            this.txtZName.RequiredChar = '*';
            this.txtZName.Size = new System.Drawing.Size(218, 45);
            this.txtZName.TabIndex = 64;
            this.txtZName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtZCode
            // 
            this.txtZCode.AdvanceText = "0";
            this.txtZCode.Enabled = false;
            this.txtZCode.InvalidMessage = null;
            this.txtZCode.IsRequired = false;
            this.txtZCode.Location = new System.Drawing.Point(174, 15);
            this.txtZCode.Name = "txtZCode";
            this.txtZCode.RequiredChar = '*';
            this.txtZCode.Size = new System.Drawing.Size(218, 45);
            this.txtZCode.TabIndex = 63;
            this.txtZCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Zone Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Zone Code";
            // 
            // ZoneDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 599);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneDelete";
            this.Text = "ZoneDelete";
            this.Load += new System.EventHandler(this.ZoneDelete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.Label txtMessage;
        private AdvanceTextControl txtZName;
        private AdvanceTextControl txtZCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}