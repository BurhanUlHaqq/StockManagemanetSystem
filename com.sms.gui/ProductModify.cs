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
    public partial class ProductModify : Form
    {
        public ProductModify()
        {
            InitializeComponent();
        }
        DataTable companyList;
        bool ModeID;
        private void ProductModify_Load(object sender, EventArgs e)
        {
            calOnLoad();

        }

        private void calOnLoad()
        {

            ModeID = false;
            txtPSalesTax.AdvanceText = ConfigApp.SALES_TEX_PERCENTAGE.ToString();
            companyList = new DataTable();
            DatePicker.CustomFormat = ConfigApp.DATETIME_FORMATE;
            HandlerToDB.SetComboBox(combMedType, ConfigFormNames.PRODUCT_NEW);
            HandlerToDB.SetComboBox(combSTMode, ConfigSelectQueries.SALES_TAX_MODE);
            HandlerToDB.SetComboBox(combDisMode, ConfigSelectQueries.DISCOUNT_MODE);
            HandlerToDB.SetComboBox(combGroup, ConfigSelectQueries.GROUPS_LOAD);
            ComDataGrid.DataSource = companyList = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_COMPANY);
            DataGrid.DataSource = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_PRODUCTS);
        }

        private void ProductModify_KeyDown(object sender, KeyEventArgs e)
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
                txtProductDiscription.Focus();
            }
            if (e.KeyCode == Keys.F11)
            {
                ComDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Down)
            {
                DataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Up)
            {
                ComDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Right)
            {
                txtProductDiscription.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Left)
            {
                ComDataGrid.Focus();
            }
        }
        private void resetForm()
        {
            txtProductDiscription.AdvanceText = "";
            txtPack.AdvanceText = "";
            txtRetailPrice.AdvanceText = "";
            txtTradePrice.AdvanceText = "";
            txtPSalesTax.AdvanceText = ConfigApp.SALES_TEX_PERCENTAGE.ToString();
            txtPDiscount.AdvanceText = "";
        }

        private bool isFormValidated()
        {
            if (txtProductDiscription.AdvanceText == "" || txtPack.AdvanceText == "" || txtRetailPrice.AdvanceText == "" || txtTradePrice.AdvanceText == "" || txtPDiscount.AdvanceText == "")
            {
                return false;
            }
            return true;
        }

        private void setObject()
        {
            OBJ_Product.BOUNS = Convert.ToInt32(txtBouns.AdvanceText);
            OBJ_Product.COMPANY_CODE = Convert.ToInt32(txtCompanyCode.AdvanceText);
            OBJ_Product.DATE = DatePicker.Text;
            OBJ_Product.DISCOUNT = Convert.ToInt32(txtPDiscount.AdvanceText);
            OBJ_Product.DISCREPTION = txtProductDiscription.AdvanceText;
            OBJ_Product.TRADE_PRICE = float.Parse(txtTradePrice.AdvanceText);
            OBJ_Product.PACK = txtPack.AdvanceText;
            OBJ_Product.PRODUCT_CODE = Convert.ToInt32(txtProductCode.AdvanceText);
            OBJ_Product.RETAIL_PRICE = float.Parse(txtRetailPrice.AdvanceText);
            OBJ_Product.SALES_TAX = Convert.ToInt32(txtPSalesTax.AdvanceText);
            OBJ_Product.SALES_TAX_MODE = Convert.ToInt32((((DataRowView)combSTMode.SelectedItem).Row.ItemArray)[0]);
            OBJ_Product.GROUP_ID = Convert.ToInt32((((DataRowView)combGroup.SelectedItem).Row.ItemArray)[0]);
            OBJ_Product.MEDICINE_TYPE = Convert.ToInt32((((DataRowView)combMedType.SelectedItem).Row.ItemArray)[0]);
            OBJ_Product.DISCOUNT_MODE = Convert.ToInt32((((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[0]);

        }
        private void updateRecord()
        {
            if (isFormValidated())
            {
                setObject();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.PRODUCT_NEW, ConfigQueryModes.UPDATE) + " " + ConfigApp.UPDATE_MESSAGE);
                calOnLoad();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ComDataGrid.DataSource = companyList;
            try
            {
                if (ModeID)
                {
                    (ComDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
                        "C_Code IS NOT NULL" :
                        String.Format("Convert(C_Code, 'System.String') LIKE '" + txtSearch.Text + "%' ");
                }
                else
                {
                    (ComDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
                        "C_Name IS NOT NULL" :
                        String.Format("Convert(C_Name, 'System.String') LIKE '" + txtSearch.Text + "%'");
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
                ComDataGrid.Focus();
        }

        private void ComDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ComDataGrid.RowCount; i++)
            {
                if (ComDataGrid.Rows[i].IsSelected)
                {
                    txtCompanyName.AdvanceText = ComDataGrid.Rows[i].Cells["C_Name"].Value.ToString();
                    txtCompanyCode.AdvanceText = ComDataGrid.Rows[i].Cells["C_Code"].Value.ToString();
                }
            }
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                    txtCompanyName.AdvanceText = DataGrid.Rows[i].Cells["C_NAME"].Value.ToString();
                    txtCompanyCode.AdvanceText = DataGrid.Rows[i].Cells["COM_CODE"].Value.ToString();
                    txtProductDiscription.AdvanceText = DataGrid.Rows[i].Cells["DISC"].Value.ToString();
                    txtPack.AdvanceText = DataGrid.Rows[i].Cells["PACK"].Value.ToString();
                    txtRetailPrice.AdvanceText = DataGrid.Rows[i].Cells["RP"].Value.ToString();
                    txtTradePrice.AdvanceText = DataGrid.Rows[i].Cells["TP"].Value.ToString(); ;
                    txtPSalesTax.AdvanceText = DataGrid.Rows[i].Cells["S_TAX"].Value.ToString();
                    txtPDiscount.AdvanceText = DataGrid.Rows[i].Cells["DISCOUNT"].Value.ToString();
                    txtBouns.AdvanceText = DataGrid.Rows[i].Cells["BOUNS"].Value.ToString();
                    DatePicker.Value = DateTime.Parse(DataGrid.Rows[i].Cells["P_DATE"].Value.ToString());
                    txtProductCode.AdvanceText = DataGrid.Rows[i].Cells["P_CODE"].Value.ToString();
                    string ID = DataGrid.Rows[i].Cells["M_TYPE"].Value.ToString();
                    for (int j = 0; j < combMedType.Items.Count; j++)
                    {
                        if (ID == (((DataRowView)combMedType.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combMedType.SelectedIndex = j;
                        }
                    }
                    ID = DataGrid.Rows[i].Cells["S_TAX_MODE"].Value.ToString();
                    for (int j = 0; j < combSTMode.Items.Count; j++)
                    {
                        if (ID == (((DataRowView)combSTMode.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combSTMode.SelectedIndex = j;
                        }
                    }
                    ID = DataGrid.Rows[i].Cells["DIS_MODE"].Value.ToString();
                    for (int j = 0; j < combDisMode.Items.Count; j++)
                    {
                        if (ID == (((DataRowView)combDisMode.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combDisMode.SelectedIndex = j;
                        }
                    }
                    ID = DataGrid.Rows[i].Cells["GROUPS"].Value.ToString();
                    for (int j = 0; j < combGroup.Items.Count; j++)
                    {
                        if (ID == (((DataRowView)combGroup.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combGroup.SelectedIndex = j;
                        }
                    }
                }
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////Authentications/////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void combSTMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = (((DataRowView)combSTMode.SelectedItem).Row.ItemArray)[1].ToString();
            if (val == CONFIG.TAX_MODE_TP)
            {
                lblPercentageTax.Visible = true;
               // txtPSalesTax.MaxLength = 2;
            }
            else if (val == CONFIG.TAX_MODE_NILL)
            {
                lblPercentageTax.Visible = false;
              //  txtPSalesTax.AdvanceText = "0";
              //  txtPSalesTax.MaxLength = 1;
            }
            else if (val == CONFIG.TAX_MODE_PP)
            {
                lblPercentageTax.Visible = false;
               // txtPSalesTax.MaxLength = 3;
            }
            else if (val == CONFIG.TAX_MODE_GVD)
            {
                lblPercentageTax.Visible = true;
              //  txtPSalesTax.MaxLength = 2;
            }
            else if (val == CONFIG.TAX_MODE_RP)
            {
                lblPercentageTax.Visible = true;
               // txtPSalesTax.MaxLength = 2;
            }
        }

        private void combDisMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = (((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[1].ToString();
            if (val == CONFIG.DISCOUNT_MODE_TP)
            {
                lblPercentageDiscount.Visible = true;
               // txtPDiscount.MaxLength = 2;
            }
            else if (val == CONFIG.DISCOUNT_MODE_NILL)
            {
                lblPercentageDiscount.Visible = false;
                txtPDiscount.AdvanceText = "0";
              //  txtPDiscount.MaxLength = 1;
            }
            else if (val == CONFIG.DISCOUNT_MODE_PP)
            {
                lblPercentageDiscount.Visible = false;
              //  txtPDiscount.MaxLength = 3;
            }
            else if (val == CONFIG.DISCOUNT_MODE_GVD)
            {
                lblPercentageDiscount.Visible = true;
             //   txtPDiscount.MaxLength = 2;
            }
            else if (val == CONFIG.DISCOUNT_MODE_RP)
            {
                lblPercentageDiscount.Visible = true;
             //   txtPDiscount.MaxLength = 2;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void ProductModify_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
