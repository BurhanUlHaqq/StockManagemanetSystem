using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.sms.config
{
    class NonQueries
    {
        //Zone
        public const string ZONE_INSERT = "insert into zone(zone) values('V_ZONE_NAME');";
        public const string ZONE_UPDATE = "update zone set zone='V_ZONE_NAME' where z_code = V_ZONE_CODE";
        public const string ZONE_DELETE = "delete from zone where z_code=V_ZONE_CODE";
        
        //City
        public const string CITY_INSERT = "insert into cities([z_code] , [cz_code] , [city_name]) values(V_ZONE_CODE,V_CZ_CODE,'V_CITY_NAME');";
        public const string CITY_UPDATE = "update cities set z_code=V_ZONE_CODE , cz_code=V_CZ_CODE , city_name='V_CITY_NAME' where city_code=V_CITY_CODE";
       
        //Company
        public const string COMPANY_INSERT = "insert into  [company]([C_NAME] ,[C_DATE] ,[ADDR] ,[CITY] , [PH] ,[FAX] ,[E_MAIL] )values('V_COM_NAME','V_COM_DATE','V_COM_ADD','V_COM_CITY','V_COM_PH','V_COM_FAX','V_COM_MAIL');";
        public const string COMPANY_UPDATE = "update [company] set [C_NAME]='V_COM_NAME' ,[C_DATE]='V_COM_DATE' ,[ADDR]='V_COM_ADD' ,[CITY]='V_COM_CITY' , [PH]='V_COM_PH' ,[FAX]='V_COM_FAX' ,[E_MAIL]='V_COM_MAIL' where [C_CODE]=V_COM_CODE";
       
        //Customer
        public const string CUSTOMER_INSERT = "insert into Customer_info ([z_code], [city_code], [name], [addr] , [ph], [licence] , [cust_date] , [lic_exp_date] , [city] , [chk_exp_date]) values (V_ZONE_CODE, V_CITY_CODE,'V_CUS_NAME','V_ADDRESS','V_PH','V_LICENCE','V_CUS_DATE','V_LIC_EXP_DATE','V_CITY', V_CHE_EXP_DATE);";
        public const string CUSTOMER_UPDATE = "update [Customer_info] set [z_code]=V_Z_CODE, [city_code]=V_CITY_CODE, [name]='V_NAME', [addr]='V_ADDRESS', [ph]='V_PH', [licence]='V_LICENCE', [cust_date]='V_CUS_DATE', [lic_exp_date]='V_LIC_EXP_DATE', [city]='V_CITY', [chk_exp_date] =V_CHK_EXP_DATE where [cust_code]=V_CUST_CODE;";

        //Sales Man
        public const string SALES_MAN_INSERT = "insert into sales_man ([z_code], [sm_name]) values (V_ZONE_CODE,'V_SALESMAN_NAME');";
        public const string SALES_MAN_UPDATE = "update [sales_man] set [z_code]=V_ZONE_CODE, [sm_name]='V_SALESMAN_NAME' where [sales_man].sm_code=V_SALESMAN_CODE";

        //Product
        public const string PRODUCT_INSERT = "insert into product ( [C_CODE], [P_DATE],[DISC],[PACK],[TP],[RP],[BOUNS],[S_TAX],[DISCOUNT],[GROUPS],[M_TYPE],[S_TAX_MODE],[DIS_MODE])values(V_C_CODE,'V_PRODUCT_DATE','V_DISCREPTION','V_PACK',V_T_P,V_R_P,V_BOUNS,V_S_TAX,'V_DISCOUNT',V_GROUPS,V_M_TYPE,V_SALE_TAX_MODE,V_DIS_MODE);";
        public const string PRODUCT_UPDATE = "update product set [C_CODE] = V_C_CODE, [P_DATE] = 'V_PRODUCT_DATE',[DISC] = 'V_DISCREPTION',[PACK] = 'V_PACK',[TP] = V_T_P,[RP] = V_R_P,[BOUNS] = V_BOUNS,[S_TAX] = V_S_TAX,[DISCOUNT] = 'V_DISCOUNT',[GROUPS] = V_GROUPS,[M_TYPE] = V_M_TYPE,[S_TAX_MODE] = V_SALE_TAX_MODE,[DIS_MODE] = V_DIS_MODE where[P_CODE]=V_P_CODE;";

        //Stock
        public const string STOCK_INSERT = "insert into [stock] ([C_CODE],  [p_CODE],  [batch_no],  [qty],  [BOUNS],  [tP],  [DISCOUNT],  [s_date],  [net_value],  [dis_value],  [invoice_no],  [s_tax],  [s_tax_value],  [s_tax_mode],  [gross_val],  [RP],  [dis_mode],  [t_stock_val],  [t_qty],  [t_bouns],  [exp_date]) values (V_C_CODE, V_P_CODE, 'V_BATCH_NO', V_QUANTITY, V_BOUNUS, V_TRADE_PRICE, V_DISCOUNT, 'V_STOCK_DATE', V_NET_VALUE, V_VALUE_DISCOUNT, 'V_INVOICE_NO', V_SALES_TAX, V_VALUE_SALES_TAX, V_MODE_SALES_TAX, V_GROSS_VALUE, V_RETAIL_PRICE, V_MODE_DISCOUNT, V_REMAINING_STOCK_VALUE, V_REMAINING_QUANTITY, V_REMAINING_BOUNUS, 'V_EXPITY_DATE')";
        public const string STOCK_UPDATE = "update [stock] set [C_CODE]=V_C_CODE,  [p_CODE]=V_P_CODE,  [batch_no]='V_BATCH_NO',  [qty]=V_QUANTITY,  [BOUNS]=V_BOUNUS,  [tP]=V_TRADE_PRICE,  [DISCOUNT]=V_DISCOUNT,  [s_date]='V_STOCK_DATE',  [net_value]=V_NET_VALUE,  [dis_value]=V_VALUE_DISCOUNT,  [invoice_no]='V_INVOICE_NO',  [s_tax]=V_SALES_TAX,  [s_tax_value]=V_VALUE_SALES_TAX,  [s_tax_mode]=V_MODE_SALES_TAX,  [gross_val]=V_GROSS_VALUE,  [RP]=V_RETAIL_PRICE,  [dis_mode]=V_MODE_DISCOUNT,  [t_stock_val]=V_REMAINING_STOCK_VALUE,  [t_qty]=V_REMAINING_QUANTITY,  [t_bouns]=V_REMAINING_BOUNUS,  [exp_date]='V_EXPITY_DATE' where [S_CODE]=V_S_CODE;";

        //Sale
        public const string SALE_INSERT = "INSERT INTO [sales] ([C_CODE],  [p_CODE],  [batch_no],  [qty],  [RP],  [BOUNS],  [gross_val],  [DISCOUNT],  [dis_mode],  [dis_value],  [s_tax_mode],  [s_tax],  [s_tax_value],  [net_value],  [S_date],  [smz_code],  [Disc],  [czc_code],  [chk_ignore],  [m_type], [SM_CODE], [invoice_no]) VALUES(V_CUS_CODE,V_PRO_CODE,'V_BATCH_NO',V_QUANTITY,V_R_PRICE,V_BOUNS,V_GROSS_VALUE,V_DISCOUNT,V_MODE_DISCOUNT,V_VALUE_DISCOUNT,V_MODE_TAX,V_S_TAX,V_VALUE_S_TAX,V_NET_VALUE,'V_SALE_DATE',V_SMZ_CODE,'V_DISC',V_CZC_CODE,V_CHECK_IGNORE,V_MED_TYPE,V_SM_CODE,V_INVOICE_NO);";
    }
}
