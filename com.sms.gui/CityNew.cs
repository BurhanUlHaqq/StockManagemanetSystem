using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class CityNew : Form
    {
        public CityNew()
        {
            InitializeComponent();
        }

        

        private void btnAddNewZone_Click(object sender, EventArgs e)
        {
            GUI.loadFormInDialoge(ConfigFormNames.ZONE_NEW);
            HandlerToDB.SetComboBox(combZoneName, ConfigFormNames.CITY_NEW);
        }

        private void CityNew_Load(object sender, EventArgs e)
        {
            HandlerToDB.SetComboBox(combZoneName, ConfigFormNames.CITY_NEW);
            txtCCode2.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.CITY_NEW).ToString();
        }

        private void combZoneName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCCode1.AdvanceText = (((DataRowView)combZoneName.SelectedItem).Row.ItemArray)[0].ToString();          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void setObject()
        {
            OBJ_Cities.CITY_CODE = Convert.ToInt32(txtCCode2.AdvanceText);
            OBJ_Cities.ZONE_CODE = Convert.ToInt32(txtCCode1.AdvanceText);
            OBJ_Cities.CITY_ZONE_CODE = Convert.ToInt32(txtCCode2.AdvanceText + txtCCode2.AdvanceText);
            OBJ_Cities.CITY_NAME = txtCName.AdvanceText;
        }

        private void FormReset()
        {
            txtCName.AdvanceText = "";
        }

        private bool isValid()
        {
            if(txtCName.AdvanceText != "")
            {
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormReset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void CityNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                addRecord();
            }
            if(e.KeyCode==Keys.F12)
            {
                txtCName.Focus();
            }
        }

        private void addRecord()
        {
            if (isValid())
            {
                setObject();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.CITY_NEW, ConfigQueryModes.INSERT) + " " + ConfigApp.INSERT_MESSAGE);
                txtCCode2.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.CITY_NEW).ToString();
                FormReset();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void txtMessage_Click(object sender, EventArgs e)
        {

        }

        private void CityNew_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
