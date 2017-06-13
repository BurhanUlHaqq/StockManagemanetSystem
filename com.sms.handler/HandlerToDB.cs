using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using com.sms.db;

namespace com.sms.handler
{
    public class HandlerToDB
    {
        public static int GetNewID(string ID_For)
        {
            return DBGetNumbers.GetID(ID_For);
        }
        public static int GetCount(string ID_For)
        {
            return DBGetNumbers.GetCount(ID_For);
        }
        public static int InsertOrUpdate(string ID_From,string QueryMode)
        {
            return DBInsertOrUpdate.InsertOrUpdate(ID_From, QueryMode);
        }
        public static DataTable GetDataTable(string Query)
        {
            return DBGetDataTable.GetDataTable(Query);
        }
        public static DataTable GetDataTableWhere(string Mode)
        {
            return DBGetDataTable.GetDataTableWhere(Mode);
        }

        public static void SetComboBox(ComboBox comboBox, string ID_For)
        {
            DBSetComboBox.Set(comboBox, ID_For);
        }
    }
}
