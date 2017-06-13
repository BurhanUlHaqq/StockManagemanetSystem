namespace com.sms.gui
{
    partial class ZoneNew
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtZName = new com.sms.gui.AdvanceTextControl();
            this.txtZCode = new com.sms.gui.AdvanceTextControl();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Zone Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Zone Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtZName);
            this.groupBox2.Controls.Add(this.txtZCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 186);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zone Form";
            // 
            // txtZName
            // 
            this.txtZName.AdvanceText = "";
            this.txtZName.InvalidMessage = null;
            this.txtZName.IsRequired = false;
            this.txtZName.Location = new System.Drawing.Point(154, 77);
            this.txtZName.Name = "txtZName";
            this.txtZName.RequiredChar = '*';
            this.txtZName.Size = new System.Drawing.Size(218, 45);
            this.txtZName.TabIndex = 56;
            this.txtZName.Type = com.sms.gui.AdvanceTextControl.TextType.TEXT;
            // 
            // txtZCode
            // 
            this.txtZCode.AdvanceText = "0";
            this.txtZCode.Enabled = false;
            this.txtZCode.InvalidMessage = null;
            this.txtZCode.IsRequired = false;
            this.txtZCode.Location = new System.Drawing.Point(154, 16);
            this.txtZCode.Name = "txtZCode";
            this.txtZCode.RequiredChar = '*';
            this.txtZCode.Size = new System.Drawing.Size(218, 45);
            this.txtZCode.TabIndex = 55;
            this.txtZCode.Type = com.sms.gui.AdvanceTextControl.TextType.NUMBER;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(603, 7);
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
            this.btnList.Text = "Zone List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(264, 315);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(467, 49);
            this.txtMessage.TabIndex = 57;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMessage.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(37, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 203);
            this.panel1.TabIndex = 64;
            // 
            // ZoneNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMessage);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ZoneNew";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Zone";
            this.Load += new System.EventHandler(this.ZoneNew_Load);
            this.ResizeEnd += new System.EventHandler(this.ZoneNew_ResizeEnd);
            this.FontChanged += new System.EventHandler(this.ZoneNew_FontChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ZoneNew_KeyDown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private AdvanceTextControl txtZCode;
        private AdvanceTextControl txtZName;
        private System.Windows.Forms.Label txtMessage;
        private System.Windows.Forms.Panel panel1;
    }
}