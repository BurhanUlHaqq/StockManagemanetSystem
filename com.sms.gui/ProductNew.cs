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
    public partial class ProductNew : Form
    {
        public ProductNew()
        {
            InitializeComponent();
        }

        DataTable companyList;
        bool ModeID;

        private void ProductNew_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void callOnLoad()
        {
            ModeID = false;
            txtPSalesTax.Text = ConfigApp.SALES_TEX_PERCENTAGE.ToString();
            companyList = new DataTable();
            DatePicker.CustomFormat = ConfigApp.DATETIME_FORMATE;
            txtProductCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.PRODUCT_NEW).ToString();
            HandlerToDB.SetComboBox(combMedType, ConfigFormNames.PRODUCT_NEW);
            HandlerToDB.SetComboBox(combSTMode, ConfigSelectQueries.SALES_TAX_MODE);
            HandlerToDB.SetComboBox(combDisMode, ConfigSelectQueries.DISCOUNT_MODE);
            HandlerToDB.SetComboBox(combGroup, ConfigSelectQueries.GROUPS_LOAD);
            DataGrid.DataSource = companyList = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_COMPANY);
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
            if (e.Control && e.KeyCode == Keys.S)
            {
                addRecord();
            }
            if (e.KeyCode == Keys.F12)
            {
                txtProductDiscription.Focus();
            }
        }


        private void ProductNew_KeyDown(object sender, KeyEventArgs e)
        {
            callOnKeyDown(e);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataGrid.DataSource = companyList;
            try
            {
                if (ModeID)
                {
                    (DataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
                        "C_Code IS NOT NULL" :
                        String.Format("Convert(C_Code, 'System.String') LIKE '" + txtSearch.Text + "%' ");
                }
                else
                {
                    (DataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearch.Text) ?
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
                    txtCompanyName.AdvanceText = DataGrid.Rows[i].Cells["C_Name"].Value.ToString();
                    txtCompanyCode.AdvanceText = DataGrid.Rows[i].Cells["C_Code"].Value.ToString();
                }
            }
        }

        private void DataGrid_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void resetForm()
        {
            txtProductDiscription.AdvanceText = "";
            txtPack.AdvanceText = "";
            txtRetailPrice.AdvanceText = "";
            txtTradePrice.AdvanceText = "";
            txtPSalesTax.Text = ConfigApp.SALES_TEX_PERCENTAGE.ToString();
            txtBouns.AdvanceText = "";
        }

        private bool isFormValidated()
        {
            if (txtProductDiscription.AdvanceText == "" || txtPack.AdvanceText == "" || txtRetailPrice.AdvanceText == "" || txtTradePrice.AdvanceText == "" || txtBouns.AdvanceText == "")
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
            OBJ_Product.DISCOUNT = Convert.ToInt32(txtBouns.AdvanceText);
            OBJ_Product.DISCOUNT_MODE = Convert.ToInt32((((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[0]);
            OBJ_Product.DISCREPTION = txtProductDiscription.AdvanceText;
            OBJ_Product.GROUP_ID = Convert.ToInt32((((DataRowView)combGroup.SelectedItem).Row.ItemArray)[0]);
            OBJ_Product.MEDICINE_TYPE = Convert.ToInt32((((DataRowView)combMedType.SelectedItem).Row.ItemArray)[0]);
            OBJ_Product.PACK = txtPack.AdvanceText;
            OBJ_Product.PRODUCT_CODE = Convert.ToInt32(txtProductCode.AdvanceText);
            OBJ_Product.RETAIL_PRICE = float.Parse(txtRetailPrice.AdvanceText);
            OBJ_Product.SALES_TAX = Convert.ToInt32(txtPSalesTax.AdvanceText);
            OBJ_Product.SALES_TAX_MODE = Convert.ToInt32((((DataRowView)combSTMode.SelectedItem).Row.ItemArray)[0]);
            OBJ_Product.TRADE_PRICE = float.Parse(txtTradePrice.AdvanceText);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        private void addRecord()
        {
            if (isFormValidated())
            {
                setObject();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.PRODUCT_NEW, ConfigQueryModes.INSERT) + " " + ConfigApp.INSERT_MESSAGE);
                txtProductCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.PRODUCT_NEW).ToString();
                resetForm();
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoadGUI.LoadForm(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }

        private void combSTMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = (((DataRowView)combSTMode.SelectedItem).Row.ItemArray)[1].ToString();
            if (val == CONFIG.TAX_MODE_TP)
            {
                lblPercentageTax.Visible = true;
              //  txtPSalesTax.MaxLength = 2;
            }
            else if (val == CONFIG.TAX_MODE_NILL)
            {
                lblPercentageTax.Visible = false;
             //   txtPSalesTax.Text = "0";
              //  txtPSalesTax.MaxLength = 1;
            }
            else if (val == CONFIG.TAX_MODE_PP)
            {
                lblPercentageTax.Visible = false;
             //   txtPSalesTax.MaxLength = 3;
            }
            else if (val == CONFIG.TAX_MODE_GVD)
            {
                lblPercentageTax.Visible = true;
             //   txtPSalesTax.MaxLength = 2;
            }
            else if (val == CONFIG.TAX_MODE_RP)
            {
                lblPercentageTax.Visible = true;
             //   txtPSalesTax.MaxLength = 2;
            }
        }

        private void combDisMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = (((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[1].ToString();
            if (val == CONFIG.DISCOUNT_MODE_TP)
            {
                lblPercentageDiscount.Visible = true;
              //  txtPDiscount.MaxLength = 2;
            }
            else if (val == CONFIG.DISCOUNT_MODE_NILL)
            {
                lblPercentageDiscount.Visible = false;
                txtPDiscount.Text = "0";
              //  txtPDiscount.MaxLength = 1;
            }
            else if (val == CONFIG.DISCOUNT_MODE_PP)
            {
                lblPercentageDiscount.Visible = false;
            //    txtPDiscount.MaxLength = 3;
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

        private void ProductNew_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
