namespace com.sms.gui
{
    partial class AdvanceTextControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(254, 30);
            this.lbl.TabIndex = 3;
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // box
            // 
            this.box.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.box.Location = new System.Drawing.Point(0, 30);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(254, 22);
            this.box.TabIndex = 2;
            this.box.TextChanged += new System.EventHandler(this.box_TextChanged);
            // 
            // AdvanceTextControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.box);
            this.Name = "AdvanceTextControl";
            this.Size = new System.Drawing.Size(254, 52);
            this.Load += new System.EventHandler(this.AdvanceTextControl_Load);
            this.FontChanged += new System.EventHandler(this.AdvanceTextControl_FontChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox box;
    }
}
