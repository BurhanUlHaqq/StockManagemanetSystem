using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.sms.db
{
    class RunUpdateQuery
    {
        public static int InsertOrUpdate(string Query)
        {
            int val = 0;
            SQLiteConnection conn = Conn.GetConnection();           
            try
            {
                SQLiteCommand sqlite_cmd;

                // create a new SQL command:
                sqlite_cmd = conn.CreateCommand();

                // Let the SQLiteCommand object know our SQL-Query:
                sqlite_cmd.CommandText = Query;
                val = sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return val;
        }
    }
}
