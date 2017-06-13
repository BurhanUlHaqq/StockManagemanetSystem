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
    public partial class SalesManNew : Form
    {
        public SalesManNew()
        {
            InitializeComponent();
        }

        private void SalesManNew_Load(object sender, EventArgs e)
        {
            callOnLoad();
        }

        private void callOnLoad()
        {
            HandlerToDB.SetComboBox(combZone, ConfigFormNames.CITY_NEW);
            txtSalesManCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.SALES_MAN_NEW).ToString();
        }

        private void combZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtZoneCode.AdvanceText = (((DataRowView)combZone.SelectedItem).Row.ItemArray)[0].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void resetForm()
        {
            txtName.AdvanceText = "";
        }
        private bool isFormValied()
        {
            if(txtZoneCode.AdvanceText == "" ||txtName.AdvanceText=="")
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addRecord();
        }

        private void addRecord()
        {
            if (isFormValied())
            {
                setObjects();
                HANDLER.ShowMessage(txtMessage, HandlerToDB.InsertOrUpdate(ConfigFormNames.SALES_MAN_NEW, ConfigQueryModes.INSERT) + " " + ConfigApp.INSERT_MESSAGE);
                txtSalesManCode.AdvanceText = HandlerToDB.GetNewID(ConfigFormNames.SALES_MAN_NEW).ToString();
                resetForm();
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
            OBJ_Sales_Man.ZONE_CODE =Convert.ToInt32( txtZoneCode.AdvanceText);
        }

        private void SalesManNew_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.S)
            {
                addRecord();
            }
        }

        private void SalesManNew_FontChanged(object sender, EventArgs e)
        {
            HANDLER.ShowOnMidTop(panel1, this.Width);
        }
    }
}
