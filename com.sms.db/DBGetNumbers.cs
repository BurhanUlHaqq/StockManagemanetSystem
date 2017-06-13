using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using com.sms.config;
using System.Data.OleDb;
using System.Data;
using com.sms.objects;

namespace com.sms.db
{
    public class DBGetNumbers
    {
        public static int GetID(string Key_For)
        {
            int val = 0;
            string query = "";
            switch (Key_For)
            {
                case ConfigFormNames.ZONE_NEW:
                    query = ConfigSelectQueries.MAX_ZONE;
                    break;
                case ConfigFormNames.COMPANY:
                    query = ConfigSelectQueries.MAX_COMPANY;
                    break;
                case ConfigFormNames.CITY_NEW:
                    query = ConfigSelectQueries.MAX_CITY;
                    break;
                case ConfigFormNames.CUSTOMER_NEW:
                    query = ConfigSelectQueries.MAX_CUSTOMER;
                    break;
                case ConfigFormNames.SALES_MAN_NEW:
                    query = ConfigSelectQueries.MAX_SALES_MAN;
                    break;
                case ConfigFormNames.PRODUCT_NEW:
                    query = ConfigSelectQueries.MAX_PRODUCT;
                    break;
                case ConfigFormNames.STOCK_NEW:
                    query = ConfigSelectQueries.MAX_STOCK;
                    break;
                case ConfigFormNames.SALES:
                    query = ConfigSelectQueries.MAX_SALE;
                    break;
                case ConfigSelectQueryModes.MAX_INVOICE:
                    query = ConfigSelectQueries.MAX_INVOICE;
                    break;
            }
            DataTable datatable = RunSelectQueries.Select(query);
            try
            {
                val = Convert.ToInt32(datatable.Rows[0]["max"].ToString());
            }
            catch (Exception)
            {
            }
            
            return val + 1;
        }

        public static int GetCount(string Key_For)
        {
            int val = 0;
            string query = "";
            switch (Key_For)
            {
                case ConfigSelectQueryModes.NO_OF_INVOICES:
                    query = ConfigSelectQueries.INVOICE_COUNT;
                    query = query.Replace("V_INVOICE_NO", OBJ_Stock.INVOICE_NO);
                    query = query.Replace("V_C_CODE", OBJ_Stock.COMPANY_CODE.ToString());
                    break;
                case ConfigSelectQueryModes.NO_OF_BATCHS:
                    query = ConfigSelectQueries.BATCHS_COUNT;
                    query = query.Replace("V_BATCH_NO", OBJ_Stock.BATCH_NO);
                    query = query.Replace("V_C_CODE", OBJ_Stock.COMPANY_CODE.ToString());
                    break;
            }
            DataTable datatable = RunSelectQueries.Select(query);
            try
            {
                val = Convert.ToInt32(datatable.Rows[0]["NO"].ToString());
            }
            catch (Exception)
            {
            }
            return val;
        }
    }
}
