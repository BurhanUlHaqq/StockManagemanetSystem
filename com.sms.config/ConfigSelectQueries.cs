using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.sms.config
{
    public class ConfigSelectQueries
    {
        //Zone
        public const string MAX_ZONE = "SELECT Max(z_code) AS max FROM [zone];";
        public const string ALL_ZONE = "select z_code as Code,zone as 'Zone Name' from zone;";
        public const string ALL_ZONE_FOR_COMBOBOX = "select z_code as Code, zone as ZName from zone";

        //Company
        public const string MAX_COMPANY = "select max(c_code) as max from company;";
        public const string ALL_COMPANY = "select [C_CODE],[C_NAME] ,[C_DATE] ,[ADDR] ,[CITY] , [PH] ,[FAX] ,[E_MAIL] from [company]";

        //City
        public const string MAX_CITY = "select max(city_code) as max from Cities;";
        public const string ALL_CITY = "select z.z_code as ZoneCode, z.zone as ZoneName, c.city_code as CityCode, c.city_name as CityName from cities as c, zone as z where z.z_code=c.z_code;";

        //Customer
        public const string MAX_CUSTOMER = "select max(cust_code) as max from Customer_info;";
        public const string ALL_CUSTOMER = @"SELECT [main].[Customer_info].[cust_code],
  [main].[Customer_info].[z_code],
  [main].[Customer_info].[city_code],
  [main].[Customer_info].[name] AS [cus_name],
  [main].[Customer_info].[addr],
  [main].[Customer_info].[ph],
  [main].[Customer_info].[licence],
  [main].[Customer_info].[cust_date],
  [main].[Customer_info].[lic_exp_date],
  [main].[Customer_info].[city],
  [main].[Customer_info].[chk_exp_date],
  [main].[cities].[city_name],
  [main].[zone].[zone]
FROM [main].[Customer_info]
  INNER JOIN [main].[zone] ON [main].[Customer_info].[z_code] =
    [main].[zone].[z_code]
  INNER JOIN [main].[cities] ON [main].[Customer_info].[city_code] =
    [main].[cities].[city_code]";


        //Sales Man
        public const string MAX_SALES_MAN = "select max(sm_code) as max from sales_man;";
        public const string ALL_SALES_MAN = "select [sales_man].[z_code], [zone].[zone], [sales_man].[sm_code], [sales_man].[sm_name] from [sales_man], [zone] where[sales_man].z_code =zone.z_code;";

        //Product
        public const string MAX_PRODUCT = "select max(p_code) as max from product;";
        public const string ALL_DISCOUNT_MODE = "select CODE as Code, NAME as Name from discount_mode";
        public const string DISCOUNT_MODE = "DISCOUNT_MODE";
        public const string ALL_SALES_TAX_MODE = "select CODE as Code, NAME as Name from sales_text_mode";
        public const string SALES_TAX_MODE = "SALES_TAX_MODE";
        public const string ALL_MEDICINE_TYPE = "select TYPE_CODE as Code, TYPE as Name from medicine_type";
        public const string GROUPS_LOAD = "GROUPS_LOAD";
        public const string ALL_GROUPS = "select CODE as Code, NAME as Name from groups";
        public const string ALL_PRODUCTS = @"SELECT 
  [main].[product].[P_CODE],  
  [main].[product].[C_CODE] AS [COM_CODE],
  [main].[company].[C_NAME] AS [C_NAME],
  [main].[product].[P_DATE] AS [P_DATE],
  [main].[product].[DISC] AS [DISC],
  [main].[product].[PACK] AS [PACK],
  [main].[product].[DIS_MODE] AS [DIS_MODE],
  [main].[product].[S_TAX_MODE] AS [S_TAX_MODE],
  [main].[product].[M_TYPE] AS [M_TYPE],
  [main].[product].[GROUPS] AS [GROUPS],
  [main].[product].[DISCOUNT] AS [DISCOUNT],
  [main].[product].[S_TAX] AS [S_TAX],
  [main].[product].[BOUNS] AS [BOUNS],
  [main].[product].[RP] AS [RP],
  [main].[product].[TP] AS [TP],
  [main].[groups].[CODE],
  [main].[medicine_type].[TYPE_CODE],
  [main].[medicine_type].[TYPE],
  [main].[groups].[NAME],
  [main].[sales_text_mode].[CODE] AS [S_T_M_CODE],
  [main].[sales_text_mode].[NAME] AS [S_T_M_NAME],
  [main].[discount_mode].[NAME] AS [D_M_NAME],
  [main].[discount_mode].[CODE] AS [D_M_CODE]
FROM [main].[product]
  INNER JOIN [main].[company] ON [main].[product].[C_CODE] =
    [main].[company].[C_CODE]
  INNER JOIN [main].[groups] ON [main].[product].[GROUPS] =
    [main].[groups].[CODE]
  INNER JOIN [main].[medicine_type] ON [main].[product].[M_TYPE] =
    [main].[medicine_type].[TYPE_CODE]
  INNER JOIN [main].[sales_text_mode] ON [main].[product].[S_TAX_MODE] =
    [main].[sales_text_mode].[CODE]
  INNER JOIN [main].[discount_mode] ON [main].[product].[DIS_MODE] =
    [main].[discount_mode].[CODE]";

        //Stock
        public const string MAX_STOCK = "select max(s_code) as max from stock;";
        //Invoie being genrated        
        public const string CURRENT_INVOICE = @"SELECT [stock].[S_CODE],
  [stock].[C_CODE],
  [stock].[p_CODE],
  [stock].[batch_no],
  [stock].[qty],
  [stock].[BOUNS],
  [stock].[tP],
  [stock].[DISCOUNT],
  [stock].[s_date],
  [stock].[net_value],
  [stock].[dis_value],
  [stock].[invoice_no],
  [stock].[s_tax],
  [stock].[s_tax_value],
  [stock].[s_tax_mode],
  [stock].[gross_val],
  [stock].[RP],
  [stock].[dis_mode],
  [stock].[t_stock_val],
  [stock].[t_qty],
  [stock].[t_bouns],
  [stock].[exp_date],
  [company].[C_NAME] AS [COMPANY_NAME],
  [product].[DISC] AS [PRODUCT_NAME],
  [sales_text_mode].[NAME] AS [SALES_TAX_NAME],
  [discount_mode].[NAME] AS [DISCOUNT_NAME],
  [product].[GROUPS] AS [GROUP_CODE],
  [groups].[NAME] AS [GROUP_NAME],
  [product].[M_TYPE] AS [TYPE_CODE],
  [medicine_type].[TYPE] AS [PRODUCT_TYPE]
FROM [stock]
  INNER JOIN [company] ON [company].[C_CODE] =
    [stock].[C_CODE]
  INNER JOIN [product] ON [stock].[p_CODE] =
    [product].[P_CODE]
  INNER JOIN [sales_text_mode] ON [sales_text_mode].[CODE] =
    [stock].[s_tax_mode]
  INNER JOIN [discount_mode] ON [discount_mode].[CODE] =
    [stock].[dis_mode]
  INNER JOIN [groups] ON [product].[GROUPS] =
    [groups].[CODE]
  INNER JOIN [medicine_type] ON [product].[M_TYPE] =
    [medicine_type].[TYPE_CODE] WHERE [stock].[invoice_no]='V_INVOICE_NO';";

        public const string INVOICE_COUNT= "SELECT count(*) as NO from stock where [invoice_no]='V_INVOICE_NO' and [C_CODE]=V_C_CODE;;";

        public const string BATCHS_COUNT = "SELECT count(*) as NO from stock where [batch_no]='V_BATCH_NO' and [C_CODE]=V_C_CODE;";
        public const string ALL_STOCK = @"SELECT [stock].[S_CODE],
  [stock].[C_CODE],
  [stock].[p_CODE],
  [stock].[batch_no],
  [stock].[qty],
  [stock].[BOUNS],
  [stock].[tP],
  [stock].[DISCOUNT],
  [stock].[s_date],
  [stock].[net_value],
  [stock].[dis_value],
  [stock].[invoice_no],
  [stock].[s_tax],
  [stock].[s_tax_value],
  [stock].[s_tax_mode],
  [stock].[gross_val],
  [stock].[RP],
  [stock].[dis_mode],
  [stock].[t_stock_val],
  [stock].[t_qty],
  [stock].[t_bouns],
  [stock].[exp_date],
  [company].[C_NAME] AS [COMPANY_NAME],
  [product].[DISC] AS [PRODUCT_NAME],
  [sales_text_mode].[NAME] AS [SALES_TAX_NAME],
  [discount_mode].[NAME] AS [DISCOUNT_NAME],
  [product].[GROUPS] AS [GROUP_CODE],
  [groups].[NAME] AS [GROUP_NAME],
  [product].[M_TYPE] AS [TYPE_CODE],
  [medicine_type].[TYPE] AS [PRODUCT_TYPE]
FROM [stock]
  INNER JOIN [company] ON [company].[C_CODE] =
    [stock].[C_CODE]
  INNER JOIN [product] ON [stock].[p_CODE] =
    [product].[P_CODE]
  INNER JOIN [sales_text_mode] ON [sales_text_mode].[CODE] =
    [stock].[s_tax_mode]
  INNER JOIN [discount_mode] ON [discount_mode].[CODE] =
    [stock].[dis_mode]
  INNER JOIN [groups] ON [product].[GROUPS] =
    [groups].[CODE]
  INNER JOIN [medicine_type] ON [product].[M_TYPE] =
    [medicine_type].[TYPE_CODE];";

        //Sale
        public const string MAX_INVOICE = "SELECT Max([invoice_no]) AS max FROM [sales];";
        public const string MAX_SALE = "SELECT Max([SALES_NO]) AS max FROM [sales];";
        public const string CURRENT_SALE_INVOICE = "SELECT * from sales where sales.invoice_no='V_INVOICE_NO'";
    }
}
