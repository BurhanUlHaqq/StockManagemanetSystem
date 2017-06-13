using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.sms.handler;
using com.sms.config;
using com.sms.objects;

namespace com.sms.gui
{
    public partial class CompanyModify : Form
    {
        public CompanyModify()
        {
            InitializeComponent();
        }

        private void CompanyModify_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void callOnLoad()
        {
            DataGrid.DataSource= HandlerToDB.GetDataTable(ConfigSelectQueries.ALL_COMPANY);
            DataGrid.Focus();
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                if (DataGrid.Rows[i].IsSelected)
                {
                   txtCCode.AdvanceText= DataGrid.Rows[i].Cells["C_CODE"].Value.ToString();
                   txtCName.AdvanceText= DataGrid.Rows[i].Cells["C_NAME"].Value.ToString();
                   DatePicker.Value= DateTime.Parse( DataGrid.Rows[i].Cells["C_DATE"].Value.ToString());
                   txtCAddress.AdvanceText= DataGrid.Rows[i].Cells["ADDR"].Value.ToString();
                   txtCCity.AdvanceText= DataGrid.Rows[i].Cells["CITY"].Value.ToString();
                   txtCPHNo.AdvanceText= DataGrid.Rows[i].Cells["PH"].Value.ToString();
                   txtCFaxNo.AdvanceText= DataGrid.Rows[i].Cells["FAX"].Value.ToString();
                   txtCEmail.AdvanceText= DataGrid.Rows[i].Cells["E_MAIL"].Value.ToString();
                }
            }
        }
        private void setObject()
        {
            OBJ_Company.COMPANY_CODE = Convert.ToInt32(txtCCode.AdvanceText);
            OBJ_Company.COMPANY_NAME = txtCName.AdvanceText;
            OBJ_Company.COMPANY_DATE = DatePicker.Text;
            OBJ_Company.COMPANY_ADDRESS = txtCAddress.AdvanceText;
            OBJ_Company.COMPANY_CITY = txtCCity.AdvanceText;
            OBJ_Company.COMPANY_PHONE = txtCPHNo.AdvanceText;
            OBJ_Company.COMPANY_FAX = txtCFaxNo.AdvanceText;
            OBJ_Company.COMPANY_EMAIL = txtCEmail.AdvanceText;
        }

        private bool IsValidate()
        {
            if (txtCName.AdvanceText == "" || txtCAddress.AdvanceText == "" || txtCCity.AdvanceText == "" || txtCPHNo.AdvanceText == "" || txtCFaxNo.AdvanceText == "" || txtCEmail.AdvanceText == "")
            {
                HANDLER.ShowMessage(txtMessage, ConfigApp.NOT_VALID_FORM_MESSAGE);
                return false;
            }
            return true;
        }
        private void FormReset()
        {
            txtCName.AdvanceText = "";
            txtCAddress.AdvanceText = "";
            txtCCity.AdvanceText = "";
            txtCPHNo.AdvanceText = "";
            txtCFaxNo.AdvanceText = "";
            txtCEmail.AdvanceText = "";
            DatePicker.Value = DateTime.Now;
            txtCCode.AdvanceText = "";
        }
        private void updateReccord()
        {
            if (IsValidate())
            {
                setObject();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.COMPANY, ConfigQueryModes.UPDATE) + " " + ConfigApp.UPDATE_MESSAGE);
               // txtCCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.COMPANY).ToString();
                FormReset();
                callOnLoad();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateReccord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadGUI.LoadForm(ConfigApp.DisplayArea, ConfigFormNames.WELCOME_SCREEN);
        }

        private void CompanyModify_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.S)
            {
                updateReccord();
            }
            if(e.KeyCode==Keys.F12)
            {
                txtCName.Focus();
            }
            if(e.KeyCode==Keys.F11)
            {
                DataGrid.Focus();
            }
        }

        private void CompanyModify_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
