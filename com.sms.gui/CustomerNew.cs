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
    public partial class CustomerNew : Form
    {
        public CustomerNew()
        {
            InitializeComponent();
        }
        bool ModeID;
        DataTable cityRec = null;
        private void CustomerNew_KeyDown(object sender, KeyEventArgs e)
        {
            callOnKeyDown(e);
        }

        private void callOnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                lblMode.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
                ModeID = true;
                txtSearch.Focus();

            }
            if (e.KeyCode == Keys.F9)
            {
                lblMode.Text = ConfigApp.SEARCH_MODE_TEXT_MESSAGE;
                ModeID = false;
                txtSearch.Focus();

            }
            if (e.Control &&  e.KeyCode== Keys.S)
            {
                addRecord();
            }
            if (e.KeyCode == Keys.F12)
            {
                DatePicker.Focus();
            }
        }

        private void CustomerNew_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void callOnLoad()
        {
            DateTime now = DateTime.Now;
            txtCusExpDate.MinDate = new DateTime(now.Year + ConfigApp.CUSTOMER_EXPIRY_MIN_Y, now.Month + ConfigApp.CUSTOMER_EXPIRY_MIN_M, now.Day + ConfigApp.CUSTOMER_EXPIRY_MIN_D);
            DatePicker.MinDate = ConfigApp.MIN_DATETIME;
            ModeID = false;
            cityRec = new DataTable();
            txtCusCusCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.CUSTOMER_NEW).ToString();
            DataGrid.DataSource = cityRec = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_CITY);           

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataGrid.DataSource = cityRec;
            try
            {
                if (ModeID)
                {
                    (DataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
                        "CityCode IS NOT NULL" :
                        String.Format("Convert(CityCode, 'System.String') LIKE '" + txtSearch.Text + "%' ");
                }
                else
                {
                    (DataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
                        "CityName IS NOT NULL" :
                        String.Format("Convert(CityCode, 'System.String') LIKE '" + txtSearch.Text + "%' or CityName LIKE '{0}%' or ZoneName LIKE '{1}%'", txtSearch.Text, txtSearch.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                DataGrid.Focus();
            }            
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                    txtCustomerCity.AdvanceText = DataGrid.Rows[i].Cells["ZoneName"].Value.ToString()+":"+ DataGrid.Rows[i].Cells["CityName"].Value.ToString();
                    txtCusCCode.AdvanceText = DataGrid.Rows[i].Cells["CityCode"].Value.ToString();
                    txtCusZCode.AdvanceText = DataGrid.Rows[i].Cells["ZoneCode"].Value.ToString();
                }
            }
        }

        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
        
        private void setObjects()
        {
            OBJ_Customer_Info.ZONE_CODE =Convert.ToInt32( txtCusZCode.AdvanceText);
            OBJ_Customer_Info.CITY_CODE=Convert.ToInt32( txtCusCCode.AdvanceText);
            OBJ_Customer_Info.CUSTOMER_CODE = Convert.ToInt32(txtCusCusCode.AdvanceText);
            OBJ_Customer_Info.NAME = txtCusName.AdvanceText;
            OBJ_Customer_Info.ADDRESS = txtCusAddr.AdvanceText;
            OBJ_Customer_Info.PHONE = txtCusPH.AdvanceText;
            OBJ_Customer_Info.LICENSE = txtCusLicense.AdvanceText;
            OBJ_Customer_Info.CUSTOMER_DATE = DatePicker.Text;
            OBJ_Customer_Info.LICENSE_EXPIRY_DATE = txtCusExpDate.Text;
            OBJ_Customer_Info.CITY = txtCusCity.AdvanceText;
            if (isCusIgnoreExp.Checked)
                OBJ_Customer_Info.CHECK_EXPIRY_DATE = 1;
            else
                OBJ_Customer_Info.CHECK_EXPIRY_DATE = 0;
        }

        private void clearForm()
        {
            txtCusZCode.AdvanceText = "";
            txtCusCCode.AdvanceText = "";
            txtCusName.AdvanceText = "";
            txtCusAddr.AdvanceText = "";
            txtCusPH.AdvanceText = "";
            txtCusLicense.AdvanceText = "";
            DatePicker.Value = DateTime.Now;
            txtCusExpDate.Value = DateTime.Now;
            txtCusCity.AdvanceText = "";
            isCusIgnoreExp.Checked = false;
        }

        private bool isFormValidate()
        {
            if (txtCusZCode.AdvanceText == "" || txtCusCCode.AdvanceText == "" || txtCusName.AdvanceText == "" || txtCusAddr.AdvanceText == "" || txtCusPH.AdvanceText == "" || txtCusLicense.AdvanceText == "" || txtCusCity.AdvanceText == "")
            {
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            GUI.loadFormInPanel(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void addRecord()
        {
            if(isFormValidate())
            {
                setObjects();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.CUSTOMER_NEW, ConfigQueryModes.INSERT) + " " + ConfigApp.INSERT_MESSAGE);
                txtCusCusCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.CUSTOMER_NEW).ToString();
                clearForm();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void CustomerNew_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
