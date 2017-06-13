using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using com.sms.config;
using com.sms.handler;
using Telerik.WinControls.UI;

namespace com.sms.handler
{
    public class HANDLER
    {
        public static void LoadCompanyInfo()
        {

            //Company
            ConfigCompany.CompanyName = "Hanzla Traders";
            ConfigCompany.CompanyAddress = "Baldia Road Bahawalnagar";
            ConfigCompany.CompanyContact = "03004070110";
            //DataBase
            ConfigStrings.SQLITE_DB_PATH = "E:\\smsdb.dat";
            ConfigStrings.CONNECTION_STRING = @"Data Source=" + ConfigStrings.SQLITE_DB_PATH + ";Version=3;New=true;Compress=True;";
            //Application
            ConfigApp.MESSAGE_DISPLAY_DURATION = 3000;
            ConfigApp.INSERT_MESSAGE = "Records Inserted";
            ConfigApp.UPDATE_MESSAGE = "Records Updated";
            ConfigApp.DELETE_MESSAGE = "Records Deleted";
            ConfigApp.SEARCH_MODE_ID_MESSAGE = "By ID";
            ConfigApp.SEARCH_MODE_TEXT_MESSAGE = "By Name";
            ConfigApp.NOT_VALID_FORM_MESSAGE = "Please Fill Form Properly!";
            ConfigApp.setDisplayArea();
            ConfigApp.DATETIME_FORMATE = "yyyy-MM-dd hh:mm:ss tt";
            ConfigApp.SHOW_DATETIME_FORMATE = "yyyy-MM-dd hh:mm:ss tt";
            ConfigApp.DATETIME_EXPIRY_FORMATE = "yyyy-MM-dd";
            ConfigApp.MIN_DATETIME = DateTime.Now;
            ConfigApp.SALES_TEX_PERCENTAGE = 0;
            ConfigApp.LENGTH_INVALID_MESSAGE = "Maximum Exceded";
            ConfigApp.NUMBER_INVALID_MESSAGE = "Invalid Number";
            ConfigApp.EMAIL_INVALID_MESSAGE = "Invalid Email";
            ConfigApp.CURRENCCY_INVALID_MESSAGE = "Invalid Currency";
            ConfigApp.STOCK_EXPIRY_MIN_Y = 1;
            ConfigApp.STOCK_EXPIRY_MIN_M = 1;
            ConfigApp.STOCK_EXPIRY_MIN_D = 2;
            ConfigApp.CUSTOMER_EXPIRY_MIN_Y = 0;
            ConfigApp.CUSTOMER_EXPIRY_MIN_M = 1;
            ConfigApp.CUSTOMER_EXPIRY_MIN_D = 0;
            //MODES
            CONFIG.DISCOUNT_MODE_GVD = "GVD";
            CONFIG.DISCOUNT_MODE_NILL = "NILL";
            CONFIG.DISCOUNT_MODE_PP = "PP";
            CONFIG.DISCOUNT_MODE_RP = "RP";
            CONFIG.DISCOUNT_MODE_TP = "TP";
            CONFIG.TAX_MODE_GVD = "GVD";
            CONFIG.TAX_MODE_NILL = "NILL";
            CONFIG.TAX_MODE_PP = "PP";
            CONFIG.TAX_MODE_RP = "RP";
            CONFIG.TAX_MODE_TP = "TP";
        }

        public static void ShowMessage(Label lblStatus, string Message)
        {
            lblStatus.Text = Message;
            lblStatus.AutoSize = true;
            lblStatus.Anchor = AnchorStyles.None;
            lblStatus.Location = new System.Drawing.Point(lblStatus.Parent.Width - lblStatus.Width - 20, 0);
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Show();
            Timer t = new Timer();
            t.Interval = ConfigApp.MESSAGE_DISPLAY_DURATION;
            t.Tick += (a, c) =>
            {
                lblStatus.Hide();
                t.Stop();
            };
            t.Start();
        }

        public static void ShowOnMidTop(Panel obj, int TWidth)
        {
            int SWidth = obj.Width;
            int loc = (TWidth / 2) - (SWidth / 2);
            obj.Anchor = AnchorStyles.None;
            obj.Anchor = AnchorStyles.Right;
            obj.Anchor = AnchorStyles.Left;
            obj.Anchor = AnchorStyles.Top;
            obj.Location = new Point(loc, 15);
        }
    }
}
//F9: for text search
//F8: for ID search
//F12 for Next Group Focus
//F11 for Previous Group Focus
//Ctrl+S save or add new record
//ADD MEDICINE TYPE
//SalesTax Mode
//Groups
//Discount Mode
//Config Modes Values