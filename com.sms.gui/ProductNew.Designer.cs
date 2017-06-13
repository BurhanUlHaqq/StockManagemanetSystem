namespace com.sms.gui
{
    partial class ProductNew
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPack = new com.sms.gui.AdvanceTextControl();
            this.txtProductDiscription = new com.sms.gui.AdvanceTextControl();
            this.txtCompanyName = new com.sms.gui.AdvanceTextControl();
            this.txtCompanyCode = new com.sms.gui.AdvanceTextControl();
            this.txtProductCode = new com.sms.gui.AdvanceTextControl();
            this.label15 = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRetailPrice = new com.sms.gui.AdvanceTextControl();
            this.txtTradePrice = new com.sms.gui.AdvanceTextControl();
            this.txtBouns = new com.sms.gui.AdvanceTextControl();
            this.txtPDiscount = new com.sms.gui.AdvanceTextControl();
            this.txtPSalesTax = new com.sms.gui.AdvanceTextControl();
            this.lblPercentageDiscount = new System.Windows.Forms.Label();
            this.lblPercentageTax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPBouns = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combSTMode = new System.Windows.Forms.ComboBox();
            this.combDisMode = new System.Windows.Forms.ComboBox();
            this.combGroup = new System.Windows.Forms.ComboBox();
            this.combMedType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DataGrid = new Telerik.WinControls.UI.RadGridView();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(650, 520);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(620, 75);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnList.Location = new System.Drawing.Point(470, 19);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(146, 52);
            this.btnList.TabIndex = 105;
            this.btnList.Text = "Product List";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Location = new System.Drawing.Point(312, 19);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 52);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(152, 19);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 52);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.Location = new System.Drawing.Point(4, 19);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 52);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPack);
            this.groupBox2.Controls.Add(this.txtProductDiscription);
            this.groupBox2.Controls.Add(this.txtCompanyName);
            this.groupBox2.Controls.Add(this.txtCompanyCode);
            this.groupBox2.Controls.Add(this.txtProductCode);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.combGroup);
            this.groupBox2.Controls.Add(this.combMedType);
            this.groupBox2.Location = new System.Drawing.Point(650, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(620, 506);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Form";
            // 
            // txtPack
            // 
            this.txtPack.AdvanceText = "";
            this.txtPack.InvalidMessage = null;
            this.txtPack.IsRequired = false;
            this.txtPack.Location = new System.Drawing.Point(256, 220);
            this.txtPack.Name = "txtPack";
            this.txtPack.RequiredChar = '*';
            this.txtPack.Size = new System.Drawing.Size(148, 45);
            this.txtPack.TabIndex = 92;
            this.txtPack.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtProductDiscription
            // 
            this.txtProductDiscription.AdvanceText = "";
            this.txtProductDiscription.InvalidMessage = null;
            this.txtProductDiscription.IsRequired = false;
            this.txtProductDiscription.Location = new System.Drawing.Point(154, 117);
            this.txtProductDiscription.Name = "txtProductDiscription";
            this.txtProductDiscription.RequiredChar = '*';
            this.txtProductDiscription.Size = new System.Drawing.Size(241, 45);
            this.txtProductDiscription.TabIndex = 91;
            this.txtProductDiscription.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AdvanceText = "";
            this.txtCompanyName.Enabled = false;
            this.txtCompanyName.InvalidMessage = null;
            this.txtCompanyName.IsRequired = false;
            this.txtCompanyName.Location = new System.Drawing.Point(154, 67);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.RequiredChar = '*';
            this.txtCompanyName.Size = new System.Drawing.Size(226, 45);
            this.txtCompanyName.TabIndex = 90;
            this.txtCompanyName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.AdvanceText = "0";
            this.txtCompanyCode.Enabled = false;
            this.txtCompanyCode.InvalidMessage = null;
            this.txtCompanyCode.IsRequired = false;
            this.txtCompanyCode.Location = new System.Drawing.Point(154, 16);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.RequiredChar = '*';
            this.txtCompanyCode.Size = new System.Drawing.Size(74, 45);
            this.txtCompanyCode.TabIndex = 89;
            this.txtCompanyCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtProductCode
            // 
            this.txtProductCode.AdvanceText = "0";
            this.txtProductCode.Enabled = false;
            this.txtProductCode.InvalidMessage = null;
            this.txtProductCode.IsRequired = false;
            this.txtProductCode.Location = new System.Drawing.Point(233, 16);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.RequiredChar = '*';
            this.txtProductCode.Size = new System.Drawing.Size(91, 45);
            this.txtProductCode.TabIndex = 88;
            this.txtProductCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 96);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 78;
            this.label15.Text = "Company Name";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(380, 39);
            this.DatePicker.Margin = new System.Windows.Forms.Padding(4);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(224, 22);
            this.DatePicker.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 42);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 17);
            this.label13.TabIndex = 77;
            this.label13.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 76;
            this.label5.Text = "Pack";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 75;
            this.label4.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Medicine Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "Discription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 72;
            this.label1.Text = "Product Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRetailPrice);
            this.groupBox3.Controls.Add(this.txtTradePrice);
            this.groupBox3.Controls.Add(this.txtBouns);
            this.groupBox3.Controls.Add(this.txtPDiscount);
            this.groupBox3.Controls.Add(this.txtPSalesTax);
            this.groupBox3.Controls.Add(this.lblPercentageDiscount);
            this.groupBox3.Controls.Add(this.lblPercentageTax);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPBouns);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.combSTMode);
            this.groupBox3.Controls.Add(this.combDisMode);
            this.groupBox3.Location = new System.Drawing.Point(6, 271);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(610, 228);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pricing";
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.AdvanceText = "0";
            this.txtRetailPrice.InvalidMessage = "Invalid";
            this.txtRetailPrice.IsRequired = false;
            this.txtRetailPrice.Location = new System.Drawing.Point(465, 20);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.RequiredChar = '*';
            this.txtRetailPrice.Size = new System.Drawing.Size(98, 42);
            this.txtRetailPrice.TabIndex = 108;
            this.txtRetailPrice.Type = com.sms.gui.AdvanceTextControl.TextType.CURRENCY;
            // 
            // txtTradePrice
            // 
            this.txtTradePrice.AdvanceText = "0";
            this.txtTradePrice.InvalidMessage = "Invalid";
            this.txtTradePrice.IsRequired = false;
            this.txtTradePrice.Location = new System.Drawing.Point(148, 20);
            this.txtTradePrice.Name = "txtTradePrice";
            this.txtTradePrice.RequiredChar = '*';
            this.txtTradePrice.Size = new System.Drawing.Size(120, 42);
            this.txtTradePrice.TabIndex = 107;
            this.txtTradePrice.Type = com.sms.gui.AdvanceTextControl.TextType.CURRENCY;
            // 
            // txtBouns
            // 
            this.txtBouns.AdvanceText = "0";
            this.txtBouns.InvalidMessage = "InValid";
            this.txtBouns.IsRequired = false;
            this.txtBouns.Location = new System.Drawing.Point(324, 179);
            this.txtBouns.Name = "txtBouns";
            this.txtBouns.RequiredChar = '*';
            this.txtBouns.Size = new System.Drawing.Size(93, 40);
            this.txtBouns.TabIndex = 106;
            this.txtBouns.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtPDiscount
            // 
            this.txtPDiscount.AdvanceText = "0";
            this.txtPDiscount.InvalidMessage = "InValid";
            this.txtPDiscount.IsRequired = false;
            this.txtPDiscount.Location = new System.Drawing.Point(465, 120);
            this.txtPDiscount.Name = "txtPDiscount";
            this.txtPDiscount.RequiredChar = '*';
            this.txtPDiscount.Size = new System.Drawing.Size(58, 43);
            this.txtPDiscount.TabIndex = 105;
            this.txtPDiscount.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtPSalesTax
            // 
            this.txtPSalesTax.AdvanceText = "0";
            this.txtPSalesTax.InvalidMessage = "InValid";
            this.txtPSalesTax.IsRequired = false;
            this.txtPSalesTax.Location = new System.Drawing.Point(465, 74);
            this.txtPSalesTax.Name = "txtPSalesTax";
            this.txtPSalesTax.RequiredChar = '*';
            this.txtPSalesTax.Size = new System.Drawing.Size(58, 36);
            this.txtPSalesTax.TabIndex = 104;
            this.txtPSalesTax.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // lblPercentageDiscount
            // 
            this.lblPercentageDiscount.AutoSize = true;
            this.lblPercentageDiscount.Location = new System.Drawing.Point(535, 147);
            this.lblPercentageDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentageDiscount.Name = "lblPercentageDiscount";
            this.lblPercentageDiscount.Size = new System.Drawing.Size(20, 17);
            this.lblPercentageDiscount.TabIndex = 103;
            this.lblPercentageDiscount.Text = "%";
            this.lblPercentageDiscount.Visible = false;
            // 
            // lblPercentageTax
            // 
            this.lblPercentageTax.AutoSize = true;
            this.lblPercentageTax.Location = new System.Drawing.Point(532, 92);
            this.lblPercentageTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentageTax.Name = "lblPercentageTax";
            this.lblPercentageTax.Size = new System.Drawing.Size(20, 17);
            this.lblPercentageTax.TabIndex = 102;
            this.lblPercentageTax.Text = "%";
            this.lblPercentageTax.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(342, 146);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 101;
            this.label12.Text = "Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 146);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 100;
            this.label11.Text = "Dis. Mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(335, 92);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 99;
            this.label10.Text = "Sales Tax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 98;
            this.label9.Text = "S.T.Mode";
            // 
            // txtPBouns
            // 
            this.txtPBouns.AutoSize = true;
            this.txtPBouns.Location = new System.Drawing.Point(222, 201);
            this.txtPBouns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPBouns.Name = "txtPBouns";
            this.txtPBouns.Size = new System.Drawing.Size(48, 17);
            this.txtPBouns.TabIndex = 97;
            this.txtPBouns.Text = "Bouns";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 96;
            this.label7.Text = "Retail Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Trade price";
            // 
            // combSTMode
            // 
            this.combSTMode.FormattingEnabled = true;
            this.combSTMode.Location = new System.Drawing.Point(148, 87);
            this.combSTMode.Margin = new System.Windows.Forms.Padding(4);
            this.combSTMode.Name = "combSTMode";
            this.combSTMode.Size = new System.Drawing.Size(120, 24);
            this.combSTMode.TabIndex = 55;
            this.combSTMode.SelectedIndexChanged += new System.EventHandler(this.combSTMode_SelectedIndexChanged);
            // 
            // combDisMode
            // 
            this.combDisMode.FormattingEnabled = true;
            this.combDisMode.Location = new System.Drawing.Point(148, 138);
            this.combDisMode.Margin = new System.Windows.Forms.Padding(4);
            this.combDisMode.Name = "combDisMode";
            this.combDisMode.Size = new System.Drawing.Size(120, 24);
            this.combDisMode.TabIndex = 65;
            this.combDisMode.SelectedIndexChanged += new System.EventHandler(this.combDisMode_SelectedIndexChanged);
            // 
            // combGroup
            // 
            this.combGroup.FormattingEnabled = true;
            this.combGroup.Location = new System.Drawing.Point(415, 190);
            this.combGroup.Margin = new System.Windows.Forms.Padding(4);
            this.combGroup.Name = "combGroup";
            this.combGroup.Size = new System.Drawing.Size(174, 24);
            this.combGroup.TabIndex = 30;
            // 
            // combMedType
            // 
            this.combMedType.FormattingEnabled = true;
            this.combMedType.Location = new System.Drawing.Point(154, 190);
            this.combMedType.Margin = new System.Windows.Forms.Padding(4);
            this.combMedType.Name = "combMedType";
            this.combMedType.Size = new System.Drawing.Size(158, 24);
            this.combMedType.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.DataGrid);
            this.groupBox4.Controls.Add(this.lblMode);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(636, 589);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Company";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(324, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "F8: ID and F9 Name Search";
            // 
            // DataGrid
            // 
            this.DataGrid.BackColor = System.Drawing.SystemColors.Control;
            this.DataGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGrid.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DataGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGrid.Location = new System.Drawing.Point(4, 67);
            this.DataGrid.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            this.DataGrid.MasterTemplate.AllowAddNewRow = false;
            this.DataGrid.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "C_Code";
            gridViewTextBoxColumn7.HeaderText = "ID";
            gridViewTextBoxColumn7.Name = "C_Code";
            gridViewTextBoxColumn7.Width = 133;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "C_Name";
            gridViewTextBoxColumn8.HeaderText = "Name";
            gridViewTextBoxColumn8.Name = "C_Name";
            gridViewTextBoxColumn8.Width = 299;
            this.DataGrid.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.DataGrid.MasterTemplate.EnableGrouping = false;
            this.DataGrid.MasterTemplate.EnableSorting = false;
            this.DataGrid.MasterTemplate.ShowColumnHeaders = false;
            this.DataGrid.MasterTemplate.ShowRowHeaderColumn = false;
            this.DataGrid.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGrid.ShowGroupPanel = false;
            this.DataGrid.Size = new System.Drawing.Size(628, 518);
            this.DataGrid.TabIndex = 5;
            this.DataGrid.Text = "radGridView1";
            this.DataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            this.DataGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrid_KeyDown);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(6, 34);
            this.lblMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.txtSearch.Location = new System.Drawing.Point(194, 30);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(122, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(133, 710);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(642, 52);
            this.txtMessage.TabIndex = 112;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 606);
            this.panel1.TabIndex = 113;
            // 
            // ProductNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 873);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Product";
            this.Load += new System.EventHandler(this.ProductNew_Load);
            this.FontChanged += new System.EventHandler(this.ProductNew_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductNew_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox combSTMode;
        private System.Windows.Forms.ComboBox combDisMode;
        private System.Windows.Forms.ComboBox combGroup;
        private System.Windows.Forms.ComboBox combMedType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtPBouns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label lblPercentageTax;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private Telerik.WinControls.UI.RadGridView DataGrid;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Label lblPercentageDiscount;
        private AdvanceTextControl txtCompanyCode;
        private AdvanceTextControl txtProductCode;
        private AdvanceTextControl txtBouns;
        private AdvanceTextControl txtPDiscount;
        private AdvanceTextControl txtPSalesTax;
        private AdvanceTextControl txtRetailPrice;
        private AdvanceTextControl txtTradePrice;
        private AdvanceTextControl txtPack;
        private AdvanceTextControl txtProductDiscription;
        private AdvanceTextControl txtCompanyName;
        private System.Windows.Forms.Panel panel1;
    }
}