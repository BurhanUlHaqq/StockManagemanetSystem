namespace com.sms.gui
{
    partial class Company
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCEmail = new com.sms.gui.AdvanceTextControl();
            this.txtCFaxNo = new com.sms.gui.AdvanceTextControl();
            this.txtCPHNo = new com.sms.gui.AdvanceTextControl();
            this.txtCCity = new com.sms.gui.AdvanceTextControl();
            this.txtCAddress = new com.sms.gui.AdvanceTextControl();
            this.txtCName = new com.sms.gui.AdvanceTextControl();
            this.txtCCode = new com.sms.gui.AdvanceTextControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(8, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 61);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnList.Location = new System.Drawing.Point(472, 18);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(153, 40);
            this.btnList.TabIndex = 105;
            this.btnList.Text = "Company List";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Location = new System.Drawing.Point(317, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 40);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(152, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 40);
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
            this.btnAdd.Size = new System.Drawing.Size(149, 40);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCEmail);
            this.groupBox2.Controls.Add(this.txtCFaxNo);
            this.groupBox2.Controls.Add(this.txtCPHNo);
            this.groupBox2.Controls.Add(this.txtCCity);
            this.groupBox2.Controls.Add(this.txtCAddress);
            this.groupBox2.Controls.Add(this.txtCName);
            this.groupBox2.Controls.Add(this.txtCCode);
            this.groupBox2.Controls.Add(this.DatePicker);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(626, 360);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Form";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss tt";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(366, 41);
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
            this.label7.Location = new System.Drawing.Point(322, 249);
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
            this.label4.Location = new System.Drawing.Point(55, 149);
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
            this.label2.Location = new System.Drawing.Point(322, 45);
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
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(927, 710);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(193, 40);
            this.txtMessage.TabIndex = 107;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(37, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 439);
            this.panel1.TabIndex = 108;
            // 
            // txtCEmail
            // 
            this.txtCEmail.AdvanceText = "";
            this.txtCEmail.InvalidMessage = "Invalid Email";
            this.txtCEmail.IsRequired = false;
            this.txtCEmail.Length = 32767;
            this.txtCEmail.Location = new System.Drawing.Point(143, 276);
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
            this.txtCFaxNo.Length = 32767;
            this.txtCFaxNo.Location = new System.Drawing.Point(400, 223);
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
            this.txtCPHNo.Length = 32767;
            this.txtCPHNo.Location = new System.Drawing.Point(143, 225);
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
            this.txtCCity.Length = 50;
            this.txtCCity.Location = new System.Drawing.Point(143, 174);
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.RequiredChar = '*';
            this.txtCCity.Size = new System.Drawing.Size(202, 45);
            this.txtCCity.TabIndex = 90;
            this.txtCCity.Type = com.sms.gui.AdvanceTextControl.TextType.ADDRESS;
            // 
            // txtCAddress
            // 
            this.txtCAddress.AdvanceText = "";
            this.txtCAddress.InvalidMessage = null;
            this.txtCAddress.IsRequired = false;
            this.txtCAddress.Length = 100;
            this.txtCAddress.Location = new System.Drawing.Point(143, 123);
            this.txtCAddress.Name = "txtCAddress";
            this.txtCAddress.RequiredChar = '*';
            this.txtCAddress.Size = new System.Drawing.Size(437, 45);
            this.txtCAddress.TabIndex = 89;
            this.txtCAddress.Type = com.sms.gui.AdvanceTextControl.TextType.ADDRESS;
            // 
            // txtCName
            // 
            this.txtCName.AdvanceText = "";
            this.txtCName.InvalidMessage = null;
            this.txtCName.IsRequired = false;
            this.txtCName.Length = 32767;
            this.txtCName.Location = new System.Drawing.Point(143, 72);
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
            this.txtCCode.Length = 32767;
            this.txtCCode.Location = new System.Drawing.Point(143, 21);
            this.txtCCode.Name = "txtCCode";
            this.txtCCode.RequiredChar = '*';
            this.txtCCode.Size = new System.Drawing.Size(166, 45);
            this.txtCCode.TabIndex = 87;
            this.txtCCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 945);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.Name = "Company";
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            this.FontChanged += new System.EventHandler(this.Company_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Company_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label txtMessage;
        private AdvanceTextControl txtCCode;
        private AdvanceTextControl txtCEmail;
        private AdvanceTextControl txtCFaxNo;
        private AdvanceTextControl txtCPHNo;
        private AdvanceTextControl txtCCity;
        private AdvanceTextControl txtCAddress;
        private AdvanceTextControl txtCName;
        private System.Windows.Forms.Panel panel1;
    }
}