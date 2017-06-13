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
    public partial class CustomerModify : Form
    {
        public CustomerModify()
        {
            InitializeComponent();
        }
        bool ModeID;
        DataTable cityRec;
        private void CustomerModify_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void callOnLoad()
        {
            DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_CUSTOMER);
            ModeID = false;
            cityRec = new DataTable();
            CityDataGrid.DataSource = cityRec = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_CITY);
            DataGrid.Focus();
        }
        private void setObjects()
        {
            OBJ_Customer_Info.ZONE_CODE = Convert.ToInt32(txtCusZCode.AdvanceText);
            OBJ_Customer_Info.CITY_CODE = Convert.ToInt32(txtCusCCode.AdvanceText);
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
        private void updateRecord()
        {
            if (isFormValidate())
            {
                setObjects();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.CUSTOMER_NEW, ConfigQueryModes.UPDATE) + " " + ConfigApp.UPDATE_MESSAGE);
                callOnLoad();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void MasterTemplate_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                    txtCustomerCity.AdvanceText = DataGrid.Rows[i].Cells["zone"].Value.ToString() + ":" + DataGrid.Rows[i].Cells["city"].Value.ToString();
                    txtCusCCode.AdvanceText = DataGrid.Rows[i].Cells["city_code"].Value.ToString();
                    txtCusZCode.AdvanceText = DataGrid.Rows[i].Cells["z_code"].Value.ToString();
                    txtCusName.AdvanceText = DataGrid.Rows[i].Cells["cus_name"].Value.ToString();
                    txtCusCusCode.AdvanceText = DataGrid.Rows[i].Cells["cust_code"].Value.ToString();
                    txtCusAddr.AdvanceText = DataGrid.Rows[i].Cells["addr"].Value.ToString();
                    txtCusPH.AdvanceText = DataGrid.Rows[i].Cells["ph"].Value.ToString();
                    txtCusLicense.AdvanceText = DataGrid.Rows[i].Cells["licence"].Value.ToString();
                    DatePicker.Value = DateTime.Parse(DataGrid.Rows[i].Cells["cust_date"].Value.ToString());
                    DateTime date= DateTime.Parse(DataGrid.Rows[i].Cells["lic_exp_date"].Value.ToString());
                    txtCusExpDate.MinDate = date;
                    txtCusExpDate.Value = date;                    
                    txtCusCity.AdvanceText = DataGrid.Rows[i].Cells["city"].Value.ToString();
                    if(DataGrid.Rows[i].Cells["chk_exp_date"].Value.ToString()=="0")
                    {
                        isCusIgnoreExp.Checked = false;
                    }
                    else
                    {
                        isCusIgnoreExp.Checked = true;
                    }
                    
                }
            }
    }

        private void CityDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CityDataGrid.RowCount; i++)
            {
                if (CityDataGrid.Rows[i].IsSelected)
                {
                    txtCustomerCity.AdvanceText = CityDataGrid.Rows[i].Cells["ZoneName"].Value.ToString() + ":" + CityDataGrid.Rows[i].Cells["CityName"].Value.ToString();
                    txtCusCCode.AdvanceText = CityDataGrid.Rows[i].Cells["CityCode"].Value.ToString();
                    txtCusZCode.AdvanceText = CityDataGrid.Rows[i].Cells["ZoneCode"].Value.ToString();

                }
            }
        }

        private void CustomerModify_KeyDown(object sender, KeyEventArgs e)
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
            if (e.Control && e.KeyCode == Keys.S)
            {
                updateRecord();
            }
            if (e.KeyCode == Keys.F12)
            {
                txtCusName.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Down)
            {
                DataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Up)
            {
                CityDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Right)
            {
                txtCusName.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Left)
            {
                CityDataGrid.Focus();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CityDataGrid.DataSource = cityRec;
            try
            {
                if (ModeID)
                {
                    (CityDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
                        "CityCode IS NOT NULL" :
                        String.Format("Convert(CityCode, 'System.String') LIKE '" + txtSearch.Text + "%' ");
                }
                else
                {
                    (CityDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
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
            if(e.KeyCode==Keys.Down)
            CityDataGrid.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadGUI.LoadForm(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }

        private void CustomerModify_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
