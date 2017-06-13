using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.sms.handler;
using com.sms.config;
using com.sms.objects;

namespace com.sms.gui
{
    public partial class ZoneNew : Form
    {
        public ZoneNew()
        {
            InitializeComponent();
        }


        private void ZoneNew_Load(object sender, EventArgs e)
        {
            txtZCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.ZONE_NEW).ToString();
        }



        private void FormReset()
        {
            txtZName.AdvanceText = "";
        }

        private bool isValid()
        {
            if (txtZName.AdvanceText != "")
            {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormReset();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GUI.loadFormInDialoge(ConfigFormNames.ZONE_DIALOGE);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void ZoneNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                addRecord();
            }
            if (e.KeyCode == Keys.F12)
            {
                txtZName.Focus();
            }
        }

        private void addRecord()
        {
            if (isValid())
            {
                OBJ_Zone.ZONE_NAME = txtZName.AdvanceText;
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.ZONE_NEW, ConfigQueryModes.INSERT) + " " + ConfigApp.INSERT_MESSAGE);
                txtZCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.ZONE_NEW).ToString();
                FormReset();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void ZoneNew_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void ZoneNew_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
