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
    public partial class CityModify : Form
    {
        public CityModify()
        {
            InitializeComponent();
        }

        private void CityModify_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void callOnLoad()
        {
            DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_CITY);
            HandlerToDB.SetComboBox(combZoneName, ConfigFormNames.CITY_NEW);
            FormReset();
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                    txtCCode1.AdvanceText = DataGrid.Rows[i].Cells[0].Value.ToString();
                    txtCCode2.AdvanceText = DataGrid.Rows[i].Cells[2].Value.ToString();
                    txtCName.AdvanceText = DataGrid.Rows[i].Cells[3].Value.ToString();
                    for (int j = 0; j < combZoneName.Items.Count; j++)
                    {
                        if (txtCCode1.AdvanceText == (((DataRowView)combZoneName.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combZoneName.SelectedIndex = j;
                            break;
                        }
                    }
                }
            }
        }

        private void combZoneName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCCode1.AdvanceText = (((DataRowView)combZoneName.SelectedItem).Row.ItemArray)[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReset();
        }
        private void FormReset()
        {
            txtCName.AdvanceText = "";
        }

        private bool isValid()
        {
            if (txtCName.AdvanceText != "")
            {
                return true;
            }
            return false;
        }
        private void setObject()
        {
            OBJ_Cities.CITY_CODE = Convert.ToInt32(txtCCode2.AdvanceText);
            OBJ_Cities.ZONE_CODE = Convert.ToInt32(txtCCode1.AdvanceText);
            OBJ_Cities.CITY_ZONE_CODE = Convert.ToInt32(txtCCode2.AdvanceText + txtCCode2.AdvanceText);
            OBJ_Cities.CITY_NAME = txtCName.AdvanceText;
        }

        private void CityModify_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.S)
            {
                saveRecord();
            }
            if (e.KeyCode == Keys.F12 || (e.Control && e.KeyCode == Keys.Up))
            {
                txtCName.Focus();
            }
            if (e.KeyCode == Keys.F11 || (e.Control && e.KeyCode == Keys.Down))
            {
                DataGrid.Focus();
            }
        }

        private void saveRecord()
        {
            if (isValid())
            {
                setObject();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.CITY_NEW, ConfigQueryModes.UPDATE) + " " + ConfigApp.UPDATE_MESSAGE);
                callOnLoad();
                FormReset();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void CityModify_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
