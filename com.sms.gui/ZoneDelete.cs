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
    public partial class ZoneDelete : Form
    {
        public ZoneDelete()
        {
            InitializeComponent();
        }

        private void ZoneDelete_Load(object sender, EventArgs e)
        {
            DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_ZONE);
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                    txtZCode.AdvanceText = DataGrid.Rows[i].Cells[0].Value.ToString();
                    txtZName.AdvanceText = DataGrid.Rows[i].Cells[1].Value.ToString();
                }
            }
        }

        private void FormReset()
        {
            txtZName.AdvanceText = "";
            txtZCode.AdvanceText = "0";
        }

        private bool isValid()
        {
            if (txtZName.AdvanceText != "")
            {
                return true;
            }
            return false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormReset();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                OBJ_Zone.ZONE_CODE = Convert.ToInt32( txtZCode.AdvanceText);
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.ZONE_NEW, ConfigQueryModes.DELETE) + " " + ConfigApp.DELETE_MESSAGE);
                                FormReset();
                DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_ZONE);
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }
    }
}
