namespace com.sms.gui
{
    partial class CityNew
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
            this.combZoneName = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCCode2 = new com.sms.gui.AdvanceTextControl();
            this.txtCName = new com.sms.gui.AdvanceTextControl();
            this.txtCCode1 = new com.sms.gui.AdvanceTextControl();
            this.btnAddNewZone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combZoneName
            // 
            this.combZoneName.FormattingEnabled = true;
            this.combZoneName.Location = new System.Drawing.Point(136, 37);
            this.combZoneName.Name = "combZoneName";
            this.combZoneName.Size = new System.Drawing.Size(189, 24);
            this.combZoneName.TabIndex = 5;
            this.combZoneName.SelectedIndexChanged += new System.EventHandler(this.combZoneName_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCCode2);
            this.groupBox2.Controls.Add(this.txtCName);
            this.groupBox2.Controls.Add(this.txtCCode1);
            this.groupBox2.Controls.Add(this.btnAddNewZone);
            this.groupBox2.Controls.Add(this.combZoneName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 206);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "City Form";
            // 
            // txtCCode2
            // 
            this.txtCCode2.AdvanceText = "0";
            this.txtCCode2.Enabled = false;
            this.txtCCode2.InvalidMessage = null;
            this.txtCCode2.IsRequired = false;
            this.txtCCode2.Location = new System.Drawing.Point(230, 68);
            this.txtCCode2.Name = "txtCCode2";
            this.txtCCode2.RequiredChar = '*';
            this.txtCCode2.Size = new System.Drawing.Size(79, 45);
            this.txtCCode2.TabIndex = 59;
            this.txtCCode2.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // txtCName
            // 
            this.txtCName.AdvanceText = "";
            this.txtCName.InvalidMessage = null;
            this.txtCName.IsRequired = false;
            this.txtCName.Location = new System.Drawing.Point(136, 130);
            this.txtCName.Name = "txtCName";
            this.txtCName.RequiredChar = '*';
            this.txtCName.Size = new System.Drawing.Size(218, 45);
            this.txtCName.TabIndex = 58;
            this.txtCName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtCCode1
            // 
            this.txtCCode1.AdvanceText = "0";
            this.txtCCode1.Enabled = false;
            this.txtCCode1.InvalidMessage = null;
            this.txtCCode1.IsRequired = false;
            this.txtCCode1.Location = new System.Drawing.Point(136, 69);
            this.txtCCode1.Name = "txtCCode1";
            this.txtCCode1.RequiredChar = '*';
            this.txtCCode1.Size = new System.Drawing.Size(79, 45);
            this.txtCCode1.TabIndex = 57;
            this.txtCCode1.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // btnAddNewZone
            // 
            this.btnAddNewZone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddNewZone.Location = new System.Drawing.Point(381, 31);
            this.btnAddNewZone.Name = "btnAddNewZone";
            this.btnAddNewZone.Size = new System.Drawing.Size(127, 34);
            this.btnAddNewZone.TabIndex = 21;
            this.btnAddNewZone.Text = "Add New Zone";
            this.btnAddNewZone.UseVisualStyleBackColor = true;
            this.btnAddNewZone.Click += new System.EventHandler(this.btnAddNewZone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "City Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(6, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 73);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            // 
            // btnList
            // 
            this.btnList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnList.Location = new System.Drawing.Point(447, 18);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(151, 52);
            this.btnList.TabIndex = 105;
            this.btnList.Text = "City List";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Location = new System.Drawing.Point(293, 18);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 52);
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
            this.btnCancel.Size = new System.Drawing.Size(141, 52);
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
            this.btnAdd.Size = new System.Drawing.Size(149, 52);
            this.btnAdd.TabIndex = 90;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(441, 533);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(323, 59);
            this.txtMessage.TabIndex = 64;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            this.txtMessage.Click += new System.EventHandler(this.txtMessage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(48, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 304);
            this.panel1.TabIndex = 65;
            // 
            // CityNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 872);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CityNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New City";
            this.Load += new System.EventHandler(this.CityNew_Load);
            this.FontChanged += new System.EventHandler(this.CityNew_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CityNew_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox combZoneName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddNewZone;
        private System.Windows.Forms.Label txtMessage;
        private AdvanceTextControl txtCCode2;
        private AdvanceTextControl txtCName;
        private AdvanceTextControl txtCCode1;
        private System.Windows.Forms.Panel panel1;
    }
}