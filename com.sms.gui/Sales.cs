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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }
        private enum Stage
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Locked = 5,
            Failed = 6
        }
        private Stage CurrentStage
        {
            get { return currentSgate; }
            set { currentSgate = value; }
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }
        bool ModeID;
        DataTable cityRec;
        DataTable cusREC;
        DataTable smREC;
        DataTable companyList;
        DataTable ProREC;
        DataTable stockREC;
        private Stage currentSgate;
        private bool LicenseExpLock;
        private bool SalesManLock;
        private bool CustomerLock;
        private bool ModeIDPro;
        private bool ProductLock;
        private void callOnLoad()
        {
            HandlerToDB.SetComboBox(combMedType, ConfigFormNames.PRODUCT_NEW);
            HandlerToDB.SetComboBox(combSTMode, ConfigSelectQueries.SALES_TAX_MODE);
            HandlerToDB.SetComboBox(combDisMode, ConfigSelectQueries.DISCOUNT_MODE);
            stockDataGrid.DataSource = stockREC = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_STOCK);
            proDataGrid.DataSource = ProREC = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_PRODUCTS);
            ComDataGrid.DataSource = companyList = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_COMPANY);
            SalesManDataGrid.DataSource = smREC = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_SALES_MAN);
            cusDataGrid.DataSource = cusREC = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_CUSTOMER);
            ModeID = false;
            cityRec = new DataTable();
            CityDataGrid.DataSource = cityRec = HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_CITY);
            // cusDataGrid.Focus();
            CurrentStage = Stage.One;
            Stage1.Visible = true;
            lblSearchPro.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
            ModeIDPro = true;
            lblMode.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
            lblSearchCom.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
            ModeID = true;
            //CityDataGrid.Focus();
            dateInvoice.CustomFormat = ConfigApp.DATETIME_FORMATE;
            txtSalesNo.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.SALES).ToString();
            txtInvoice.AdvanceText = HandlerToDB.GetNewID(ConfigSelectQueryModes.MAX_INVOICE).ToString();
            txtSearch.Focus();
        }
        private void Sales_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(Stage1, this.Width);
            HANDLER.ShowOnMidTop(Stage2, this.Width);
            HANDLER.ShowOnMidTop(Stage3, this.Width);
            HANDLER.ShowOnMidTop(Stage4, this.Width);
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
        private void Sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F8)
            {
                lblSearchPro.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
                ModeIDPro = true;
                txtSearchPro.Focus();
            }
            else if (e.KeyCode == Keys.F8)
            {
                lblMode.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
                lblSearchCom.Text = ConfigApp.SEARCH_MODE_ID_MESSAGE;
                ModeID = true;
                txtSearch.Focus();
                txtSearchCom.Focus();
            }
            if (e.Control && e.KeyCode == Keys.F9)
            {
                lblSearchPro.Text = ConfigApp.SEARCH_MODE_TEXT_MESSAGE;
                ModeIDPro = false;
                txtSearchPro.Focus();
            }
            else if (e.KeyCode == Keys.F9)
            {
                lblMode.Text = ConfigApp.SEARCH_MODE_TEXT_MESSAGE;
                lblSearchCom.Text = ConfigApp.SEARCH_MODE_TEXT_MESSAGE;
                ModeID = false;
                txtSearch.Focus();
                txtSearchCom.Focus();
            }
            if (e.Control && e.KeyCode == Keys.S)
            {

            }
            if (e.KeyCode == Keys.F12)
            {

            }
            if (e.Control && e.KeyCode == Keys.Down)
            {
                stockDataGrid.Focus();
                cusDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Up)
            {
                CityDataGrid.Focus();
                ComDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Right)
            {
                groupBox1.Focus();//foucs on payment method
                proDataGrid.Focus();
            }
            if (e.Control && e.KeyCode == Keys.Left)
            {
                CityDataGrid.Focus();
                ComDataGrid.Focus();

            }
        }
        private void CityDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cusDataGrid.Focus();
            }
        }
        private void cusDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                groupBox1.Focus();
            }
        }
        private void ComDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                proDataGrid.Focus();
            }
        }
        private void proDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            stockDataGrid.Focus();
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                CityDataGrid.Focus();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (formValidate())
            {
                setObjects();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.SALES, ConfigQueryModes.INSERT) + " " + ConfigApp.INSERT_MESSAGE);
                currentSgate = Stage.Locked;
                clearForm();
                btnNewInvoice.Enabled = true;
                txtSalesNo.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.SALES).ToString();
                salesDataGrid.DataSource = HandlerToDB.GetDataTableWhere(ConfigSelectQueryModes.CURRENT_SALE_INVOICE_MODE);
            }
            else
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
            }
        }

        private void clearForm()
        {
            txtQuantity.AdvanceText = "";

        }

        private void setObjects()
        {
            OBJ_Sales.BATCH_NO = txtBatchNo.AdvanceText;
            OBJ_Sales.BOUNUS = Convert.ToInt32(txtBouns.AdvanceText);
            if (chIgnore.Checked)
                OBJ_Sales.CHECKC_IGNORE = 1;
            else
                OBJ_Sales.CHECKC_IGNORE = 0;
            OBJ_Sales.CUSTOMER_CODE = Convert.ToInt32(txtCusId.AdvanceText);
            OBJ_Sales.CUSTOMER_ZONE_CODE = Convert.ToInt32(cusDataGrid.Rows[cusDataGrid.SelectedRows[0].Index].Cells["z_code"].Value.ToString());
            OBJ_Sales.DISCOUNT = float.Parse(txtDiscount.AdvanceText);
            OBJ_Sales.DISCOUNT_MODE = Convert.ToInt32((((DataRowView)combDisMode.SelectedItem).Row.ItemArray)[0]);
            OBJ_Sales.DISCOUNT_VALUE = float.Parse(txtDiscountValue.AdvanceText);
            OBJ_Sales.GROSS_VALUE = float.Parse(txtGrossValue.AdvanceText);
            OBJ_Sales.INVOICE_NO = Convert.ToInt32(txtInvoice.AdvanceText);
            OBJ_Sales.MEDICINE_TYPE_CODE = Convert.ToInt32((((DataRowView)combMedType.SelectedItem).Row.ItemArray)[0]);
            OBJ_Sales.NET_VALUE = float.Parse(txtNetValue.AdvanceText);
            OBJ_Sales.PRODUCT_CODE = Convert.ToInt32(proDataGrid.Rows[proDataGrid.SelectedRows[0].Index].Cells["P_CODE"].Value.ToString());
            OBJ_Sales.PRODUCT_NAME = proDataGrid.Rows[proDataGrid.SelectedRows[0].Index].Cells["DISC"].Value.ToString();
            OBJ_Sales.QUANTITY = Convert.ToInt32(txtQuantity.AdvanceText);
            OBJ_Sales.RETAIL_PRICE = float.Parse(txtRetailPrice.AdvanceText);
            OBJ_Sales.SALES_DATE = dateInvoice.Text;
            OBJ_Sales.SALES_MAN_CODE = Convert.ToInt32(SalesManDataGrid.Rows[SalesManDataGrid.SelectedRows[0].Index].Cells["sm_code"].Value.ToString());
            OBJ_Sales.SALES_MAN_ZONE_CODE = Convert.ToInt32(SalesManDataGrid.Rows[SalesManDataGrid.SelectedRows[0].Index].Cells["z_code"].Value.ToString());
            OBJ_Sales.SALES_NO = Convert.ToInt32(txtSalesNo.AdvanceText);
            OBJ_Sales.SALES_TAX = Convert.ToInt32(txtSalesTax.AdvanceText);
            OBJ_Sales.SALES_TAX_MODE = Convert.ToInt32((((DataRowView)combSTMode.SelectedItem).Row.ItemArray)[0]);
            OBJ_Sales.SALES_TAX_VALUE = float.Parse(txtTaxVal.AdvanceText);
        }

        private bool formValidate()
        {
            if (txtQuantity.AdvanceText == "0")
            {
                return false;
            }
            return true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            nextStage();
        }
        private void btnBack2_Click(object sender, EventArgs e)
        {
            previousStage();
        }
        private void btnNext2_Click(object sender, EventArgs e)
        {
            nextStage();
        }
        private void btnBack3_Click(object sender, EventArgs e)
        {
            previousStage();
        }
        private void btnNext3_Click(object sender, EventArgs e)
        {
            nextStage();
        }
        private void chIgnore_CheckedChanged(object sender, EventArgs e)
        {
            if (chIgnore.Checked)
            {
                LicenseExpLock = false;
            }
            else
            {
                LicenseExpLock = true;
            }
        }
        //
        //Selection Changed
        //
        private void CityDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CityDataGrid.RowCount; i++)
            {
                if (CityDataGrid.Rows[i].IsSelected)
                {
                    string CusCity = CityDataGrid.Rows[i].Cells["CityCode"].Value.ToString();
                    string CusZone = CityDataGrid.Rows[i].Cells["ZoneCode"].Value.ToString();
                    cusDataGrid.DataSource = cusREC;
                    try
                    {
                        (cusDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(CusCity) ?
                            "city_code IS NOT NULL" :
                            String.Format("Convert(city_code, 'System.String') = '" + CusCity + "' ");
                        if (cusDataGrid.RowCount == 0)
                        {
                            lblWarn.Visible = false;
                            chIgnore.Visible = false;
                            LicenseExpLock = false;
                            chIgnore.Checked = false;
                            CustomerLock = true;
                        }
                        else
                        {
                            LicenseExpLock = false;
                            CustomerLock = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                    SalesManDataGrid.DataSource = smREC;
                    try
                    {
                        (SalesManDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(CusZone) ?
                            "z_code IS NOT NULL" :
                            String.Format("Convert(z_code, 'System.String') = '" + CusZone + "' ");
                        //show available Sales Man
                        groupBox3.Text = "Select City and Zone | " + SalesManDataGrid.RowCount + " Sales Men";
                        if (SalesManDataGrid.RowCount == 0)
                        {
                            groupBox3.ForeColor = Color.Red;
                            SalesManLock = true;
                        }
                        else
                        {
                            groupBox3.ForeColor = Color.Black;
                            SalesManLock = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                    break;
                }
            }
        }
        private void ComDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ComDataGrid.RowCount; i++)
            {
                if (ComDataGrid.Rows[i].IsSelected)
                {
                    string ComID = ComDataGrid.Rows[i].Cells["C_Code"].Value.ToString();
                    proDataGrid.DataSource = ProREC;
                    try
                    {
                        (proDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(ComID) ?
                            "COM_CODE IS NOT NULL" :
                            String.Format("Convert(COM_CODE, 'System.String') = '" + ComID + "' ");
                        if (proDataGrid.RowCount == 0)
                        {
                            stockDataGrid.DataSource = null;
                            ProductLock = true;
                        }
                        else
                        {
                            ProductLock = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                    break;
                }
            }
        }
        private void proDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < proDataGrid.RowCount; i++)
            {
                if (proDataGrid.Rows[i].IsSelected)
                {
                    string ProID = proDataGrid.Rows[i].Cells["P_CODE"].Value.ToString();
                    txtProName.AdvanceText = proDataGrid.Rows[i].Cells["DISC"].Value.ToString() + " | " + proDataGrid.Rows[i].Cells["C_NAME"].Value.ToString();
                    string ID = proDataGrid.Rows[i].Cells["TYPE_CODE"].Value.ToString();
                    for (int j = 0; j < combMedType.Items.Count; j++)
                    {
                        if (ID == (((DataRowView)combMedType.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combMedType.SelectedIndex = j;
                        }
                    }
                    stockDataGrid.DataSource = stockREC;
                    try
                    {
                        (stockDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(ProID) ?
                            "p_CODE IS NOT NULL" :
                            String.Format("Convert(p_CODE, 'System.String') = '" + ProID + "' ");
                        // groupBox3.Text = "Select City and Zone | " + SalesManDataGrid.RowCount + " Sales Men";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                    break;
                }
            }
        }
        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cusDataGrid.RowCount; i++)
            {
                if (cusDataGrid.Rows[i].IsSelected)
                {
                    string Expirey = cusDataGrid.Rows[i].Cells["lic_exp_date"].Value.ToString();
                    DateTime exp = DateTime.Parse(Expirey);
                    lblWarn.Text = "";
                    if (exp < DateTime.Now)
                    {
                        string Ignore = cusDataGrid.Rows[i].Cells["chk_exp_date"].Value.ToString();
                        if (Ignore != "0")
                        {
                            lblWarn.Text = "Licence Expired" + Environment.NewLine + "But Ignored";
                            chIgnore.Visible = false;
                            LicenseExpLock = false;
                            chIgnore.Checked = false;
                            lblWarn.Visible = true;
                        }
                        else
                        {
                            lblWarn.Text = "Licence Expired";
                            lblWarn.Visible = true;
                            chIgnore.Visible = true;
                            chIgnore.Checked = false;
                            LicenseExpLock = true;
                        }
                    }
                    else
                    {
                        lblWarn.Text = "";
                        lblWarn.Visible = false;
                        chIgnore.Visible = false;
                        chIgnore.Checked = false;
                    }
                    txtCusId.AdvanceText = cusDataGrid.Rows[i].Cells["cust_code"].Value.ToString();
                    txtCusName.AdvanceText = cusDataGrid.Rows[i].Cells["cus_name"].Value.ToString();
                    txtCusAddress.AdvanceText = cusDataGrid.Rows[i].Cells["addr"].Value.ToString();
                    break;
                }
            }
        }
        private void txtSearchCom_TextChanged(object sender, EventArgs e)
        {
            ComDataGrid.DataSource = companyList;
            try
            {
                if (ModeID)
                {
                    (ComDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearchCom.Text) ?
                        "C_Code IS NOT NULL" :
                        String.Format("Convert(C_Code, 'System.String') LIKE '" + txtSearchCom.Text + "%' ");
                }
                else
                {
                    (ComDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearchCom.Text) ?
                        "C_Name IS NOT NULL" :
                        String.Format("Convert(C_Name, 'System.String') LIKE '%" + txtSearchCom.Text + "%'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void txtSearchPro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ComID = ComDataGrid.Rows[ComDataGrid.SelectedRows[0].Index].Cells["C_Code"].Value.ToString();
                if (txtSearchPro.Text != "")
                {
                    if (ModeIDPro)
                    {
                        (proDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearchPro.Text) ?
                            "P_CODE IS NOT NULL" :
                            String.Format("(Convert(P_CODE, 'System.String') = '" + txtSearchPro.Text + "%') and Convert(COM_CODE, 'System.String') = '" + ComID + "' ");
                    }
                    else
                    {
                        (proDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(txtSearchPro.Text) ?
                            "DISC IS NOT NULL" :
                            String.Format("(Convert(DISC, 'System.String') LIKE '%" + txtSearchPro.Text + "%' OR Convert(PACK, 'System.String') LIKE '%" + txtSearchPro.Text + "%') and Convert(COM_CODE, 'System.String') = '" + ComID + "' ");
                    }
                }
                else
                {
                    proDataGrid.DataSource = ProREC;
                    try
                    {
                        (proDataGrid.DataSource as DataTable).DefaultView.RowFilter = String.IsNullOrEmpty(ComID) ?
                            "COM_CODE IS NOT NULL" :
                            String.Format("Convert(COM_CODE, 'System.String') = '" + ComID + "' ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.StackTrace);
                    }
                }
                if (proDataGrid.RowCount == 0)
                {
                    ProductLock = true;
                    stockDataGrid.DataSource = null;
                }
                else
                {
                    ProductLock = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }
        private void SalesManDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < SalesManDataGrid.RowCount; i++)
            {
                if (SalesManDataGrid.Rows[i].IsSelected)
                {
                    txtSMID.AdvanceText = SalesManDataGrid.Rows[i].Cells["sm_code"].Value.ToString();
                    txtSMName.AdvanceText = SalesManDataGrid.Rows[i].Cells["sm_name"].Value.ToString();
                }
            }
        }
        private void stockDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < stockDataGrid.RowCount; i++)
            {
                if (stockDataGrid.Rows[i].IsSelected)
                {
                    txtBatchNo.AdvanceText = stockDataGrid.Rows[i].Cells["batch_no"].Value.ToString();
                    txtTradePrice.AdvanceText = stockDataGrid.Rows[i].Cells["tP"].Value.ToString();
                    txtRetailPrice.AdvanceText = stockDataGrid.Rows[i].Cells["RP"].Value.ToString();
                    txtSalesTax.AdvanceText = stockDataGrid.Rows[i].Cells["s_tax"].Value.ToString();
                    txtExpiry.Text = stockDataGrid.Rows[i].Cells["exp_date"].Value.ToString();
                    string stm = stockDataGrid.Rows[i].Cells["s_tax_mode"].Value.ToString();
                    for (int j = 0; j < combMedType.Items.Count; j++)
                    {
                        if (stm == (((DataRowView)combSTMode.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combSTMode.SelectedIndex = j;
                            break;
                        }
                    }
                    txtDiscount.AdvanceText = stockDataGrid.Rows[i].Cells["DISCOUNT"].Value.ToString();
                    string dm = stockDataGrid.Rows[i].Cells["DISCOUNT"].Value.ToString();
                    for (int j = 0; j < combDisMode.Items.Count; j++)
                    {
                        if (dm == (((DataRowView)combDisMode.Items[j]).Row.ItemArray)[0].ToString())
                        {
                            combDisMode.SelectedIndex = j;
                            break;
                        }
                    }
                }
            }
        }
        private void nextStage()
        {
            if (checkLocks())
            {
                switch (CurrentStage)
                {
                    case Stage.One:
                        CurrentStage = Stage.Two;
                        Stage1.Visible = false;
                        Stage2.Visible = true;
                        Stage3.Visible = false;
                        Stage4.Visible = false;
                        SalesManDataGrid.Focus();
                        break;
                    case Stage.Two:
                        CurrentStage = Stage.Three;
                        Stage1.Visible = false;
                        Stage2.Visible = false;
                        Stage3.Visible = true;
                        Stage4.Visible = false;
                        txtSearchCom.Focus();
                        break;
                    case Stage.Three:
                        CurrentStage = Stage.Four;
                        Stage1.Visible = false;
                        Stage2.Visible = false;
                        Stage3.Visible = false;
                        Stage4.Visible = true;
                        txtQuantity.Focus();
                        break;
                    case Stage.Four:
                        break;
                    case Stage.Locked:
                        Stage1.Visible = false;
                        Stage2.Visible = false;
                        Stage3.Visible = false;
                        Stage4.Visible = true;
                        txtQuantity.Focus();
                        break;
                    case Stage.Failed:
                        break;
                    default:
                        break;
                }
            }
        }
        private void previousStage()
        {
            switch (CurrentStage)
            {
                case Stage.One:
                    break;
                case Stage.Two:
                    CurrentStage = Stage.One;
                    Stage1.Visible = true;
                    Stage2.Visible = false;
                    Stage3.Visible = false;
                    Stage4.Visible = false;
                    txtSearch.Focus();
                    break;
                case Stage.Three:
                    CurrentStage = Stage.Two;
                    Stage1.Visible = false;
                    Stage2.Visible = true;
                    Stage3.Visible = false;
                    Stage4.Visible = false;
                    SalesManDataGrid.Focus();
                    break;
                case Stage.Four:
                    CurrentStage = Stage.Three;
                    Stage1.Visible = false;
                    Stage2.Visible = false;
                    Stage3.Visible = true;
                    Stage4.Visible = false;
                    txtSearchCom.Focus();
                    break;
                case Stage.Locked:
                    Stage1.Visible = false;
                    Stage2.Visible = false;
                    Stage3.Visible = true;
                    Stage4.Visible = false;
                    break;
                case Stage.Failed:
                    break;
                default:
                    break;
            }
        }
        private bool checkLocks()
        {
            if (LicenseExpLock)
            {
                HANDLER.ShowMessage(txtMessage, "License is Expired of this customer" + Environment.NewLine + "Check \"Ignore this time\" to ignore");
                return false;
            }
            if (CustomerLock)
            {
                HANDLER.ShowMessage(txtMessage, "No customer in this city you selected" + Environment.NewLine + "Please select another city having atleast 1 customer");
                return false;
            }
            if (SalesManLock)
            {
                HANDLER.ShowMessage(txtMessage, "No sales man in this Zone you selected" + Environment.NewLine + "Please first asign zone to a sales man");
                return false;
            }
            if (ProductLock)
            {
                HANDLER.ShowMessage(txtMessage, "No Product in company or search in your choice" + Environment.NewLine + "Please search other one or select another company");
                return false;
            }
            return true;
        }

        private void SalesManDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnNext2.Focus();
        }

        private void stockDataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnNext3.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            previousStage();
        }

        private void txtSearchCom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ComDataGrid.Focus();
            }
        }

        private void txtSearchPro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                proDataGrid.Focus();
            }
        }


        ///////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////Authentications/////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////
        private void calculations()
        {
            if (CurrentStage == Stage.Four || currentSgate == Stage.Locked)
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

        private void txtSalesTax_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtDiscount_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtRetailPrice_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtQuantity_TextUpdated(object sender, EventArgs e)
        {
            calculations();
        }

        private void txtSalesTax_Load(object sender, EventArgs e)
        {

        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            callOnLoad();
            Stage1.Visible = true;
            Stage2.Visible = false;
            Stage3.Visible = false;
            Stage4.Visible = false;
        }
    }
}
