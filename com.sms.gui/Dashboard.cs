using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using com.sms.config;
using com.sms.handler;

namespace com.sms.gui
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.COMPANY);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.COMPANY_MODIFY);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.COMPANY_DELETE);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.PRODUCT_NEW);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.PRODUCT_MODIFY);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.PRODUCT_DELETE);
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.CITY_NEW);
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.CITY_MODIFY);
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.CITY_DELETE);
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.CUSTOMER_NEW);
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.CUSTOMER_MODIFY);
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.CUSTOMER_DELETE);
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.SALES_MAN_NEW);
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.SALES_MAN_MODIFY);
        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.SALES_MAN_DELETE);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.ZONE_NEW);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.ZONE_MODIFY);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.ZONE_DELETE);
        }
        private void toolStripButton27_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.SALES);
        }
        private void toolStripButton29_Click(object sender, EventArgs e)
        {
            LoadGUI.LoadForm(ConfigApp.DisplayArea, ConfigFormNames.STOCK_NEW);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            SetSize();
            HANDLER.LoadCompanyInfo();
            panel1.Controls.Add(ConfigApp.DisplayArea);
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
            this.Text = "Sotck Management System | BSolutions | " + ConfigCompany.CompanyName;

        }

        private void SetFormSize()
        {

        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SetSize()
        {
            this.Location = new Point(0, 0);
            this.Width = Screen.PrimaryScreen.WorkingArea.Size.Width;
            this.Height = (Screen.PrimaryScreen.WorkingArea.Size.Height - 5) - (Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom);
            ribbonControlAdv1.Width = this.Width - 10;
            radPanel1.Location = new Point(0, 0);
            radPanel1.Size = this.Size;
            panel1.Location = new Point(0, 155);
            panel1.Height = (this.Height - 5 - ribbonControlAdv1.Height) - (Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom);
            panel1.Width = this.Width - 10;
        }

        

        private void radTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            
            int val = Convert.ToInt32(radTrackBar1.Value);
            Font font;
            switch (val)
            {
                case 0:
                    font = new Font(FontFamily.GenericSansSerif, 7.8f);
                    ConfigApp.DisplayArea.Font = font;
                    break;
                case 1:
                    font = new Font(FontFamily.GenericSansSerif, 8.5f);
                    ConfigApp.DisplayArea.Font = font;
                    break;
                case 2:
                    font = new Font(FontFamily.GenericSansSerif, 9.0f);
                    ConfigApp.DisplayArea.Font = font;
                    break;
                case 3:
                    font = new Font(FontFamily.GenericSansSerif, 9.5f);
                    ConfigApp.DisplayArea.Font = font;
                    break;
                case 4:
                    font = new Font(FontFamily.GenericSansSerif, 10.0f);
                    ConfigApp.DisplayArea.Font = font;
                    break;
                case 5:
                    font = new Font(FontFamily.GenericSansSerif, 10.5f);
                    ConfigApp.DisplayArea.Font = font;
                    break;
            }
            foreach (Control p in ConfigApp.DisplayArea.Controls)
            {
                if (p is Form)
                {
                    p.Focus();
                    break;
                }
                //if (p is Panel)
                //{
                //    Panel panel = (Panel)p;
                //    int PHeight = panel.Height + 100 + (Screen.PrimaryScreen.Bounds.Bottom - Screen.PrimaryScreen.WorkingArea.Bottom);
                //    int AreaHeight = panel1.Height;
                //    int PWidth = panel.Width + 100;
                //    int AreaWidth = panel1.Width;
                //    if (PHeight > AreaHeight || PWidth > AreaWidth)
                //    {
                //        panel1.AutoScroll = true;
                //        /* If the AutoScrollMargin is set to less 
                //           than (5,5), set it to 5,5. */
                //        if (panel1.AutoScrollMargin.Width < 5 || panel1.AutoScrollMargin.Height < 5)
                //        {
                //            panel1.SetAutoScrollMargin(5, 5);
                //        }
                //    }
                //    else
                //    {
                //        panel1.AutoScroll = false;
                //    }
                //    break;
                //}
            }
                        
        }

        
    }
}
