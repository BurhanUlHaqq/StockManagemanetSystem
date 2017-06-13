namespace com.sms.gui
{
    partial class ProductDelete
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
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPBouns = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combSTMode = new System.Windows.Forms.ComboBox();
            this.combDisMode = new System.Windows.Forms.ComboBox();
            this.txtPSalesTax = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox10 = new Telerik.WinControls.UI.RadTextBox();
            this.txtPRetailPrice = new Telerik.WinControls.UI.RadTextBox();
            this.txtPDiscount = new Telerik.WinControls.UI.RadTextBox();
            this.txtPTradePrice = new Telerik.WinControls.UI.RadTextBox();
            this.combGroup = new System.Windows.Forms.ComboBox();
            this.combMedType = new System.Windows.Forms.ComboBox();
            this.txtPCode2 = new Telerik.WinControls.UI.RadTextBox();
            this.txtPPack = new Telerik.WinControls.UI.RadTextBox();
            this.txtPDiscription = new Telerik.WinControls.UI.RadTextBox();
            this.txtPCode1 = new Telerik.WinControls.UI.RadTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSalesTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTradePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDiscription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DataGrid);
            this.panel1.Location = new System.Drawing.Point(3, 546);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 205);
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
            this.DataGrid.Size = new System.Drawing.Size(1096, 205);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "radGridView1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExit);
            this.groupBox2.Controls.Add(this.BtnCancel);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Location = new System.Drawing.Point(41, 462);
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
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.combGroup);
            this.groupBox1.Controls.Add(this.combMedType);
            this.groupBox1.Controls.Add(this.txtPCode2);
            this.groupBox1.Controls.Add(this.txtPPack);
            this.groupBox1.Controls.Add(this.txtPDiscription);
            this.groupBox1.Controls.Add(this.txtPCode1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(41, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 426);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Form";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(381, 36);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(166, 22);
            this.DatePicker.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(337, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 77;
            this.label13.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Pack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Medicine Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Discription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Product Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPBouns);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.combSTMode);
            this.groupBox3.Controls.Add(this.combDisMode);
            this.groupBox3.Controls.Add(this.txtPSalesTax);
            this.groupBox3.Controls.Add(this.radTextBox10);
            this.groupBox3.Controls.Add(this.txtPRetailPrice);
            this.groupBox3.Controls.Add(this.txtPDiscount);
            this.groupBox3.Controls.Add(this.txtPTradePrice);
            this.groupBox3.Location = new System.Drawing.Point(6, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 201);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pricing";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(215, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 101;
            this.label12.Text = "Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 100;
            this.label11.Text = "Dis. Mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(71, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Sales Tax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 98;
            this.label9.Text = "S.T.Mode";
            // 
            // txtPBouns
            // 
            this.txtPBouns.AutoSize = true;
            this.txtPBouns.Location = new System.Drawing.Point(93, 79);
            this.txtPBouns.Name = "txtPBouns";
            this.txtPBouns.Size = new System.Drawing.Size(48, 17);
            this.txtPBouns.TabIndex = 97;
            this.txtPBouns.Text = "Bouns";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Retail Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Trade price";
            // 
            // combSTMode
            // 
            this.combSTMode.FormattingEnabled = true;
            this.combSTMode.Location = new System.Drawing.Point(378, 76);
            this.combSTMode.Name = "combSTMode";
            this.combSTMode.Size = new System.Drawing.Size(121, 24);
            this.combSTMode.TabIndex = 55;
            // 
            // combDisMode
            // 
            this.combDisMode.FormattingEnabled = true;
            this.combDisMode.Location = new System.Drawing.Point(378, 119);
            this.combDisMode.Name = "combDisMode";
            this.combDisMode.Size = new System.Drawing.Size(121, 24);
            this.combDisMode.TabIndex = 65;
            // 
            // txtPSalesTax
            // 
            this.txtPSalesTax.Location = new System.Drawing.Point(150, 118);
            this.txtPSalesTax.Name = "txtPSalesTax";
            this.txtPSalesTax.Size = new System.Drawing.Size(128, 24);
            this.txtPSalesTax.TabIndex = 60;
            // 
            // radTextBox10
            // 
            this.radTextBox10.Location = new System.Drawing.Point(150, 75);
            this.radTextBox10.Name = "radTextBox10";
            this.radTextBox10.Size = new System.Drawing.Size(125, 24);
            this.radTextBox10.TabIndex = 50;
            // 
            // txtPRetailPrice
            // 
            this.txtPRetailPrice.Location = new System.Drawing.Point(378, 26);
            this.txtPRetailPrice.Name = "txtPRetailPrice";
            this.txtPRetailPrice.Size = new System.Drawing.Size(173, 24);
            this.txtPRetailPrice.TabIndex = 45;
            // 
            // txtPDiscount
            // 
            this.txtPDiscount.Location = new System.Drawing.Point(284, 164);
            this.txtPDiscount.Name = "txtPDiscount";
            this.txtPDiscount.Size = new System.Drawing.Size(128, 24);
            this.txtPDiscount.TabIndex = 70;
            // 
            // txtPTradePrice
            // 
            this.txtPTradePrice.Location = new System.Drawing.Point(150, 24);
            this.txtPTradePrice.Name = "txtPTradePrice";
            this.txtPTradePrice.Size = new System.Drawing.Size(125, 24);
            this.txtPTradePrice.TabIndex = 40;
            // 
            // combGroup
            // 
            this.combGroup.FormattingEnabled = true;
            this.combGroup.Location = new System.Drawing.Point(381, 128);
            this.combGroup.Name = "combGroup";
            this.combGroup.Size = new System.Drawing.Size(173, 24);
            this.combGroup.TabIndex = 30;
            // 
            // combMedType
            // 
            this.combMedType.FormattingEnabled = true;
            this.combMedType.Location = new System.Drawing.Point(153, 128);
            this.combMedType.Name = "combMedType";
            this.combMedType.Size = new System.Drawing.Size(157, 24);
            this.combMedType.TabIndex = 25;
            // 
            // txtPCode2
            // 
            this.txtPCode2.Enabled = false;
            this.txtPCode2.Location = new System.Drawing.Point(215, 34);
            this.txtPCode2.Name = "txtPCode2";
            this.txtPCode2.Size = new System.Drawing.Size(81, 24);
            this.txtPCode2.TabIndex = 10;
            // 
            // txtPPack
            // 
            this.txtPPack.Location = new System.Drawing.Point(153, 176);
            this.txtPPack.Name = "txtPPack";
            this.txtPPack.Size = new System.Drawing.Size(125, 24);
            this.txtPPack.TabIndex = 35;
            // 
            // txtPDiscription
            // 
            this.txtPDiscription.Location = new System.Drawing.Point(153, 81);
            this.txtPDiscription.Name = "txtPDiscription";
            this.txtPDiscription.Size = new System.Drawing.Size(316, 24);
            this.txtPDiscription.TabIndex = 20;
            // 
            // txtPCode1
            // 
            this.txtPCode1.Enabled = false;
            this.txtPCode1.Location = new System.Drawing.Point(153, 34);
            this.txtPCode1.Name = "txtPCode1";
            this.txtPCode1.Size = new System.Drawing.Size(56, 24);
            this.txtPCode1.TabIndex = 5;
            // 
            // ProductDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProductDelete";
            this.Text = "ProductDelete";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPSalesTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPTradePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPDiscription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPCode1)).EndInit();
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtPBouns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combSTMode;
        private System.Windows.Forms.ComboBox combDisMode;
        private Telerik.WinControls.UI.RadTextBox txtPSalesTax;
        private Telerik.WinControls.UI.RadTextBox radTextBox10;
        private Telerik.WinControls.UI.RadTextBox txtPRetailPrice;
        private Telerik.WinControls.UI.RadTextBox txtPDiscount;
        private Telerik.WinControls.UI.RadTextBox txtPTradePrice;
        private System.Windows.Forms.ComboBox combGroup;
        private System.Windows.Forms.ComboBox combMedType;
        private Telerik.WinControls.UI.RadTextBox txtPCode2;
        private Telerik.WinControls.UI.RadTextBox txtPPack;
        private Telerik.WinControls.UI.RadTextBox txtPDiscription;
        private Telerik.WinControls.UI.RadTextBox txtPCode1;
    }
}