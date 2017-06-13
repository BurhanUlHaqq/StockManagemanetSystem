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
    public partial class SalesManModify : Form
    {
        public SalesManModify()
        {
            InitializeComponent();
        }

        private void updateRecord()
        {
            if (isFormValied())
            {
                setObjects();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.SALES_MAN_NEW, ConfigQueryModes.UPDATE) + " " + ConfigApp.UPDATE_MESSAGE);
                resetForm();
                callOnLoad();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void setObjects()
        {
            OBJ_Sales_Man.SALES_MAN_CODE = Convert.ToInt32(txtSalesManCode.AdvanceText);
            OBJ_Sales_Man.SALES_MAN_NAME = txtName.AdvanceText;
            OBJ_Sales_Man.ZONE_CODE = Convert.ToInt32(txtZoneCode.AdvanceText);
        }

        private void resetForm()
        {
            txtName.AdvanceText = "";
        }
        private bool isFormValied()
        {
            if (txtZoneCode.AdvanceText == "" || txtName.AdvanceText == "")
            {
                return false;
            }
            return true;
        }

        private void SalesManModify_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void callOnLoad()
        {
            HandlerToDB.SetComboBox(combZone, ConfigFormNames.CITY_NEW);
            DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_SALES_MAN);
            DataGrid.Focus();
        }

        private void SalesManModify_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                txtName.Focus();
            }
            if (e.KeyCode == Keys.F11)
            {
                DataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                updateRecord();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadGUI.LoadForm(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }

        private void combZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtZoneCode.AdvanceText = (((DataRowView)combZone.SelectedItem).Row.ItemArray)[0].ToString();
        }

        private void MasterTemplate_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                    txtName.AdvanceText = DataGrid.Rows[i].Cells["sm_name"].Value.ToString();
                    txtSalesManCode.AdvanceText = DataGrid.Rows[i].Cells["sm_code"].Value.ToString();
                    string selID = DataGrid.Rows[i].Cells["z_code"].Value.ToString();
                    for (int j = 0; j < combZone.Items.Count; j++)
                    {
                        if (selID == (((DataRowView)combZone.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combZone.SelectedIndex = j;
                            txtZoneCode.AdvanceText = selID;
                            break;
                        }
                    }

                }
            }
        }

        private void SalesManModify_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
