using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.sms.config;
using com.sms.handler;
using com.sms.objects;

namespace com.sms.gui
{
    public partial class ZoneModify : Form
    {
        public ZoneModify()
        {
            InitializeComponent();
        }

        private void ZoneModify_Load(object sender, EventArgs e)
        {
            
            DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_ZONE);            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            saveRecord();
        }
        private void FormReset()
        {
            txtName.AdvanceText = "";
            txtCode.AdvanceText = "0";
        }

        private bool isValid()
        {
            if (txtName.AdvanceText != "")
            {
                return true;
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReset();
        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                    txtCode.AdvanceText = DataGrid.Rows[i].Cells[0].Value.ToString();
                    txtName.AdvanceText = DataGrid.Rows[i].Cells[1].Value.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }

        private void ZoneModify_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.S)
            {
                saveRecord();
            }
            if (e.KeyCode == Keys.F11 || (e.Control && e.KeyCode == Keys.Down))
            {
                DataGrid.Focus();
            }
            if (e.KeyCode == Keys.F12 || (e.Control && e.KeyCode == Keys.Up))
            {
                txtName.Focus();
            }
        }

        private void saveRecord()
        {
            if (isValid())
            {
                OBJ_Zone.ZONE_NAME = txtName.AdvanceText;
                OBJ_Zone.ZONE_CODE = Convert.ToInt32(txtCode.AdvanceText);
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.ZONE_NEW, ConfigQueryModes.UPDATE) + " " + ConfigApp.UPDATE_MESSAGE);
                DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_ZONE);
                FormReset();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void ZoneModify_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
