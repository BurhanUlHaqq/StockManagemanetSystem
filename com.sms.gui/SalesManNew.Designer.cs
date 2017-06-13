namespace com.sms.gui
{
    partial class SalesManNew
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
            this.txtName = new com.sms.gui.AdvanceTextControl();
            this.txtSalesManCode = new com.sms.gui.AdvanceTextControl();
            this.txtZoneCode = new com.sms.gui.AdvanceTextControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combZone = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.groupBox1.Location = new System.Drawing.Point(559, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 172);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnList.Location = new System.Drawing.Point(3, 130);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(179, 36);
            this.btnList.TabIndex = 105;
            this.btnList.Text = "Sales Man List";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.Location = new System.Drawing.Point(3, 98);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(179, 32);
            this.btnExit.TabIndex = 100;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Location = new System.Drawing.Point(3, 58);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 40);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(3, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 40);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtSalesManCode);
            this.groupBox2.Controls.Add(this.txtZoneCode);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.combZone);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 204);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales Man Form";
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
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(862, 384);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(193, 50);
            this.txtMessage.TabIndex = 110;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(47, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 213);
            this.panel1.TabIndex = 111;
            // 
            // SalesManNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 557);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.Name = "SalesManNew";
            this.Text = "SalesManNew";
            this.Load += new System.EventHandler(this.SalesManNew_Load);
            this.FontChanged += new System.EventHandler(this.SalesManNew_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesManNew_KeyDown);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combZone;
        private System.Windows.Forms.Label txtMessage;
        private AdvanceTextControl txtSalesManCode;
        private AdvanceTextControl txtZoneCode;
        private AdvanceTextControl txtName;
        private System.Windows.Forms.Panel panel1;
    }
}