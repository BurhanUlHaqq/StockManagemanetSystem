using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.sms.config;
using System.Windows.Forms;

namespace com.sms.gui
{
    class LoadGUI
    {
        internal static void LoadForm(Panel panel, string FormName)
        {
            Form ShowForm = LoadGUI.LoadFormInPanel(FormName);
            if (ShowForm != null)
            {
                ShowForm.TopLevel = false;
                ShowForm.Dock = DockStyle.Fill;
                ShowForm.FormBorderStyle = FormBorderStyle.None;
                ShowForm.Size = panel.Size;
                panel.Controls.Clear();
                panel.Controls.Add(ShowForm);
                ShowForm.Show();
                ShowForm.Focus();
            }
        }

        internal static void LoadDialoge(string FormName)
        {
            Form ShowForm = LoadGUI.LoadFormInDialoge(FormName);
            if (ShowForm != null)
            {
                ShowForm.ShowDialog();
            }
        }

        private static Form LoadFormInDialoge(string FormName)
        {
            switch (FormName)
            {
                //Zone
                case ConfigFormNames.ZONE_DIALOGE:
                    return new DialogeZoneList();
                case ConfigFormNames.ZONE_NEW:
                    return new ZoneNew();
            }
            return null;
        }
        private static Form LoadFormInPanel(string FormName)
        {
            switch (FormName)
            {
                //Company
                case ConfigFormNames.COMPANY:
                    return new Company();
                case ConfigFormNames.COMPANY_MODIFY:
                    return new CompanyModify();
                case ConfigFormNames.COMPANY_DELETE:
                    return new CompanyDelete();
                //Product
                case ConfigFormNames.PRODUCT_NEW:
                    return new ProductNew();
                case ConfigFormNames.PRODUCT_MODIFY:
                    return new ProductModify();
                case ConfigFormNames.PRODUCT_DELETE:
                    return new ProductDelete();
                //Zone
                case ConfigFormNames.ZONE_NEW:
                    return new ZoneNew();
                case ConfigFormNames.ZONE_MODIFY:
                    return new ZoneModify();
                case ConfigFormNames.ZONE_DELETE:
                    return new ZoneDelete();
                //City
                case ConfigFormNames.CITY_NEW:
                    return new CityNew();
                case ConfigFormNames.CITY_MODIFY:
                    return new CityModify();
                case ConfigFormNames.CITY_DELETE:
                    return new CityDelete();
                //Customer
                case ConfigFormNames.CUSTOMER_NEW:
                    return new CustomerNew();
                case ConfigFormNames.CUSTOMER_MODIFY:
                    return new CustomerModify();
                case ConfigFormNames.CUSTOMER_DELETE:
                    return new CustomerDelete();
                //Sales_Man
                case ConfigFormNames.SALES_MAN_NEW:
                    return new SalesManNew();
                case ConfigFormNames.SALES_MAN_MODIFY:
                    return new SalesManModify();
                case ConfigFormNames.SALES_MAN_DELETE:
                    return new SalesManDelete();
                //Welcome 
                case ConfigFormNames.WELCOME_SCREEN:
                    return new Welcome();
                //Stock
                case ConfigFormNames.STOCK_NEW:
                    return new Stock();
                //Stock
                case ConfigFormNames.SALES:
                    return new Sales();
            }
            return null;
        }
    }
}
