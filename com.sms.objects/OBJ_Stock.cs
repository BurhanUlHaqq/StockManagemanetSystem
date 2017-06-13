using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.sms.objects
{
    public class OBJ_Stock
    {
        public static int COMPANY_CODE { get; set; }
        public static int PRODUCT_CODE { get; set; }
        public static int STOCK_CODE { get; set; }
        public static string BATCH_NO { get; set; }
        public static int QUANTITY { get; set; }
        public static int BOUNUS { get; set; }
        public static float TRADE_PRICE { get; set; }
        public static float DISCOUNT { get; set; }
        public static float NET_VALUE { get; set; }
        public static string STOCK_DATE { get; set; }
        public static string INVOICE_NO { get; set; }
        public static float DISCOUNT_VALUE { get; set; }
        public static int SALES_TAX { get; set; }
        public static float SALES_TAX_VALUE { get; set; }
        public static int SALES_TAX_MODE { get; set; }
        public static float GROSS_VALUE { get; set; }
        public static float RETAIL_PRICE { get; set; }
        public static int DISCOUNT_MODE { get; set; }
        public static int REMANING_STOCK_VALUE { get; set; }
        public static int REMAINING_QUANTITY { get; set; }
        public static float REMAINING_BOUNOUS { get; set; }
        public static string EXPIRY_DATE { get; set; }
    }
}
