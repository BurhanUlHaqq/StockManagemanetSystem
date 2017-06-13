using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.sms.config;
using com.sms.objects;

namespace com.sms.db
{
    public class DBGetDataTable
    {
        public static DataTable GetDataTable(string Query)
        {
            return RunSelectQueries.Select(Query);
        }
        public static DataTable GetDataTableWhere(string Mode)
        {
            string Query = "";
            switch (Mode)
            {
                case ConfigSelectQueryModes.CURRENT_INVOICE_MODE:
                    {
                        Query = ConfigSelectQueries.CURRENT_INVOICE;
                        Query = Query.Replace("V_INVOICE_NO", OBJ_Stock.INVOICE_NO);
                    }
                    break;
                case ConfigSelectQueryModes.CURRENT_SALE_INVOICE_MODE:
                    {
                        Query = ConfigSelectQueries.CURRENT_SALE_INVOICE;
                        Query = Query.Replace("V_INVOICE_NO", OBJ_Sales.INVOICE_NO.ToString());
                    }
                    break;
            }
            return RunSelectQueries.Select(Query);
        }
    }
}
