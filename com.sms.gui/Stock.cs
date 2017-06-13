using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.sms.config;
using com.sms.handler;
using com.sms.objects;

namespace com.sms.gui
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }
        private enum Stage
        {
            Zero = 0,
            one = 1,
            two = 2,
            three = 3,
            locked = 4,
            //it will stop to going to add stock
            NoProduct = 5
        }
        private Stage currentstage;
        private Stage CurrentStage
        {
            get { return currentstage; }
            set { currentstage = value; }
        }
        private void Stock_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel2.Visible = false;
            panel1.Visible = true;
            CurrentStage = Stage.one;
            callOnLoad();
        }
        DataTable companyList;
        DataTable productList;
        bool ModeID;
        bool ModeIDPRO;
        private void callOnLoad()
        {
            lblModePro.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
            ModeIDPRO = true;
            lblMode.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
            ModeID = true;
            companyList = new DataTable();
            productList = new DataTable();
            ProDataGrid.DataSource = productList = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_PRODUCTS);
            ComDataGrid.DataSource = companyList = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_COMPANY);
            DateExpiry.CustomFormat = ConfigApp.DATETIME_EXPIRY_FORMATE;
            DateTime now = DateTime.Now;
            DateExpiry.MinDate = new DateTime(now.Year + ConfigApp.STOCK_EXPIRY_MIN_Y, now.Month + ConfigApp.STOCK_EXPIRY_MIN_M, now.Day + ConfigApp.STOCK_EXPIRY_MIN_D);
            dateInvoice.CustomFormat = ConfigApp.DATETIME_FORMATE;
            dateInvoice.MinDate = DateTime.Now;
            HandlerToDB.SetComboBox(combSTMode, ConfigSelectQueries.SALES_TAX_MODE);
            HandlerToDB.SetComboBox(combDisMode, ConfigSelectQueries.DISCOUNT_MODE);
            txtStockCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.STOCK_NEW).ToString();
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
        private void Stock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                lblMode.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
                ModeID = true;
                txtSearch.Focus();
                lblModePro.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
                ModeIDPRO = true;
                txtProSearch.Focus();

            }
            else if (e.KeyCode == Keys.F9)
            {
                lblMode.Text = ConfigApp.SEARCH_MODE_TEXT_MESSAGE;
                ModeID = false;
                txtSearch.Focus();
                lblModePro.Text = ConfigApp.SEARCH_MODE_TEXT_MESSAGE;
                ModeIDPRO = false;
                txtProSearch.Focus();

            }
            if (e.Control && e.KeyCode == Keys.S)
            {
                addRecord();
            }
            if (e.KeyCode == Keys.F12)
            {
                txtInvoice.Focus();
            }
            if (e.KeyCode == Keys.F11)
            {
                if (ComDataGrid.Focused)
                    ProDataGrid.Focus();
                else
                    ComDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Down)
            {
                txtInvoice.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Up)
            {
                ComDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Right)
            {
                ProDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Left)
            {
                ComDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                nextStage();
            }
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                PreviousStage();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (CurrentStage != Stage.locked && txtInvoice.Enabled!=false)
                {
                    if (txtInvoice.AdvanceText != "")
                    {
                        setInvoice();
                    }
                }
                else if(txtBatchNo.Enabled!=false)
                {
                    setBatch();
                }
            }
        }
        private void setInvoice()
        {
            //Check if invoice already exist or not
            OBJ_Stock.INVOICE_NO = txtInvoice.AdvanceText;
            OBJ_Stock.COMPANY_CODE =Convert.ToInt32( txtComCode.AdvanceText);
            if (HandlerToDB.GetCount(ConfigSelectQueryModes.NO_OF_INVOICES) == 0)
            {
                txtInvoice.Enabled = false;
                txtBatchNo.Enabled = true;
                txtBatchNo.Focus();
                CurrentStage = Stage.locked;
            }
            else
            {
                txtInvoice.AdvanceText = "";
                HANDLER.ShowMessage(txtMessage, "Invoice Already Exist in "+ ComDataGrid.Rows[ComDataGrid.SelectedRows[0].Index].Cells["C_Name"].Value.ToString());
            }
        }

        private void setBatch()
        {
            //Check if invoice already exist or not
            OBJ_Stock.BATCH_NO = txtBatchNo.AdvanceText;
            OBJ_Stock.COMPANY_CODE = Convert.ToInt32(txtComCode.AdvanceText);
            if (HandlerToDB.GetCount(ConfigSelectQueryModes.NO_OF_BATCHS) == 0)
            {
                txtQuantity.Enabled = true;
                dateInvoice.Enabled = true;
                DateExpiry.Enabled = true;                
                gbActions.Enabled = true;
                gPricing.Enabled = true;
                txtBatchNo.Enabled = false;
            }
            else
            {
                txtBatchNo.AdvanceText = "";
                HANDLER.ShowMessage(txtMessage, "Batch Already Exist in "+ComDataGrid.Rows[ComDataGrid.SelectedRows[0].Index].Cells["C_Name"].Value.ToString());
            }
        }
        private void ComDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ComDataGrid.RowCount; i++)
            {
                if (ComDataGrid.Rows[i].IsSelected)
                {
                    string ID = ComDataGrid.Rows[i].Cells["C_Code"].Value.ToString();
                    ProDataGrid.DataSource = productList;
                    try
                    {
                        (ProDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(ID) ?
                            "COM_CODE IS NOT NULL" :
                            String.Format("Convert(COM_CODE, 'System.String') = '" + ID + "'");
                        stage1.Text = "Select Company | " + ProDataGrid.RowCount + " Products";
                        if (ProDataGrid.RowCount == 0)
                        {
                            CurrentStage = Stage.NoProduct;
                            clearForm();
                        }
                        else
                        {
                            CurrentStage = Stage.one;
                        }
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
            }
        }
        private void txtProSearch_TextChanged(object sender, EventArgs e)
        {
            ProDataGrid.DataSource = productList;
            try
            {
                if (ModeIDPRO)
                {
                    (ProDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtProSearch.Text) ?
                        "P_CODE IS NOT NULL" :
                        String.Format("Convert(P_CODE, 'System.String') LIKE '" + txtProSearch.Text + "%' ");
                }
                else
                {
                    (ProDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtProSearch.Text) ?
                        "DISC IS NOT NULL" :
                        String.Format("Convert(DISC, 'System.String') LIKE '" + txtProSearch.Text + "%'");
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
                ComDataGrid.Focus();
            }
        }
        private void txtProSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ProDataGrid.Focus();
            }
        }
        private void ProDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ProDataGrid.RowCount; i++)
            {
                if (ProDataGrid.Rows[i].IsSelected)
                {
                    txtComCode.AdvanceText = ProDataGrid.Rows[i].Cells["COM_CODE"].Value.ToString();
                    txtRetailPrice.AdvanceText = ProDataGrid.Rows[i].Cells["RP"].Value.ToString();
                    txtTradePrice.AdvanceText = ProDataGrid.Rows[i].Cells["TP"].Value.ToString(); ;
                    txtSalesTax.AdvanceText = ProDataGrid.Rows[i].Cells["S_TAX"].Value.ToString();
                    txtDiscount.AdvanceText = ProDataGrid.Rows[i].Cells["DISCOUNT"].Value.ToString();
                    txtBouns.AdvanceText = ProDataGrid.Rows[i].Cells["BOUNS"].Value.ToString();
                    txtProCode.AdvanceText = ProDataGrid.Rows[i].Cells["P_CODE"].Value.ToString();
                    string ID = ProDataGrid.Rows[i].Cells["S_TAX_MODE"].Value.ToString();
                    for (int j = 0; j < combSTMode.Items.Count; j++)
                    {
                        if (ID == (((DataRowView)combSTMode.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combSTMode.SelectedIndex = j;
                        }
                    }
                    ID = ProDataGrid.Rows[i].Cells["DIS_MODE"].Value.ToString();

                    for (int j = 0; j < combDisMode.Items.Count; j++)
                    {
                        if (ID == (((DataRowView)combDisMode.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combDisMode.SelectedIndex = j;
                        }
                    }
                    return;
                }
            }
        }
        private void clearForm()
        {
            //txtComCode.AdvanceText = "";
            txtRetailPrice.AdvanceText = "";
            txtTradePrice.AdvanceText = "";
            txtSalesTax.AdvanceText = "";
            txtDiscount.AdvanceText = "";
            txtBouns.AdvanceText = "";
            //  txtProCode.AdvanceText = "";
            combSTMode.SelectedIndex = 0;
            combDisMode.SelectedIndex = 0;
            txtQuantity.AdvanceText = "";
            txtBatchNo.AdvanceText = "";
            // txtInvoice.AdvanceText = "";
        }
        private void setObjects()
        {
            OBJ_Stock.STOCK_CODE = Convert.ToInt32(txtStockCode.AdvanceText);
            OBJ_Stock.COMPANY_CODE = Convert.ToInt32(txtComCode.AdvanceText);
            OBJ_Stock.PRODUCT_CODE = Convert.ToInt32(txtProCode.AdvanceText);
            OBJ_Stock.STOCK_DATE = dateInvoice.Text;
            OBJ_Stock.INVOICE_NO = txtInvoice.AdvanceText;
            OBJ_Stock.EXPIRY_DATE = DateExpiry.Text;
            OBJ_Stock.BATCH_NO = txtBatchNo.AdvanceText;
            OBJ_Stock.QUANTITY = Convert.ToInt32(txtQuantity.AdvanceText);
            OBJ_Stock.DISCOUNT_VALUE = float.Parse(txtDiscountValue.AdvanceText);
            OBJ_Stock.SALES_TAX_VALUE = float.Parse(txtTaxVal.AdvanceText);
            OBJ_Stock.GROSS_VALUE = float.Parse(txtGrossValue.AdvanceText);
            OBJ_Stock.NET_VALUE = float.Parse(txtNetValue.AdvanceText);
            OBJ_Stock.BOUNUS = Convert.ToInt32(txtBouns.AdvanceText);
            OBJ_Stock.TRADE_PRICE = float.Parse(txtTradePrice.AdvanceText);
            OBJ_Stock.RETAIL_PRICE = float.Parse(txtRetailPrice.AdvanceText);
            OBJ_Stock.SALES_TAX = Convert.ToInt32(txtSalesTax.AdvanceText);
            OBJ_Stock.SALES_TAX_MODE = Convert.ToInt32((((DataRowView)combSTMode.SelectedItem).Row.ItemArray)[0]);
            OBJ_Stock.DISCOUNT = float.Parse(txtDiscount.AdvanceText);
            OBJ_Stock.DISCOUNT_MODE = Convert.ToInt32((((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[0]);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (CurrentStage == Stage.locked)
            {
                if (DialogResult.OK == MessageBox.Show("You are entering Stock Do you realy want to Exit?", "It is Not Recommended!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    LoadGUI.LoadForm(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
                }
            }
            else
            {
                LoadGUI.LoadForm(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRecord();
        }
        private void addRecord()
        {
            if (CurrentStage == Stage.locked)
            {
                if (formValidate())
                {
                    setObjects();
                    HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.STOCK_NEW, ConfigQueryModes.INSERT) + " " + ConfigApp.INSERT_MESSAGE);
                    // callOnLoad();
                    clearForm();
                    txtStockCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.STOCK_NEW).ToString();
                    DataGrid.DataSource = HandlerToDB.GetDataTableWhere(ConfigSelectQueryModes.CURRENT_INVOICE_MODE);
                    txtProCode.AdvanceText = "0";
                    txtBatchNo.Enabled = true;
                    txtBatchNo.Focus();
                }
                else
                {
                    HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
                }
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, "Enter Invoice No To Proced");
            }
        }
        private bool formValidate()
        {
            if (txtQuantity.AdvanceText == "0" || txtBatchNo.AdvanceText == "" || txtInvoice.AdvanceText == "" || txtComCode.AdvanceText == "0" || txtTradePrice.AdvanceText == "0" || txtProCode.AdvanceText == "0")
            {
                return false;
            }
            return true;
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
                txtSalesTax.Enabled = true;
                // txtSalesTax.MaxLength = 2;
            }
            else if (val == CONFIG.TAX_MODE_NILL)
            {
                lblPercentageTax.Visible = false;
                txtSalesTax.Enabled = false;
                txtSalesTax.AdvanceText = "0";
                // txtSalesTax.MaxLength = 1;
            }
            else if (val == CONFIG.TAX_MODE_PP)
            {
                lblPercentageTax.Visible = false;
                txtSalesTax.Enabled = true;
                //  txtSalesTax.MaxLength = 3;
            }
            else if (val == CONFIG.TAX_MODE_GVD)
            {
                lblPercentageTax.Visible = true;
                txtSalesTax.Enabled = true;
                //  txtSalesTax.MaxLength = 2;
            }
            else if (val == CONFIG.TAX_MODE_RP)
            {
                lblPercentageTax.Visible = true;
                txtSalesTax.Enabled = true;
                // txtSalesTax.MaxLength = 2;
            }
            calculations();
        }
        private void combDisMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = (((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[1].ToString();
            if (val == CONFIG.DISCOUNT_MODE_TP)
            {
                lblPercentageDiscount.Visible = true;
                txtDiscount.Enabled = true;
                //   txtDiscount.MaxLength = 2;
            }
            else if (val == CONFIG.DISCOUNT_MODE_NILL)
            {
                lblPercentageDiscount.Visible = false;
                txtDiscount.Enabled = false;
                txtDiscount.AdvanceText = "0";
                //  txtDiscount.AdvanceText = "0";
                //   txtDiscount.MaxLength = 1;
            }
            else if (val == CONFIG.DISCOUNT_MODE_PP)
            {
                lblPercentageDiscount.Visible = false;
                txtDiscount.Enabled = true;
                //  txtDiscount.MaxLength = 3;
            }
            else if (val == CONFIG.DISCOUNT_MODE_GVD)
            {
                lblPercentageDiscount.Visible = true;
                txtDiscount.Enabled = true;
                //   txtDiscount.MaxLength = 2;
            }
            else if (val == CONFIG.DISCOUNT_MODE_RP)
            {
                lblPercentageDiscount.Visible = true;
                txtDiscount.Enabled = true;
                //   txtDiscount.MaxLength = 2;
            }
            calculations();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            nextStage();
        }
        private void nextStage()
        {
            switch (CurrentStage)
            {
                case Stage.Zero:
                    CurrentStage = Stage.one;
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    break;
                case Stage.one:
                    CurrentStage = Stage.two;
                    panel1.Visible = false;
                    panel2.Visible = true;
                    panel3.Visible = false;
                    break;
                case Stage.two:
                    CurrentStage = Stage.three;
                    panel1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = true;
                    txtInvoice.Focus();
                    gbActions.Enabled = false;
                    break;
                case Stage.three:
                    break;
                case Stage.locked:
                    //to select another product
                    panel2.Visible = false;
                    panel3.Visible = true;
                    break;
                case Stage.NoProduct:
                    HANDLER.ShowMessage(txtMessage, "Select company having atleast 1 one product");
                    break;
                default:
                    break;
            }
        }
        private void PreviousStage()
        {
            switch (CurrentStage)
            {
                case Stage.one:
                    break;
                case Stage.two:
                    CurrentStage = Stage.one;
                    panel1.Visible = true;
                    panel2.Visible = false;
                    panel3.Visible = false;
                    break;
                case Stage.three:
                    CurrentStage = Stage.two;
                    panel3.Visible = false;
                    panel2.Visible = true;
                    panel1.Visible = false;
                    break;
                case Stage.locked:
                    //to change product
                    panel3.Visible = false;
                    panel2.Visible = true;
                    break;
                case Stage.NoProduct:
                    break;
                default:
                    break;
            }
        }
        private void btnNext2_Click(object sender, EventArgs e)
        {
            nextStage();
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
            PreviousStage();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            PreviousStage();
        }
        private void txtTradePrice_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }
        private void txtQuantity_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }
        private void txtSalesTax_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }
        private void txtDiscount_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }
        private void calculations()
        {
            if (CurrentStage == Stage.locked)
            {
                //gross and net 
                txtNetValue.AdvanceText = txtGrossValue.AdvanceText = (Convert.ToInt32(txtQuantity.AdvanceText) * float.Parse(txtTradePrice.AdvanceText)).ToString();
                //find tax mod 
                string val = (((DataRowView)combSTMode.SelectedItem).Row.ItemArray)[1].ToString();
                //calculate acording to sales tax mod
                if (val == CONFIG.TAX_MODE_NILL)
                {
                    txtTaxVal.AdvanceText = "0";
                }
                else if (val == CONFIG.TAX_MODE_PP)
                {
                    txtTaxVal.AdvanceText = ((Convert.ToInt32(txtSalesTax.AdvanceText)) * (Convert.ToInt32(txtQuantity.AdvanceText))).ToString();
                    txtNetValue.AdvanceText = (float.Parse(txtGrossValue.AdvanceText) + float.Parse(txtTaxVal.AdvanceText)).ToString();
                }
                else if (val == CONFIG.TAX_MODE_TP)
                {

                }
                else if (val == CONFIG.TAX_MODE_GVD)
                {

                }
                else if (val == CONFIG.TAX_MODE_RP)
                {

                }
                //find discount mod
                val = (((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[1].ToString();
                //calculate acording to Discount mod
                if (val == CONFIG.DISCOUNT_MODE_NILL)
                {
                    txtDiscountValue.AdvanceText = "0";
                }
                else if (val == CONFIG.DISCOUNT_MODE_PP)
                {
                    txtDiscountValue.AdvanceText = ((Convert.ToInt32(txtDiscount.AdvanceText)) * (Convert.ToInt32(txtQuantity.AdvanceText))).ToString();
                    txtNetValue.AdvanceText = (float.Parse(txtNetValue.AdvanceText) - float.Parse(txtDiscountValue.AdvanceText)).ToString();
                }
                else if (val == CONFIG.DISCOUNT_MODE_TP)
                {

                }
                else if (val == CONFIG.DISCOUNT_MODE_GVD)
                {

                }
                else if (val == CONFIG.DISCOUNT_MODE_RP)
                {

                }
            }
        }
        private void Stock_FontChanged(object sender, EventArgs e)
        {

            HANDLER.ShowOnMidTop(panel2, this.Width);
            HANDLER.ShowOnMidTop(panel1, this.Width);
            HANDLER.ShowOnMidTop(panel3, this.Width);
        }
        private void btnOther_Click(object sender, EventArgs e)
        {
            PreviousStage();
        }
        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            CurrentStage = Stage.Zero;
            txtInvoice.Enabled = true;
            txtInvoice.AdvanceText = "";
            nextStage();
        }
    }
}
