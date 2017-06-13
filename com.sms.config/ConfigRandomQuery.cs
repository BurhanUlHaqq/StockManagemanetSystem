using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.sms.config;
using com.sms.objects;

namespace com.sms.config
{
    public class ConfigRandomQuery
    {
        public static string Query(string ID_From, string QueryMode)
        {
            string query = null;
            switch (ID_From)
            {
                //Zone
                case ConfigFormNames.ZONE_NEW:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.ZONE_INSERT;
                        query = query.Replace("V_ZONE_NAME", OBJ_Zone.ZONE_NAME);
                        return query;
                    }
                    else if (QueryMode == ConfigQueryModes.UPDATE)
                    {
                        query = NonQueries.ZONE_UPDATE;
                        query = query.Replace("V_ZONE_CODE", OBJ_Zone.ZONE_CODE.ToString());
                        query = query.Replace("V_ZONE_NAME", OBJ_Zone.ZONE_NAME);
                    }
                    else if (QueryMode == ConfigQueryModes.DELETE)
                    {
                        query = NonQueries.ZONE_DELETE;
                        query = query.Replace("V_ZONE_CODE", OBJ_Zone.ZONE_CODE.ToString());
                    }
                    break;
                //City
                case ConfigFormNames.CITY_NEW:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.CITY_INSERT;
                        query = query.Replace("V_ZONE_CODE", OBJ_Cities.ZONE_CODE.ToString());
                        query = query.Replace("V_CZ_CODE", OBJ_Cities.CITY_ZONE_CODE.ToString());
                        query = query.Replace("V_CITY_NAME", OBJ_Cities.CITY_NAME);
                    }
                    else if (QueryMode == ConfigQueryModes.UPDATE)
                    {
                        query = NonQueries.CITY_UPDATE;
                        query = query.Replace("V_ZONE_CODE", OBJ_Cities.ZONE_CODE.ToString());
                        query = query.Replace("V_CITY_CODE", OBJ_Cities.CITY_CODE.ToString());
                        query = query.Replace("V_CZ_CODE", OBJ_Cities.CITY_ZONE_CODE.ToString());
                        query = query.Replace("V_CITY_NAME", OBJ_Cities.CITY_NAME);
                    }
                    break;
                //Company
                case ConfigFormNames.COMPANY:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.COMPANY_INSERT;
                        query = query.Replace("V_COM_NAME", OBJ_Company.COMPANY_NAME);
                        query = query.Replace("V_COM_DATE", OBJ_Company.COMPANY_DATE);
                        query = query.Replace("V_COM_ADD", OBJ_Company.COMPANY_ADDRESS);
                        query = query.Replace("V_COM_CITY", OBJ_Company.COMPANY_CITY);
                        query = query.Replace("V_COM_PH", OBJ_Company.COMPANY_PHONE);
                        query = query.Replace("V_COM_FAX", OBJ_Company.COMPANY_FAX);
                        query = query.Replace("V_COM_MAIL", OBJ_Company.COMPANY_EMAIL);
                    }
                    else if (QueryMode == ConfigQueryModes.UPDATE)
                    {
                        query = NonQueries.COMPANY_UPDATE;
                        query = query.Replace("V_COM_CODE", OBJ_Company.COMPANY_CODE.ToString());
                        query = query.Replace("V_COM_NAME", OBJ_Company.COMPANY_NAME);
                        query = query.Replace("V_COM_DATE", OBJ_Company.COMPANY_DATE);
                        query = query.Replace("V_COM_ADD", OBJ_Company.COMPANY_ADDRESS);
                        query = query.Replace("V_COM_CITY", OBJ_Company.COMPANY_CITY);
                        query = query.Replace("V_COM_PH", OBJ_Company.COMPANY_PHONE);
                        query = query.Replace("V_COM_FAX", OBJ_Company.COMPANY_FAX);
                        query = query.Replace("V_COM_MAIL", OBJ_Company.COMPANY_EMAIL);
                    }
                    break;
                //Customer
                case ConfigFormNames.CUSTOMER_NEW:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.CUSTOMER_INSERT;
                        query = query.Replace("V_ZONE_CODE", OBJ_Customer_Info.ZONE_CODE.ToString());
                        query = query.Replace("V_CITY_CODE", OBJ_Customer_Info.CITY_CODE.ToString());
                        query = query.Replace("V_CUS_NAME", OBJ_Customer_Info.NAME);
                        query = query.Replace("V_ADDRESS", OBJ_Customer_Info.ADDRESS);
                        query = query.Replace("V_PH", OBJ_Customer_Info.PHONE);
                        query = query.Replace("V_LICENCE", OBJ_Customer_Info.LICENSE);
                        query = query.Replace("V_CUS_DATE", OBJ_Customer_Info.CUSTOMER_DATE);
                        query = query.Replace("V_LIC_EXP_DATE", OBJ_Customer_Info.LICENSE_EXPIRY_DATE);
                        query = query.Replace("V_CITY", OBJ_Customer_Info.CITY);
                        query = query.Replace("V_CHE_EXP_DATE", OBJ_Customer_Info.CHECK_EXPIRY_DATE.ToString());
                    }
                    else if (QueryMode == ConfigQueryModes.UPDATE)
                    {
                        query = NonQueries.CUSTOMER_UPDATE;
                        query = query.Replace("V_Z_CODE", OBJ_Customer_Info.ZONE_CODE.ToString());
                        query = query.Replace("V_CUST_CODE", OBJ_Customer_Info.CUSTOMER_CODE.ToString());
                        query = query.Replace("V_CITY_CODE", OBJ_Customer_Info.CITY_CODE.ToString());
                        query = query.Replace("V_NAME", OBJ_Customer_Info.NAME);
                        query = query.Replace("V_ADDRESS", OBJ_Customer_Info.ADDRESS);
                        query = query.Replace("V_PH", OBJ_Customer_Info.PHONE);
                        query = query.Replace("V_LICENCE", OBJ_Customer_Info.LICENSE);
                        query = query.Replace("V_CUS_DATE", OBJ_Customer_Info.CUSTOMER_DATE);
                        query = query.Replace("V_LIC_EXP_DATE", OBJ_Customer_Info.LICENSE_EXPIRY_DATE);
                        query = query.Replace("V_CITY", OBJ_Customer_Info.CITY);
                        query = query.Replace("V_CHK_EXP_DATE", OBJ_Customer_Info.CHECK_EXPIRY_DATE.ToString());
                    }
                    break;
                //Sales Man
                case ConfigFormNames.SALES_MAN_NEW:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.SALES_MAN_INSERT;
                        query = query.Replace("V_SALESMAN_CODE", OBJ_Sales_Man.SALES_MAN_CODE.ToString());
                        query = query.Replace("V_ZONE_CODE", OBJ_Sales_Man.ZONE_CODE.ToString());
                        query = query.Replace("V_SALESMAN_NAME", OBJ_Sales_Man.SALES_MAN_NAME);
                    }
                    else if (QueryMode == ConfigQueryModes.UPDATE)
                    {
                        query = NonQueries.SALES_MAN_UPDATE;
                        query = query.Replace("V_SALESMAN_CODE", OBJ_Sales_Man.SALES_MAN_CODE.ToString());
                        query = query.Replace("V_ZONE_CODE", OBJ_Sales_Man.ZONE_CODE.ToString());
                        query = query.Replace("V_SALESMAN_NAME", OBJ_Sales_Man.SALES_MAN_NAME);
                    }
                    break;
                //Product
                case ConfigFormNames.PRODUCT_NEW:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.PRODUCT_INSERT;
                        query = query.Replace("V_C_CODE", OBJ_Product.COMPANY_CODE.ToString());
                        query = query.Replace("V_PRODUCT_DATE", OBJ_Product.DATE);
                        query = query.Replace("V_DISCREPTION", OBJ_Product.DISCREPTION);
                        query = query.Replace("V_PACK", OBJ_Product.PACK);
                        query = query.Replace("V_T_P", OBJ_Product.TRADE_PRICE.ToString());
                        query = query.Replace("V_R_P", OBJ_Product.RETAIL_PRICE.ToString());
                        query = query.Replace("V_BOUNS", OBJ_Product.BOUNS.ToString());
                        query = query.Replace("V_S_TAX", OBJ_Product.SALES_TAX.ToString());
                        query = query.Replace("V_DISCOUNT", OBJ_Product.DISCOUNT.ToString());
                        query = query.Replace("V_GROUPS", OBJ_Product.GROUP_ID.ToString());
                        query = query.Replace("V_M_TYPE", OBJ_Product.MEDICINE_TYPE.ToString());
                        query = query.Replace("V_SALE_TAX_MODE", OBJ_Product.SALES_TAX_MODE.ToString());
                        query = query.Replace("V_DIS_MODE", OBJ_Product.DISCOUNT_MODE.ToString());
                    }
                    else if (QueryMode == ConfigQueryModes.UPDATE)
                    {
                        query = NonQueries.PRODUCT_UPDATE;
                        query = query.Replace("V_P_CODE", OBJ_Product.PRODUCT_CODE.ToString());
                        query = query.Replace("V_C_CODE", OBJ_Product.COMPANY_CODE.ToString());
                        query = query.Replace("V_PRODUCT_DATE", OBJ_Product.DATE);
                        query = query.Replace("V_DISCREPTION", OBJ_Product.DISCREPTION);
                        query = query.Replace("V_PACK", OBJ_Product.PACK);
                        query = query.Replace("V_T_P", OBJ_Product.TRADE_PRICE.ToString());
                        query = query.Replace("V_R_P", OBJ_Product.RETAIL_PRICE.ToString());
                        query = query.Replace("V_BOUNS", OBJ_Product.BOUNS.ToString());
                        query = query.Replace("V_S_TAX", OBJ_Product.SALES_TAX.ToString());
                        query = query.Replace("V_DISCOUNT", OBJ_Product.DISCOUNT.ToString());
                        query = query.Replace("V_GROUPS", OBJ_Product.GROUP_ID.ToString());
                        query = query.Replace("V_M_TYPE", OBJ_Product.MEDICINE_TYPE.ToString());
                        query = query.Replace("V_SALE_TAX_MODE", OBJ_Product.SALES_TAX_MODE.ToString());
                        query = query.Replace("V_DIS_MODE", OBJ_Product.DISCOUNT_MODE.ToString());
                    }
                    break;
                //Stock
                case ConfigFormNames.STOCK_NEW:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.STOCK_INSERT;
                        query = query.Replace("V_C_CODE", OBJ_Stock.COMPANY_CODE.ToString());
                        query = query.Replace("V_P_CODE", OBJ_Stock.PRODUCT_CODE.ToString());
                        query = query.Replace("V_BATCH_NO", OBJ_Stock.BATCH_NO.ToString());
                        query = query.Replace("V_QUANTITY", OBJ_Stock.QUANTITY.ToString());
                        query = query.Replace("V_BOUNUS", OBJ_Stock.BOUNUS.ToString());
                        query = query.Replace("V_TRADE_PRICE", OBJ_Stock.TRADE_PRICE.ToString());
                        query = query.Replace("V_DISCOUNT", OBJ_Stock.DISCOUNT.ToString());
                        query = query.Replace("V_STOCK_DATE", OBJ_Stock.STOCK_DATE);
                        query = query.Replace("V_NET_VALUE", OBJ_Stock.NET_VALUE.ToString());
                        query = query.Replace("V_VALUE_DISCOUNT", OBJ_Stock.DISCOUNT_VALUE.ToString());
                        query = query.Replace("V_INVOICE_NO", OBJ_Stock.INVOICE_NO);
                        query = query.Replace("V_SALES_TAX", OBJ_Stock.SALES_TAX.ToString());
                        query = query.Replace("V_VALUE_SALES_TAX", OBJ_Stock.SALES_TAX_VALUE.ToString());
                        query = query.Replace("V_MODE_SALES_TAX", OBJ_Stock.SALES_TAX_MODE.ToString());
                        query = query.Replace("V_GROSS_VALUE", OBJ_Stock.GROSS_VALUE.ToString());
                        query = query.Replace("V_RETAIL_PRICE", OBJ_Stock.RETAIL_PRICE.ToString());
                        query = query.Replace("V_MODE_DISCOUNT", OBJ_Stock.DISCOUNT_MODE.ToString());
                        query = query.Replace("V_REMAINING_STOCK_VALUE", OBJ_Stock.NET_VALUE.ToString());
                        query = query.Replace("V_REMAINING_QUANTITY", OBJ_Stock.QUANTITY.ToString());
                        query = query.Replace("V_REMAINING_BOUNUS", OBJ_Stock.BOUNUS.ToString());
                        query = query.Replace("V_EXPITY_DATE", OBJ_Stock.EXPIRY_DATE);
                    }
                    else if (QueryMode == ConfigQueryModes.UPDATE)
                    {
                        query = NonQueries.STOCK_UPDATE;
                        query = query.Replace("V_S_CODE", OBJ_Stock.STOCK_CODE.ToString());
                        query = query.Replace("V_C_CODE", OBJ_Stock.COMPANY_CODE.ToString());
                        query = query.Replace("V_P_CODE", OBJ_Stock.PRODUCT_CODE.ToString());
                        query = query.Replace("V_BATCH_NO", OBJ_Stock.BATCH_NO.ToString());
                        query = query.Replace("V_QUANTITY", OBJ_Stock.QUANTITY.ToString());
                        query = query.Replace("V_BOUNUS", OBJ_Stock.BOUNUS.ToString());
                        query = query.Replace("V_TRADE_PRICE", OBJ_Stock.TRADE_PRICE.ToString());
                        query = query.Replace("V_DISCOUNT", OBJ_Stock.DISCOUNT.ToString());
                        query = query.Replace("V_STOCK_DATE", OBJ_Stock.STOCK_DATE);
                        query = query.Replace("V_NET_VALUE", OBJ_Stock.NET_VALUE.ToString());
                        query = query.Replace("V_VALUE_DISCOUNT", OBJ_Stock.DISCOUNT_VALUE.ToString());
                        query = query.Replace("V_INVOICE_NO", OBJ_Stock.INVOICE_NO);
                        query = query.Replace("V_SALES_TAX", OBJ_Stock.SALES_TAX.ToString());
                        query = query.Replace("V_VALUE_SALES_TAX", OBJ_Stock.SALES_TAX_VALUE.ToString());
                        query = query.Replace("V_MODE_SALES_TAX", OBJ_Stock.SALES_TAX_MODE.ToString());
                        query = query.Replace("V_GROSS_VALUE", OBJ_Stock.GROSS_VALUE.ToString());
                        query = query.Replace("V_RETAIL_PRICE", OBJ_Stock.RETAIL_PRICE.ToString());
                        query = query.Replace("V_MODE_DISCOUNT", OBJ_Stock.DISCOUNT_MODE.ToString());
                        query = query.Replace("V_REMAINING_STOCK_VALUE", OBJ_Stock.NET_VALUE.ToString());
                        query = query.Replace("V_REMAINING_QUANTITY", OBJ_Stock.QUANTITY.ToString());
                        query = query.Replace("V_REMAINING_BOUNUS", OBJ_Stock.BOUNUS.ToString());
                        query = query.Replace("V_EXPITY_DATE", OBJ_Stock.EXPIRY_DATE);
                    }
                    break;
                //Sale
                case ConfigFormNames.SALES:
                    if (QueryMode == ConfigQueryModes.INSERT)
                    {
                        query = NonQueries.SALE_INSERT;
                        query = query.Replace("V_CUS_CODE", OBJ_Sales.CUSTOMER_CODE.ToString());
                        query = query.Replace("V_PRO_CODE", OBJ_Sales.PRODUCT_CODE.ToString());
                        query = query.Replace("V_BATCH_NO", OBJ_Sales.BATCH_NO);
                        query = query.Replace("V_QUANTITY", OBJ_Sales.QUANTITY.ToString());
                        query = query.Replace("V_R_PRICE", OBJ_Sales.RETAIL_PRICE.ToString());
                        query = query.Replace("V_BOUNS", OBJ_Sales.BOUNUS.ToString());
                        query = query.Replace("V_GROSS_VALUE", OBJ_Sales.GROSS_VALUE.ToString());
                        query = query.Replace("V_DISCOUNT", OBJ_Sales.DISCOUNT.ToString());
                        query = query.Replace("V_MODE_DISCOUNT", OBJ_Sales.DISCOUNT_MODE.ToString());
                        query = query.Replace("V_VALUE_DISCOUNT", OBJ_Sales.DISCOUNT_VALUE.ToString());
                        query = query.Replace("V_MODE_TAX", OBJ_Sales.SALES_TAX_MODE.ToString());
                        query = query.Replace("V_S_TAX", OBJ_Sales.SALES_TAX.ToString());
                        query = query.Replace("V_VALUE_S_TAX", OBJ_Sales.SALES_TAX_VALUE.ToString());
                        query = query.Replace("V_NET_VALUE", OBJ_Sales.NET_VALUE.ToString());
                        query = query.Replace("V_SALE_DATE", OBJ_Sales.SALES_DATE.ToString());
                        query = query.Replace("V_SMZ_CODE", OBJ_Sales.SALES_MAN_ZONE_CODE.ToString());
                        query = query.Replace("V_DISC", OBJ_Sales.PRODUCT_NAME.ToString());
                        query = query.Replace("V_CZC_CODE", OBJ_Sales.CUSTOMER_ZONE_CODE.ToString());
                        query = query.Replace("V_CHECK_IGNORE", OBJ_Sales.CHECKC_IGNORE.ToString());
                        query = query.Replace("V_MED_TYPE", OBJ_Sales.MEDICINE_TYPE_CODE.ToString());
                        query = query.Replace("V_SM_CODE", OBJ_Sales.SALES_MAN_CODE.ToString());
                        query = query.Replace("V_INVOICE_NO", OBJ_Sales.INVOICE_NO.ToString());
                    }
                    break;
            }
            return query;
        }
    }
}
