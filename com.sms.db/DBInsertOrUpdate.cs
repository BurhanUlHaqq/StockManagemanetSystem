using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.sms.config;

namespace com.sms.db
{
    public class DBInsertOrUpdate
    {
        public static int InsertOrUpdate(string Key_FROM, string QueryMode)
        {
            int val = 0;
            string query = "";
            query = ConfigRandomQuery.Query(Key_FROM, QueryMode);
            val = RunUpdateQuery.InsertOrUpdate(query);
            return val;
        }
    }
}
