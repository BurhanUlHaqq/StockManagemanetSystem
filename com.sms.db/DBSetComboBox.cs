using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using com.sms.config;

namespace com.sms.db
{
    public class DBSetComboBox
    {
        public static void Set(ComboBox comboBox, string ID_For)
        {
            DataTable dataTable = new DataTable();
            switch (ID_For)
            {
                case ConfigFormNames.CITY_NEW:
                    {
                        dataTable = RunSelectQueries.Select(ConfigSelectQueries.ALL_ZONE_FOR_COMBOBOX);
                        comboBox.DisplayMember = "ZName";
                        comboBox.ValueMember = "Code";
                        comboBox.DataSource = dataTable;
                    }
                    break;
                case ConfigFormNames.PRODUCT_NEW:
                    {
                        dataTable = RunSelectQueries.Select(ConfigSelectQueries.ALL_MEDICINE_TYPE);
                        comboBox.DisplayMember = "Name";
                        comboBox.ValueMember = "Code";
                        comboBox.DataSource = dataTable;
                    }
                    break;
                case ConfigSelectQueries.DISCOUNT_MODE:
                    {
                        dataTable = RunSelectQueries.Select(ConfigSelectQueries.ALL_DISCOUNT_MODE);
                        comboBox.DisplayMember = "Name";
                        comboBox.ValueMember = "Code";
                        comboBox.DataSource = dataTable;
                    }
                    break;
                case ConfigSelectQueries.SALES_TAX_MODE:
                    {
                        dataTable = RunSelectQueries.Select(ConfigSelectQueries.ALL_SALES_TAX_MODE);
                        comboBox.DisplayMember = "Name";
                        comboBox.ValueMember = "Code";
                        comboBox.DataSource = dataTable;
                    }
                    break;
                case ConfigSelectQueries.GROUPS_LOAD:
                    {
                        dataTable = RunSelectQueries.Select(ConfigSelectQueries.ALL_GROUPS);
                        comboBox.DisplayMember = "Name";
                        comboBox.ValueMember = "Code";
                        comboBox.DataSource = dataTable;
                    }
                    break;
            }
        }
    }
}
