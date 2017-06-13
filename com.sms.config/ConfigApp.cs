using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.sms.config
{
    public class ConfigApp
    {
        public static int MESSAGE_DISPLAY_DURATION { get; set; }
        public static string INSERT_MESSAGE { get; set; }
        public static string UPDATE_MESSAGE { get; set; }
        public static string NOT_VALID_FORM_MESSAGE { get; set; }
        public static string DELETE_MESSAGE { get; set; }

        public static string SEARCH_MODE_ID_MESSAGE { get; set; }

        public static string SEARCH_MODE_TEXT_MESSAGE { get; set; }

        public static DateTime MIN_DATETIME { get; set; }

        public static string DATETIME_FORMATE { get; set; }
        public static string DATETIME_EXPIRY_FORMATE { get; set; }

        public static string SHOW_DATETIME_FORMATE { get; set; }
        public static int SALES_TEX_PERCENTAGE { get; set; }
        public static string LENGTH_INVALID_MESSAGE { get; set; }
        public static string NUMBER_INVALID_MESSAGE { get; set; }
        public static string EMAIL_INVALID_MESSAGE { get; set; }
        public static string CURRENCCY_INVALID_MESSAGE { get; set; }
        public static int STOCK_EXPIRY_MIN_Y { get; set; }
        public static int STOCK_EXPIRY_MIN_M { get; set; }
        public static int STOCK_EXPIRY_MIN_D { get; set; }
        public static int CUSTOMER_EXPIRY_MIN_Y { get; set; }
        public static int CUSTOMER_EXPIRY_MIN_M { get; set; }
        public static int CUSTOMER_EXPIRY_MIN_D { get; set; }

        public static Panel DisplayArea;

        public static void setDisplayArea()
        {
            DisplayArea = new Panel();
            DisplayArea.Dock = DockStyle.Fill;
            DisplayArea.Location = new System.Drawing.Point(0, 255);
            DisplayArea.Name = "DisplayArea";
            DisplayArea.Size = new System.Drawing.Size(1193, 595);
            DisplayArea.TabIndex = 5;
        }
    }
}
